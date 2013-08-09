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
    public partial class frmConsultarArticulo : Form
    {
        public clsArticulo e = new clsArticulo();
        public frmConsultarArticulo()
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
            e.IdArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            e.FechaProduccion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaProduccion));
            e.CantidadMinima = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantidadMinima));
            e.CantidadMaxima = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantidadMaxima));
            e.CantidadActual = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantidadActual));
            e.IdUnidadMedida = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUnidadMedida));
            //e.IdTipoArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.IdGrupo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdGrupo));
            e.IdChasis = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdChasis));
            e.IdTipoMotor= Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoMotor));
            e.NroPlaca = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNroPlaca));
            e.IdTipoCombustible = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoCombustible));
            e.IdColor = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdColor));
            e.IdMarca = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdMarca));
            e.IdModelo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdModelo));
            e.IdTipoMaterial = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoMaterial));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
            e.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            e.IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
            e.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }

        public void FillGrid()
        {
            datArticulo odatArticulo= new datArticulo();
            gridControl1.DataSource = odatArticulo.Consultar();
        }

        private void frmConsultarArticulo_Load_1(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
