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
using clases.RecursosHumanos;
using datos.RecursosHumanos;


namespace forms.Inventario
{
    public partial class frmBodega : Form
    {
        int EU = 1;
        frmConsultaBodega consulta = new frmConsultaBodega();
        public clsBodega oBodega = new clsBodega();
        datBodega oDatBodega = new datBodega();

        public frmBodega()
        {
            InitializeComponent();
        }
        

        public string accion { get; set; }


        datBodega datos = new datBodega();

        private void Bodega_Load(object sender, EventArgs e)
        {
            datBodega cd = new datBodega();
            
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
            oBodega.empresa = EU;
            oBodega.codigo = Convert.ToInt32(txtCodigo.Text);
            oBodega.descripcion = txtDescripcion.Text;
            oBodega.capacidadm2 = Convert.ToInt32(txtCapacidadm2.Text);
            oBodega.responsable = Convert.ToString(cbxResponsable.Text);
            oBodega.percha = Convert.ToString(cbxPercha.Text);
            oBodega.direccion = txtDireccion.Text;
            oBodega.telefono = txtTelefono.Text;
            oBodega.estado = cbxEstado.Text;

        }

        public void get()
        {
            oBodega.empresa = EU;
            oBodega.codigo = Convert.ToInt32(txtCodigo.Text);
            oBodega.descripcion = txtDescripcion.Text;
            oBodega.capacidadm2 = Convert.ToInt32(txtCapacidadm2.Text);
            oBodega.responsable = Convert.ToString(cbxResponsable.EditValue);
            oBodega.percha = Convert.ToString(cbxPercha.EditValue);
            oBodega.direccion = txtDireccion.Text;
            oBodega.telefono = txtTelefono.Text;
            oBodega.estado = cbxEstado.EditValue.ToString();
        }

        public bool getdatos()
        {
            oBodega.empresa = EU;
            oBodega.codigo = Convert.ToInt32(txtCodigo.Text);
            oBodega.descripcion = txtDescripcion.Text;
            oBodega.capacidadm2 = Convert.ToInt32(txtCapacidadm2.Text);
            oBodega.responsable = Convert.ToString(cbxResponsable.Text);
            oBodega.percha = Convert.ToString(cbxPercha.Text);
            oBodega.direccion = txtDireccion.Text;
            oBodega.telefono = txtTelefono.Text;
            oBodega.estado = cbxEstado.Text;
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
            get();
            string Mensaje = "";

            if (oDatBodega.guardar(oBodega, ref Mensaje))
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);


            if (accion == "M")
            {

            }
            if (accion == "E")
            {
                oDatBodega.eliminar(oBodega);
            }

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            get();
            if (oDatBodega.modificar(oBodega))
            {
                MessageBox.Show("Actualizado OK");
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        void consulta_Event_frmConsultaBodega_FormClosing(object sender, EventArgs e)
        {
            clsBodega bodega = (clsBodega)sender;
            txtCodigo.Text = bodega.codigo.ToString();
            txtDescripcion.Text = bodega.descripcion;
            txtCapacidadm2.Text = bodega.capacidadm2.ToString();
            cbxResponsable.Text = bodega.responsable;
            cbxPercha.Text = bodega.percha;
            txtDireccion.Text = bodega.direccion;
            txtTelefono.Text = bodega.telefono;
            cbxEstado.Text = bodega.estado;
            consulta.Visible = false;
        }

        private void btnConsultaCodigo_Click(object sender, EventArgs e)
        {
            
            frmConsultaBodega f = new frmConsultaBodega();
            f.ShowDialog();
            oBodega = f.cls; //oBodega viene de las clases 
            txtCodigo.Text = Convert.ToString(oBodega.codigo);
            txtDescripcion.Text = oBodega.descripcion;
            txtCapacidadm2.Text = Convert.ToString(oBodega.capacidadm2);
            txtDireccion.Text = oBodega.direccion;
            cbxResponsable.EditValue = oBodega.responsable;//FK
            txtTelefono.Text = oBodega.telefono;
            cbxEstado.EditValue = oBodega.estado;//FK
            cbxPercha.EditValue = Convert.ToString(oBodega.percha);//FK

        }

        private void frmBodega_Load(object sender, EventArgs e)
        {

            int a = datos.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);

            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.consEstado();
            datPercha data2 = new datPercha();
            this.cbxPercha.Properties.DataSource = data2.consulta();
            clsDatosPersona data3 = new clsDatosPersona();
            cbxResponsable.Properties.DataSource = data3.ConsultaPersona();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
