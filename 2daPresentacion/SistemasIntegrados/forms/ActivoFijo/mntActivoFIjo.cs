using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using clases.Inventario;
using clases.Seguridad;
using datos.ActivoFijo;
using datos.Inventario;
using datos.Seguridad;


namespace forms.ActivoFijo
{
    public partial class mntActivoFIjo : Form
    {
        public mntActivoFIjo()
        {
            InitializeComponent();
        }


        //Declare una instancia de la clase de Subgrupos para poder llenar los datos
        public char accion { get; set; }
        public clsSubgrupoActivoFijo clase = new clsSubgrupoActivoFijo();
        clsSubgrupoActivoFijo oActivoFijo = new clsSubgrupoActivoFijo();
        clsEmpresa oEmpresa = new clsEmpresa();
        clsEstado oEstado = new clsEstado();
        clsGrupoAF oGrupo = new clsGrupoAF();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();

        clsClaseDatosSubgrupoActivoFijo datoActivoFijo = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosActivoFijo datActFij = new clsClaseDatosActivoFijo();
        datEstado datoEstado = new datEstado();
        datEmpresa datoEmpresa = new datEmpresa();





        #region"Evento Load"
        private void mntActivoFIjo_Load(object sender, EventArgs e)
        {
            //Llenamos el combo grupo de inventario en la pantalla 
            clsClaseDatosGrupo dat = new clsClaseDatosGrupo();
            cbxGrupo.Properties.DataSource = dat.consultaGrupo();

            //Llenamos el combo de Estado de Seguridad en la pantalla
            cbxEstado.Properties.DataSource = datoEstado.ConsultaTodos();

            //Llenamos el combo de Empresa de Seguridad en la pantalla
            cbxEmpresa.Properties.DataSource = datoEmpresa.Consultar();
        }
        #endregion



        #region"Operaciones de Controles"
        public void set(clsSubgrupoActivoFijo oActivFijo)
        {
            txtCodigoActivo.Text = Convert.ToString(oActivFijo.Codigo);
            cbxGrupo.EditValue = datActFij.getDescripcionSegunIdInventarioGrupo(oActivFijo.Grupo);
            txtSubgrupo.Text = oActivFijo.descripcion;
            dtFecha.EditValue = oActivFijo.Fecha;
            cbxEstado.EditValue = datoEstado.getDescripcionSegunId(oActivoFijo.IdEstado);
            cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId(oActivoFijo.Empresa);
        }

        public bool getValor()
        {
            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;
            }
            else
            {
                if (txtCodigoActivo.Text == "" || txtCodigoActivo.Text == "0")
                {
                    clase.Codigo = 0;//PK
                }
                else
                {
                    clase.Codigo = Convert.ToInt32(txtCodigoActivo.Text);
                }


                if ((txtSubgrupo.Text == null || txtSubgrupo.Text == "") || (dtFecha.EditValue == null) ||
                    (cbxGrupo.EditValue == null) || (cbxEmpresa.EditValue == null) || (cbxEstado.EditValue == null))
                {
                    return false;
                }

                //clase.Codigo  =Convert.ToInt32 (txtCodigoActivo.Text);
                clase.descripcion = txtSubgrupo.Text;
                clase.Fecha = Convert.ToDateTime(dtFecha.EditValue);
                oGrupo.Descripcion = Convert.ToString(cbxGrupo.EditValue);//Se llena el campo descripcion del estado
                clase.Grupo = Convert.ToInt32(datActFij.getIdSegunDescripcionInventarioGrupo(oGrupo.Descripcion));
                oEstado.descripcion = Convert.ToString(cbxEstado.EditValue);//Se llena el campo descripcion del estado
                clase.IdEstado = Convert.ToInt32(datoEstado.getIdSegunDescripcion(oEstado.descripcion));
                oEmpresa.descripcion = Convert.ToString(cbxEmpresa.EditValue);//se llena el campo descripcion de la empresa
                clase.Empresa = Convert.ToInt32(datoEmpresa.ConsultarPorNombreComercial(oEmpresa.descripcion));


                return true;
            }
        }

        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnbuscar.Enabled = true;
            txtCodigoActivo.Enabled = false;
            cbxGrupo.Enabled = true;
            txtSubgrupo.Enabled = true;
            cbxEstado.Enabled = true;
            dtFecha.Enabled = true;
            cbxEmpresa.Enabled = true;

        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnbuscar.Enabled = false;
            //txtCodigoActivo.Enabled = false;
            cbxGrupo.Enabled = false;
            txtSubgrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            cbxEmpresa.Enabled = false;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            cbxGrupo.EditValue = "";
            txtSubgrupo.Text = "";
            dtFecha.EditValue = "";
            cbxEstado.Text = "";
            cbxEmpresa.Text = "";

        }

        #endregion


        #region"Operaciones Basicas"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(msj.Cancelar, msj.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            accion = 'C';

            VtnConsultaSubgrupo frm = new VtnConsultaSubgrupo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = false;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnModificar.Enabled = true;//
                btnEliminar.Enabled = true;//
                oActivoFijo = frm.cls;//Aqui lo que hace es pasar los datos de la pantalla consulta a la variable de la calse
                //de SUbgrupo con la ayuda de la variable cls la cual en la pantalla de consulta se les
                //paso todos los datos que poseia el gridView al momento de dar clic en la operacion 
                //GridView_RowClick
                set(oActivoFijo);
            }
            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnModificar.Enabled = false;//
                btnEliminar.Enabled = false;//
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            limpiarControles();

        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (getValor())
            {
                if (clase.Codigo == 0)
                {
                    if (datoActivoFijo.guardar(clase))
                    {
                        MessageBox.Show(msj.Guardar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (datoActivoFijo.modificar(clase))
                    {
                        MessageBox.Show(msj.Modificar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Modificar_error);
                    }

                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = 'E';
            try
            {
                if (accion == 'E')
                {
                    if (datoActivoFijo.eliminar(clase))
                    {
                        MessageBox.Show(msj.Eliminar_ok);
                        limpiarControles();
                        BloquearControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Eliminar_error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = 'M';
            try
            {
                getValor();
                if (accion == 'M')
                {
                    if (datoActivoFijo.modificar(clase))//Esto va hacer que compare si el resultado de esta opdracion es true o false tal como se declara la funsion en datos de tipo boolean
                    {
                        MessageBox.Show(msj.Modificar_ok);
                        limpiarControles();
                        BloquearControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Modificar_error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(msj.Modificar_error); ;
            }


        }


        #endregion



    }
}
