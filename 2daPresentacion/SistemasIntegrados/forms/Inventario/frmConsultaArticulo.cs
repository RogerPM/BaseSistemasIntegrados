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
    public partial class frmConsultaArticulo : Form
    {
        public frmConsultaArticulo()
        {
            InitializeComponent();
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar() {
            datArticulo da = new datArticulo();
            gridControl1.DataSource = da.consultaArt();
        }

        clsArticulo clArt = new clsArticulo();
        public void get()
        {
            clArt.EmpresaArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEmpresaArt));
            clArt.IdArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArt));
            clArt.DescArt = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescArt));
            clArt.FProduccion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFProduccion));
            clArt.CantMinima = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantMinima));
            clArt.CantMaxima = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantMaxima));
            clArt.CantActual = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCantActual));
            clArt.UMed = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colUMed));
            clArt.FCaducidad = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFCaducidad));
            clArt.TipoArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoArt));
            clArt.GrupoArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colGrupoArt));
            clArt.TipoChasis = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoChasis));
            clArt.SChasis = Convert.ToString(gridView1.GetFocusedRowCellValue(colSChasis));
            clArt.TipoMotor = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoMotor));
            clArt.SMotor = Convert.ToString(gridView1.GetFocusedRowCellValue(colSMotor));
            clArt.NPlaca = Convert.ToString(gridView1.GetFocusedRowCellValue(colNPlaca));
            clArt.TipoComb = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoComb));
            clArt.ColorArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colColorArt));
            clArt.MarcaArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colMarcaArt));
            clArt.ModeloArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colModeloArt));
            clArt.TipoMat = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoMat));
            clArt.ObservArt = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservArt));
            clArt.EstArt = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEstArt));
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmArticulo artInv = new frmArticulo();
            get();
            artInv.classArt = clArt;
            artInv.accion = "M";
            artInv.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmArticulo articInv = new frmArticulo();
            get();
            articInv.classArt = clArt;
            articInv.accion = "E";
            articInv.ShowDialog();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }





    }
}
