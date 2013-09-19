using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Inventario;
using clases.Inventario;

namespace forms.Inventario
{
    public partial class frmLLegadaMercaderia : Form
    {
        public frmLLegadaMercaderia()
        {
            InitializeComponent();
        }
        clsInventario dat = new clsInventario();
        clsLlegadaMercaderia clase = new clsLlegadaMercaderia();
        private void frmLLegadaMercaderia_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            try
            {
                cmbArticulo.DataSource = dat.consultainventario();
                cmbPercha.DataSource = dat.consultapercha();
                cmbBodega.Properties.DataSource = dat.consultaBodega();
                cbxMotivo.Properties.DataSource = dat.consultaMotivo();
            }
            catch (Exception)
            {
            }
        }
        private void get()
        {
            try
            {
                clase.IdBodega = Convert.ToInt32(cmbBodega.EditValue);
                clase.Factura = Convert.ToDecimal(txtNumeroFact.Text);
                clase.Observacion = txtObservacion.Text;

            }
            catch (Exception)
            {
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaLLegada frm = new frmConsultaLLegada();
                frm.ShowDialog();
                txtOrden.Text=frm.idNroMovimiento.ToString();
                clase=dat.consultaOrdencompra(Convert.ToInt32(txtOrden.Text));
                gcllegada.DataSource = clase.detalle;
                txtObservacion.Text = clase.Observacion;
            }
            catch (Exception)
            {
            }
        }

        private void gvllegada_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                List<clsLlegadaMercaderiaDet> lista = new List<clsLlegadaMercaderiaDet>();
                lista = (List<clsLlegadaMercaderiaDet>)gcllegada.DataSource;
                foreach (var item in lista)
                {
                    item.Subtotal = item.Precio * item.CantidadLlegada;
                    item.ValorIVA = item.Subtotal * Convert.ToDecimal("0,12");
                    item.ValorTotal = item.ValorIVA +item.Subtotal;
                }
                gcllegada.DataSource = lista;

            }
            catch (Exception)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<clsLlegadaMercaderiaDet> lista = new List<clsLlegadaMercaderiaDet>();
            lista = (List<clsLlegadaMercaderiaDet>)gcllegada.DataSource;
            clase.detalle = lista;
            if(dat.guardarLLegada(clase)){MessageBox.Show("OK");}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                gcllegada.DataSource = null;
                clsLlegadaMercaderiaDetBindingSource.Clear();
                txtNumeroFact.Text = txtObservacion.Text="";
            }
            catch (Exception)
            {
            }
        }
    }
}
