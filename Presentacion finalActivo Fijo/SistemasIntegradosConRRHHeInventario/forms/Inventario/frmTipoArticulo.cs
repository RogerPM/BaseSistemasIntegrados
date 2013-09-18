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
    public partial class frmTipoArticulo : Form
    {
        public frmTipoArticulo()
        {
            InitializeComponent();
        }

        int EU = 1;
        public clsTipoArticulo cTipoArticulo = new clsTipoArticulo();
        datTipoArticulo cd = new datTipoArticulo();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datTipoArticulo cd = new datTipoArticulo();
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
            EU = cTipoArticulo.empresa;
            txt_CodigoArticulo.Text = Convert.ToString(cTipoArticulo.codigo);
            txt_DescripcionArticulo.Text = cTipoArticulo.descripcion;
            // EU = cTipoArticulo.usuario;
            cbx_EstadoArticulo.Text = cTipoArticulo.estado;

        }

        public void get()
        {
            cTipoArticulo.empresa = EU;
            cTipoArticulo.codigo = Convert.ToInt32(txt_CodigoArticulo.Text);
            cTipoArticulo.descripcion = txt_DescripcionArticulo.Text;
            //cTipoArticulo.usuario = EU;
            cTipoArticulo.estado = cbx_EstadoArticulo.EditValue.ToString();
        }

        public bool getdatos()
        {
            cTipoArticulo.empresa = EU;
            cTipoArticulo.codigo = Convert.ToInt32(txt_CodigoArticulo.Text);
            cTipoArticulo.descripcion = txt_DescripcionArticulo.Text;
            cTipoArticulo.estado = cbx_EstadoArticulo.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoArticulo.Text = "";
            txt_DescripcionArticulo.Text = "";
            cbx_EstadoArticulo.EditValue = "";
        }



        private void frmTipoArticulo_Load(object sender, EventArgs e)
        {

        }

        private void tsb_NuevoTipoArticulo_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        frmConsultaTipoArticulo consulta = new frmConsultaTipoArticulo();
        private void btn_ConsultaArticulo_Click_1(object sender, EventArgs e)
        {

        }
        void consulta_Event_frmConsultaTipoArticulo_FormClosing(object sender, EventArgs e)
        {
            clsTipoArticulo motor = (clsTipoArticulo)sender;
            txt_CodigoArticulo.Text = motor.codigo.ToString();
            txt_DescripcionArticulo.Text = motor.descripcion;
            cbx_EstadoArticulo.Text = motor.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaTipoArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tsb_GuardarTipoArticulo_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tsb_ModificarTipoArticulo_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tsb_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaArticulo_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_GuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cTipoArticulo, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cTipoArticulo);
            }
        }

        private void tsb_ModificarTipoArticulo_Click(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cTipoArticulo))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaArticulo_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaTipoArticulo();
            consulta.ShowDialog();
            cTipoArticulo  = consulta.clastm;
            txt_CodigoArticulo.Text = cTipoArticulo.codigo.ToString();
            txt_DescripcionArticulo.Text = cTipoArticulo.descripcion;
            cbx_EstadoArticulo.EditValue = Convert.ToString(cTipoArticulo.estado);
        }

        
        private void frmTipoArticulo_Load_1(object sender, EventArgs e)
        {
           
            datEstado data1 = new datEstado();
            cbx_EstadoArticulo.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
