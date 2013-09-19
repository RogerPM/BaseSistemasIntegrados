using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;
using clases.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class DetTerrenos : UserControl
    {
        public DetTerrenos()
        {
            InitializeComponent();
        }

        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();

        clsClaseDatosActivoFijo datoActivosFijos = new clsClaseDatosActivoFijo();
        clsTerreno  oTerreno = new clsTerreno ();
        clsActivoFijo oActivoFijo = new clsActivoFijo();

        public clsTerreno auxiTerreno { get; set; }

        private void DetTerrenos_Load(object sender, EventArgs e)
        {

            //llenamos el combo de la Persona que es Proveedor
            cbxProveedor.Properties.DataSource = datoProvePersoBajaActivo.consultaEspecial();

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

        public void limpiarTerrenos()
        {
            cbxProveedor.EditValue = null;
            dtFechaAdquisicion.EditValue = null;
            dtFechaLegalizacion.EditValue = null;
            txtAvaluo.Text = "";
            txtV_Adquisicion.Text = "";
            txtV_Residual.Text = "";
            rtbObservacion.Text = "";
            txtCodigoCatastral.Text = "";
            txtDimAncho.Text = "";
            txtDimLargo.Text = "";
            txtUbicacion.Text = "";

        }
        public bool getValorTerreno(clsActivoFijo auxi)
        {
            oTerreno.idCodActivoFijo = oActivoFijo.Codigo;


            if ((dtFechaLegalizacion.EditValue == null) || (rtbObservacion.Text == "") || (dtFechaAdquisicion.EditValue== null) || (txtDimAncho.Text == "") || (txtDimLargo.Text == "") || (txtCodigoCatastral.Text == "") || (txtUbicacion.Text == "") ||
               (cbxProveedor.EditValue == null) || (txtAvaluo.Text == "") || (txtV_Adquisicion.Text == "") || (txtV_Residual.Text == ""))
            {
                return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }

            oTerreno.observacion = rtbObservacion.Text;
            oTerreno.dimenAncho = Convert.ToDouble(txtDimAncho.Text);
            oTerreno.dimenLargo = Convert.ToDouble(txtDimLargo.Text);
            oTerreno.CodigoCatrastal = Convert.ToString(txtCodigoCatastral.Text);
            oTerreno.fechaLegalizacion = Convert.ToDateTime(dtFechaLegalizacion.EditValue);
            oTerreno.direccion = Convert.ToString(txtUbicacion.Text);
            oTerreno.observacion = Convert.ToString(rtbObservacion.Text);

            auxi.Fecha_Adquisicion = Convert.ToDateTime(dtFechaAdquisicion.EditValue);
            auxi.Cantidad = 1;
            auxi.proveedor = datoActivosFijos.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
            auxi.ano_vidautil = 0;
            auxi.valor_nominal = Convert.ToDouble(txtAvaluo.Text);
            auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
            auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);

            auxiTerreno = oTerreno;
            return true;

        }

        public void setTerreno(clsActivoFijo auxi)
        {
            oTerreno = datoActivosFijos.consultaTerreno(auxi.Codigo);//Consulta de sincronizacion

            rtbObservacion.Text = oTerreno.observacion;
            txtDimAncho.Text = Convert.ToString(oTerreno.dimenAncho);
            txtDimLargo.Text = Convert.ToString(oTerreno.dimenLargo);
            txtCodigoCatastral.Text = Convert.ToString(oTerreno.CodigoCatrastal);
            dtFechaLegalizacion.EditValue = Convert.ToDateTime(oTerreno.fechaLegalizacion);
            txtUbicacion.Text = Convert.ToString(oTerreno.direccion);
            rtbObservacion.Text = Convert.ToString(oTerreno.observacion);

            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            cbxProveedor.Text = datoActivosFijos.getDescripcionSegunIdComprasProveedor(auxi.proveedor);
            txtAvaluo.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
            txtV_Adquisicion.Text = Convert.ToString(auxi.valor_actualserie);
        
        }

    }
}
