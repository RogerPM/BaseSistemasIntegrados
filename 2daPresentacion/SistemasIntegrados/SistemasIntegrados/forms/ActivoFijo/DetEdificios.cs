using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using datos.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class DetEdificios : UserControl
    {
        public DetEdificios()
        {
            InitializeComponent();
        }
        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();

        clsClaseDatosActivoFijo datoActivosFijos = new clsClaseDatosActivoFijo();
        clsEdificio oEdificio = new clsEdificio();
        clsActivoFijo oActivoFijo = new clsActivoFijo();

        public clsEdificio auxiEdificio { get; set; }

        private void DetEdificios_Load(object sender, EventArgs e)
        {
            //llenamos el combo de la Persona que es Proveedor
            cbxProveedor.Properties.DataSource = datoProvePersoBajaActivo.consultaEspecial();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicional_Click(object sender, EventArgs e)
        {
            if (rtbObservacion.Enabled == true)
            {
                rtbObservacion.Enabled = false;
            }
            else
            {
                rtbObservacion.Enabled = true;
            }
        }

        public void limpiarEdificio()
        {
            cbxProveedor.EditValue = null;
            dtFechaAdquisicion.EditValue = null;
            dtFechaConstruccion.EditValue = null;
            txtAvaluo.Text = "";
            txtV_Adquisicion.Text = "";
            txtV_Residual.Text = "";
            rtbObservacion.Text = "";
            txtNoPisos.Text = "";
            txtAñosDepreciados.Text = "";
            txtCodigoCatastral.Text = "";
            txtDimAncho.Text = "";
            txtDimLargo.Text = "";
            txtUbicacion.Text = "";
            txtAñosVidaUtil.EditValue = null;

        }

        public bool getValorEdificios(clsActivoFijo auxi)
        {
            oEdificio.idCodActivoFijo = oActivoFijo.Codigo;


            if ((cbxProveedor.EditValue == null || dtFechaConstruccion.EditValue == null) || (dtFechaAdquisicion.EditValue == null) ||
               (txtDimAncho.Text == "") || (txtDimLargo.Text == "") || (txtNoPisos.Text == "") || (txtAñosDepreciados.Text == "") || (txtAñosVidaUtil.SelectedText == "") || (txtAvaluo.Text == "") || (txtV_Residual.Text == "") || (txtV_Adquisicion.Text == "") || (txtV_Residual.Text == "" || (txtCodigoCatastral.Text =="") || txtUbicacion.Text==""|| rtbObservacion.Text =="" ))
            {
                return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }
         
            oEdificio.fechaConstruccion = Convert.ToDateTime(dtFechaConstruccion.EditValue);          
            oEdificio.DimenAncho = Convert.ToDouble(txtDimAncho);
            oEdificio.DimenLargo = Convert.ToDouble(txtDimLargo);
            oEdificio.NumPisos = Convert.ToInt32(txtNoPisos.Text);
            oEdificio.AniosDepreciados = Convert.ToInt32(txtAñosDepreciados);
            oEdificio.codCatrastal = Convert.ToString(txtCodigoCatastral.Text);
            oEdificio.ubicacion = Convert.ToString(txtUbicacion.Text);
            oEdificio.observacion = Convert.ToString(rtbObservacion.Text);

            auxi.Fecha_Adquisicion = Convert.ToDateTime(dtFechaAdquisicion.EditValue);
            auxi.proveedor = datoActivosFijos.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
            auxi.ano_vidautil =Convert.ToInt32( txtAñosVidaUtil.Text);
            auxi.valor_nominal = Convert.ToDouble(txtAvaluo.Text);
            auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
            auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.Cantidad = 1;

            auxiEdificio = oEdificio;
            return true;

        }

        public void setEdificios(clsActivoFijo auxi)
        {
            oEdificio = datoActivosFijos.consultaEdificios(auxi.Codigo);//Consulta de sincronizacion


            dtFechaConstruccion.EditValue = Convert.ToDateTime(oEdificio.fechaConstruccion);
            txtDimAncho.Text =Convert.ToString( oEdificio.DimenAncho);
            txtDimLargo.Text = Convert.ToString(oEdificio.DimenLargo);
            txtNoPisos.Text = Convert.ToString(oEdificio.NumPisos);
            txtAñosDepreciados.Text = Convert.ToString(oEdificio.AniosDepreciados);
            txtCodigoCatastral.Text = Convert.ToString(oEdificio.codCatrastal);
            txtUbicacion.Text = Convert.ToString(oEdificio.ubicacion);
            rtbObservacion.Text = Convert.ToString(oEdificio.observacion);

            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            cbxProveedor.Text = datoActivosFijos.getDescripcionSegunIdComprasProveedor(auxi.proveedor);
            txtAñosVidaUtil.Text = Convert.ToString(auxi.ano_vidautil);
            txtAvaluo.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
            txtV_Adquisicion.Text = Convert.ToString(auxi.valor_actualserie);

        }


    }
}
