using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using datos.Seguridad;

namespace forms.Seguridad
{
    public partial class frmConsultarImagen : Form
    {
        public clsImagen oImg = new clsImagen();
        private clsMensajeSeguridad msj = new clsMensajeSeguridad();
        public frmConsultarImagen()
        {
            InitializeComponent();
        }

        private void frmConsultarImagen_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datImagen datImg = new datImagen();

            gridControl1.DataSource = datImg.Consultar();
            if (gridControl1.DataSource == null)
            {
                MessageBox.Show(msj.NoDatos, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            oImg = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsImagen getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsImagen)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
