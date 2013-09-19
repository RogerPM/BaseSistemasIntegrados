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
    public partial class frmConsultaTipoCombustible : Form
    {
        public frmConsultaTipoCombustible()
        {
            InitializeComponent();
            cargarTabla();
        }
        void frmConsultaTipoCombustible_Event_frmConsultaTipoCombustible_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaTipoCombustible_Event_frmConsultaTipoCombustibleo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datTipoCombustible cd = new datTipoCombustible();
            var ListTipoCombustible = cd.consulta();
            //ListTipoCombustible.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaTipoCombustible.DataSource = ListTipoCombustible;
        }


        public clsTipoCombustible clastm = new clsTipoCombustible();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }
        private void tsbNuevaConsultaTipoCombustible_Click(object sender, EventArgs e)
        {
            frmTipoCombustible cInv = new frmTipoCombustible();
            get();
            cInv.cTipoCombustible = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsultaTipoCombustible_Click(object sender, EventArgs e)
        {
            frmTipoCombustible cInv = new frmTipoCombustible();
            get();
            cInv.cTipoCombustible = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsultaTipoCombustible_Click(object sender, EventArgs e)
        {
            frmTipoCombustible cInv = new frmTipoCombustible();
            get();
            cInv.cTipoCombustible = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsultaTipoCombustible_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsTipoCombustible TipoCombustible = (clsTipoCombustible)gridView1.GetFocusedRow();
            Event_frmConsultaTipoCombustible_FormClosing(TipoCombustible, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaTipoCombustible_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaTipoCombustible_FormClosing Event_frmConsultaTipoCombustible_FormClosing;
        private void frmConsultaTipoCombustible_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmConsultaTipoCombustible_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsTipoCombustible getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsTipoCombustible)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
