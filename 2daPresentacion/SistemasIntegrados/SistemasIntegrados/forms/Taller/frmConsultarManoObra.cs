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
    public partial class frmConsultarManoObra : Form
    {
        public clsManoObra e = new clsManoObra();
        public clsPresupuestoMO pmo = new clsPresupuestoMO();
        public frmConsultarManoObra()
        {
            InitializeComponent();
        }

        public void getSeleccion()
        {
            e.IdManoObra = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdManoObra));
            e.IdTipoTrabajo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoTrabajo));
            e.PrecioHora = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colPrecioHora));
            e.NroHoras = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNroHoras));
            e.Total = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotal));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
            e.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            e.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));  
        }

        public void getSeleccionPresupuesto()
        {
            pmo.IdManoObra = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdManoObra));
            pmo.IdTrabajo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoTrabajo));
            pmo.PrecioHora = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colPrecioHora));
            pmo.NroHoras = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNroHoras));
            pmo.Total = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotal));
        }


        private void frmConsultarManoObra_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datManoObra odatManoObra = new datManoObra();
            grdManoObra.DataSource = odatManoObra.Consultar();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            getSeleccionPresupuesto();
            this.Close();
        }
    }
}
