using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Taller;
using clases.Taller;

namespace forms.Taller
{
    public partial class frmConsultarOrdenTrabajo : Form
    {
        public clsOrdenTrabajo e = new clsOrdenTrabajo();
        public frmConsultarOrdenTrabajo()
        {
            InitializeComponent();
        }

        public void getSeleccion()
        {
            e.IdOrdenTrabajo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdOrdenTrabajo));
            e.IdPresupuesto = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdPresupuesto));
            e.IdPersona = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdPersona));
            e.IdArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.NroPlaca = Convert.ToString(gridView1.GetFocusedRowCellValue(colNroPlaca));
            e.Marca = Convert.ToString(gridView1.GetFocusedRowCellValue(colMarca));
            e.Modelo = Convert.ToString(gridView1.GetFocusedRowCellValue(colModelo));
            e.Color = Convert.ToString(gridView1.GetFocusedRowCellValue(colColor));
            e.Combustible = Convert.ToString(gridView1.GetFocusedRowCellValue(colCombustible));
            e.Chasis = Convert.ToString(gridView1.GetFocusedRowCellValue(colChasis));
            e.Kilometraje = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKilometraje));
            e.Combustible = Convert.ToString(gridView1.GetFocusedRowCellValue(colCombustible));
            e.Deposito = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colDeposito));
            e.FechaRecepcion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaRecepcion));
            e.InicioReparacion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colInicioReparacion));
            e.FechaIngreso = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaIngreso));
            e.FechaEntrega = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaEntrega));
            e.IvaTrabajos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colIvaTrabajos));
            e.TotalTrabajos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalTrabajos));
            e.IvaRepuestos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colIvaRepuestos));
            e.TotalRepuestos = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalRepuestos));
            e.IvaOtros = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colIvaOtros));
            e.TotalOtros = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalOtros));
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
            datOrdenTrabajo odatOrdenTrabajo = new datOrdenTrabajo();
            gridControl1.DataSource = odatOrdenTrabajo.Consultar();
        }

        private void frmConsultarOrdenTrabajo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
