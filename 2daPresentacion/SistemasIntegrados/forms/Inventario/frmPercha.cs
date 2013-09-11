using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;
using datos.Seguridad;

namespace forms.Inventario
{
    public partial class frmPercha : Form
    {
        public frmPercha()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsPercha cPercha = new clsPercha();
        datPercha cd = new datPercha();

        public string accion { get; set; }

        private void Percha_Load(object sender, EventArgs e)
        {
            datPercha cd = new datPercha();
            if (accion == "M")
            {

                set();
            }
            if (accion == "E")
            {
                set();
            }


        }

        public void set()
        {
            cPercha.empresa = EU;
            cPercha.codigo = Convert.ToInt32(txtCodigo.Text);
            cPercha.descripcion = txtDescripcion.Text;
            cPercha.divisiones = Convert.ToInt32(txtNDivisiones.Text);
            cPercha.bodega = Convert.ToString(cbxBodega.Text);
            cPercha.estado = cbxEstado.Text;

        }

        public void get()
        {
            cPercha.empresa = EU;
            cPercha.codigo = Convert.ToInt32(txtCodigo.Text);
            cPercha.descripcion = txtDescripcion.Text;
            cPercha.divisiones = Convert.ToInt32(txtNDivisiones.Text);
            cPercha.bodega = Convert.ToString(cbxBodega.EditValue);
            cPercha.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            cPercha.empresa = EU;
            cPercha.codigo = Convert.ToInt32(txtCodigo.Text);
            cPercha.descripcion = txtDescripcion.Text;
            cPercha.divisiones = Convert.ToInt32(txtNDivisiones.Text);
            cPercha.bodega = Convert.ToString(cbxBodega.Text);
            cPercha.estado = cbxEstado.Text;
            return true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            {
                limpiar();
            }
        }
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNDivisiones.Text = "";
            cbxBodega.Text = "";
            cbxEstado.EditValue = "";
        }

        frmConsultaPercha consulta = new frmConsultaPercha();

        void consulta_Event_frmConsultaPercha_FormClosing(object sender, EventArgs e)
        {
            clsPercha percha = (clsPercha)sender;
            txtCodigo.Text = percha.codigo.ToString();
            txtDescripcion.Text = percha.descripcion.ToString();
            txtNDivisiones.Text = percha.divisiones.ToString();
            cbxBodega.Text = percha.bodega.ToString();
            cbxEstado.Text = percha.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaPercha_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmPercha_Load(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
          
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaCodigo_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cPercha, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cPercha);
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cPercha))
            {
                MessageBox.Show("Actualizado OK");
            }

        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaCodigo_Click_1(object sender, EventArgs e)
        {
            consulta = new frmConsultaPercha();
            consulta.ShowDialog();
            cPercha = consulta.clastm;
            txtCodigo.Text = cPercha.codigo.ToString();
            txtDescripcion.Text = cPercha.descripcion;
            txtNDivisiones.Text = cPercha.divisiones.ToString();
            cbxBodega.EditValue = Convert.ToString(cPercha.bodega);
            cbxEstado.EditValue = Convert.ToString(cPercha.estado);
        }

        datPercha datos = new datPercha();

        private void frmPercha_Load_1(object sender, EventArgs e)
        {
            
            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
            datBodega data2 = new datBodega();
            cbxBodega.Properties.DataSource = data2.consulta();
        }
    }
}
