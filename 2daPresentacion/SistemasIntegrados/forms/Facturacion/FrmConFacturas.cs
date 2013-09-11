using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos;
using datos.Facturacion;

namespace forms.Facturacion.Consultas
{
    public partial class FrmConFacturas : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public FrmConFacturas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Fecha = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                CodCotizacion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FormaDePago = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                codcliente = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Cliente = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                PorcentajeEntrada = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                ValorEntrada = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                EntradaMinimaRequerida = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                FechaInicialPago = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                FechaFinalPago = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                Subtotal = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                Iva = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                Ice = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                Descuento = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                ValorCancelar = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                codPromocion = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                DesPromocion = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                codEstado = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                descripEstado = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception ex)
            { }
            this.Close();
        }

        private void FrmConFacturas_Load(object sender, EventArgs e)
        {

            try
            {

                var produc =
                    from a in da.Factura
                    join b in da.Cotizacion on a.IdNumeroCotizacion equals b.IdNumeroCotizacion
                    join c in da.ClienteDefactura on b.IdNumeroCliente equals c.IdNumeroCliente 
                    join de in da.Promocion on a.IdPromocion equals de.IdPromocion
                    join es in da.Estado on a.idEstado equals es.IdEstado 
                    where a.IdNumeroCliente == c.IdNumeroCliente
                    select new
                    {
                        Codigo = a.IdNumeroFactura,
                        //NumSRI = a.
                        Fecha = a.Fecha,
                        CodCotizacion = a.IdNumeroCotizacion,
                        FormaDePago = a.IdFormaPago,
                        codcliente = a.IdNumeroCliente,
                        Cliente = c.NombreRazonSocial,
                        PorcentajeEntrada = b.PorcentajeEntrada,
                        ValorEntrada = a.ValorEntrada,
                        EntradaMinimaRequerida = b.EntradaMinimaRequerida,
                        b.FechaInicialPago,
                        b.FechaFinalPago,
                        Subtotal = a.Subtotal,
                        Iva = a.Iva,
                        Ice = a.Ice,
                        Descuento = a.Descuento,
                        ValorCancelar = a.TotalPagar,
                        codPromocion = de.IdPromocion,
                        DesPromocion = de.descripcion,
                        codEstado = es.IdEstado ,
                        descripEstado = es.Descripcion,
                    };

                dataGridView1.DataSource = produc.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        
                public  string Codigo { get; set; }
                public  string Fecha { get; set; }
                public  string CodCotizacion { get; set; }
                public  string codcliente { get; set; }
                public  string Cliente { get; set; }
                public  string PorcentajeEntrada { get; set; }
                public  string ValorEntrada { get; set; }
                public  string EntradaMinimaRequerida { get; set; }
                public  string FechaInicialPago { get; set; }
                public  string FechaFinalPago { get; set; }
                public  string Subtotal { get; set; }
                public  string Iva { get; set; }
                public  string Ice { get; set; }
                public  string Descuento { get; set; }
                public  string ValorCancelar { get; set; }
                public  string FormaDePago { get; set; }

                private void button1_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

                public string codPromocion { get; set; }

                public string DesPromocion { get; set; }

                public string codEstado { get; set; }

                public string descripEstado { get; set; }
    }
}

