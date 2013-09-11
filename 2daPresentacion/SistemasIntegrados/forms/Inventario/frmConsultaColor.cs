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
    public partial class frmConsultaColor : Form
    {
        public clsColor cls = new clsColor();
        public frmConsultaColor()
        {
            InitializeComponent();
            cargarTabla();

            Event_frmConsultaColor_FormClosing += new delegate_frmConsultaColor_FormClosing(frmConsultaColor_Event_frmConsultaColor_FormClosing);
        }

        void frmConsultaColor_Event_frmConsultaColor_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaColor_Event_frmConsultaColor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datColor cd = new datColor();
            var ListColor = cd.consulta();
            //ListColor.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaColor.DataSource = ListColor;
        }


        public clsColor clastm = new clsColor();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }



        private void frmConsultaColor_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmColor cInv = new frmColor();
            get();
            cInv.cColor = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmColor cInv = new frmColor();
            get();
            cInv.cColor = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmColor cInv = new frmColor();
            get();
            cInv.cColor = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsColor Color = (clsColor)gridView1.GetFocusedRow();
            Event_frmConsultaColor_FormClosing(Color, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaColor_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaColor_FormClosing Event_frmConsultaColor_FormClosing;
        private void frmConsultaColor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    MessageBox.Show("llego");
        //    cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
        //    Close(); 
        //}

        private clsColor getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsColor)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }

        //private void gridView1_Click(object sender, EventArgs e)
        //{
        //    clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
        //    Close();
        //}

        //private clsColor getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        //{
        //    try
        //    {
        //        return (clsColor)view.GetRow(view.FocusedRowHandle);
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }
}
