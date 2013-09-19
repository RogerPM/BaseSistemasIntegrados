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
    public partial class FrmConFacturasDet : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private int codigofactura = 0;

        public FrmConFacturasDet()
        {
            InitializeComponent();
        }

        public FrmConFacturasDet(int cod)
        {
            InitializeComponent();
            codigofactura = cod;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Codigo = dataGridView1.CurrentRow.Cells["IdArticulo"].Value.ToString();
                desarticulo = dataGridView1.CurrentRow.Cells["marca"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["modelo"].Value.ToString();
                cantidad = Double.Parse(dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString());
              
            }
            catch (Exception ex)
            { }
            this.Close();
        }

        private void FrmConFacturas_Load(object sender, EventArgs e)
        {

            try
            {

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
                        b.IdArticulo,
                        a.precio,
                        a.cantidad,
                        b.Descripcion,
                        marca = c.Descripcion,
                        modelo = es.Descripcion,
                        chasis = b.Chasis.Descripcion,
                        color = b.Color.Descripcion

                    };

                dataGridView1.DataSource = detfactura.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        
                public  string Codigo { get; set; }
                public  string desarticulo { get; set; }
                public double cantidad { get; set; }

                private void button1_Click(object sender, EventArgs e)
                {
                    this.Close();
                }             
    }
}

