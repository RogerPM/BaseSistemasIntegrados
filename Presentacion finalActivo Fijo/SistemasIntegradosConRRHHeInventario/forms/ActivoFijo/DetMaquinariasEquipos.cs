using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;
using datos.Inventario;
using clases.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class DetMaquinariasEquipos : UserControl
    {
        public DetMaquinariasEquipos()
        {
            InitializeComponent();
        }

        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        datMarca datoMarca = new datMarca();
        datModelo datoModelo = new datModelo();
        datColor datoColor = new datColor();

        clsClaseDatosActivoFijo datoActivosFijos = new clsClaseDatosActivoFijo();
        clsEquipoMaquinariaMebles oMaquinariaEquipo = new clsEquipoMaquinariaMebles();
        clsActivoFijo oActivoFijo = new clsActivoFijo();

        public clsEquipoMaquinariaMebles auxiEquipMaqu { get; set; }

        private void DetMaquinariasEquipos_Load(object sender, EventArgs e)
        {
            //llenamos el combo de la Persona que es Proveedor
            cbxProveedor.Properties.DataSource = datoProvePersoBajaActivo.consultaEspecial();


            //llenamos el combo de Marca 
            cbxMarca.Properties.DataSource = datoMarca.consulta();

            //llenamos el combo de Modelo 
            cbxModelo.Properties.DataSource = datoModelo.consulta();

            //llenamos el combo de Color 
            cbxColor.Properties.DataSource = datoColor.consulta();

        }

        private void dtFechaAdquisicion_EditValueChanged(object sender, EventArgs e)
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
        public void limpiarMaquinariasEquipos()
        {
            cbxMarca.EditValue = null;
            cbxProveedor.EditValue = null;
            cbxModelo.EditValue = null;
            cbxColor.EditValue = null;
            txtCarga.Text = "";
            txtCantidad.Text = "";
            dtFechaAdquisicion.EditValue = null;
            txtCosto.Text = "";
            txtV_Adquisicion.Text = "";
            txtV_Residual.Text = "";
            rtbObservacion.Text = "";           
            txtAñosDepreciados.Text = "";
            txtAñosVidaUtil.EditValue = null;
            txtDimenAncho.Text = "";
            txtDimenLargo.Text = "";
          
        }

        public bool getValorMaquinariasEquipos(clsActivoFijo auxi)
        {
            oMaquinariaEquipo.idCodActivoFijo = oActivoFijo.Codigo;


            if ((cbxMarca.EditValue == null || cbxModelo.EditValue == null) || (dtFechaAdquisicion.EditValue == null) ||
               (cbxColor.EditValue == null) || (txtCarga.Text== "") || (rtbObservacion.Text == "") || (txtCantidad.Text == "") || (txtDimenAlto.Text== "") || (txtDimenAncho.Text =="")||(txtDimenLargo.Text=="")|| (txtAñosDepreciados.Text =="")|| (txtAñosVidaUtil.Text=="")||
               (cbxProveedor.EditValue == null) || (txtCosto.Text == "") || (txtV_Adquisicion.Text == "") || (txtV_Residual.Text == ""))
            {
                return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }

            oMaquinariaEquipo.idMarca = datoActivosFijos.getIdSegunDescripcionInventarioMarca(cbxMarca.Text);
            oMaquinariaEquipo.idModelo = datoActivosFijos.getIdSegunDescripcionInventarioModelo(cbxModelo.Text);
            oMaquinariaEquipo.idColor = datoActivosFijos.getIdSegunDescripcionInventarioColor(cbxColor.Text);
            oMaquinariaEquipo.carga = Convert.ToDouble ( txtCarga.Text);
            oMaquinariaEquipo.observacion = rtbObservacion.Text;
            oMaquinariaEquipo.DimenAncho = Convert.ToDouble(txtDimenAncho.Text);
            oMaquinariaEquipo.DimenLargo = Convert.ToDouble(txtDimenLargo.Text);
            oMaquinariaEquipo.DimenAlto = Convert.ToDouble(txtDimenAlto.Text);
            oMaquinariaEquipo.AniosDepreciados = Convert.ToInt32(txtAñosDepreciados.Text);

            auxi.Fecha_Adquisicion = Convert.ToDateTime(dtFechaAdquisicion.EditValue);
            auxi.Cantidad = Convert.ToInt32(txtCantidad.Text);
            auxi.proveedor = datoActivosFijos.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
            auxi.ano_vidautil = Convert.ToInt32 ( txtAñosVidaUtil.Text);
            auxi.valor_nominal = Convert.ToDouble(txtCosto.Text);
            auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
            auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);

            auxiEquipMaqu = oMaquinariaEquipo;

            return true;

        }

        public void setMaquinariasEquipos(clsActivoFijo auxi)
        {
            oMaquinariaEquipo = datoActivosFijos.consultaEquiposMaquinariasMuebles(auxi.Codigo);//Consulta de sincronizacion

            cbxMarca.Text = datoActivosFijos.getDescripcionSegunIdInventarioMarca(oMaquinariaEquipo.idMarca);
            cbxModelo.Text = datoActivosFijos.getDescripcionSegunIdInventarioModelo(oMaquinariaEquipo.idModelo);
            cbxColor.Text = datoActivosFijos.getDescripcionSegunIdInventarioColor(oMaquinariaEquipo.idColor);
            txtCarga.Text = Convert.ToString(oMaquinariaEquipo.carga);
            rtbObservacion.Text = oMaquinariaEquipo.observacion;
            txtDimenAncho.Text = Convert.ToString(oMaquinariaEquipo.DimenAncho);
            txtDimenLargo.Text = Convert.ToString(oMaquinariaEquipo.DimenLargo);
            txtDimenAlto.Text = Convert.ToString(oMaquinariaEquipo.DimenAlto);
            txtAñosDepreciados.Text = Convert.ToString(oMaquinariaEquipo.AniosDepreciados);

            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            txtCantidad.Text = Convert.ToString(auxi.Cantidad);
            cbxProveedor.Text = datoActivosFijos.getDescripcionSegunIdComprasProveedor(auxi.proveedor);
            txtAñosVidaUtil.Text = Convert.ToString(auxi.ano_vidautil);
            txtCosto.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
            txtV_Adquisicion.Text = Convert.ToString(auxi.valor_actualserie);
        }
       
    }
}
