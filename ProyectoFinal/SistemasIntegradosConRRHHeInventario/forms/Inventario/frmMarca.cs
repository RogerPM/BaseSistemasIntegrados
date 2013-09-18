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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsMarca cMarca = new clsMarca();
        datMarca cd = new datMarca();

        public string accion { get; set; }

        private void Marca_Load(object sender, EventArgs e)
        {
            datMarca cd = new datMarca();
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
            EU = cMarca.empresa;
            txtCodigo.Text = Convert.ToString(cMarca.codigo);
            txtDescripcion.Text = cMarca.descripcion;
            cbxEstado.Text = cMarca.estado;

        }

        public void get()
        {
            cMarca.empresa = EU;
            cMarca.codigo = Convert.ToInt32(txtCodigo.Text);
            cMarca.descripcion = txtDescripcion.Text;
            cMarca.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            cMarca.empresa = EU;
            cMarca.codigo = Convert.ToInt32(txtCodigo.Text);
            cMarca.descripcion = txtDescripcion.Text;
            cMarca.estado = cbxEstado.Text;
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
            cbxEstado.EditValue = "";
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmConsultaMarca consulta = new frmConsultaMarca();
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            
        }

        void consulta_Event_frmConsultaMarca_FormClosing(object sender, EventArgs e)
        {
            clsMarca marca = (clsMarca)sender;
            txtCodigo.Text = marca.codigo.ToString();
            txtDescripcion.Text = marca.descripcion;
            cbxEstado.Text = marca.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cMarca, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cMarca);
            }
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cMarca))
            {
                MessageBox.Show("Actualizado OK");
            }

        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCodigo_Click_1(object sender, EventArgs e)
        {
            consulta = new frmConsultaMarca();
            consulta.ShowDialog();
            cMarca = consulta.clastm;
            txtCodigo.Text = cMarca.codigo.ToString();
            txtDescripcion.Text = cMarca.descripcion;
            cbxEstado.EditValue = Convert.ToString(cMarca.estado);
        }

        datMarca datos = new datMarca();

        private void frmMarca_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
