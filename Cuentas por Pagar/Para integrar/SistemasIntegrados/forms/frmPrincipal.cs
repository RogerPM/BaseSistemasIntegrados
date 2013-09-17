using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Seguridad;

namespace forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCrearUsuario f = new frmCrearUsuario();
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCrearPerfil f = new frmCrearPerfil();
            f.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCambiarContrasena f = new frmCambiarContrasena();
            f.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAsignarPerfil f = new frmAsignarPerfil();
            f.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptAccesoxUsuario f = new frmRptAccesoxUsuario();
            f.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptHorarioAccesoxUsuario f = new frmRptHorarioAccesoxUsuario();
            f.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptEstadoxUsuario f = new frmRptEstadoxUsuario();
            f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptPrivilegiosxUsuario f = new frmRptPrivilegiosxUsuario();
            f.ShowDialog();
        }
    }
}
