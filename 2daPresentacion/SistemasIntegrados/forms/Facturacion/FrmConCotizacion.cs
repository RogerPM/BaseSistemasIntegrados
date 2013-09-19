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

namespace forms.Facturacion
{
    public partial class FrmConCotizacion : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public FrmConCotizacion()
        {
            InitializeComponent();
        }

        private void FrmConCotizacion_Load(object sender, EventArgs e)
        {
            try
            {

                var produc =
                    from a in da.Cotizacion
                    join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                    join es in da.Estado on a.idEstado equals es.IdEstado 
                    select new
                    {
                        codigo = a.IdNumeroCotizacion, 
                        FormaPago= a.FormaPago,
                        codcliente = a.IdNumeroCliente, 
                        Cliente = b.NombreRazonSocial,
                        Fecha= a.Fecha, 
                        ValorCancelar= a.ValorCancelar,
                        PorcentajeEntrada = a.PorcentajeEntrada,
                        ValorEntrada = a.ValorEntrada,
                        EntradaMinimaRequerida= a.EntradaMinimaRequerida,
                        a.FechaInicialPago,
                        a.FechaFinalPago,
                        codEstado = es.IdEstado,
                        descripEstado = es.Descripcion,
                    };


                this.dataGridView1.DataSource = produc.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               codigo  = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               FormaPago  = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                codcliente  = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
                Cliente  = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Fecha  = dataGridView1.CurrentRow.Cells[4].Value.ToString();     
                ValorCancelar  = dataGridView1.CurrentRow.Cells[5].Value.ToString();        
                PorcentajeEntrada  = dataGridView1.CurrentRow.Cells[6].Value.ToString();    
                ValorEntrada    = dataGridView1.CurrentRow.Cells[7].Value.ToString();       
                EntradaMinimaRequerida  = dataGridView1.CurrentRow.Cells[7].Value.ToString(); 
                FechaInicialPago  = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                FechaFinalPago = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                codEstado = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                descripEstado = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            }
            catch (Exception ex)
            { }
            this.Close();
        }

        public string codigo { get; set; }

        public string FormaPago { get; set; }

        public string codcliente { get; set; }

        public string Cliente { get; set; }

        public string Fecha { get; set; }

        public string ValorCancelar { get; set; }

        public string PorcentajeEntrada { get; set; }

        public string ValorEntrada { get; set; }

        public string EntradaMinimaRequerida { get; set; }

        public string FechaInicialPago { get; set; }

        public string FechaFinalPago { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string codEstado { get; set; }

        public string descripEstado { get; set; }
    }
}
