using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.CuentasxCobrar
{
    public partial class frm_CajaApertura : Form
    {
        public frm_CajaApertura()
        {
            InitializeComponent();
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDetalleMonetario ca = new frm_MantenimientoDetalleMonetario();
            ca.ShowDialog();
        }
    }
}
