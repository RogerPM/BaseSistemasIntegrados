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
using datos.Inventario;

namespace forms.ActivoFijo
{
    public partial class DetMueblesEnseres : UserControl
    {
        public DetMueblesEnseres()
        {
            InitializeComponent();
        }

        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        datMarca datoMarca = new datMarca();
        datModelo datoModelo = new datModelo();
        datColor datoColor = new datColor();

        clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();
        clsEquipoMaquinariaMebles oEquipoMaquMueb = new clsEquipoMaquinariaMebles();
        clsActivoFijo oActivoFijo = new clsActivoFijo();

        public clsEquipoMaquinariaMebles auxiMuebles { get; set; }
        
        private void DetMueblesEnseres_Load(object sender, EventArgs e)
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

        public void limpiarMueblesEnseres()
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
            txtDimenAlto.Text = "";

        }


        public bool getValorMueblesEnseres(clsActivoFijo auxi)
        {
            oEquipoMaquMueb.idCodActivoFijo = oActivoFijo.Codigo;
            if ((cbxMarca.EditValue == null || cbxModelo.EditValue == null) || (dtFechaAdquisicion.EditValue == null) ||
               (cbxColor.EditValue == null) || (txtCarga.Text == "") || (rtbObservacion.Text == "") || (txtCantidad.Text == "") || (txtDimenAlto.Text == "") || (txtDimenAncho.Text == "") || (txtDimenLargo.Text == "") || (txtAñosDepreciados.Text == "") || (txtAñosVidaUtil.Text == "") ||
               (cbxProveedor.EditValue == null) || (txtCosto.Text == "") || (txtV_Adquisicion.Text == "") || (txtV_Residual.Text == ""))
            {
                return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }

            oEquipoMaquMueb.idMarca = datoActivo.getIdSegunDescripcionInventarioMarca(cbxMarca.Text);
            oEquipoMaquMueb.idModelo = datoActivo.getIdSegunDescripcionInventarioModelo(cbxModelo.Text);
            oEquipoMaquMueb.idColor = datoActivo.getIdSegunDescripcionInventarioColor(cbxColor.Text);
            oEquipoMaquMueb.carga = Convert.ToDouble(txtCarga.Text);
            oEquipoMaquMueb.observacion = rtbObservacion.Text;
            oEquipoMaquMueb.DimenAncho = Convert.ToDouble(txtDimenAncho.Text);
            oEquipoMaquMueb.DimenLargo = Convert.ToDouble(txtDimenLargo.Text);
            oEquipoMaquMueb.DimenAlto = Convert.ToDouble(txtDimenAlto.Text);
            oEquipoMaquMueb.AniosDepreciados = Convert.ToInt32(txtAñosDepreciados.Text);

            auxi.Fecha_Adquisicion = Convert.ToDateTime(dtFechaAdquisicion.EditValue);
            auxi.Cantidad = Convert.ToInt32(txtCantidad.Text);
            auxi.proveedor = datoActivo.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
            auxi.ano_vidautil = Convert.ToInt32(txtAñosVidaUtil.Text);
            auxi.valor_nominal = Convert.ToDouble(txtCosto.Text);
            auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
            auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);

            auxiMuebles = oEquipoMaquMueb;
            return true;
        }

        public void setMueblesEnseres(clsActivoFijo auxi)
        {
            oEquipoMaquMueb = datoActivo.consultaEquiposMaquinariasMuebles(auxi.Codigo);//Consulta de sincronizacion

            cbxMarca.Text = datoActivo.getDescripcionSegunIdInventarioMarca(oEquipoMaquMueb.idMarca);
            cbxModelo.Text = datoActivo.getDescripcionSegunIdInventarioModelo(oEquipoMaquMueb.idModelo);
            cbxColor.Text = datoActivo.getDescripcionSegunIdInventarioColor(oEquipoMaquMueb.idColor);

            txtCarga.Text = Convert.ToString(oEquipoMaquMueb.carga);
            rtbObservacion.Text = oEquipoMaquMueb.observacion;
            txtDimenAncho.Text = Convert.ToString(oEquipoMaquMueb.DimenAncho);
            txtDimenLargo.Text = Convert.ToString(oEquipoMaquMueb.DimenLargo);
            txtDimenAlto.Text = Convert.ToString(oEquipoMaquMueb.DimenAlto);
            txtAñosDepreciados.Text = Convert.ToString(oEquipoMaquMueb.AniosDepreciados);

            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            txtCantidad.Text = Convert.ToString(auxi.Cantidad);
            cbxProveedor.Text = datoActivo.getDescripcionSegunIdComprasProveedor(auxi.proveedor);
            txtAñosVidaUtil.Text = Convert.ToString(auxi.ano_vidautil);
            txtCosto.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
            txtV_Adquisicion.Text = Convert.ToString(auxi.valor_actualserie);
        }

    }
}
