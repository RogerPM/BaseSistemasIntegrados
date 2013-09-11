using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;
namespace forms.CuentasxCobrar
{
    public partial class frm_MantenimientoCuentaBancaria : Form
    {
        public clsCuentaBancaria objCuentaBancaria = new clsCuentaBancaria();
        public clsBanco objBanco = new clsBanco();
        public clsPersonaCXC objPersona = new clsPersonaCXC(); 
        /*public String[] strPersona = new String[2];*/
        
        int idEmpresa = 1;
        String AccionBotonAplastado;

        public frm_MantenimientoCuentaBancaria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Inactivar();
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensaje objMensaje = new clsMensaje();


            clsDatosCuentaBancaria objDatosCuentaBancaria = new clsDatosCuentaBancaria();
            clsDatosBanco objDatosBanco = new clsDatosBanco();
            clsDatosPersonaCXC objDatosPersona = new clsDatosPersonaCXC();
            String[] NombresColumnas = new String[8];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "ID Cuenta Bancaria";
            NombresColumnas[2] = "Banco";
            NombresColumnas[3] = "Titular";
            NombresColumnas[4] = "Numero de Cuenta";
            NombresColumnas[5] = "Tipo";
            NombresColumnas[6] = "Saldo";
            NombresColumnas[7] = "Estado";

            List<object> lista = new List<object>(objDatosCuentaBancaria.consultaCuentaBancariaGeneralINNER()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Busqueda de Unidad de Tiempo", NombresColumnas);
                FormularioBusqueda.OcultarColumna(0);
                FormularioBusqueda.ShowDialog();

                if (FormularioBusqueda.Seleccion)
                {
                    DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                    objCuentaBancaria.idCuentaBancaria = Convert.ToInt32(Fila.Cells[1].Value);
                    objDatosCuentaBancaria.ConsultaCuentaBancariaEspecifica(objCuentaBancaria);
                    objBanco.idBanco = objCuentaBancaria.idBanco;
                    objDatosBanco.consultaBancoEspecifica(objBanco);
                    objPersona.IdPersona = objCuentaBancaria.idTitular;
                    objDatosPersona.ConsultaPersonaEspecifica(objPersona);
                    this.Set();
                }
            }
            else
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }

            this.Inactivar();
        }

        public void Set()
        {
            this.txtCodigo.Text = Convert.ToString(objCuentaBancaria.idCuentaBancaria);
            this.txtTitular.Text = objPersona.NombreRazonSocial + " " + objPersona.Apellido;
            this.txtBanco.Text = objBanco.Nombre;
            this.txtNumeroCuenta.Text = Convert.ToString(objCuentaBancaria.NumeroCuenta);
            this.cbxTipoCuenta.SelectedText = objCuentaBancaria.TipoCuenta;
            this.txtSaldo.Text = Convert.ToString(objCuentaBancaria.Saldo);
            if (this.objCuentaBancaria.Estado.Equals("A"))
            {
                this.ckbActivo.Checked = true;
            }
            else
            {
                this.ckbActivo.Checked = false;
            }
        }

        public Boolean Get()
        {
            clsMensaje objMensaje = new clsMensaje();
            try
            {
                objCuentaBancaria.idEmpresa = idEmpresa;
                objCuentaBancaria.idCuentaBancaria = Convert.ToInt32(this.txtCodigo.Text);
                objCuentaBancaria.idTitular = objPersona.IdPersona;
                objCuentaBancaria.idBanco = objBanco.idBanco;
                objCuentaBancaria.NumeroCuenta = Convert.ToInt32(this.txtNumeroCuenta.Text);
                objCuentaBancaria.TipoCuenta = this.cbxTipoCuenta.Text;
                objCuentaBancaria.Saldo = Convert.ToDecimal(this.txtSaldo.Text);
                if (ckbActivo.Checked)
                {
                    objCuentaBancaria.Estado = "A";
                }
                else
                {
                    objCuentaBancaria.Estado = "I";
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }

        }

        public void Inactivar()
        {
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtTitular.Properties.ReadOnly = true;
            this.txtBanco.Properties.ReadOnly = true;
            this.txtNumeroCuenta.Properties.ReadOnly = true;
            this.cbxTipoCuenta.Enabled = false;
            this.txtSaldo.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = true;
            btnBuscarBanco.Enabled = false;
            btnBuscarTitular.Enabled = false;
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtTitular.Text = "";
            this.txtBanco.Text = "";
            this.txtNumeroCuenta.Text = "";
            this.cbxTipoCuenta.SelectedIndex=1;
            this.txtSaldo.Text = "";
            this.ckbActivo.Checked = true;
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtTitular.Properties.ReadOnly = true;
            this.txtBanco.Properties.ReadOnly = true;
            this.txtNumeroCuenta.Properties.ReadOnly = false;
            this.cbxTipoCuenta.Enabled = true;
            this.txtSaldo.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;
            btnBuscarBanco.Enabled = true;
            btnBuscarTitular.Enabled = true;

            this.Limpiar();

            clsDatosCuentaBancaria objDatosCuentaBancaria = new clsDatosCuentaBancaria();
            this.txtCodigo.Text = Convert.ToString(objDatosCuentaBancaria.getIdSiguiente());

        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosCuentaBancaria objDatosCuentaBancaria = new clsDatosCuentaBancaria();
            clsMensaje objMensaje = new clsMensaje();

            if (this.Get()){
            if (AccionBotonAplastado == "N")
            {
               
                if (objDatosCuentaBancaria.guardar(objCuentaBancaria))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                }
            }
            else if (AccionBotonAplastado == "M")
            {
                
                if (objDatosCuentaBancaria.modificar(objCuentaBancaria))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Modificar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Modificar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                }
            }
        }

            this.Limpiar();
            this.Inactivar();
            AccionBotonAplastado = "G";
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "M";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtTitular.Properties.ReadOnly = true;
            this.txtBanco.Properties.ReadOnly = true;
            this.txtNumeroCuenta.Properties.ReadOnly = false;
            this.cbxTipoCuenta.Enabled = true;
            this.txtSaldo.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;
            btnBuscarBanco.Enabled = true;
            btnBuscarTitular.Enabled = true;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosCuentaBancaria objDatosCuentaBancaria = new clsDatosCuentaBancaria();
            clsMensaje objMensaje = new clsMensaje();
            this.Get();

            if (AccionBotonAplastado == "B")
            {
                if (objDatosCuentaBancaria.eliminar(objCuentaBancaria))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Eliminar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Eliminar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                }
            }
            this.Limpiar();
            this.Inactivar();
            AccionBotonAplastado = "E";
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "S";
            this.Close();
        }

        private void btnBuscarTitular_Click(object sender, EventArgs e)
        {
            clsMensaje objMensaje = new clsMensaje();

            clsDatosPersonaCXC objDatosPersona = new clsDatosPersonaCXC();
            clsDatosCuentaBancaria objDatosCuentaBancaria = new clsDatosCuentaBancaria();
            String[] NombresColumnas = new String[16];
            NombresColumnas[0] = "ID Persona";
            NombresColumnas[1] = "Identificacion";
            NombresColumnas[2] = "ID Empresa";
            NombresColumnas[3] = "ID Tipo Persona";
            NombresColumnas[4] = "Nombre o Razon Social";
            NombresColumnas[5] = "Apellido";
            NombresColumnas[6] = "Fecha Nacimiento";
            NombresColumnas[7] = "Genero";
            NombresColumnas[8] = "Tipo Identificacion";
            NombresColumnas[9] = "Direccion";
            NombresColumnas[10] = "Telefono General";
            NombresColumnas[11] = "Telefono Movil";
            NombresColumnas[12] = "Telefono Casa";
            NombresColumnas[13] = "Telefono Otros";
            NombresColumnas[14] = "Email";
            NombresColumnas[15] = "Estado";

            
            List<object> lista = new List<object>(objDatosPersona.ConsultaPersona()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Busqueda de Titular", NombresColumnas);
                FormularioBusqueda.OcultarColumna(1);
                FormularioBusqueda.OcultarColumna(2);
                FormularioBusqueda.OcultarColumna(3);
                FormularioBusqueda.OcultarColumna(6);
                FormularioBusqueda.OcultarColumna(7);
                FormularioBusqueda.OcultarColumna(8);
                FormularioBusqueda.OcultarColumna(9);
                FormularioBusqueda.OcultarColumna(10);
                FormularioBusqueda.OcultarColumna(11);
                FormularioBusqueda.OcultarColumna(13);
                FormularioBusqueda.OcultarColumna(14);
                FormularioBusqueda.OcultarColumna(15);

                FormularioBusqueda.ShowDialog();

                if (FormularioBusqueda.Seleccion)
                {
                    DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                    objPersona.IdPersona = Convert.ToInt32(Fila.Cells[0].Value);
                    objDatosPersona.ConsultaPersonaEspecifica(objPersona);
                    this.txtTitular.Text = objPersona.NombreRazonSocial + " " + objPersona.Apellido;                    
                }
            }
            else
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            clsMensaje objMensaje = new clsMensaje();

            clsDatosBanco objDatosBanco = new clsDatosBanco();
            String[] NombresColumnas = new String[4];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "Codigo";
            NombresColumnas[2] = "Banco";
            NombresColumnas[3] = "Estado";

            List<object> lista = new List<object>(objDatosBanco.consultaBancoGeneral()); ;
            if (lista.Count > 0)
            {
            frm_Busqueda FormularioBusqueda = new frm_Busqueda();
            FormularioBusqueda.CargarBanco(lista);
            FormularioBusqueda.EstablecerPropiedades("Busqueda de Bancos", NombresColumnas);
            FormularioBusqueda.OcultarColumna(0);
            FormularioBusqueda.ShowDialog();

            if (FormularioBusqueda.Seleccion)
            {
                DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                objBanco.idEmpresa = Convert.ToInt32(Fila.Cells[0].Value);
                objBanco.idBanco = Convert.ToInt32(Fila.Cells[1].Value);
                objBanco.Nombre = Convert.ToString(Fila.Cells[2].Value);
                objBanco.Estado = Convert.ToString(Fila.Cells[3].Value);
                this.txtBanco.Text = objBanco.Nombre;
            }
             }
            else 
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }
        }
        

    }
}











