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
    public partial class frmConsultaTipoMaterial : Form
    {
        public frmConsultaTipoMaterial()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaTipoMaterial_FormClosing += new delegate_frmConsultaTipoMaterial_FormClosing(frmConsultaTipoMaterial_Event_frmConsultaTipoMaterial_FormClosing);
        }
        void frmConsultaTipoMaterial_Event_frmConsultaTipoMaterial_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaTipoMaterial_Event_frmConsultaTipoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void frmConsultaTipoMaterial_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        public void cargarTabla()
        {
            datTipoMaterial cd = new datTipoMaterial();
            gdcConsultaTipoMaterial.DataSource = cd.consulta();
        }



        public clsTipoMaterial clastm = new clsTipoMaterial();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }





        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMaterial cInv = new frmTipoMaterial();
            get();
            cInv.cTipoMaterial = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMaterial cInv = new frmTipoMaterial();
            get();
            cInv.cTipoMaterial = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMaterial cInv = new frmTipoMaterial();
            get();
            cInv.cTipoMaterial = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsTipoMaterial TipoMaterial = (clsTipoMaterial)gridView1.GetFocusedRow();
            Event_frmConsultaTipoMaterial_FormClosing(TipoMaterial, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaTipoMaterial_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaTipoMaterial_FormClosing Event_frmConsultaTipoMaterial_FormClosing;
        private void frmConsultaTipoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsTipoMaterial getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsTipoMaterial)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
