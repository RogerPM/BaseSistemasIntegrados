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
    public partial class FrmconDevolucion : Form
    {
        
        private FacturacionEntities da = new FacturacionEntities();
        public FrmconDevolucion()
        {
            InitializeComponent();
        }

        private void FrmconDevolucion_Load(object sender, EventArgs e)
        {
            try
            {

                var produc =
                    from a in da.DevolucionVenta 
                    join b in da.Factura on a.IdNumeroFactura equals b.IdNumeroFactura
                    join c in da.ClienteDefactura on b.IdNumeroCliente equals c.IdNumeroCliente

                    join es in da.Estado on a.idEstado equals es.IdEstado 
                    //where a.IdNumeroCliente == c.IdNumeroCliente
                    select new
                    {
                        Codigo = a.IdNumeroDevolucion,
                        Fecha = a.Fecha,
                        codigoFact= b.IdNumeroFactura,
                        Cliente = c.NombreRazonSocial,
                        
                        codEstado = es.IdEstado,
                        descripEstado = es.Descripcion,
                    };

                dataGridView1.DataSource = produc.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Fecha = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                codigoFact = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Cliente = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                codEstado = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                descripEstado = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            { }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Codigo { get; set; }

        public string Fecha { get; set; }

        public string Cliente { get; set; }

        public string codEstado { get; set; }

        public string descripEstado { get; set; }

        public string codigoFact { get; set; }
    }
}
