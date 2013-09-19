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
    public partial class DetVehiculo : UserControl
    {
        
        public DetVehiculo()
        {
            InitializeComponent();
        }

        clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();
        datMarca datoMarca = new datMarca();
        datModelo datoModelo = new datModelo();
        datColor datoColor = new datColor();
        datTipoMaterial datoMaterial = new datTipoMaterial();
        datTipoMotor datoMotor = new datTipoMotor();
        datTipoChasis datoChasis = new datTipoChasis();


        clsClaseDatosActivoFijo datoActivosFijos = new clsClaseDatosActivoFijo();
        clsVehiculos  oVehiculo = new clsVehiculos();
        clsActivoFijo oActivoFijo = new clsActivoFijo();


      
        public clsVehiculos auxiVehi { get; set; }
        public clsActivoFijo  AX { get; set; }


        private void DetVehiculo_Load(object sender, EventArgs e)
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

            //llenamos el combo de Motor 
            cbxMotor.Properties.DataSource = datoMotor.consulta();

            //llenamos el combo de chasis 
            cbxChasis.Properties.DataSource = datoChasis.consulta();
            
            
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

        public void limpiarMaquinariasVehiculos()
        {
            cbxProveedor.EditValue = null;
            cbxMarca.EditValue = null;            
            cbxModelo.EditValue = null;
            cbxColor.EditValue = null;
            cbxMaterial.EditValue = null;
            cbxMotor.EditValue = null;
            txtSerieMotor.Text = "";
            txtMatricula.Text = "";
            txtPlaca.Text = "";
            txtCapacidad.Text = "";
            txtKilometro.Text = "";
            cbxChasis.EditValue = null;
            txtNumPuertas.Text = "";
            dtFechaAdquisicion.EditValue = null;
            dtFechaCreacion.EditValue = null;
            cbxTransmision.EditValue = null;
            txtCarga.Text = "";           
            txtCosto.Text = "";
            txtV_Adquisicion.Text = "";
            txtV_Residual.Text = "";
            rtbObservacion.Text = "";
            txtAñosDepreciados.Text = "";
            //txtAñosVidaUtil.Text = "";

        }

        public bool getValorVehiculo(clsActivoFijo auxi)
        {

            oVehiculo.idCodActivoFijo = auxi.Codigo;


            if ((cbxMarca.EditValue == null || cbxModelo.EditValue == null) || (dtFechaAdquisicion.EditValue == null) ||(cbxColor.EditValue == null) || (txtMatricula.Text=="")|| (txtPlaca.Text =="") ||(cbxChasis.EditValue == null ) ||  (txtNumPuertas.Text =="") || (cbxTransmision.SelectedText=="")||(txtCarga.Text == "") || (rtbObservacion.Text == "") || (txtAñosDepreciados.Text == "")|| (txtAñosVidaUtil.Text=="")|| (cbxProveedor.EditValue == null) ||(cbxMaterial.EditValue==null)||(cbxMotor.EditValue==null)|| (txtSerieMotor.Text=="") || (txtCapacidad.Text=="")  || (txtKilometro.Text=="") || (dtFechaCreacion.EditValue==null) || (txtCosto.Text == "") || (txtV_Adquisicion.Text == "") || (txtV_Residual.Text == ""))
            {
                return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }
            oVehiculo.idMarca = datoActivosFijos.getIdSegunDescripcionInventarioMarca(cbxMarca.Text);
            oVehiculo.idModelo = datoActivosFijos.getIdSegunDescripcionInventarioModelo(cbxModelo.Text);
            oVehiculo.idColor = datoActivosFijos.getIdSegunDescripcionInventarioColor(cbxColor.Text);
            oVehiculo.Matricula = txtMatricula.Text;
            oVehiculo.placa = txtPlaca.Text;
            oVehiculo.idChasis = datoActivosFijos.getIdSegunDescripcionInventarioChasis(cbxChasis.Text);
            oVehiculo.NumPuertas = Convert.ToInt32(txtNumPuertas.Text);
            oVehiculo.Transmision = Convert.ToString(cbxTransmision.Text);
            oVehiculo.carga = Convert.ToDouble(txtCarga.Text);
            oVehiculo.AniosDepreciados = Convert.ToInt32(txtAñosDepreciados.Text);
            oVehiculo.Descripcion = rtbObservacion.Text;
            oVehiculo.idMaterial = datoActivosFijos.getIdSegunDescripcionInventarioMaterial(cbxMaterial.Text);
            oVehiculo.idMotor = datoActivosFijos.getIdSegunDescripcionInventarioMotor(cbxMotor.Text);
            oVehiculo.serie = txtSerieMotor.Text;
            oVehiculo.capacidad = Convert.ToDouble(txtCapacidad.Text);
            oVehiculo.kilometraje = Convert.ToDouble(txtKilometro.Text);
            oVehiculo.FechaCracion = Convert.ToDateTime(dtFechaCreacion.EditValue);

            auxi.Fecha_Adquisicion = Convert.ToDateTime(dtFechaAdquisicion.EditValue);
            auxi.Cantidad = 1;
            auxi.proveedor = datoActivosFijos.getIdSegunDescripcionComprasProveedor(cbxProveedor.Text);
            auxi.ano_vidautil = Convert.ToInt32(txtAñosVidaUtil.Text);
            auxi.valor_nominal = Convert.ToDouble(txtCosto.Text);
            auxi.ValorAdquisicion = Convert.ToDouble(txtV_Adquisicion.Text);
            auxi.valor_residual = Convert.ToDouble(txtV_Residual.Text);
            auxi.valor_actualserie = Convert.ToDouble(txtV_Adquisicion.Text);

            auxiVehi = oVehiculo;
            datoActivo.auxi=auxi;
            datoActivo.vehiculo = oVehiculo;
            return true;

        }

        public void setVehiculo(clsActivoFijo auxi)
        {
            oVehiculo=datoActivosFijos.consultaVehiculos(auxi.Codigo);//Esta es la consulta especial para poder mandar a sincronizarlo para hacer la consulta perninente 

            txtMatricula.Text =Convert.ToString( oVehiculo.Matricula);
            txtPlaca.Text = oVehiculo.placa;
            cbxChasis.Text = datoActivosFijos.getDescripcionSegunIdInventarioChasis(oVehiculo.idChasis);
            txtNumPuertas.Text = Convert.ToString(oVehiculo.NumPuertas);
            cbxTransmision.Text = Convert.ToString(oVehiculo.Transmision);
            cbxMaterial.Text = datoActivosFijos.getDescripcionSegunIdInventarioMaterial(oVehiculo.idMaterial);
            cbxMotor.Text = datoActivosFijos.getDescripcionSegunIdInventarioMotor(oVehiculo.idMotor);
            txtSerieMotor.Text = oVehiculo.serie;
            txtCapacidad.Text = Convert.ToString(oVehiculo.capacidad);
            txtKilometro.Text = Convert.ToString(oVehiculo.kilometraje);
            dtFechaCreacion.EditValue = Convert.ToDateTime(oVehiculo.FechaCracion);
            cbxMarca.Text = datoActivosFijos.getDescripcionSegunIdInventarioMarca(oVehiculo.idMarca);
            cbxModelo.Text = datoActivosFijos.getDescripcionSegunIdInventarioModelo(oVehiculo.idModelo);
            cbxColor.Text = datoActivosFijos.getDescripcionSegunIdInventarioColor(oVehiculo.idColor);
            txtCarga.Text = Convert.ToString(oVehiculo.carga);
            rtbObservacion.Text = oVehiculo.Descripcion;
            txtAñosDepreciados.Text = Convert.ToString(oVehiculo.AniosDepreciados);
            dtFechaAdquisicion.EditValue = Convert.ToDateTime(auxi.Fecha_Adquisicion);
            cbxProveedor.Text = datoActivosFijos.getDescripcionSegunIdComprasProveedor(auxi.proveedor);
            txtAñosVidaUtil.Text = Convert.ToString(auxi.ano_vidautil);
            txtCosto.Text = Convert.ToString(auxi.valor_nominal);
            txtV_Adquisicion.Text = Convert.ToString(auxi.ValorAdquisicion);           
            txtV_Residual.Text = Convert.ToString(auxi.valor_residual);
        }

        public void calcular() 
        {
            if (txtCosto.Text == "")
            {
                txtV_Residual.Text = "0";
            }
            else
            {
                if (txtV_Adquisicion.Text == "")
                {
                    txtV_Residual.Text = "0";
                }
                else
                {
                    if (txtCosto.Text == "" | txtV_Adquisicion.Text == "")
                    {
                        txtV_Adquisicion.Text = "0"; txtCosto.Text = "0";
                    }
                  txtV_Residual.Text = Convert.ToString(Convert.ToDecimal(txtCosto.Text) - Convert.ToDecimal(txtV_Adquisicion.Text));
                    
                }
            }

           
        }

        private void txtCosto_EditValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtV_Adquisicion_EditValueChanged(object sender, EventArgs e)
        {
            calcular();
        }


       
    }
}
