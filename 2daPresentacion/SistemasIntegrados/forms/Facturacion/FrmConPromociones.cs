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
    public partial class FrmConPromociones : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public FrmConPromociones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                  
                this.Close();
        }

        private void FrmConPromociones_Load(object sender, EventArgs e)
        {
           try
            {
                var promocion = da.Promocion;
                this.dataGridView1.DataSource = promocion.ToList();

            }
            catch (Exception ex)
            {

            }
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
