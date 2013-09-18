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
    public partial class DetArticulo : UserControl
    {
        public DetArticulo()
        {
            InitializeComponent();
        }


        public clsArticulo_SuministroOfic auxiArtic { get; set; }

        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        datMarca datoMarca = new datMarca();
        datModelo datoModelo = new datModelo();
        datColor datoColor = new datColor();
        datTipoMaterial datoMaterial = new datTipoMaterial();

        clsClaseDatosActivoFijo datoActivosFijos = new clsClaseDatosActivoFijo();
        clsArticulo_SuministroOfic oArticuloSuminis = new clsArticulo_SuministroOfic ();
        clsActivoFijo oActivoFijo = new clsActivoFijo();

        private void DetArticulo_Load(object sender, EventArgs e)
        {
            //llenamos el combo de la Persona que es Proveedor
            cbxProveedor.Properties.DataSource = datoProvePersoBajaActivo.consultaEspecial();

            //llenamos el combo de Marca 
            cbxMarca.Properties.DataSource = datoMarca.consulta();

            //llenamos el combo de Modelo 
            cbxModelo.Properties.DataSource = datoModelo.consulta();

            //llenamos el combo de Color 
            cbxColor.Properties.DataSource = datoColor.consulta();

            //llenamos el combo de Material 
            cbxMaterial.Properties.DataSource = datoMaterial.consulta();
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

        public void limpiarArticulo() 
        {
            cbxIdentDescripcion.SelectedIndex = -1;
            cbxMarca.EditValue = null;
            cbxProveedor.EditValue = null;
            cbxModelo.EditValue = null;
            cbxColor.EditValue = null;
            cbxMaterial.EditValue = null;
            txtCantidad.Text = "";
            dtFechaAdquisicion.EditValue = null;
            txtCosto.Text = "";
            txtV_Adquisicion.Text = "";
            txtV_Residual.Text = "";
            rtbObservacion.Text = "";
        }


        public bool  getValorArticulo(clsActivoFijo auxi)
        {
            oArticuloSuminis.idCodActivoFijo = oActivoFijo.Codigo;

            
                if ((cbxMarca.EditValue== null || cbxModelo.EditValue == null) || (dtFechaAdquisicion.EditValue == null) ||
                   (cbxColor.EditValue == null) || (cbxMaterial.EditValue == null) || (rtbObservacion.Text == "") || (txtCantidad.Text == "") || (cbxIdentDescripcion.SelectedText=="")|| 
                   (cbxProveedor.EditValue==null)|| (txtCosto.Text =="") || (txtV_Adquisicion.Text=="") || (txtV_Residual.Text==""))
                {
                    return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                    //bote un error 
                }

                oArticuloSuminis.idMarca = datoActivosFijos.getIdSegunDescripcionInventarioMarca(cbxMarca.Text);
                oArticuloSuminis.idModelo = datoActivosFijos.getIdSegunDescripcionInventarioModelo(cbxModelo.Text);
                oArticuloSuminis.idColor = datoActivosFijos.getIdSegunDescripcionInventarioColor(cbxColor.Text);
                oArticuloSuminis.idMaterial = datoActivosFijos.getIdSegunDescripcionInventarioMaterial(cbxMaterial.Text);
                oArticuloSuminis.Observacion = rtbObservacion.Text;

                auxi.Fecha_Adquisicion = Convert.ToDateTime ( dtFechaAdquisicion.EditValue);
                auxi.Cantidad = Convert.ToInt32 ( txtCantidad.Text);
                auxi.proveedor = datoActivosFijos.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
                auxi.ano_vidautil = 0;
                auxi.valor_nominal =Convert.ToDouble (txtCosto.Text);
                auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
                auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
                auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);

                auxiArtic = oArticuloSuminis;

                return true;
            
        }

        public void setArticulo(clsActivoFijo auxi)
        {
            oArticuloSuminis = datoActivosFijos.consultaArticulos_Suministros(auxi.Codigo);

            cbxMarca.Text = datoActivosFijos.getDescripcionSegunIdInventarioMarca(oArticuloSuminis.idMarca);
            cbxModelo.Text = datoActivosFijos.getDescripcionSegunIdInventarioModelo(oArticuloSuminis.idModelo);
            cbxColor.Text = datoActivosFijos.getDescripcionSegunIdInventarioColor(oArticuloSuminis.idColor);
            cbxMaterial.Text = datoActivosFijos.getDescripcionSegunIdInventarioMaterial(oArticuloSuminis.idMaterial);
            rtbObservacion.Text = oArticuloSuminis.Observacion;

            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            txtCantidad.Text = Convert.ToString(auxi.Cantidad);
            cbxProveedor.Text = datoActivosFijos.getDescripcionSegunIdComprasProveedor(auxi.proveedor);

            txtCosto.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
            txtV_Adquisicion.Text = Convert.ToString(auxi.valor_actualserie);
        }

    }
}
