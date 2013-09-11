using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using datos;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class Formview : Form
    {
        
        private FacturacionEntities da = new FacturacionEntities();
        private int codigofactura = 0;
        public Formview()
        {
            InitializeComponent();
        }

        public Formview(int cod)
        {
            InitializeComponent();
            codigofactura = cod;
        }

        private void Formview_Load(object sender, EventArgs e)
        {
            //codigofactura = 1;
            var produc =
                    from a in da.Factura
                    join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente                   
                    join c in da.Empresa on  a.IdEmpresa equals c.IdEmpresa
                    join d in da.Estado on a.idEstado equals d.IdEstado
                    join es in da.Usuario on a.idUsuario equals es.IdUsuario
                    join f in da.FormaPago  on a.IdFormaPago equals f.IdFormaPago
                    where a.IdNumeroFactura == codigofactura
                    select new
                    {
                        empresa = c.Descripcion,
                        formaPago = f.Descripcion,
                        cliente = b.NombreRazonSocial,
                        total = a.TotalPagar,
                        iva = a.Iva,
                        ice = a.Ice,
                        subtotal = a.Subtotal,
                        Fecha= a.Fecha,
                        cuotas = a.NumeroCuotaMensual,
                        estado = d.Descripcion,
                        usuario= es.NombreUsuario,
                        c.RazonSocial,
                        c.Ruc,
                        c.Direccion,
                        b.Identificacion
                    };


            var detfactura =
                    from a in da.FacturaDet
                    join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                    join c in da.Marca on b.IdMarca equals c.IdMarca
                    join d in da.Estado on a.idEstado equals d.IdEstado
                    join es in da.Modelo on b.IdModelo equals es.IdModelo
                    where a.IdNumeroFactura == codigofactura
                    select new
                    {
                        a.Linea,
                        a.IdNumeroFactura,
                        a.precio,
                        a.cantidad,
                        b.Descripcion,
                        marca= c.Descripcion,
                        modelo= es.Descripcion,
                        chasis= b.Chasis.Descripcion,
                        color= b.Color.Descripcion

                    };

            var CabeceraCuotas =
                   from a in da.Factura
                   join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                   join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                   join d in da.Estado on a.idEstado equals d.IdEstado
                   join es in da.Usuario on a.idUsuario equals es.IdUsuario
                   join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                   join g in da.CuentaxCobrar on a.IdNumeroFactura equals g.idFactura
                   where g.Modulo ==1 && a.IdNumeroFactura == codigofactura
                   select new
                   {
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
                       b.Identificacion,
                       g.Modulo,
                       g.porcentaje_interes,
                       g.TotalCuotas,
                      a.TotalPagar
                       
                   };

            var DetalleCuotas =
                   from a in da.Factura
                   join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                   join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                   join d in da.Estado on a.idEstado equals d.IdEstado
                   join es in da.Usuario on a.idUsuario equals es.IdUsuario
                   join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                   join g in da.CuentaxCobrar on a.IdNumeroFactura equals g.idFactura
                   join h in da.CuentaxCobrarDet on g.idCuentaxCobrar equals h.idCuentaxCobrar
                   where g.Modulo==1 &&  a.IdNumeroFactura == codigofactura
                   select new
                   {
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
                       b.Identificacion,
                       h.idCuentaxCobrar,
                       h.Numero,
                       h.numero_cuota,
                       h.valor_cuota,
                       h.valor_mora,
                       h.valor_interes,
                       h.fecha_cobro,
                       h.fecha_vencimiento
                   };


            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CabeceraFact", produc.ToList()));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DetalleFact", detfactura.ToList()));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CabeceraCuotas", CabeceraCuotas.ToList()));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DetalleCuotas", DetalleCuotas.ToList()));
            reportViewer1.LocalReport.Refresh();

            //ReportParameter aus = new ReportParameter ();
            //aus.Name ="Empresa";
            //    aus.Values.Add("1");

            // ReportParameter aus1 = new ReportParameter ();
            // aus1.Name = "codfactura";
            // aus1.Values.Add("1");
            // List<ReportParameter> lispara;

            // lispara = new List<ReportParameter>();
            // lispara.Add (aus);
            // lispara.Add(aus1);

             //reportViewer1.LocalReport.SetParameters(lispara);
                //reportViewer1.ServerReport.SetParameters(aus1);
            //reportViewer1.
            //this.reportViewer1.RefreshReport();

             this.reportViewer1.RefreshReport();
        }
    }
}
