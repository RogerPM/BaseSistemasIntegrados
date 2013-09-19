using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using datos.Seguridad;
using Core.Erp.Info.Seguridad;
using clases.Seguridad;
using DevExpress.XtraEditors;

namespace forms._Otro
{
    public partial class IGUMetroControl : UserControl
    {
        public IGUMetroControl()
        {
            InitializeComponent();
        }
        public List<clsModuloR> oListaModulos { get; set; }
        public IGUMetroControl(List<clsModuloR> _ListaModulos):this ()
        {
            oListaModulos = _ListaModulos;
            Thread Hilo = new Thread(new ThreadStart(CrearMenuPadre));
            Hilo.Start();
            Evente_tileItem_ItemClick += new delegate_tileItem_ItemClick(ControlGUI_Evente_tileItem_ItemClick);
        
        }
        void ControlGUI_Evente_tileItem_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }
        datMenuPadre oMenu = new datMenuPadre();
        global::System.Resources.ResourceManager ResourceManager = new System.Resources.ResourceManager("forms.Properties.Resources", typeof(global::forms.Properties.Resources).Assembly);
        List<clsMenu> ListMenuPadre = new List<clsMenu>();
        datModulosPorUsuario oDatModuloUsuario = new datModulosPorUsuario();
        List<clsModuloR> ListaModulos = new List<clsModuloR>();
        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Thread Hilo = new Thread(new ThreadStart(CrearMenuPadre));
            Hilo.Start();
        }
        int IdMeni = 0;
        public delegate void delegate_tileItem_ItemClick(object sender, TileItemEventArgs e);
        public event delegate_tileItem_ItemClick Evente_tileItem_ItemClick;
        void tileItem_ItemClick(object sender, TileItemEventArgs e)
        {
            var itemModulo = ListaModulos.First(var => var.Nombre == e.Item.Text);
            IdMeni = itemModulo.IdModulo;            
            //frmPrincipal ofrm = new frmPrincipal(IdMeni);
            //ofrm.Text = ofrm.Text + "-----------------" + e.Item.Text;
            //ofrm.ShowDialog();
            Evente_tileItem_ItemClick(sender, e);
        }

        void CrearMenuPadre()
        {
            tileGroup2.Items.Clear();
            ListaModulos = oListaModulos;// oMisModulos.ConsultaModulosUsuario();
            foreach (var item in ListaModulos)
            {
                var Imagen = ResourceManager.GetObject(item.Logo);
                TileItemElement tileItemElement = new TileItemElement();
                TileItem tileItem = new TileItem();
                tileItem.Elements.Add(tileItemElement);
                tileItem.Id = 13;
                tileItem.Text = item.Nombre;
                tileItem.BackgroundImage = (Image)Imagen;
                tileItem.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
                this.tileGroup2.Items.Add(tileItem);
                tileItem.ItemClick += new TileItemClickEventHandler(tileItem_ItemClick);
                Thread.Sleep(new TimeSpan(0, 0, 0, 0, 300));
            }
        }

        private void tileItemActualizar_ItemClick(object sender, TileItemEventArgs e)
        {
            Thread Hilo = new Thread(new ThreadStart(CrearMenuPadre));
            Hilo.Start();
        }
    }
}
