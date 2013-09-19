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
    public partial class FrmConClientes : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public FrmConClientes()
        {
            InitializeComponent();
        }

        private void FrmConClientes_Load(object sender, EventArgs e)
        {
            try
            {
                var cliente = da.ClienteDefactura;
                this.dataGridView1.DataSource = cliente.ToList();
            }
            catch (Exception ex)
            { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string codigo { get; set; }
        public string descripcion { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells[5].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            { }
            this.Close();
        }
    }
}
