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
    public partial class frmGrupo : Form
    {
        public frmGrupo()
        {
            InitializeComponent();
        }
        int EU = 1;

        public clsGrupo cGrupo = new clsGrupo();
        datGrupo cd = new datGrupo();

        public string accion { get; set; }

        private void Grupo_Load(object sender, EventArgs e)
        {
            datGrupo cd = new datGrupo();
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
            cGrupo.empresa = EU;
            cGrupo.codigo = Convert.ToInt32(txtCodigo.Text);
            cGrupo.descripcion = txtDescripcion.Text;
            //cGrupo.tipoarticulo = Convert.ToString(txtTipoArticulo.Text);
            cGrupo.estado = cbxEstado.Text;

        }

        public void get()
        {
            cGrupo.empresa = EU;
            cGrupo.codigo = Convert.ToInt32(txtCodigo.Text);
            cGrupo.descripcion = txtDescripcion.Text;
            cGrupo.tipoarticulo = Convert.ToString(cbxTipoArticulo.EditValue );
            cGrupo.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            cGrupo.empresa = EU;
            cGrupo.codigo = Convert.ToInt32(txtCodigo.Text);
            cGrupo.descripcion = txtDescripcion.Text;
            //cGrupo.tipoarticulo = Convert.ToString(tExtTipoArticulo.Text);
            cGrupo.estado = cbxEstado.Text;
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
        frmConsultaGrupo consulta = new frmConsultaGrupo();
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            
        }

        void consulta_Event_frmConsultaGrupo_FormClosing(object sender, EventArgs e)
        {
            clsGrupo grupo = (clsGrupo)sender;
            txtCodigo.Text = grupo.codigo.ToString();
            txtDescripcion.Text = grupo.descripcion;
            cbxEstado.Text = grupo.estado;
            consulta.Visible = false;
        }

        void consulta_Event_frmConsultaGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";

            if (cd.guardar(cGrupo, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                cd.eliminar(cGrupo);
            }
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            get();
            if (cd.modificar(cGrupo))
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
            consulta = new frmConsultaGrupo();
            consulta.ShowDialog();
            cGrupo  = consulta.clastm;
            txtCodigo .Text = cGrupo.codigo.ToString();
            txtDescripcion.Text = cGrupo.descripcion;
            cbxTipoArticulo.EditValue = Convert.ToString(cGrupo.tipoarticulo);
            cbxEstado.EditValue = Convert.ToString(cGrupo.estado);
            
        }

        datGrupo datos = new datGrupo();


        private void frmGrupo_Load_1(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);

            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
            datTipoArticulo data2 = new datTipoArticulo();
            cbxTipoArticulo.Properties.DataSource = data2.consulta();
        }
    }
}
