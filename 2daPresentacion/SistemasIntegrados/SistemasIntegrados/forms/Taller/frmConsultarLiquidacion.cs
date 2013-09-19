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
    public partial class frmConsultarLiquidacion : Form
    {
        public clsLiquidacion e = new clsLiquidacion();

        public frmConsultarLiquidacion()
        {
            InitializeComponent();
        }


        public void getSeleccion()
        {
            e.IdLiquidacion = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdLiquidacion));
            e.IdOrdenTrabajo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdOrdenTrabajo));
            e.Fecha = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFecha));
            e.Cliente = Convert.ToString(gridView1.GetFocusedRowCellValue(colCliente));
            e.NroPlaca = Convert.ToString(gridView1.GetFocusedRowCellValue(colNroPlaca));
            e.Marca = Convert.ToString(gridView1.GetFocusedRowCellValue(colMarca));
            e.Modelo = Convert.ToString(gridView1.GetFocusedRowCellValue(colModelo));
            e.Color = Convert.ToString(gridView1.GetFocusedRowCellValue(colColor));
            e.FechaIngreso = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaIngreso));
            e.FechaEntrega = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaEntrega));
            e.TotalTrabajos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalTrabajos));
            e.TotalRepuestos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalRepuestos));
            e.TotalOtros = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalOtros));
            e.TotalPagar = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalPagar));
            e.IdFormaPago = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdFormaPago));
            e.NumeroCuotaMensual = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNumeroCuotaMensual));
            e.CuotaMensual = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colCuotaMensual));
            e.FechaInicialPago = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaInicialPago));
            e.FechaFinalPago = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaFinalPago));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
            e.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }


        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void FillGrid()
        {
            datLiquidacion odatLiquidacion = new datLiquidacion();
            gridControl1.DataSource = odatLiquidacion.Consultar();
        }

        private void frmConsultarLiquidacion_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
