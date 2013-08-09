using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms
{
    public partial class frmGUImetro : Form
    {
        public frmGUImetro()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Desea salir del programa? ", "TECA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        //modulo seguridad
        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "Seguridad";
            f.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "Compras";
            f.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MessageBox.Show("Módulo inventario en mantenimiento", "TECA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmSesion f = new frmSesion();
            //f.ShowDialog();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MessageBox.Show("Módulo facturación en mantenimiento", "TECA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmSesion f = new frmSesion();
            //f.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "CuentasPorPagar";
            f.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "CuentasPorCobrar";
            f.ShowDialog();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "ActivoFijo";
            f.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "Contabilidad";
            f.ShowDialog();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "RecursosHumanos";
            f.ShowDialog();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSesion f = new frmSesion();
            f.NombreModulo = "Taller";
            f.ShowDialog();

        }
    }
}

