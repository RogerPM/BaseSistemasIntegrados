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
    public partial class FormviewDevolucion : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private int codigodevolucion=0;
        public FormviewDevolucion()
        {
            InitializeComponent();
        }

        public FormviewDevolucion(int cod)
        {
            InitializeComponent();
            codigodevolucion = cod;
        }

        private void FormviewDevolucion_Load(object sender, EventArgs e)
        {
            var produc =               
                   from a in da.Factura
                   join dev in da.DevolucionVenta on a.IdNumeroFactura equals dev.IdNumeroFactura
                   join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                   join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                   join d in da.Estado on a.idEstado equals d.IdEstado
                   join es in da.Usuario on a.idUsuario equals es.IdUsuario
                   join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                   where dev.IdNumeroDevolucion == codigodevolucion
                   select new
                   {
                       codFactura = dev.IdNumeroFactura,
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
                       codDevolucion = dev.IdNumeroDevolucion
                   };


            var detfactura =
                    from a in da.FacturaDet
                    join dev in da.DevolucionVenta on a.IdNumeroFactura equals dev.IdNumeroFactura  
                    join devdet in da.DevolucionDet on dev.IdNumeroDevolucion equals devdet.IdNumeroDevolucion
                    join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                    join c in da.Marca on b.IdMarca equals c.IdMarca
                    join d in da.Estado on a.idEstado equals d.IdEstado
                    join es in da.Modelo on b.IdModelo equals es.IdModelo
                    where dev.IdNumeroDevolucion == codigodevolucion && devdet.IdArticulo == a.IdArticulo
                    && devdet.IdArticulo == b.IdArticulo
                    select new
                    {
                        a.Linea,
                        a.IdNumeroFactura,
                        a.precio,
                        a.cantidad,
                        b.Descripcion,
                        marca = c.Descripcion,
                        modelo = es.Descripcion,
                        chasis = b.Chasis.Descripcion,
                        color = b.Color.Descripcion

                    };

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CabeceraDevolucion", produc.ToList()));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DetalleDevolucion", detfactura.ToList()));
            this.reportViewer1.RefreshReport();
        }
    }
}
