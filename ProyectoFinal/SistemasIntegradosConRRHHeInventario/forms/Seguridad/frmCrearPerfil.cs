using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using System.Reflection;
using datos.Seguridad;
//using clases._Otro;
using DevExpress.XtraEditors;

namespace forms.Seguridad
{
    public partial class frmCrearPerfil : XtraForm
    {
        public frmCrearPerfil()
        {
            InitializeComponent();
        }

        private void frmCrearPerfil_Load(object sender, EventArgs e)
        {
                       CargarGRid();
                       btnGuardar.Enabled = false;
        }
        BindingList<clsHorario> DataSource = new BindingList<clsHorario>();
        void CargarGRid() 
        {
            DataSource = new BindingList<clsHorario>();
            clsHorario Lunes = new clsHorario();
            Lunes.dia = "Lunes";
            clsHorario Martes = new clsHorario();
            Martes.dia = "Martes";
            clsHorario Miercoles = new clsHorario();
            Miercoles.dia = "Miercoles";
            clsHorario Jueves = new clsHorario();
            Jueves.dia = "Jueves";
            clsHorario Viernes = new clsHorario();
            Viernes.dia = "Viernes";
            clsHorario Sabado = new clsHorario();
            Sabado.dia = "Sabado";
            clsHorario Domingo = new clsHorario();
            Domingo.dia = "Domingo";
            DataSource.Add(Lunes);
            DataSource.Add(Martes);
            DataSource.Add(Miercoles);
            DataSource.Add(Jueves);
            DataSource.Add(Viernes);
            DataSource.Add(Sabado);
            DataSource.Add(Domingo);
            gridControl1.DataSource = DataSource;

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
                   
        }
        datPerfil Data = new datPerfil();
        clsPerfil GetPerfil()
        {
            clsPerfil ob = new clsPerfil();
            ob.Descripcion = txtDescripcion.Text;
            ob.IdPErfil = Convert.ToInt32((txtCodigo.Text == "") ? "0" : txtCodigo.Text);
            ob.IdEstado = (chkActivo.Checked == true) ? 1 : 2;
            return ob;
            
        }
        Boolean Validar() 
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text)) 
                {
                    MessageBox.Show("Por favor ingrese descripcion");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        datHorario DatHOrario = new datHorario();
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            int IdPerfil=0;
            if (!Validar()) return;

            if (Data.Guardar(GetPerfil(), ref IdPerfil)) 
            {
                MessageBox.Show("Registro Ingresado Correctametne");
                txtCodigo.Text = IdPerfil.ToString();
                foreach (var item in DataSource)
                {
                    item.IdPerfil = IdPerfil;
                    DatHOrario.Guardar(item);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultarPerfiles ofrm = new frmConsultarPerfiles();
                ofrm.Event_frmConsultarPerfiles_FormClosing += new frmConsultarPerfiles.Delegate_frmConsultarPerfiles_FormClosing(ofrm_Event_frmConsultarPerfiles_FormClosing);
                ofrm.ShowDialog();

            }
            catch (Exception)
            {
                
            }
        }

        void ofrm_Event_frmConsultarPerfiles_FormClosing(object sender, FormClosingEventArgs e)
        {

            var Item = (clsPerfil)sender;
            txtCodigo.Text = Item.IdPErfil.ToString();
            txtDescripcion.Text = Item.Descripcion;
            chkActivo.Checked = (Item.IdEstado == 1) ? true : false;
            DataSource= new BindingList<clsHorario>(DatHOrario.COnsultar(Item.IdPErfil));
            gridControl1.DataSource = DataSource;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            chkActivo.Checked = true;
            CargarGRid();
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
                btnGuardar.Enabled = false;
            else
                btnGuardar.Enabled = !btnGuardar.Enabled;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            //MessageBox.Show(param.IdEmpresa  +"  "+param.IdUsuario+"    "+ param.ip +"   "+param.nom_pc);
            
        }

      
    }
}
