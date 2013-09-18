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
    public partial class frmConsultaUnidadMedida : Form
    {
        public frmConsultaUnidadMedida()
        {
            InitializeComponent();
            cargarTabla();

            Event_frmConsultaUnidadMedida_FormClosing += new delegate_frmConsultaUnidadMedida_FormClosing(frmConsultaUnidadMedida_Event_frmConsultaUnidadMedida_FormClosing);

        }
        void frmConsultaUnidadMedida_Event_frmConsultaUnidadMedida_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaUnidadMedida_Event_frmConsultaUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void cargarTabla()
        {
            datUnidadMedida cd = new datUnidadMedida();
            var ListUnidadMedida = cd.consulta();
            //ListUnidadMedida.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaUnidadMedida.DataSource = ListUnidadMedida;
        }
        public clsUnidadMedida clastm = new clsUnidadMedida();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            //clastm.usuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colusuario));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbNuevaConsultaUnidadMedida_Click(object sender, EventArgs e)
        {
            frmUnidadMedida cInv = new frmUnidadMedida();
            get();
            cInv.cUnidadMedida = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }



        private void tsbEliminarConsultaUnidadMedida_Click(object sender, EventArgs e)
        {
            frmUnidadMedida cInv = new frmUnidadMedida();
            get();
            cInv.cUnidadMedida = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsultaUnidadMedida_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsUnidadMedida UnidadMedida = (clsUnidadMedida)gridView1.GetFocusedRow();
            Event_frmConsultaUnidadMedida_FormClosing(UnidadMedida, e);
            //  Close();|
        }

        public delegate void delegate_frmConsultaUnidadMedida_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaUnidadMedida_FormClosing Event_frmConsultaUnidadMedida_FormClosing;
        private void frmConsultaUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void frmConsultaUnidadMedida_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void tsbModificarConsultaUnidadMedida_Click(object sender, EventArgs e)
        {
            frmUnidadMedida cInv = new frmUnidadMedida();
            get();
            cInv.cUnidadMedida = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsUnidadMedida getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsUnidadMedida)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
