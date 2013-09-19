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
    public partial class frmConsultaBodega : Form
    {
        public clsBodega cls= new clsBodega();
        

        public frmConsultaBodega() {
            InitializeComponent();
        }

        private void frmConsultaBodega_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datBodega odatBodega = new datBodega();
            gdcConsultaBodega.DataSource = odatBodega.consulta();
            if (gdcConsultaBodega.DataSource == null)
            {
                //MessageBox.Show(msj.NoDatos, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("sin datos", "Teca inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsBodega getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsBodega)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }

        private void gdcConsultaBodega_Click(object sender, EventArgs e)
        {

        }


    }
}
