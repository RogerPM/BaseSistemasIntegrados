using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using datos.Seguridad;

namespace forms.Seguridad
{
    public partial class frmAsignarUsuariosAEmpresa : Form
    {
        private clsUsuario ou = new clsUsuario();
        private datUsuario odu = new datUsuario();
        private clsEmpresa oe = new clsEmpresa();
        private datEmpresa ode = new datEmpresa();
        private clsUsuarioPorEmpresa oue = new clsUsuarioPorEmpresa();
        private datUsuarioPorEmpresa odue = new datUsuarioPorEmpresa();
        private List<clsUsuario> ListaSelec = new List<clsUsuario>();
        private clsMensajeSeguridad mess = new clsMensajeSeguridad();

        public frmAsignarUsuariosAEmpresa()
        {
            InitializeComponent();
        }

        private void frmAsignarUsuariosAEmpresa_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private clsUsuario getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {

                return (clsUsuario)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }

        

        private void cargar() 
        {
            gridControl1.DataSource = odu.ConsultarTodos();
            cmbEmpresa.Properties.DataSource = ode.Consultar();
            ListaSelec.Clear();
            listBoxControl1.Items.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (vacio())
            {
                MessageBox.Show(mess.NoDatos, mess.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (guardarCambios())
                {
                    MessageBox.Show(mess.Guardar_ok, mess.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mess.Guardar_error, mess.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool vacio()
        {
            if ((cmbEmpresa.EditValue == null) || (ListaSelec == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool guardarCambios()
        {
            try
            {
                foreach (var item in ListaSelec)
                {

                    clsUsuarioPorEmpresa uxe = new clsUsuarioPorEmpresa();
                    uxe.IdUsuario = item.IdUsuario;
                    uxe.IdEmpresa = Convert.ToInt32(cmbEmpresa.EditValue);
                    uxe.Descripcion = "g";
                    datUsuarioPorEmpresa.GuardarEmpresa(uxe);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return false;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ou = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            if (!(ListaSelec.Contains(ou)))
            {
                ListaSelec.Add(ou);
                listBoxControl1.Items.Add(ou.NombreUsuario);
            }
        }

    }
}
