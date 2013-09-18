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
    public partial class frmUnidadMedida : Form
    {
        public frmUnidadMedida()
        {
            InitializeComponent();
        }
        int EU = 1;

        public clsUnidadMedida cUnidadMedida = new clsUnidadMedida();
        datUnidadMedida cd = new datUnidadMedida();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datUnidadMedida cd = new datUnidadMedida();
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
            EU = cUnidadMedida.empresa;
            txt_CodigoUnidadMedida.Text = Convert.ToString(cUnidadMedida.codigo);
            txt_DescripcionUnidadMedida.Text = cUnidadMedida.descripcion;
            // EU = cColor.usuario;
            cbx_EstadoUnidadMedida.Text = cUnidadMedida.estado;

        }

        public void get()
        {
            cUnidadMedida.empresa = EU;
            cUnidadMedida.codigo = Convert.ToInt32(txt_CodigoUnidadMedida.Text);
            cUnidadMedida.descripcion = txt_DescripcionUnidadMedida.Text;
            // cColor.usuario = EU;
            cUnidadMedida.estado = cbx_EstadoUnidadMedida.EditValue.ToString();
        }

        public bool getdatos()
        {
            cUnidadMedida.empresa = EU;
            cUnidadMedida.codigo = Convert.ToInt32(txt_CodigoUnidadMedida.Text);
            cUnidadMedida.descripcion = txt_DescripcionUnidadMedida.Text;
            cUnidadMedida.estado = cbx_EstadoUnidadMedida.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoUnidadMedida.Text = "";
            txt_DescripcionUnidadMedida.Text = "";
            cbx_EstadoUnidadMedida.EditValue = "";
        }


        private void tsb_NuevaUnidadMedida_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsb_GuardarUnidadMedida_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_ModificarUnidadMedida_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_SalirUnidadMedida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmConsultaUnidadMedida consulta = new frmConsultaUnidadMedida();
        private void btn_ConsultaUnidadMedida_Click(object sender, EventArgs e)
        {
            
        }
        void consulta_Event_frmConsultaUnidadMedida_FormClosing(object sender, EventArgs e)
        {
            clsUnidadMedida UnidadMedida = (clsUnidadMedida)sender;
            txt_CodigoUnidadMedida.Text = UnidadMedida.codigo.ToString();
            txt_DescripcionUnidadMedida.Text = UnidadMedida.descripcion;
            cbx_EstadoUnidadMedida.Text = UnidadMedida.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void frmUnidadMedida_Load(object sender, EventArgs e)
        {

        }

        private void tsb_GuardarUnidadMedida_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cUnidadMedida, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cUnidadMedida);
            }
        }

        private void tsb_ModificarUnidadMedida_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cUnidadMedida))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_SalirUnidadMedida_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaUnidadMedida_Click_1(object sender, EventArgs e)
        {
            consulta = new frmConsultaUnidadMedida();
            consulta.ShowDialog();
            cUnidadMedida = consulta.clastm;
            txt_CodigoUnidadMedida .Text = cUnidadMedida.codigo.ToString();
            txt_DescripcionUnidadMedida.Text = cUnidadMedida.descripcion;
            cbx_EstadoUnidadMedida.EditValue = Convert.ToString(cUnidadMedida .estado);
        }
        datUnidadMedida datos = new datUnidadMedida();
        private void frmUnidadMedida_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txt_CodigoUnidadMedida.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoUnidadMedida.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
