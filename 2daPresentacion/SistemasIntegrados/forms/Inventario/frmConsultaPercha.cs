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
    public partial class frmConsultaPercha : Form
    {
        public frmConsultaPercha()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaPercha_FormClosing += new delegate_frmConsultaPercha_FormClosing(frmConsultaPercha_Event_frmConsultaPercha_FormClosing);
        }

        void frmConsultaPercha_Event_frmConsultaPercha_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaPercha_Event_frmConsultaPercha_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void cargarTabla()
        {
            datPercha cd = new datPercha();
            var ListPercha = cd.consulta();
            //ListPercha.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaPercha.DataSource = ListPercha;
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmPercha cInv = new frmPercha();
            get();
            cInv.cPercha = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        public clsPercha clastm = new clsPercha();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.divisiones = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Divisiones));
            clastm.bodega = Convert.ToString(gridView1.GetFocusedRowCellValue(Bodega));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmPercha cInv = new frmPercha();
            get();
            cInv.cPercha = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }


        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmPercha cInv = new frmPercha();
            get();
            cInv.cPercha = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void frmConsultaPercha_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsPercha Percha = (clsPercha)gridView1.GetFocusedRow();
            Event_frmConsultaPercha_FormClosing(Percha, e);
            //  Close();
        }

        public delegate void delegate_frmConsultaPercha_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaPercha_FormClosing Event_frmConsultaPercha_FormClosing;
        private void frmConsultaPercha_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmConsultaPercha_Load_1(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsPercha getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsPercha)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
