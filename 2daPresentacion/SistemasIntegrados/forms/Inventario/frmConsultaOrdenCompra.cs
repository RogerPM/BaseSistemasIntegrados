using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;

namespace forms.Inventario
{
    public partial class frmConsultaOrdenCompra : Form
    {
        public clsOrdenCompraDET clsOC = new clsOrdenCompraDET();        
        public frmConsultaOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmConsultaOrdenCompra_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datOrdenCompraDET oOrdenCompraDet = new datOrdenCompraDET();
            gdcConsultaOrdenCompra.DataSource = oOrdenCompraDet.consulta();
            if (gdcConsultaOrdenCompra.DataSource == null)
            {
                //MessageBox.Show(msj.NoDatos, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("sin datos", "Teca inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clsOC = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsOrdenCompraDET getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsOrdenCompraDET)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
