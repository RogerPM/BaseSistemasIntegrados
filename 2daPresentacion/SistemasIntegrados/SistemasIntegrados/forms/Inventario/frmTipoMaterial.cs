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
    public partial class frmTipoMaterial : Form
    {
        public frmTipoMaterial()
        {
            InitializeComponent();
        }
        int EU = 1;
        public clsTipoMaterial cTipoMaterial = new clsTipoMaterial();
        datTipoMaterial cd = new datTipoMaterial();

        public string accion { get; set; }

        private void Motivo_Load(object sender, EventArgs e)
        {
            datTipoMaterial cd = new datTipoMaterial();
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
            EU = cTipoMaterial.empresa;
            txt_CodigoMaterial.Text = Convert.ToString(cTipoMaterial.codigo);
            txt_DescripcionMaterial.Text = cTipoMaterial.descripcion;
            //EU = cTipoMaterial.usuario;
            cbx_EstadoMaterial.Text = cTipoMaterial.estado;

        }

        public void get()
        {
            cTipoMaterial.empresa = EU;
            cTipoMaterial.codigo = Convert.ToInt32(txt_CodigoMaterial.Text);
            cTipoMaterial.descripcion = txt_DescripcionMaterial.Text;
            //cTipoMaterial.usuario = EU;
            cTipoMaterial.estado = cbx_EstadoMaterial.EditValue.ToString();
        }

        public bool getdatos()
        {
            cTipoMaterial.empresa = EU;
            cTipoMaterial.codigo = Convert.ToInt32(txt_CodigoMaterial.Text);
            cTipoMaterial.descripcion = txt_DescripcionMaterial.Text;
            cTipoMaterial.estado = cbx_EstadoMaterial.Text;
            return true;
        }
        public void limpiar()
        {
            txt_CodigoMaterial.Text = "";
            txt_DescripcionMaterial.Text = "";
            cbx_EstadoMaterial.EditValue = "";
        }

        private void frmTipoMaterial_Load(object sender, EventArgs e)
        {

        }

        private void tsb_NuevoTipoMaterial_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsb_GuardarTipoMaterial_Click_1(object sender, EventArgs e)
        {

        }

        private void tsb_ModificarTipoMaterial_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cTipoMaterial))
            {
                MessageBox.Show("Actualizado OK");
            }

        }

        private void tsb_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        frmConsultaTipoMaterial consulta = new frmConsultaTipoMaterial();
        private void btn_ConsultaMaterial_Click_1(object sender, EventArgs e)
        {
            consulta = new frmConsultaTipoMaterial();
            consulta.Event_frmConsultaTipoMaterial_FormClosing += new frmConsultaTipoMaterial.delegate_frmConsultaTipoMaterial_FormClosing(consulta_Event_frmConsultaTipoMaterial_FormClosing);
            consulta.Show();
        }
        void consulta_Event_frmConsultaTipoMaterial_FormClosing(object sender, EventArgs e)
        {
            clsTipoMaterial TipoMaterial = (clsTipoMaterial)sender;
            txt_CodigoMaterial.Text = TipoMaterial.codigo.ToString();
            txt_DescripcionMaterial.Text = TipoMaterial.descripcion;
            cbx_EstadoMaterial.Text = TipoMaterial.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaTipoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void tsb_GuardarTipoMaterial_Click(object sender, EventArgs e)
        {
           
        }

        private void tsb_ModificarTipoMaterial_Click(object sender, EventArgs e)
        {
           
        }

        private void tsb_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaMaterial_Click(object sender, EventArgs e)
        {
           
        }

        private void tsb_GuardarTipoMaterial_Click_2(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cTipoMaterial, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cTipoMaterial);
            }
        }

        private void tsb_ModificarTipoMaterial_Click_2(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cTipoMaterial))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsb_Salir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultaMaterial_Click_2(object sender, EventArgs e)
        {
            consulta = new frmConsultaTipoMaterial();
            consulta.ShowDialog();
            cTipoMaterial  = consulta.clastm;
            txt_CodigoMaterial .Text = cTipoMaterial.codigo.ToString();
            txt_DescripcionMaterial.Text = cTipoMaterial.descripcion;
            cbx_EstadoMaterial.EditValue = Convert.ToString(cTipoMaterial.estado);
        }

        datTipoMaterial datos = new datTipoMaterial();
        private void frmTipoMaterial_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txt_CodigoMaterial.Text = Convert.ToString(a);
            datEstado data1 = new datEstado();
            cbx_EstadoMaterial.Properties.DataSource = data1.ConsultaTodos();
        }
    }
}
