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
    public partial class frmConsultaGrupo : Form
    {
        public frmConsultaGrupo()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaGrupo_FormClosing += new delegate_frmConsultaGrupo_FormClosing(frmConsultaGrupo_Event_frmConsultaGrupo_FormClosing);
        }

        void frmConsultaGrupo_Event_frmConsultaGrupo_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaGrupo_Event_frmConsultaGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void cargarTabla()
        {
            datGrupo cd = new datGrupo();
            var ListGrupo = cd.consulta();
           // ListGrupo.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaGrupo.DataSource = ListGrupo;
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmGrupo cInv = new frmGrupo();
            get();
            cInv.cGrupo = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

       public  clsGrupo clastm = new clsGrupo();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.tipoarticulo = Convert.ToString(gridView1.GetFocusedRowCellValue(TipoArticulo));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmGrupo cInv = new frmGrupo();
            get();
            cInv.cGrupo = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }


        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmGrupo cInv = new frmGrupo();
            get();
            cInv.cGrupo = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void frmConsultaGrupo_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsGrupo Grupo = (clsGrupo)gridView1.GetFocusedRow();
            Event_frmConsultaGrupo_FormClosing(Grupo, e);
            //  Close();
        }

        public delegate void delegate_frmConsultaGrupo_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaGrupo_FormClosing Event_frmConsultaGrupo_FormClosing;
        private void frmConsultaGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmConsultaGrupo_Load_1(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsGrupo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsGrupo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
