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
    public partial class frmConsultaIngresoEgresoCAB : Form
    {

        public clsIngresoEgresoCAB cls = new clsIngresoEgresoCAB();
        public frmConsultaIngresoEgresoCAB()
        {
            InitializeComponent();
        }

        private void frmConsultaIngresoEgresoCAB_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datIngresoEgresoBodegaCAB  odatIngEg = new datIngresoEgresoBodegaCAB ();
            gdcConsultaIngresoEgreso.DataSource = odatIngEg.consulta();
            if (gdcConsultaIngresoEgreso.DataSource == null)
            {
                //MessageBox.Show(msj.NoDatos, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("sin datos", "Teca inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsIngresoEgresoCAB  getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsIngresoEgresoCAB )view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }




    }
}
