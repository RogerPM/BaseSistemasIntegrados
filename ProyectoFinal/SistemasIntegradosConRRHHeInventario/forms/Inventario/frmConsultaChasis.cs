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
    public partial class frmConsultaChasis : Form
    {
        public clsTipoChasis clastm = new clsTipoChasis();
        public frmConsultaChasis()
        {
            InitializeComponent();
            cargarTabla();

           
            Event_frmConsultaChasis_FormClosing += new delegate_frmConsultaChasis_FormClosing(frmConsultaChasis_Event_frmConsultaChasis_FormClosing);

        }
        void frmConsultaChasis_Event_frmConsultaChasis_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaChasis_Event_frmConsultaChasis_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datTipoChasis cd = new datTipoChasis();
            var ListChasis = cd.consulta();
            ListChasis.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaChasis.DataSource = ListChasis;
        }


        
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbNuevaConsultaChasis_Click(object sender, EventArgs e)
        {
            frmChasis cInv = new frmChasis();
            get();
            cInv.cChasis = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsultaChasis_Click(object sender, EventArgs e)
        {
            frmChasis cInv = new frmChasis();
            get();
            cInv.cChasis = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsultaChasis_Click(object sender, EventArgs e)
        {
            frmChasis cInv = new frmChasis();
            get();
            cInv.cChasis = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();

        }

        private void tsbCargarConsultaChasis_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsTipoChasis Chasis = (clsTipoChasis)gridView1.GetFocusedRow();
            Event_frmConsultaChasis_FormClosing(Chasis, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaChasis_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaChasis_FormClosing Event_frmConsultaChasis_FormClosing;
        private void frmConsultaChasis_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmConsultaChasis_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsTipoChasis getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsTipoChasis)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
