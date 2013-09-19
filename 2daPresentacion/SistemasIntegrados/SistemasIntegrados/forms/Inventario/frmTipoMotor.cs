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
    public partial class frmTipoMotor : Form
    {
        public frmTipoMotor()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsTipoMotor cTipoMotor = new clsTipoMotor();
        datTipoMotor cd = new datTipoMotor();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datTipoMotor cd = new datTipoMotor();
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
            EU = cTipoMotor.empresa;
            txtCodigo.Text = Convert.ToString(cTipoMotor.codigo);
            txtDescripcion.Text = cTipoMotor.descripcion;
            cbxEstado.Text = cTipoMotor.estado;

        }

        public void get()
        {
            cTipoMotor.empresa = EU;
            cTipoMotor.codigo = Convert.ToInt32(txtCodigo.Text);
            cTipoMotor.descripcion = txtDescripcion.Text;
            cTipoMotor.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            cTipoMotor.empresa = EU;
            cTipoMotor.codigo = Convert.ToInt32(txtCodigo.Text);
            cTipoMotor.descripcion = txtDescripcion.Text;
            cTipoMotor.estado = cbxEstado.Text;
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
        frmConsultaTipoMotor consulta = new frmConsultaTipoMotor();
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
          
        }

        void consulta_Event_frmConsultaTipoMotor_FormClosing(object sender, EventArgs e)
        {
            clsTipoMotor motor = (clsTipoMotor)sender;
            txtCodigo.Text = motor.codigo.ToString();
            txtDescripcion.Text = motor.descripcion;
            cbxEstado.Text = motor.estado;
            consulta.Visible = false;
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cTipoMotor, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cTipoMotor);
            }
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cTipoMotor))
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
            consulta = new frmConsultaTipoMotor();
            consulta.ShowDialog();
            cTipoMotor  = consulta.clastm;
            txtCodigo.Text = cTipoMotor.codigo.ToString();
            txtDescripcion.Text = cTipoMotor.descripcion;
            cbxEstado.EditValue = Convert.ToString(cTipoMotor.estado);
        }
        datTipoMotor datos = new datTipoMotor();
        private void frmTipoMotor_Load(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
        }

    }
}
