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
    public partial class frmTipoCombustible : Form
    {
        public frmTipoCombustible()
        {
            InitializeComponent();
        }
        int EU = 1;

        public clsTipoCombustible cTipoCombustible = new clsTipoCombustible();
        datTipoCombustible cd = new datTipoCombustible();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datTipoCombustible cd = new datTipoCombustible();
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
            EU = cTipoCombustible.empresa;
            txt_CodigoCombustible.Text = Convert.ToString(cTipoCombustible.codigo);
            txt_DescripcionTipoCombustible.Text = cTipoCombustible.descripcion;
            // EU = cTipoArticulo.usuario;
            cbx_EstadoTipoCombustible.Text = cTipoCombustible.estado;

        }

        public void get()
        {
            cTipoCombustible.empresa = EU;
            cTipoCombustible.codigo = Convert.ToInt32(txt_CodigoCombustible.Text);
            cTipoCombustible.descripcion = txt_DescripcionTipoCombustible.Text;
            //cTipoArticulo.usuario = EU;
            cTipoCombustible.estado = cbx_EstadoTipoCombustible.EditValue.ToString();
        }

        public bool getdatos()
        {
            cTipoCombustible.empresa = EU;
            cTipoCombustible.codigo = Convert.ToInt32(txt_CodigoCombustible.Text);
            cTipoCombustible.descripcion = txt_DescripcionTipoCombustible.Text;
            cTipoCombustible.estado = cbx_EstadoTipoCombustible.Text;
            return true;
        }

        public void limpiar()
        {
            txt_CodigoCombustible.Text = "";
            txt_DescripcionTipoCombustible.Text = "";
            cbx_EstadoTipoCombustible.EditValue = "";
        }


        private void tsb_NuevoTipoCombustible_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsb_ModificarTipoCombustible_Click(object sender, EventArgs e)
        {

        }

        private void tsb_SalirTipoCombustible_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmConsultaTipoCombustible consulta = new frmConsultaTipoCombustible();
        private void btn_ConsultaTipoCombustible_Click(object sender, EventArgs e)
        {

        }
        void consulta_Event_frmConsultaTipoCombustible_FormClosing(object sender, EventArgs e)
        {
            clsTipoCombustible TipoCombustible = (clsTipoCombustible)sender;
            txt_CodigoCombustible.Text = TipoCombustible.codigo.ToString();
            txt_DescripcionTipoCombustible.Text = TipoCombustible.descripcion;
            cbx_EstadoTipoCombustible.Text = TipoCombustible.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaTipoCombustible_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void frmTipoCombustible_Load(object sender, EventArgs e)
        {

        }

        private void tsb_GuardarTipoCombustible_Click_1(object sender, EventArgs e)
        {
           
        }

        private void tsb_ModificarTipoCombustible_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_ConsultaTipoCombustible_Click_1(object sender, EventArgs e)
        {
            consulta = new frmConsultaTipoCombustible();
            consulta.Event_frmConsultaTipoCombustible_FormClosing += new frmConsultaTipoCombustible.delegate_frmConsultaTipoCombustible_FormClosing(consulta_Event_frmConsultaTipoCombustible_FormClosing);
            consulta.Show();
        }

        private void tsb_GuardarTipoCombustible_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cTipoCombustible, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cTipoCombustible);
            }
        }

        private void tsb_ModificarTipoCombustible_Click_2(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cTipoCombustible))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_SalirTipoCombustible_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaTipoCombustible_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaTipoCombustible();
            consulta.ShowDialog();
            cTipoCombustible  = consulta.clastm;
            txt_CodigoCombustible.Text = cTipoCombustible.codigo.ToString();
            txt_DescripcionTipoCombustible.Text = cTipoCombustible .descripcion;
            cbx_EstadoTipoCombustible.EditValue = Convert.ToString(cTipoCombustible.estado);
        }

        datTipoCombustible datos = new datTipoCombustible();
        private void frmTipoCombustible_Load_1(object sender, EventArgs e)
        {

            int a = datos.getIdSiguiente();
            txt_CodigoCombustible.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoTipoCombustible.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
