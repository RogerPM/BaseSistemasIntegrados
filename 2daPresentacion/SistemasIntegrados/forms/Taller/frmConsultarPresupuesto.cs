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
    public partial class frmConsultarPresupuesto : Form
    {
        public clsPresupuesto e = new clsPresupuesto();
        public frmConsultarPresupuesto()
        {
            InitializeComponent();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void getSeleccion()
        {
            e.IdPresupuesto = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdPresupuesto));
            e.IdPersona = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdPersona));
            e.IdArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.NroPlaca = Convert.ToString(gridView1.GetFocusedRowCellValue(colNroPlaca));
            e.Marca = Convert.ToString(gridView1.GetFocusedRowCellValue(colMarca));
            e.Modelo = Convert.ToString(gridView1.GetFocusedRowCellValue(colModelo));
            e.Color = Convert.ToString(gridView1.GetFocusedRowCellValue(colColor));
            e.Combustible = Convert.ToString(gridView1.GetFocusedRowCellValue(colCombustible));
            e.Chasis = Convert.ToString(gridView1.GetFocusedRowCellValue(colChasis));
            e.Fecha = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFecha));
            e.TotalTiempoTrabajo= Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTotalTiempoTrabajo));
            e.Subtotal = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colSubtotal));
            e.Iva = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colIva));
            e.TotalPresupuesto = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalPresupuesto));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
            e.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }

        private void frmConsultarPresupuesto_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datPresupuesto odatPresupuesto = new datPresupuesto();
            gridControl1.DataSource = odatPresupuesto.Consultar();
        }
    }
}
