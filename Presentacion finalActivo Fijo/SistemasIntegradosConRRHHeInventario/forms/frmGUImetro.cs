using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using datos.Seguridad;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Resources;
using DevExpress.XtraBars.Helpers;
using clases.Seguridad;

namespace forms
{
    public partial class frmGUImetro : DevExpress.XtraEditors.XtraForm
    {
        public frmGUImetro()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Thread Hilo = new Thread(new ThreadStart(CargarModulo));
            Hilo.Start();
        }

        //tb_Menu_Data Menu_D = new tb_Menu_Data();
        global::System.Resources.ResourceManager ResourceManager = new System.Resources.ResourceManager("forms.Properties.Resources", typeof(global::forms.Properties.Resources).Assembly);
        // List<tb_Menu_Info> ListMenuPadre = new List<tb_Menu_Info>();
        datModulo oDatModulo = new datModulo();
        List<clsModulo> ListaModulos = new List<clsModulo>();
        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Thread Hilo = new Thread(new ThreadStart(CargarModulo));
            Hilo.Start();

        }
        int menuIndice = 0; //indice para deducir el modulo elegido
        void tileItem_ItemClick(object sender, TileItemEventArgs e)
        {
            var opcion = ListaModulos.First(var => var.Nombre == e.Item.Text);
            menuIndice = opcion.IdModulo;
            //frmPrincipalSeguridad ofrm = new frmPrincipalSeguridad(IdMeni);
            //frmPrincipalSeguridad ofrm = new frmPrincipalSeguridad();
            //ofrm.Text = ofrm.Text + "-----------------" + e.Item.Text;
            //ofrm.ShowDialog();
            frmSesion sesion = new frmSesion();
            sesion.NombreModulo = opcion.Nombre;
            sesion.ShowDialog();
        }

        void CargarModulo()
        {
            tileGroup2.Items.Clear();
            ListaModulos = oDatModulo.ConsultaModulos();

            foreach (var item in ListaModulos)
            {

                var Imagen = ResourceManager.GetObject(item.Logo);
                TileItemElement tileItemElement = new TileItemElement();
                TileItem tileItem = new TileItem();
                tileItem.Elements.Add(tileItemElement);
                tileItem.Id = 13;
                tileItem.Text = item.Nombre;
                tileItem.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
                tileItem.BackgroundImage = (Image)Imagen;
                tileItem.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                this.tileGroup2.Items.Add(tileItem);

                tileItem.ItemClick += new TileItemClickEventHandler(tileItem_ItemClick);

                Thread.Sleep(new TimeSpan(0, 0, 0, 0, 300));

            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Desea salir del programa? ", "TECA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                base.Close();
                //this.Close();
                //this.Dispose();
            }
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            forms.Seguridad.frmCambiarContrasena f = new forms.Seguridad.frmCambiarContrasena();
            f.ShowDialog();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            forms.Seguridad.frmCambiarContrasena f = new forms.Seguridad.frmCambiarContrasena();
            f.ShowDialog();
        }

    }
}
