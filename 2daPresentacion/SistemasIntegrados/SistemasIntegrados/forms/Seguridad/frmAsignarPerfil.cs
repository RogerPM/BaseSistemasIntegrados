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
    public partial class frmAsignarPerfil : Form
    {
        private clsUsuario u = new clsUsuario();
        private datUsuario oDatUser = new datUsuario();
       // private clsPerfil oPerfil = new clsPerfil();
        private datPerfil oDatPerfil = new datPerfil();
        private List<clsUsuario> listaSelecc = new List<clsUsuario>();
        private clsMensajeSeguridad msj = new clsMensajeSeguridad();
        
        public frmAsignarPerfil()
        {
            InitializeComponent();
        }

        private void frmAsignarPerfil_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            
        }

        private clsUsuario getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                
                return (clsUsuario)view.GetRow(view.FocusedRowHandle);//convierte a objeto usuario
            }
            catch (Exception)
            {
                return null;
            }

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {//you have to do this.gridView1.OptionsBehavior.Editable = false;
            u = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            if (!(listaSelecc.Contains(u)))
            {
                listaSelecc.Add(u);
                listBoxControl1.Items.Add(u.NombreUsuario);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (vacio())
            {
                MessageBox.Show(msj.NoDatos, msj.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (guardarCambios())
                {
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
                else
                {
                    MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
        }

        private bool vacio() {
            if ((cbxPerfil.EditValue==null)||(listaSelecc==null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool guardarCambios() {
            try
            {
                foreach (var item in listaSelecc)
                {

                    clsUsuario user = new clsUsuario();
                    user.IdUsuario = item.IdUsuario;
                    user.NombreUsuario = item.NombreUsuario;
                    user.Contrasena = item.Contrasena;
                    user.IdImagen = item.IdImagen;
                    user.IdEstado = item.IdEstado;
                    user.IdPerfil = Convert.ToInt32(cbxPerfil.EditValue);
                    datUsuario.Modificar(user);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" +ex);
                return false;
            }
        
        }
        private void cargar() {
            gridControl1.DataSource = oDatUser.ConsultarTodos();
            cbxPerfil.Properties.DataSource = oDatPerfil.ConsultarTodos();
            listaSelecc.Clear();
            listBoxControl1.Items.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
