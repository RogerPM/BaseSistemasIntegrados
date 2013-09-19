using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Taller;
using datos.Taller;

namespace forms.Taller
{
    public partial class frmConsultarRepuesto : Form
    {
        public clsArticuloTaller e = new clsArticuloTaller();
        public frmConsultarRepuesto()
        {
            InitializeComponent();
        }

        public void getSeleccion()
        {
            e.IdArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            e.PrecioUnitario = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colPrecioUnitario));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void FillGrid()
        {
            datArticuloTaller odatArticulo = new datArticuloTaller();
            gridControl1.DataSource = odatArticulo.ConsultarRepuesto();
        }

        private void frmConsultarRepuesto_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
