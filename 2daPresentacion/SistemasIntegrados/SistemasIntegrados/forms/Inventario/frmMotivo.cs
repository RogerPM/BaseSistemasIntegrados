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
    public partial class frmMotivo : Form
    {
        public frmMotivo()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsMotivo cMotivo = new clsMotivo();
        datMotivo cd = new datMotivo();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datMotivo cd = new datMotivo();
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
            EU = cMotivo.empresa;
            txtCodigo.Text = Convert.ToString(cMotivo.codigo);
            txtDescripcion.Text = cMotivo.descripcion;
            cbxEstado.Text = cMotivo.estado;

        }

        public void get()
        {
            cMotivo.empresa = EU;
            cMotivo.codigo = Convert.ToInt32(txtCodigo.Text);
            cMotivo.descripcion = txtDescripcion.Text;
            cMotivo.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            cMotivo.empresa = EU;
            cMotivo.codigo = Convert.ToInt32(txtCodigo.Text);
            cMotivo.descripcion = txtDescripcion.Text;
            cMotivo.estado = cbxEstado.Text;
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
        frmConsultaMotivo consulta = new frmConsultaMotivo();
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            
        }

        void consulta_Event_frmConsultaMotivo_FormClosing(object sender, EventArgs e)
        {
            clsMotivo motivo = (clsMotivo)sender;
            txtCodigo.Text = motivo.codigo.ToString();
            txtDescripcion.Text = motivo.descripcion;
            cbxEstado.Text = motivo.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaMotivo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmMotivo_Load(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cMotivo, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cMotivo);
            }
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cMotivo))
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
            consulta = new frmConsultaMotivo();
            consulta.ShowDialog();
            cMotivo = consulta.clastm;
            txtCodigo.Text = cMotivo.codigo.ToString();
            txtDescripcion.Text = cMotivo.descripcion;
            cbxEstado.EditValue = Convert.ToString(cMotivo.estado);
        }
        datMotivo datos = new datMotivo();
        private void frmMotivo_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
        }



    }
}
