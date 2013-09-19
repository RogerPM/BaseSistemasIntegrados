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
    public partial class frmConsultaMarca : Form
    {
        public frmConsultaMarca()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaMarca_FormClosing += new delegate_frmConsultaMarca_FormClosing(frmConsultaMarca_Event_frmConsultaMarca_FormClosing);
        }

        void frmConsultaMarca_Event_frmConsultaMarca_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaMarca_Event_frmConsultaMarca_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void cargarTabla()
        {
            datMarca cd = new datMarca();
            var ListMarca = cd.consulta();
            //ListMarca.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaMarca.DataSource = ListMarca;
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmMarca cInv = new frmMarca();
            get();
            cInv.cMarca = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        public clsMarca clastm = new clsMarca();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmMarca cInv = new frmMarca();
            get();
            cInv.cMarca = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }


        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmMarca cInv = new frmMarca();
            get();
            cInv.cMarca = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void frmConsultaMarca_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsMarca Marca = (clsMarca)gridView1.GetFocusedRow();
            Event_frmConsultaMarca_FormClosing(Marca, e);
            //  Close();
        }

        public delegate void delegate_frmConsultaMarca_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaMarca_FormClosing Event_frmConsultaMarca_FormClosing;
        private void frmConsultaMarca_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmConsultaMarca_Load_1(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }
        private clsMarca getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsMarca)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
