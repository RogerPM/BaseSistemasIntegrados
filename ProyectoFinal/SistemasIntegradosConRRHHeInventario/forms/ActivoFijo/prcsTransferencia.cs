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
    public partial class prcsTransferencia : Form
    {
        public char accion { get; set; }
        clsClaseDatosGrupo datoGrupo = new clsClaseDatosGrupo();
        clsClaseDatosSubgrupoActivoFijo datoSubGrup = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosActivoFijo datoActivoFijo = new clsClaseDatosActivoFijo();
        clsClaseDatosTransferenciaActivo datotransferencia = new clsClaseDatosTransferenciaActivo();
        datBodega datosbodega = new datBodega();
        datEmpresa datosempresa = new datEmpresa();
        clsDatosDepartamento datosdepartamento = new clsDatosDepartamento();




         clsActivoFijo oactivofijo = new clsActivoFijo();
         public clsTransferencia otransferencia = new clsTransferencia();
        datEstado datoEsta = new datEstado();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();



        public prcsTransferencia()
        {
            InitializeComponent();
        }

        #region"Evento Load"

        private void prcsTransferencia_Load(object sender, EventArgs e)
        {
            //userPrincipal frm = new userPrincipal();
            //pnlCargar.Controls.Add(frm);
            //Llenamos el combo grupo de inventario en la pantalla 


            cbxGrupo.Properties.DataSource = datoGrupo.consultaGrupo();
            cbxBodegaFutura.Properties.DataSource = datosbodega.consulta();
            cbxEmpresa.Properties.DataSource = datosempresa.Consultar();
            cbxDepartamento.Properties.DataSource = datosdepartamento.ConsultaDepartamento();


            BloquearControles();
            cbxEstado.Properties.DataSource = datoEsta.ConsultaTodos();
            cbxSubGrupo.Properties.DataSource = datoSubGrup.consulta();
            dtFecha.DateTime = DateTime.Now;

            

        }
        #endregion


        #region"Operaciones de Controles"

        public void set(clsActivoFijo ActiFijo)
        {
            txtCodigoActivo.Text = Convert.ToString(ActiFijo.Codigo);
            cbxGrupo.EditValue = datoActivoFijo.getDescripcionSegunIdInventarioGrupo(ActiFijo.grupo);
            cbxSubGrupo.EditValue = datoSubGrup.getDescripcionSegunIdActivoFIjoSubGrupo(ActiFijo.subgrupo);
            dtFecha.EditValue = ActiFijo.fecha_registro;
            cbxEstado.EditValue = datoEsta.getDescripcionSegunId(ActiFijo.estado);
            txtDescripcion.Text = ActiFijo.descripcion;
        }


        public bool getValor()
        {
            otransferencia.idActivoFijo = 0;//PK //lo que se hace aqui es colocar los pk en 0 para que se las pueda utilizar 

            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }
            else
            {


                if ((txtCodigoActivo.Text == "" || cbxGrupo.EditValue == null) || (dtFecha.EditValue == null) ||
                    (cbxSubGrupo.EditValue == null) || (cbxEstado.EditValue == null) || (txteUsuario.Text == "") || (txtDescripcion.Text == ""))
                {
                    return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                    //bote un error 
                }

                otransferencia.fecha = Convert.ToDateTime(dtFecha.EditValue);
                otransferencia.Observaciones = Convert.ToString(txtDescripcion.Text);
                otransferencia.idActivoFijo = Convert.ToInt32(txtCodigoActivo.Text);//Se llena el campo del acivo fijo 

                return true;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote que todos los datos estan llenos 
            }

        }


        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;

            btnConsultar.Enabled = true;
            btnBuscar.Enabled = true;

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
            cbxTraspaso.Enabled = false;
            cbxGrupo.Enabled = false;
            cbxSubGrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            txtDescripcion.Enabled = false;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            cbxGrupo.EditValue = "";
            cbxSubGrupo.Text = "";
            //dtFecha.EditValue = "";
            cbxEstado.Text = "";
            txtDescripcion.Text = "";
            cbxTraspaso.Text = "";
            cbxEmpresa.Text = "";
            cbxBodegaFutura.Text = "";
            cbxDepartamento.Text = "";
            btneResponsable.Text = "";



        }



        #endregion


        #region"Operaciones Basicas"

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VtnConsultaActivoFijo frm = new VtnConsultaActivoFijo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                //btnAnular.Enabled = true;//
                //btnConsultar.Enabled = true;//

                oactivofijo = frm.cls;
                set(oactivofijo);
                cbxTraspaso.Enabled = true;
            }

            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                cbxTraspaso.Enabled = false;

                btnConsultar.Enabled = false;//
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (getValor())
            {

                if (otransferencia.idActivoFijo == 0)
                {

                    if (datotransferencia.guardartransferencia(otransferencia))
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
                    if (datotransferencia.modificar(otransferencia))
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
        
      #endregion




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
            HabilitarControles();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


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

        private void cbxTraspaso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTraspaso.SelectedItem.Equals("Bodega"))
            {
                SeteoBodega(true);
                SeteoDepartamento(false);
                SeteoResponsable(true);
                SeteoObservacion(true);

            }
            else
            {
                if (cbxTraspaso.SelectedItem.Equals("Departamento"))
                {
                    SeteoDepartamento(true);
                    SeteoBodega(false);
                    SeteoResponsable(true);
                    SeteoObservacion(true);
                }
            }
        }


        public void SeteoDepartamento(Boolean prm)
        {
            cbxDepartamento.Enabled = prm;
        }

        public void SeteoBodega(Boolean prm)
        {
            cbxBodegaFutura.Enabled = prm;
        }

        public void SeteoResponsable(Boolean prm)
        {
            btneResponsable.Enabled = prm;
        }

        public void SeteoObservacion(Boolean prm)
        {
            rtbxDetalle.Enabled = prm;
        }

        private void cbxDepartamento_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxEmpresa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gbxTransferencia_Enter(object sender, EventArgs e)
        {

        }



















    }





}