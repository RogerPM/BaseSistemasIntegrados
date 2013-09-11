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
    public partial class frmChasis : Form
    {
        public frmChasis()
        {
            InitializeComponent();
        }
        int EU = 1;

        public clsTipoChasis cChasis = new clsTipoChasis();
        datTipoChasis cd = new datTipoChasis();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datTipoChasis cd = new datTipoChasis();
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
            EU = cChasis.empresa;
            txt_CodigoChasis.Text = Convert.ToString(cChasis.codigo);
            txt_DescripcionChasis.Text = cChasis.descripcion;
            // EU = cColor.usuario;
            cbx_EstadoChasis.Text = cChasis.estado;

        }

        public void get()
        {
            cChasis.empresa = EU;
            cChasis.codigo = Convert.ToInt32(txt_CodigoChasis.Text);
            cChasis.descripcion = txt_DescripcionChasis.Text;
            // cColor.usuario = EU;
            cChasis.estado = cbx_EstadoChasis.EditValue.ToString();
        }

        public bool getdatos()
        {
            cChasis.empresa = EU;
            cChasis.codigo = Convert.ToInt32(txt_CodigoChasis.Text);
            cChasis.descripcion = txt_DescripcionChasis.Text;
            cChasis.estado = cbx_EstadoChasis.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoChasis.Text = "";
            txt_DescripcionChasis.Text = "";
            cbx_EstadoChasis.EditValue = "";
        }

        private void tsb_NuevoChasis_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        frmConsultaChasis consulta = new frmConsultaChasis();
        private void btn_ConsultaChasis_Click(object sender, EventArgs e)
        {

        }
        void consulta_Event_frmConsultaChasis_FormClosing(object sender, EventArgs e)
        {
            clsTipoChasis Chasis = (clsTipoChasis)sender;
            txt_CodigoChasis.Text = Chasis.codigo.ToString();
            txt_DescripcionChasis.Text = Chasis.descripcion;
            cbx_EstadoChasis.Text = Chasis.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaChasis_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tsb_SalirChasis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaChasis_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tsb_GuardarChasis_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tsb_ModificarChasis_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tsb_GuardarChasis_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cChasis, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cChasis);
            }
        }

        private void tsb_ModificarChasis_Click(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cChasis))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_SalirChasis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaChasis_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaChasis();
            consulta.ShowDialog();
            cChasis = consulta.clastm;
            txt_CodigoChasis.Text = cChasis.codigo.ToString();
            txt_DescripcionChasis.Text = cChasis.descripcion;
            cbx_EstadoChasis.EditValue = Convert.ToString(cChasis.estado);
            //consulta.Show();
        }

        datTipoChasis  datos = new datTipoChasis();

        private void frmChasis_Load(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txt_CodigoChasis.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoChasis.Properties.DataSource = data1.ConsultaTodos();
        }
        
    }
}
