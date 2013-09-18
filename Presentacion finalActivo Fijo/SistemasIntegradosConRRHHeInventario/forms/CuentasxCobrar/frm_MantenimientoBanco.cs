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
    public partial class frm_MantenimientoBanco : Form
    {
        public clsBanco objBanco = new clsBanco();
        int idEmpresa = 1;
        String AccionBotonAplastado;

        public frm_MantenimientoBanco()
        {
            InitializeComponent();
        }

        private void frm_MantenimientoBanco_Load(object sender, EventArgs e)
        {
            this.Inactivar();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
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
            this.txtCodigo.Text = Convert.ToString(objBanco.idBanco);
            this.txtNombre.Text = objBanco.Nombre;
            if (this.objBanco.Estado.Equals("A"))
            {
                this.ckbActivo.Checked = true;
            }
            else
            {
                this.ckbActivo.Checked = false;
            }
        }
        
        public void Get()
        {
            objBanco.idEmpresa = idEmpresa;
            objBanco.idBanco = Convert.ToInt32(this.txtCodigo.Text);
            objBanco.Nombre = this.txtNombre.Text;
            if (ckbActivo.Checked)
            {
            objBanco.Estado = "A";
            }
            else
            {
            objBanco.Estado = "I";
            }
        }
        
        public void Inactivar()
        {
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtNombre.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = true;
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.ckbActivo.Checked = true;
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtNombre.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;

            this.Limpiar();

            clsDatosBanco objDatosBanco = new clsDatosBanco();
            this.txtCodigo.Text=Convert.ToString(objDatosBanco.getIdSiguiente());
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosBanco objDatosBanco = new clsDatosBanco();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            

            if (AccionBotonAplastado == "N")
            {
                this.Get();
                if (objDatosBanco.guardar(objBanco))
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
                this.Get();
                if (objDatosBanco.modificar(objBanco))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Modificar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Modificar_error, objMensaje.Titulo, MessageBoxButtons.OK);
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
            this.txtNombre.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosBanco objDatosBanco = new clsDatosBanco();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            this.Get();

            if (AccionBotonAplastado=="B")
            {
                if (objDatosBanco.eliminar(objBanco))
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



    }
}
