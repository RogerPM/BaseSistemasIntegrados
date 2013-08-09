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
    public partial class frmPrincipalSeguridad : Form
    {
        public frmPrincipalSeguridad()
        {
            InitializeComponent();
        }

        private bool noChild()
        {
            Form[] fcChild = MdiChildren;
            if (fcChild.Count()==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bloqMenu()
        {
            if (ribbonControl1.Enabled==true)
            {
                ribbonControl1.Enabled = false;
                ribbonControl1.Minimized = true;
            }
            else
            {
                ribbonControl1.Enabled = true;
                ribbonControl1.Minimized = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild()==true)
            {
                frmCrearUsuario f = new frmCrearUsuario();
                f.MdiParent = this;
                f.Show();
               // f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmCrearPerfil f = new frmCrearPerfil();
                f.MdiParent = this;
                f.Show();
                //f.WindowState = FormWindowState .Maximized;
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmCambiarContrasena f = new frmCambiarContrasena();
                f.MdiParent = this;
                f.Show();
              //  f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmAsignarPerfil f = new frmAsignarPerfil();
                f.MdiParent = this;
                f.Show();
               // f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmRptAccesoxUsuario f = new frmRptAccesoxUsuario();
                f.MdiParent = this;
                f.Show();
              //  f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmRptHorarioAccesoxUsuario f = new frmRptHorarioAccesoxUsuario();
                f.MdiParent = this;
                f.Show();
              //  f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmRptEstadoxUsuario f = new frmRptEstadoxUsuario();
                f.MdiParent = this;
                f.Show();
             //   f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmRptPrivilegiosxUsuario f = new frmRptPrivilegiosxUsuario();
                f.MdiParent = this;
                f.Show();
              //  f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmMonitoreoUsuarios f = new frmMonitoreoUsuarios();
                f.MdiParent = this;
                f.Show();
              //  f.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmPrincipalSeguridad_MdiChildActivate(object sender, EventArgs e)
        {
            //evento sucede cuando un child es llamado y/o cerrado
            bloqMenu();
        }

        private void ribbonControl1_MinimizedChanged(object sender, EventArgs e)
        {
            //evento sucede cuando se colapsa-minimiza el ribbon
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmpresa f = new frmEmpresa();
            f.MdiParent = this;
            f.Show();
            //  f.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFotoSeguridad f = new frmFotoSeguridad();
            f.MdiParent = this;
            f.Show();
            //  f.WindowState = FormWindowState.Maximized;
        }
    }
}
