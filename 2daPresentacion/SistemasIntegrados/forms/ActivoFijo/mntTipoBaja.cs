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
    public partial class mntTipoBaja : Form
    {
        public mntTipoBaja()
        {
            InitializeComponent();
        }

        //Declare una instancia de la clase de Subgrupos para poder llenar los datos
        public char accion { get; set; }
        // public clsSubgrupoActivoFijo clase = new clsSubgrupoActivoFijo();
        // clsSubgrupoActivoFijo oSubGrupo = new clsSubgrupoActivoFijo();
        //clsEmpresa oEmpresa = new clsEmpresa();
        //clsEstado  oEstado  = new clsEstado();
        //clsGrupo   oGrupo   = new clsGrupo();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();
        clsBajaActivo oBajaActivo = new clsBajaActivo();

        clsClaseDatosSubgrupoActivoFijo datoSubgrupo = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosGrupo datGrupo = new clsClaseDatosGrupo();
        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        datEstado datoEstado = new datEstado();
        datEmpresa datoEmpresa = new datEmpresa();

        clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();




        //public clsClaseDatosBajaActivo clas = new clsClaseDatosBajaActivo();
        private void mntTipoBaja_Load(object sender, EventArgs e)
        {
            //Llenamos el combo grupo de inventario en la pantalla 

            cbxGrupo.Properties.DataSource = datGrupo.consultaGrupo();

            //Llenamos el combo de Estado de Seguridad en la pantalla
            cbxEstado.Properties.DataSource = datoEstado.ConsultaTodos();

            //Llenamos el combo de Empresa de Seguridad en la pantalla
            cbxEmpresa.Properties.DataSource = datoEmpresa.Consultar();

            //llenamos el combo de Subgrupo de ActivoFijo en la pantalla
            cbxSubGrupo.Properties.DataSource = datoSubgrupo.consulta();

            //llenamos el combo de la Persona que es Proveedor
            cbxProveedor.Properties.DataSource = datoProvePersoBajaActivo.consultaEspecial();
        }


        #region"Operaciones de Controles"
        //public void set(clsBajaActivo  oBajaActivo)
        //{
        //   // txtCodigoActivo.Text = Convert.ToString(oBajaActivo.Codigo);
        //    cbxGrupo.EditValue = datoActivo.getDescripcionSegunIdInventarioGrupo(oBajaActivo.Grupo);
        //    cbxSubGrupo.Text = datoSubgrupo.getDescripcionSegunIdActivoFIjoSubGrupo (oBajaActivo.Subgrupo);
        //    dtFecha.EditValue = oBajaActivo.Fecha;
        //    txtDescripcion.Text  = oBajaActivo.Descripcion;
        //    cbxEstado.EditValue = datoEstado.getDescripcionSegunId(oBajaActivo.IdEstado);
        //    cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId(oBajaActivo.IdEmpresa);
        //}

        public bool getValor()
        {

            //if (txtCodigoActivo.Text == "" || txtCodigoActivo.Text == "0")
            //{
            //    clase.Codigo = 0;//PK
            //}
            //else
            //{
            //    clase.Codigo = Convert.ToInt32(txtCodigoActivo.Text);
            //}
            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;
            }
            else
            {


                //if ((txtSubgrupo.Text == null || txtSubgrupo.Text == "") || (dtFecha.EditValue == null) ||
                //    (cbxGrupo.EditValue == null) || (cbxEmpresa.EditValue == null) || (cbxEstado.EditValue == null))
                //{
                //    return false;
                //}

                ////clase.Codigo  =Convert.ToInt32 (txtCodigoActivo.Text);
                //clase.descripcion = txtSubgrupo.Text;
                //clase.Fecha = Convert.ToDateTime(dtFecha.EditValue);
                //oGrupo.Descripcion = Convert.ToString(cbxGrupo.EditValue);//Se llena el campo descripcion del estado
                //clase.Grupo = Convert.ToInt32(datoActivoFijo.getIdSegunDescripcionInventarioGrupo(oGrupo.Descripcion));
                //oEstado.descripcion = Convert.ToString(cbxEstado.EditValue);//Se llena el campo descripcion del estado
                //clase.IdEstado = Convert.ToInt32(datoEstado.getIdSegunDescripcion(oEstado.descripcion));
                //oEmpresa.descripcion = Convert.ToString(cbxEmpresa.EditValue);//se llena el campo descripcion de la empresa
                //clase.Empresa = Convert.ToInt32(datoEmpresa.ConsultarPorNombreComercial(oEmpresa.descripcion));


                return true;
            }
        }

        private void HabilitarControles()
        {
            //btnGuardar.Enabled = true;
            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
            //btnbuscar.Enabled = true;
            //txtCodigoActivo.Enabled = false;
            //cbxGrupo.Enabled = true;
            //txtSubgrupo.Enabled = true;
            //cbxEstado.Enabled = true;
            //dtFecha.Enabled = true;
            //cbxEmpresa.Enabled = true;

        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;
            //txtCodigoActivo.Enabled = false;
            cbxGrupo.Enabled = false;
            //txtSubgrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            cbxEmpresa.Enabled = false;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            cbxGrupo.EditValue = "";
            cbxSubGrupo.EditValue = "";
            dtFecha.EditValue = "";
            cbxEstado.Text = "";
            cbxEmpresa.Text = "";

        }

        #endregion




        private void btneCodigoActivo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VtnConsultaTipoBaja frm = new VtnConsultaTipoBaja();
            frm.ShowDialog();

            if (frm.Cancelar())
            {
                btnGuardar.Enabled = false;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnModificar.Enabled = true;//
                btnEliminar.Enabled = true;//
                oBajaActivo = frm.cls;
                //set(oBajaActivo);
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

        private void cbxProveedor_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
