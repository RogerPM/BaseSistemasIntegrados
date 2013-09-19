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
    public partial class FormviewGuiaRemision : Form
    {
        private FacturacionEntities da = new FacturacionEntities();

        private int codigoguia = 0;
        
        public FormviewGuiaRemision()
        {
            InitializeComponent();
        }

        public FormviewGuiaRemision(int cod)
        {
            InitializeComponent();
            codigoguia = cod;
        }

        private void FormviewGuiaRemision_Load(object sender, EventArgs e)
        {
            var produc =
                   from a in da.GuiaRemision
                   join b in da.Persona on a.IdPesonaNatural equals b.IdPersona 
                   join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                   join d in da.Estado on a.idEstado equals d.IdEstado
                   join es in da.Usuario on a.idUsuario equals es.IdUsuario
                   //join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                   where a.IdNumeroGuiaRemision == codigoguia
                   select new
                   {
                       IdNumeroGuiaRemision = a.IdNumeroGuiaRemision,
                       empresa = c.Descripcion,
                       FechaTraslado = a.FechaTraslado,
                       FechaEmision = a.FechaEmision,
                       estado = d.Descripcion,
                       usuario = es.NombreUsuario,
                       SitioSalida = a.SitioSalida,
                       IdPersonaNatural = b.IdPersona,
                       SitioLlegada = a.Sitiollegada,
                       RazonSocial = c.RazonSocial,
                       Ruc = c.Ruc,
                       Direccion = c.Direccion,
                       Identificacion =  b.Identificacion,
                       NombreConductor = b.NombreRazonSocial 

                       //cliente = b.NombreRazonSocial,
                       //total = a.TotalPagar,
                       //iva = a.Iva,
                       //ice = a.Ice,
                       //subtotal = a.Subtotal,
                       //Fecha = a.Fecha,
                       //cuotas = a.NumeroCuotaMensual,


                   };            
                       
                      

              //<DesignColumnRef Name="empresa" />
              //<DesignColumnRef Name="IdNumeroGuiaRemision" />
              //<DesignColumnRef Name="FechaTraslado" />
              //<DesignColumnRef Name="FechaEmision" />
              //<DesignColumnRef Name="estado" />
              //<DesignColumnRef Name="usuario" />
              //<DesignColumnRef Name="SitioSalida" />
              //<DesignColumnRef Name="IdPersonaNatural" />
              //<DesignColumnRef Name="SitioLlegada" />
              //<DesignColumnRef Name="RazonSocial" />
              //<DesignColumnRef Name="Ruc" />
              //<DesignColumnRef Name="Direccion" />
              //<DesignColumnRef Name="Identificacion" />
              //<DesignColumnRef Name="NombreConductor" />

            var detfactura =
                    from a in da.GuiaRemisionDet
                    join b in da.FacturaDet on a.IdNumeroFactura equals b.IdNumeroFactura
                    join fac in da.Factura on a.IdNumeroFactura equals fac.IdNumeroFactura
                    join cli in da.ClienteDefactura on fac.IdNumeroCliente equals cli.IdNumeroCliente
                    join c in da.Articulo on b.IdArticulo equals c.IdArticulo
                    join d in da.Marca on c.IdMarca equals d.IdMarca
                    join ee in da.Estado on a.idEstado equals ee.IdEstado
                    join es in da.Modelo on c.IdModelo equals es.IdModelo
                    where a.IdNumeroGuiaRemision == codigoguia
                    select new
                    {
                        Linea = a.Linea,
                        IdNumeroGuiaRemision = a.IdNumeroGuiaRemision,
                        FechaEntrega = a.FechaEntrega,
                        IdNumeroFactura = fac.IdNumeroFactura,
                        Descripcion = c.Descripcion,
                        marca = d.Descripcion,
                        modelo = es.Descripcion,
                        chasis = c.Chasis.Descripcion,
                        color = c.Color.Descripcion,
                        Cliente = cli.NombreRazonSocial

                    };



            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CabGuiaremision", produc.ToList()));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DetGuiaremision", detfactura.ToList()));

            this.reportViewer1.RefreshReport();
        }
    }
}
