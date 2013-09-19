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
    public partial class frmConsultaTipoMotor : Form
    {
        public frmConsultaTipoMotor()
        {
            InitializeComponent();
            cargarTabla();
            Event_frmConsultaTipoMotor_FormClosing += new delegate_frmConsultaTipoMotor_FormClosing(frmConsultaTipoMotor_Event_frmConsultaTipoMotor_FormClosing);
        }

        void frmConsultaTipoMotor_Event_frmConsultaTipoMotor_FormClosing(object sender, EventArgs e)
        {
        }

        void frmConsultaTipoMotor_Event_frmConsultaTipoMotor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void cargarTabla()
        {
            datTipoMotor cd = new datTipoMotor();
            var ListTipoMotor = cd.consulta();
            //ListTipoMotor.ForEach(v => { v.estado = (v.estado == "1") ? "Activo" : "Inactivo"; });
            gdcConsultaTipoMotor.DataSource = ListTipoMotor;
        }

        private void tsbNuevaConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMotor cInv = new frmTipoMotor();
            get();
            cInv.cTipoMotor = clastm;
            cInv.accion = "G";

            cInv.ShowDialog();
        }

        public clsTipoMotor clastm = new clsTipoMotor();
        public void get()
        {
            clastm.empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Empresa));
            clastm.codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Codigo));
            clastm.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(Descripcion));
            clastm.estado = Convert.ToString(gridView1.GetFocusedRowCellValue(Estado));
        }

        private void tsbModificarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMotor cInv = new frmTipoMotor();
            get();
            cInv.cTipoMotor = clastm;
            cInv.accion = "M";

            cInv.ShowDialog();
        }


        private void tsbEliminarConsulta_Click(object sender, EventArgs e)
        {
            frmTipoMotor cInv = new frmTipoMotor();
            get();
            cInv.cTipoMotor = clastm;
            cInv.accion = "E";

            cInv.ShowDialog();
        }

        private void tsbCargarConsulta_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            clsTipoMotor Motor = (clsTipoMotor)gridView1.GetFocusedRow();
            Event_frmConsultaTipoMotor_FormClosing(Motor, e);
            //  Close();
        }

        public delegate void delegate_frmConsultaTipoMotor_FormClosing(object sender, EventArgs e);
        public event delegate_frmConsultaTipoMotor_FormClosing Event_frmConsultaTipoMotor_FormClosing;
        private void frmConsultaTipoMotor_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmConsultaTipoMotor_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clastm = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsTipoMotor getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsTipoMotor)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
