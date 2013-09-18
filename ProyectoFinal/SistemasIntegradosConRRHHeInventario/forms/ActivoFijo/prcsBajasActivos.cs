using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using clases.ActivoFijo;
using datos.Seguridad;
using datos.Inventario;
using datos.ActivoFijo;
using datos.RecursosHumanos;

namespace forms.ActivoFijo
{
    public partial class prcsBajasActivos : Form
    {
        
        clsClaseDatosGrupo datoGrupo = new clsClaseDatosGrupo();
        clsClaseDatosSubgrupoActivoFijo datoSubGrup = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosActivoFijo datoActivoFijo = new clsClaseDatosActivoFijo();
        clsDatosBajaActivoProce datoBajaActivoPro = new clsDatosBajaActivoProce();
        datEmpresa datosempresa = new datEmpresa();
        datosmotivobaja datosmotivobaja = new datosmotivobaja();




        clsActivoFijo oactivofijo = new clsActivoFijo();
        clsActivoFijo kauxi = new clsActivoFijo();
        clsBajaActivoProc oBajaActivopro = new clsBajaActivoProc();
        datEstado datoEsta = new datEstado();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();







        public prcsBajasActivos()
        {
            InitializeComponent();
        }

        #region"Evento Load"
        private void prcsBajasActivos_Load(object sender, EventArgs e)
        {
            //userPrincipal clss = new userPrincipal();
            //cbxGrupo.Properties.DataSource= datoGrupo.consultaGrupo();

            cbxGrupo.Properties.DataSource = datoGrupo.consultaGrupo();
            cbxMotivo.Properties.DataSource = datosmotivobaja.Consultar();
            BloquearControles();
            cbxEstado.Properties.DataSource = datoEsta.ConsultaTodos();
            cbxSubGrupo.Properties.DataSource = datoSubGrup.consulta();
            dtFecha.DateTime = DateTime.Now;
            cbxMotivo.Enabled= true;
            
        }


        #endregion

        #region "Operaciones de controles "

        public void set(clsActivoFijo ActiFijo)
        {
            txtCodigoActivo.Text = Convert.ToString(ActiFijo.Codigo);
            cbxMotivo.EditValue = datoActivoFijo.getDescripcionSegunIdInventarioGrupo(ActiFijo.grupo);
            cbxGrupo.EditValue = datoActivoFijo.getDescripcionSegunIdInventarioGrupo(ActiFijo.grupo);
            cbxSubGrupo.EditValue = datoSubGrup.getDescripcionSegunIdActivoFIjoSubGrupo(ActiFijo.subgrupo);
            dtFecha.EditValue = ActiFijo.fecha_registro;
            cbxEstado.EditValue = datoEsta.getDescripcionSegunId(ActiFijo.estado);
            txtDescripcion.Text = ActiFijo.descripcion;
            
        }


        public bool getValor()
        {
            oBajaActivopro.codBajaActivo = 0;//PK //lo que se hace aqui es colocar los pk en 0 para que se las pueda utilizar 

            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }
            else
            {


                if ((txtCodigoActivo.Text == "" || cbxMotivo.EditValue == null) || (dtFecha.EditValue == null) ||
                    (cbxSubGrupo.EditValue == null) || (cbxEstado.EditValue == null) || (txteUsuario.Text == "") || (txtDescripcion.Text == ""))
                {
                    return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                    //bote un error 
                }

                oBajaActivopro.fecha = Convert.ToDateTime(dtFecha.EditValue);
                oBajaActivopro.descripcion = txtDescripcion.Text;
                oBajaActivopro.Observacion = Convert.ToString(rtObservacion.Text);
                oBajaActivopro.idActivoFijo = Convert.ToInt32(txtCodigoActivo.Text);//Se llena el campo del acivo fijo 
                oBajaActivopro.Empresa = kauxi.Empresa;
                oBajaActivopro.IdMotivoBaja =datoActivoFijo.getIdSegunDescripcionIdMotivo(cbxMotivo.Text);
                //oBajaActivopro.idImagen = 1;
                oBajaActivopro.estadoproceso = oactivofijo._EstadoProceso;
                return true;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote que todos los datos estan llenos 
            }

        }

        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;

            btnConsultar.Enabled = true;
            btnBuscar.Enabled = true;
            cbxMotivo.Enabled = true;
            //btnProcesar.Enabled = true;
            //txtCodigoActivo.Enabled = false;
            //cbxGrupo.Enabled = true;
            //cbxSubGrupo.Enabled = true;
            //cbxEstado.Enabled = true;
            //dtFecha.Enabled = true;
            //txtDescripcion.Enabled = true;
            //GridDepreciacion.Enabled = true;
        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnConsultar.Enabled = false;
            btnBuscar.Enabled = false;
            cbxMotivo.Enabled = false;
            cbxSubGrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            txtDescripcion.Enabled = false;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            cbxMotivo.EditValue = "";
            cbxSubGrupo.Text = "";
            //dtFecha.EditValue = "";
            cbxEstado.Text = "";
            txtDescripcion.Text = "";
            


        }


        #endregion 


        #region"Operaciones Basicas"

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            if (getValor())
            {
                if (oBajaActivopro.idActivoFijo == 0 )
                {
                    if (datoBajaActivoPro.guardar(oBajaActivopro))
                    {
                        MessageBox.Show(msj.Guardar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion







        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(msj.Eliminar_ok);
                limpiarControles();
                BloquearControles();
                {
                    MessageBox.Show(msj.Eliminar_error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
            HabilitarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxGrupo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            VtnConsultaActivoFijo frm = new VtnConsultaActivoFijo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                //btnAnular.Enabled = true;//
                
                

                oactivofijo = frm.cls;
                set(oactivofijo);
            }
            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnConsultar.Enabled = false;//
                
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cbxGrupo_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cbxMotivo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void clsMotivoBajaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (getValor())
            {

                if (oBajaActivopro.codBajaActivo == 0)
                {

                    if (datoBajaActivoPro.guardar(oBajaActivopro))
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
                    if (datoBajaActivoPro.modificar(oBajaActivopro))
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

        
        

        
    }
}
