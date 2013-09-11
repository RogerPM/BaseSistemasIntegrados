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
    public partial class frmColor : Form
    {
        clsColor oColor = new clsColor();
        public frmColor()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsColor cColor = new clsColor();
        datColor cd = new datColor();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datColor cd = new datColor();
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
            EU = cColor.empresa;
            txt_CodigoColor.Text = Convert.ToString(cColor.codigo);
            txt_DescripcionColor.Text = cColor.descripcion;
            // EU = cColor.usuario;
            cbx_EstadoColor.Text = cColor.estado;

        }

        public void get()
        {
            cColor.empresa = EU;
            cColor.codigo = Convert.ToInt32(txt_CodigoColor.Text);
            cColor.descripcion = txt_DescripcionColor.Text;
            // cColor.usuario = EU;
            cColor.estado = cbx_EstadoColor.EditValue.ToString();
        }

        public bool getdatos()
        {
            cColor.empresa = EU;
            cColor.codigo = Convert.ToInt32(txt_CodigoColor.Text);
            cColor.descripcion = txt_DescripcionColor.Text;
            cColor.estado = cbx_EstadoColor.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoColor.Text = "";
            txt_DescripcionColor.Text = "";
            cbx_EstadoColor.EditValue = "";
        }

        private void frmColor_Load(object sender, EventArgs e)
        {

        }

        private void tsb_NuevoColor_Click_1(object sender, EventArgs e)
        {
            
        }


        frmConsultaColor consulta = new frmConsultaColor();
        private void btn_ConsultaColor_Click_1(object sender, EventArgs e)
        {

        }
        void consulta_Event_frmConsultaColor_FormClosing(object sender, EventArgs e)
        {
            clsColor color = (clsColor)sender;
            txt_CodigoColor.Text = color.codigo.ToString();
            txt_DescripcionColor.Text = color.descripcion;
            cbx_EstadoColor.Text = color.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaColor_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tsb_GuardarColor_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_ModificarColor_Click(object sender, EventArgs e)
        {
           
        }

        private void tsb_SalirColor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaColor_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_NuevoColor_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsb_GuardarColor_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cColor, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cColor);
            }
        }

        private void tsb_ModificarColor_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cColor))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_SalirColor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaColor_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaColor();
            consulta.ShowDialog();
            cColor = consulta.clastm;
            txt_CodigoColor.Text = cColor.codigo.ToString();
            txt_DescripcionColor.Text = cColor.descripcion;
            cbx_EstadoColor.EditValue = Convert.ToString(cColor.estado);

        }

        datColor datos = new datColor();
        private void frmColor_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txt_CodigoColor.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoColor.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
