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
    public partial class frmConsultaModelo : Form
    {
        public frmConsultaModelo()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaModelo_FormClosing += new delegate_frmConsultaModelo_FormClosing(frmConsultaModelo_Event_frmConsultaModelo_FormClosing);
        }
        void frmConsultaModelo_Event_frmConsultaModelo_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaModelo_Event_frmConsultaModelo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datModelo cd = new datModelo();
            var ListModelo = cd.consulta();
            //ListModelo.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaModelo.DataSource = ListModelo;
        }

        public clsModelo clastm = new clsModelo();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
            clastm.marca = Convert.ToString(gridView1.GetFocusedRowCellValue(Marca));
        }



        private void frmConsultaModelo_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmModelo cInv = new frmModelo();
            get();
            cInv.cModelo = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmModelo cInv = new frmModelo();
            get();
            cInv.cModelo = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmModelo cInv = new frmModelo();
            get();
            cInv.cModelo = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsModelo Modelo = (clsModelo)gridView1.GetFocusedRow();
            Event_frmConsultaModelo_FormClosing(Modelo, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaModelo_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaModelo_FormClosing Event_frmConsultaModelo_FormClosing;
        private void frmConsultaModelo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmConsultaModelo_Load_1(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsModelo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsModelo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
