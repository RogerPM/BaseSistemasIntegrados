using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class frmRptVentas : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
       
        public frmRptVentas()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRptVentas_Load(object sender, EventArgs e)
        {
            try
            {
               
                cargarFormaPagos();
                cmbformapago.SelectedIndex = -1;
            }
            catch (Exception ex) { }
        }

        private void cargarFormaPagos()
        {
            try
            {
                var FormaPago = da.FormaPago;
                this.cmbformapago.DataSource = FormaPago.ToList();
                cmbformapago.ValueMember = "IdFormaPago";
                cmbformapago.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

            }

        }
        private void btnConsultaVendedor_Click(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            clsPersona clas = new clsPersona();
            cPer.ShowDialog();
            clas = cPer.p;
            txtCodVendedor.Text = Convert.ToString(clas.IdPersona);
            txtDexcripVendedor.Text = clas.NombreRazonSocial + ' ' + clas.Apellido;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //consultar

            if (this.txtCodVendedor.Text != "" && this.cmbformapago.SelectedIndex >= 0)
            {
                int codfpago = Int32.Parse(cmbformapago.SelectedValue.ToString());
                int codusuario = Int32.Parse(txtCodVendedor.Text);
                var produc =
                 from a in da.Factura
                 join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                 join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                 join d in da.Estado on a.idEstado equals d.IdEstado
                 join es in da.Usuario on a.idUsuario equals es.IdUsuario
                 join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                 where a.IdFormaPago == codfpago && a.idUsuario == codusuario
                 select new
                 {
                     codFactura = a.IdNumeroFactura,
                     empresa = c.Descripcion,
                     formaPago = f.Descripcion,
                     cliente = b.NombreRazonSocial,
                     total = a.TotalPagar,
                     iva = a.Iva,
                     ice = a.Ice,
                     subtotal = a.Subtotal,
                     Fecha = a.Fecha,
                     cuotas = a.NumeroCuotaMensual,
                     estado = d.Descripcion,
                     usuario = es.NombreUsuario,
                     c.RazonSocial,
                     c.Ruc,
                     c.Direccion,
                     b.Identificacion
                 };
                dataGridView1.DataSource = produc.ToList();
                return;
            }

            if (this.txtCodVendedor.Text != "")
            {
                int codusuario = Int32.Parse(txtCodVendedor.Text);
                var produc =
                  from a in da.Factura
                  join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                  join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                  join d in da.Estado on a.idEstado equals d.IdEstado
                  join es in da.Usuario on a.idUsuario equals es.IdUsuario
                  join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                  where a.idUsuario == codusuario
                  select new
                  {
                      codFactura = a.IdNumeroFactura,
                      empresa = c.Descripcion,
                      formaPago = f.Descripcion,
                      cliente = b.NombreRazonSocial,
                      total = a.TotalPagar,
                      iva = a.Iva,
                      ice = a.Ice,
                      subtotal = a.Subtotal,
                      Fecha = a.Fecha,
                      cuotas = a.NumeroCuotaMensual,
                      estado = d.Descripcion,
                      usuario = es.NombreUsuario,
                      c.RazonSocial,
                      c.Ruc,
                      c.Direccion,
                      b.Identificacion
                  };
                dataGridView1.DataSource = produc.ToList();
                return;
            }


            if (this.cmbformapago.SelectedIndex >= 0)
            {
                int codforma =  Int32.Parse(cmbformapago.SelectedValue.ToString());
                var produc =
                  from a in da.Factura
                  join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                  join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                  join d in da.Estado on a.idEstado equals d.IdEstado
                  join es in da.Usuario on a.idUsuario equals es.IdUsuario
                  join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                  where a.IdFormaPago == codforma
                  select new
                  {
                      codFactura = a.IdNumeroFactura,
                      empresa = c.Descripcion,
                      formaPago = f.Descripcion,
                      cliente = b.NombreRazonSocial,
                      total = a.TotalPagar,
                      iva = a.Iva,
                      ice = a.Ice,
                      subtotal = a.Subtotal,
                      Fecha = a.Fecha,
                      cuotas = a.NumeroCuotaMensual,
                      estado = d.Descripcion,
                      usuario = es.NombreUsuario,
                      c.RazonSocial,
                      c.Ruc,
                      c.Direccion,
                      b.Identificacion
                  };
                dataGridView1.DataSource = produc.ToList();
                return;
            }

          

            {
                var produc =
                      from a in da.Factura
                      join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                      join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                      join d in da.Estado on a.idEstado equals d.IdEstado
                      join es in da.Usuario on a.idUsuario equals es.IdUsuario
                      join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                      where a.Fecha >= dtpdesde.Value && a.Fecha <= dtphasta.Value
                      select new
                      {
                          codFactura = a.IdNumeroFactura,
                          empresa = c.Descripcion,
                          formaPago = f.Descripcion,
                          cliente = b.NombreRazonSocial,
                          total = a.TotalPagar,
                          iva = a.Iva,
                          ice = a.Ice,
                          subtotal = a.Subtotal,
                          Fecha = a.Fecha,
                          cuotas = a.NumeroCuotaMensual,
                          estado = d.Descripcion,
                          usuario = es.NombreUsuario,
                          c.RazonSocial,
                          c.Ruc,
                          c.Direccion,
                          b.Identificacion
                      };
                dataGridView1.DataSource = produc.ToList();
            }

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ImprimirReporte();

        }

        private void ImprimirReporte()
        {

            FormViewVentas obj = new FormViewVentas( dtpdesde.Value,  dtphasta.Value, this.txtCodVendedor.Text, cmbformapago);
            obj.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtCodVendedor.Text = "";
                this.txtDexcripVendedor.Text = "";
                this.cmbformapago.SelectedIndex = -1;

                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            { }
        }
    }
}
