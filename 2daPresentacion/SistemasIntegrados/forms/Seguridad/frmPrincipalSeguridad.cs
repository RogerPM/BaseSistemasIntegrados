using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Seguridad;
using clases.Seguridad;

namespace forms
{
    public partial class frmPrincipalSeguridad : Form
    {
        //public static clsVwUsuarioPermisos permisos = frmSesion.per;
        public static List<clsVwUsuarioPermisos> permisos = new List<clsVwUsuarioPermisos>();//

        
        
        #region "Distribuido por Seguridad 2/3"
        //codigo de Seguridad
        public static clsVwUsuarioPermisos permisoFrm = new clsVwUsuarioPermisos();
        private bool permitir(string formName) {//call in every button click event
            try
            {
                var x = (from w in permisos where w.nombreFormulario == formName select w).First();
                if (x != null)
                {
                    permisoFrm.idUsuario = x.idUsuario;
                    permisoFrm.nombreUsuario = x.nombreUsuario;
                    permisoFrm.descripcion = x.descripcion;
                    permisoFrm.idModulo = x.idModulo;
                    permisoFrm.nombre = x.nombre;
                    permisoFrm.nombreFormulario = x.nombreFormulario;
                    permisoFrm.lectura = x.lectura;
                    permisoFrm.escritura = x.escritura;
                    permisoFrm.eliminacion = x.eliminacion;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        private void barraInferior() {
            barStaticItem1.Caption = clsVwUsuarioInformacion.nombreUsuario;
            permisos = frmSesion.per;
        }

        private void sinPermiso() {
            clsMensajeSeguridad m = new clsMensajeSeguridad();
            MessageBox.Show(permisoFrm.nombreUsuario+m.ErrorPermiso, m.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

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
                if (permitir("frmCrearUsuario"))//copy
                {
                    frmCrearUsuario f = new frmCrearUsuario();
                    f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    sinPermiso();//copy
                }
               // f.WindowState = FormWindowState.Maximized;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                MessageBox.Show("Programador de vacaciones","En mantenimiento");
                /*
                frmCrearPerfil f = new frmCrearPerfil();
                f.MdiParent = this;
                f.Show();*/
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
            if (permitir("frmEmpresa"))
            {
                frmEmpresa f = new frmEmpresa();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                sinPermiso();
            }
            //  f.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (permitir("frmFotoSeguridad"))
            {
                frmFotoSeguridad f = new frmFotoSeguridad();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                sinPermiso();
            }
            //  f.WindowState = FormWindowState.Maximized;
        }

        private void frmPrincipalSeguridad_Load(object sender, EventArgs e)
        {
            barraInferior();
        }
    }
}
