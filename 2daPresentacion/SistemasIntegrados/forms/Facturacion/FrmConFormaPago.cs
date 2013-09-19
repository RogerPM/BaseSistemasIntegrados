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
    public partial class FrmConFormaPago : Form
    {
        private FacturacionEntities da = new FacturacionEntities ();
        public FrmConFormaPago()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConFormaPago_Load(object sender, EventArgs e)
        {
            //var cliente = da.FormaPago;
            //this.dataGridView1.DataSource = cliente.ToList();

            
        }

        public string codigo { get; set; }

        public string descripcion { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            { }
            this.Close();

        }
    }
}
