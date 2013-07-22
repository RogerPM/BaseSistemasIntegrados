using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//otros
using clases.Seguridad;
using datos.Seguridad;
using System.IO;
using System.Drawing.Imaging;
namespace forms.Seguridad
{
    public partial class frmEmpresa : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsEmpresa oEmpresa = new clsEmpresa();
        datEmpresa oDatEmpresa=new datEmpresa();
        public clsEstado oClsEstadoEmpresa = new clsEstado(); //se hace instancia generica para estado de la empresa
        datEstado oDatEstado = new datEstado();
        MemoryStream ms = new MemoryStream();//para imagen
        
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultar f = new FrmConsultar();
            f.ShowDialog();
            oEmpresa = f.e;
            txtcodigo.Text = Convert.ToString(oEmpresa.idEmpresa);
            txtRazonSocial.Text = Convert.ToString(oEmpresa.razonSocial);
            txtNombreComercial.Text = Convert.ToString(oEmpresa.nombreComercial);
            txtRuc.Text = Convert.ToString(oEmpresa.ruc);
            //cbxTipoEmp.SelectedText = Convert.ToString(oEmpresa.tipoEmpresa);//agregar a tabla
            txtDireccion.Text = Convert.ToString(oEmpresa.direccion);
            txtDescripcion.Text = Convert.ToString(oEmpresa.descripcion);
            cbxEstado.Text = oDatEstado.getDescripcionSegunId(oEmpresa.idEstado);
            txtCorreoElectronico.Text = Convert.ToString(oEmpresa.correo);
            txtPaginaWeb.Text = Convert.ToString(oEmpresa.sitioWeb);
         //   pictureBox1.Image = null;
         //   pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(oEmpresa.logotipo.ToArray()));
            //pictureBox1.BackgroundImage = Image.FromStream(ms);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFotoUrl.Text = Convert.ToString(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getValores();
            if (oDatEmpresa.Guardar(oEmpresa))
            {
                MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
            }
        }

        public void borrar() {
            clsEmpresa e = new clsEmpresa();
            txtcodigo.Text = "";
            txtRazonSocial.Text = "";
            txtNombreComercial.Text = "";
            txtRuc.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.SelectedText = "";
            txtCorreoElectronico.Text = "";
            txtPaginaWeb.Text = "";
            txtFotoUrl.Text = "";
            txtTelefono.Text = "";
            pictureBox1.BackgroundImage = null;

        }

        public void getValores(){
            if (txtcodigo.Text=="")
            {
                oEmpresa.idEmpresa = 0;//PK
            }
            else
            {
                oEmpresa.idEmpresa = Convert.ToInt32(txtcodigo.Text);
            }
            oEmpresa.razonSocial=txtRazonSocial.Text;
            oEmpresa.nombreComercial = txtNombreComercial.Text;
            oEmpresa.ruc = txtRuc.Text;
            oEmpresa.direccion = txtDireccion.Text;
            //oEmpresa.idImagen = 0;
            Image.FromFile(txtFotoUrl.Text).Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            oEmpresa.logotipo=ms.ToArray();//transformando de memory stream-->matriz de array-->arreglo de byte
            //oEmpresa.fechaInicioSistema=null;
            oEmpresa.correo=txtCorreoElectronico.Text;
            oEmpresa.sitioWeb=txtPaginaWeb.Text;
            oEmpresa.descripcion=txtDescripcion.Text;     
            
            oClsEstadoEmpresa.descripcion=Convert.ToString(cbxEstado.SelectedItem);
            oEmpresa.idEstado=Convert.ToInt32(oDatEstado.getIdSegunDescripcion(oClsEstadoEmpresa.descripcion));//en caso q no exista idEstado=0
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            getValores();
            if (oDatEmpresa.Modificar(oEmpresa)) {
                MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK);
            }
        }
    }
}
