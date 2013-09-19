using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Inventario;

namespace forms.Inventario
{
    public partial class frmConsultaLLegada : Form
    {
        public frmConsultaLLegada()
        {
            InitializeComponent();
        }

        private void frmConsultaLLegada_Load(object sender, EventArgs e)
        {
            clsInventario dat = new clsInventario();
            gdcConsultaIngresoEgreso.DataSource = dat.consultaOrdenCompra();
        }
        public int idNroMovimiento { get; set; }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idNroMovimiento = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdOrdenCompra));
            this.Close();
        }
    }
}
