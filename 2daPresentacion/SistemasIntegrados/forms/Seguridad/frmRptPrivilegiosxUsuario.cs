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
    public partial class frmRptPrivilegiosxUsuario : Form
    {


        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            toolStripButton1.Visible = frmPrincipal.Lectura;
        }
        #endregion

        public frmRptPrivilegiosxUsuario()
        {
            InitializeComponent();
        }

        datVwUsuarioPermisos oD = new datVwUsuarioPermisos();
        clsUsuario usu = new clsUsuario();
        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (radioGroup2.EditValue.ToString()=="g")
            {
                List<clsVwUsuarioPermisos> c = new List<clsVwUsuarioPermisos>();                
                rptPxU rpt = new rptPxU();
                rpt.DataSource = oD.LeerPermisoVista();
                rpt.ShowPreview();
            }else if (radioGroup2.EditValue.ToString() == "u")
            {
                if (String.IsNullOrWhiteSpace(txtCodigo.Text.ToString()))
                {
                    MessageBox.Show("Seleccione un Usuario","Error");
                }
                else
                {
                    List<clsVwUsuarioPermisos> c = new List<clsVwUsuarioPermisos>();                    
                    rptPxU rpt = new rptPxU();
                    rpt.DataSource = oD.LeerPermisos(Convert.ToInt32(txtCodigo.Text));
                    rpt.ShowPreview();
                }                
            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup2.EditValue.ToString() == "u")
            {
                groupControl3.Enabled = true;
            }
            if (radioGroup2.EditValue.ToString() == "g")
            {
                groupControl3.Enabled = false;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario of = new frmConsultarUsuario();
            of.ShowDialog();
            usu = of.oUsuario;
            txtCodigo.Text = usu.IdUsuario.ToString();
            txtNombre.Text = usu.NombreUsuario.ToString();
        }

        private void frmRptPrivilegiosxUsuario_Load(object sender, EventArgs e)
        {
            Seguridad();
        }
    }
}
