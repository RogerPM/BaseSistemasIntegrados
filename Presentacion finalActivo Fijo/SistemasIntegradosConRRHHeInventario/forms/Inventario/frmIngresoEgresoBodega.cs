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
using clases.Seguridad;
using datos.Seguridad;
using clases.RecursosHumanos;
using datos.RecursosHumanos;


namespace forms.Inventario
{
    public partial class frmIngresoEgresoBodega : Form
    {
        int EU = 1;
        frmConsultaIngresoEgresoCAB consulta = new frmConsultaIngresoEgresoCAB();
        public clsIngresoEgresoCAB  oIngresoEgreso = new clsIngresoEgresoCAB ();
        datIngresoEgresoBodegaCAB  oIngresoEgresoB = new datIngresoEgresoBodegaCAB ();



        public frmIngresoEgresoBodega()
        {
            InitializeComponent();
        }

        public void set()
        {
            oIngresoEgreso.empresa = EU;
            oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text );
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.ordenCompra = Convert.ToInt32 ( txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.DateTime);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.Text);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.Text);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.Text);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
        }


        public void get()
        {
            oIngresoEgreso.empresa = EU;
            oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text);
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.EditValue);
            oIngresoEgreso.ordenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.EditValue);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.DateTime);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.EditValue);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.EditValue);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.EditValue);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
        }

        public bool  getDatos()
        {
            oIngresoEgreso.empresa = EU;
            oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text);
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.ordenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.DateTime);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.Text);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.Text);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.Text);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
            return true;
        }

        public void limpiar()
        {
            int a = datos.getIdSiguiente();
            txtNoMovimiento.Text = Convert.ToString(a);
            cbxTipoMovimiento.Text = "";
            txtOrdenCompra.Text = "";
            cbxTipoMovimiento.Text = "";
            txtObservacion.Text = "";
            dateFecmov.Text  = "";
            cbxBodega.Text = "";
            cbxResponsable.Text = "";
            cbxEstado.Text = "";
            txtTotalPagar.Text = "";
        }



        datIngresoEgresoBodegaCAB datos = new datIngresoEgresoBodegaCAB();
        private void frmIngresoEgresoBodega_Load(object sender, EventArgs e)
        {
            int a = datos.getIdSiguiente();
            txtNoMovimiento.Text = Convert.ToString(a);
            
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
            datBodega data2 = new datBodega();
            cbxBodega.Properties.DataSource = data2.consulta();
            clsDatosPersona data3 = new clsDatosPersona();
            cbxResponsable.Properties.DataSource = data3.ConsultaPersona();
            datTipoMovimiento data4 = new datTipoMovimiento();
            cbxTipoMovimiento.Properties.DataSource = data4.consulta();
            datMotivo data5 = new datMotivo();
            cbxMotivo.Properties.DataSource = data5.consulta();
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnNvo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";
            if (oIngresoEgresoB .guardar (oIngresoEgreso, ref Mensaje ))
                      
                MessageBox.Show("Guardado Exitosamente");
            else
                MessageBox.Show(Mensaje);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        void consulta_Event_frmConsultaIngresoEgresoCAB_FormClosing(object sender, EventArgs e)
        {
            clsIngresoEgresoCAB IngEg = (clsIngresoEgresoCAB)sender;
            txtNoMovimiento.Text = IngEg.nroMovimiento.ToString();
            cbxTipoMovimiento.Text = IngEg.tipoMovimiento.ToString();
            dateFecmov.DateTime = IngEg.fechaMovimiento;
            txtOrdenCompra.Text = IngEg.ordenCompra.ToString();
            cbxMotivo.Text = IngEg.motivo.ToString();
            cbxBodega.Text = IngEg.bodega.ToString();
            cbxResponsable.Text = IngEg.responsable.ToString();
            txtTotalPagar.Text = IngEg.totalPagar.ToString();
            txtObservacion.Text = IngEg.observacion;
            cbxEstado.TabIndex = IngEg.estado;
            consulta.Visible = false;
        }

        private void btnBuscarMovmiento_Click(object sender, EventArgs e)
        {
           frmConsultaIngresoEgresoCAB consulta = new frmConsultaIngresoEgresoCAB();
           consulta.ShowDialog();
           oIngresoEgreso = consulta.cls;
           txtNoMovimiento.Text = Convert.ToString(oIngresoEgreso.nroMovimiento);
           cbxTipoMovimiento.EditValue = oIngresoEgreso.tipoMovimiento;
           dateFecmov.DateTime = Convert.ToDateTime(oIngresoEgreso.fechaMovimiento);
           txtOrdenCompra.Text = Convert.ToString(oIngresoEgreso.ordenCompra);
           cbxMotivo.EditValue = oIngresoEgreso.motivo;
           cbxBodega.EditValue = oIngresoEgreso.bodega;
           cbxResponsable.EditValue = oIngresoEgreso.responsable;
           txtTotalPagar.Text = Convert.ToString(oIngresoEgreso.totalPagar);
           txtObservacion.Text = oIngresoEgreso.observacion;
           cbxEstado.EditValue = oIngresoEgreso.estado;
         }

        private void cbxMotivo_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoMovimiento.SelectedText == "Ingreso")
            {
                if (cbxMotivo.SelectedText == "Compra")
                {
                    txtOrdenCompra.Enabled = true;
                }
                else
                {
                    txtOrdenCompra.Enabled = false;
                }
            }
            else
                if (cbxTipoMovimiento.SelectedText == "Egreso")
                {

                    txtOrdenCompra.Enabled = false;
                }

        }

        private void btnCargarNuevo_Click(object sender, EventArgs e)
        {

        }



    }
}
