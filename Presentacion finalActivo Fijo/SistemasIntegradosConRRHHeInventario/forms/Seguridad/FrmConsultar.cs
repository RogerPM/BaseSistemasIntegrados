using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//otros
using datos.Seguridad;
using clases.Seguridad;

namespace forms.Seguridad
{
    public partial class FrmConsultar : Form
    {
        public clsMensajeSeguridad msj = new clsMensajeSeguridad();
        public clsEmpresa e = new clsEmpresa();
        public clsEmpresa cls = new clsEmpresa();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datEmpresa datEmp = new datEmpresa();
            gridControl1.DataSource = datEmp.Consultar();
            if (gridControl1.DataSource == null)
            {
                MessageBox.Show(msj.NoDatos, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        #region "En desuso no utilizar"
        public void getSeleccion()
        {
            e.idEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEmpresa));
            e.razonSocial = Convert.ToString(gridView1.GetFocusedRowCellValue(colrazonSocial));
            e.nombreComercial = Convert.ToString(gridView1.GetFocusedRowCellValue(colnombreComercial));
            e.ruc = Convert.ToString(gridView1.GetFocusedRowCellValue(colruc));
            e.direccion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldireccion));
            e.logotipo = (byte[])(gridView1.GetFocusedRowCellValue(collogotipo));
            e.fechaInicioSistema = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colfechaInicioSistema));
            e.correo = Convert.ToString(gridView1.GetFocusedRowCellValue(colcorreo));
            e.sitioWeb = Convert.ToString(gridView1.GetFocusedRowCellValue(colsitioWeb));
            e.sector = Convert.ToString(gridView1.GetFocusedRowCellValue(colsector));
            e.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldescripcion));
            e.idEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEstado));
        }
        #endregion


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //evento click pero del GridControl.
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsEmpresa getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsEmpresa)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
