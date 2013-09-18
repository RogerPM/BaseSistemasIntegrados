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
    public partial class frm_MantenimientoTarjetaCredito : Form
    {
        public clsTarjetaCredito objTarjetaCredito = new clsTarjetaCredito();
        public clsBanco objBanco = new clsBanco();

        int idEmpresa = 1;
        String AccionBotonAplastado;

        public frm_MantenimientoTarjetaCredito()
        {
            InitializeComponent();
        }

        private void frm_MantenimientoTarjetaCredito_Load(object sender, EventArgs e)
        {
            this.Inactivar();
        }

        private void btnBuscarTarjeta_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();


            clsDatosTarjetaCredito objDatosTarjetaCredito = new clsDatosTarjetaCredito();
            clsDatosBanco objDatosBanco = new clsDatosBanco();
            String[] NombresColumnas = new String[5];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "ID Tarjeta";
            NombresColumnas[2] = "Descripcion";
            NombresColumnas[3] = "Banco";
            NombresColumnas[4] = "Estado";

            List<object> lista = new List<object>(objDatosTarjetaCredito.consultaTarjetaCreditoGeneralINNER()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Busqueda de Tarjeta de Credito", NombresColumnas);
                FormularioBusqueda.OcultarColumna(0);
                FormularioBusqueda.ShowDialog();

                if (FormularioBusqueda.Seleccion)
                {
                    DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                    objTarjetaCredito.idTarjeta = Convert.ToInt32(Fila.Cells[1].Value);
                    objDatosTarjetaCredito.ConsultaTarjetaCreditoEspecifica(objTarjetaCredito);
                    objBanco.idBanco = objTarjetaCredito.idBanco;
                    objDatosBanco.consultaBancoEspecifica(objBanco);
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
            this.txtCodigo.Text = Convert.ToString(objTarjetaCredito.idTarjeta);
            this.txtDescripcion.Text = objTarjetaCredito.Descripcion;
            this.txtBanco.Text = objBanco.Nombre;
            if (this.objTarjetaCredito.Estado.Equals("A"))
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
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            try
            {
                objTarjetaCredito.idEmpresa = idEmpresa;
                objTarjetaCredito.idTarjeta = Convert.ToInt32(this.txtCodigo.Text);
                objTarjetaCredito.Descripcion = this.txtDescripcion.Text;
                objTarjetaCredito.idBanco = objBanco.idBanco;
                if (ckbActivo.Checked)
                {
                    objTarjetaCredito.Estado = "A";
                }
                else
                {
                    objTarjetaCredito.Estado = "I";
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
            this.txtDescripcion.Properties.ReadOnly = true;
            this.txtBanco.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = true;
            btnBuscarBanco.Enabled = false;
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtBanco.Text = "";
            this.ckbActivo.Checked = true;
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtDescripcion.Properties.ReadOnly = false;
            this.txtBanco.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = false;
            btnBuscarBanco.Enabled = true;

            this.Limpiar();

            clsDatosTarjetaCredito objDatosTarjetaCredito = new clsDatosTarjetaCredito();
            this.txtCodigo.Text = Convert.ToString(objDatosTarjetaCredito.getIdSiguiente());
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosTarjetaCredito objDatosTarjetaCredito = new clsDatosTarjetaCredito();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

            if (this.Get())
            {
                if (AccionBotonAplastado == "N")
                {

                    if (objDatosTarjetaCredito.guardar(objTarjetaCredito))
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

                    if (objDatosTarjetaCredito.modificar(objTarjetaCredito))
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
            this.txtDescripcion.Properties.ReadOnly = false;
            this.txtBanco.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = false;
            btnBuscarBanco.Enabled = true;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosTarjetaCredito objDatosTarjetaCredito = new clsDatosTarjetaCredito();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            this.Get();

            if (AccionBotonAplastado == "B")
            {
                if (objDatosTarjetaCredito.eliminar(objTarjetaCredito))
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

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

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
