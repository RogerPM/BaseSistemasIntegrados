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
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        int EU = 1;

        public clsModelo cModelo = new clsModelo();
        datModelo cd = new datModelo();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datModelo cd = new datModelo();
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
            EU = cModelo.empresa;
            txt_CodigoModelo.Text = Convert.ToString(cModelo.codigo);
            txt_DescripcionModelo.Text = cModelo.descripcion;
            // EU = cModelo.usuario;
            cbx_EstadoModelo.Text = cModelo.estado;

        }

        public void get()
        {
            cModelo.empresa = EU;
            cModelo.codigo = Convert.ToInt32(txt_CodigoModelo.Text);
            cModelo.descripcion = txt_DescripcionModelo.Text;
            cModelo.marca = Convert.ToString(cbxMarca.EditValue) ;
            cModelo.estado = cbx_EstadoModelo.EditValue.ToString();
        }

        public bool getdatos()
        {
            cModelo.empresa = EU;
            cModelo.codigo = Convert.ToInt32(txt_CodigoModelo.Text);
            cModelo.descripcion = txt_DescripcionModelo.Text;
            cModelo.marca = Convert.ToString(cbxMarca.Text);
            cModelo.estado = cbx_EstadoModelo.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoModelo.Text = "";
            txt_DescripcionModelo.Text = "";
            cbx_EstadoModelo.EditValue = "";
        }

        private void tsb_NuevoModelo_Click_1(object sender, EventArgs e)
        {
            
        }


        private void tsb_ModificarModelo_Click(object sender, EventArgs e)
        {

        }

        private void tsb_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        frmConsultaModelo consulta = new frmConsultaModelo();
        private void btn_ConsultaModelo_Click_1(object sender, EventArgs e)
        {

        }
        void consulta_Event_frmConsultaModelo_FormClosing(object sender, EventArgs e)
        {
            clsModelo modelo = (clsModelo)sender;
            txt_CodigoModelo.Text = modelo.codigo.ToString();
            txt_DescripcionModelo.Text = modelo.descripcion;
            cbxMarca.Text = modelo.marca;
            cbx_EstadoModelo.Text = modelo.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tsb_GuardarModelo_Click(object sender, EventArgs e)
        {
           
        }

        private void tsb_ModificarModelo_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tsb_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaModelo_Click(object sender, EventArgs e)
        {
            

        }

        private void tsb_NuevoModelo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsb_GuardarModelo_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cModelo, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cModelo);
            }
        }

        private void tsb_ModificarModelo_Click_2(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cModelo))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_Salir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaModelo_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaModelo();
            consulta.ShowDialog();
            cModelo = consulta.clastm;
            txt_CodigoModelo.Text = cModelo.codigo.ToString();
            cbxMarca.EditValue = cModelo.marca.ToString();
            txt_DescripcionModelo.Text = cModelo.descripcion;
            cbx_EstadoModelo.EditValue = Convert.ToString(cModelo.estado);
        }

        datModelo datos = new datModelo();

        private void frmModelo_Load(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txt_CodigoModelo.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoModelo.Properties.DataSource = data1.ConsultaTodos();
            datMarca data2 = new datMarca();
            cbxMarca.Properties.DataSource = data2.consulta();
        }
    }
}
