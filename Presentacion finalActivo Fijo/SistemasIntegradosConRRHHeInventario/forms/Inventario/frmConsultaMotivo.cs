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
    public partial class frmConsultaMotivo : Form
    {
        public frmConsultaMotivo()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaMotivo_FormClosing += new delegate_frmConsultaMotivo_FormClosing(frmConsultaMotivo_Event_frmConsultaMotivo_FormClosing);
        }

        void frmConsultaMotivo_Event_frmConsultaMotivo_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaMotivo_Event_frmConsultaMotivo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void cargarTabla()
        {
            datMotivo cd = new datMotivo();
            var ListMotivo = cd.consulta();
            //ListMotivo.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaMotivo.DataSource = ListMotivo;
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmMotivo cInv = new frmMotivo();
            get();
            cInv.cMotivo = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        public clsMotivo clastm = new clsMotivo();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmMotivo cInv = new frmMotivo();
            get();
            cInv.cMotivo = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }


        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmMotivo cInv = new frmMotivo();
            get();
            cInv.cMotivo = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void frmConsultaMotivo_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsMotivo Motivo = (clsMotivo)gridView1.GetFocusedRow();
            Event_frmConsultaMotivo_FormClosing(Motivo, e);
            //  Close();
        }

        public delegate void delegate_frmConsultaMotivo_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaMotivo_FormClosing Event_frmConsultaMotivo_FormClosing;
        private void frmConsultaMotivo_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsMotivo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsMotivo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
