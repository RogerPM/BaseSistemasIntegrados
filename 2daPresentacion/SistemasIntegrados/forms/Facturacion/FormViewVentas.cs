using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class FormViewVentas : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DateTime desdefecha;
        private DateTime hastafecha;
        private string vendedor;
        private ComboBox fpagos;
        public FormViewVentas()
        {
            InitializeComponent();
        }

        public FormViewVentas(DateTime desde, DateTime hasta, string codigovendedor, ComboBox formapagodatos)
        {
            InitializeComponent();
            desdefecha = desde;
            hastafecha = hasta;
            vendedor = codigovendedor;
            fpagos = formapagodatos;
        }

        private void FormViewVentas_Load(object sender, EventArgs e)
        {

            try
            {

                //consultar

                if (vendedor != "" && this.fpagos.SelectedIndex >= 0)
                {
                    int codfpago = Int32.Parse(fpagos.SelectedValue.ToString());
                    int codusuario = Int32.Parse(vendedor);

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
                    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ReporteVentas", produc.ToList()));
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    return;
                }

                if (this.vendedor != "")
                {
                    int codusuario = Int32.Parse(vendedor);
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
                    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ReporteVentas", produc.ToList()));
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    return;
                }


                if (this.fpagos.SelectedIndex >= 0)
                {
                    int codforma = Int32.Parse(fpagos.SelectedValue.ToString());
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
                    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ReporteVentas", produc.ToList()));
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
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
                          where a.Fecha >= desdefecha && a.Fecha <= hastafecha
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
                    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ReporteVentas", produc.ToList()));
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                }

            }
            catch (Exception ex) { }




            

        }
    }
}
