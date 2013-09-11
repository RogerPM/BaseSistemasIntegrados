using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using Core.Erp.Info.Seguridad;
using datos.Seguridad;
using forms._Otro;
using clases.Seguridad;
using System.Threading;

namespace forms
{
    public partial class frmPrincipal : DevExpress.XtraEditors .XtraForm
    {
        datModulosPorUsuario oModulosUsuario = new datModulosPorUsuario();
        List<clsModuloR> ListaModulos = new List<clsModuloR>();
        private clsMensajeSeguridad m = new clsMensajeSeguridad();
        public static string Asemby;
        private frmSesion ofrmSesion = new frmSesion();

        #region "Distribuido por Seguridad 2/3"
        //codigo de Seguridad
        public static List<clsVwUsuarioPermisos> permissionsAll = new List<clsVwUsuarioPermisos>();//copy
        
        private void barraInferior()
        {
            barStaticItem1.Caption = clsVwUsuarioInformacion.nombreUsuario;
            permissionsAll = frmSesion.per;//copy important
        }
   
        #endregion


        public frmPrincipal()
        {
            InitializeComponent();
           
        }
        public int IdEmpresa { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public frmPrincipal(List<clsModuloR> _ListaModulos,int _IdEmpresa, String _Usuario, String _Contrasenia):this()
        {
            IdEmpresa = _IdEmpresa;
            Usuario = _Usuario;
            Contrasena = _Contrasenia;
            IGUMetroControl Control = new IGUMetroControl(_ListaModulos);
            Control.Dock = DockStyle.Fill;
            Control.Evente_tileItem_ItemClick += new IGUMetroControl.delegate_tileItem_ItemClick(Control_Evente_tileItem_ItemClick);
            panelControl1.Controls.Add(Control);
            timer1.Interval = 1;
            ListaModulos = _ListaModulos;
            btnHome_Click(new object(), new EventArgs()); 
        }

        void Control_Evente_tileItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var Menu_Item = ListaModulos.First(var => var.Nombre == e.Item.Text);
            int IdMeni = Menu_Item.IdModulo;
            //ultraSplitter1.Collapsed = true;
            //ControlMenuPrincipal uc = new ControlMenuPrincipal(IdMeni);
            //uc.Dock = DockStyle.Fill;
            //panelControl2.Controls.Add(uc);
            this.Text = "Tecnología Empresarial de Control Automatizado (TECA™) - " + e.Item.Text;
            CargarMenuPadre(IdMeni);
            BanderaCrecer = false;
            btnHome.Visible = true;
            timer1.Start();            
        }
        public frmPrincipal(int IdModulo):this  ()
        {
            CargarMenuPadre(IdModulo);
        }
        datMenuPadre oMenuModulos = new datMenuPadre();
        List<clsMenu> ListMenuPadre = new List<clsMenu>();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void CargarMen() 
        {          
        }
        public static bool Lectura;
        public static bool Escritura;
        public static bool Eliminacion;
        void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var itemMenu = ListMenuPadre.First(var => var.Descripcion == e.Item.Caption);
                Object ObjFrm;
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
                Asemby = itemMenu.NombreAssembly.Trim() + "." + itemMenu.NombreFormulario.Trim();
                Type tipo = Ensamblado.GetType(Asemby);
                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario", "TECA™", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { ObjFrm = Activator.CreateInstance(tipo);
                    Form Formulario = (Form)ObjFrm;
                    var asd = this.MdiChildren;
                    if(asd.Count()!=0)
                    {
                        try
                        {
                             Form az = asd.First(a => a.Text == Formulario.Text);
                                az.Focus();
                                return;
                        }
                        catch (Exception)
                        {}
                    }
                    Formulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    //ObjFrm = Activator.CreateInstance(tipo);
                    //Form Formulario = (Form)ObjFrm;
                    Formulario.MdiParent = this;
                    //Formulario.MdiParent = xtraTabbedMdiManager1.MdiParent;
                    try
                    {
                        var x = (from w in permissionsAll where w.nombreFormulario == frmPrincipal.Asemby.Remove(0, 6) && w.idUsuario == clsVwUsuarioInformacion.idUsuario select w).First();
                        Lectura = x.lectura;
                        Escritura = x.escritura;
                        Eliminacion = x.eliminacion; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error no existen permisos asignados: " +ex);                        
                    }

                    if (Asemby.Remove(0, 6) == "CuentasxCobrar.frm_CajaApertura")
                    {
                        timer1.Stop();
                        Formulario.MdiParent = null;
                        Formulario.ShowDialog();
                    }
                    else
                    {
                        Formulario.Show();
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error ubicación del formulario", "TECA™", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        void CargarMenuPadre(int IdModulo) 
        {            
            ListMenuPadre = oMenuModulos.ConsultaMenuModulo(IdModulo,IdEmpresa,Usuario,Contrasena);
            var Carpetas = ListMenuPadre.FindAll(var => var.IdPadre == null || var.IdPadre == 0);
            ribbonControl1.Pages.Clear();
            foreach (var item in Carpetas)
            {                
                RibbonPage ribbonPage = new RibbonPage(item.Descripcion);                
                ribbonControl1.Pages.Add(ribbonPage);             
                var Botones = ListMenuPadre.FindAll(var => var.IdPadre == item.IdMenu);
                foreach (var Pantalla in Botones)
                {
                    RibbonPageGroup ribbonPageGroup = new RibbonPageGroup();
                    ribbonPage.Groups.Add(ribbonPageGroup);
                    BarButtonItem barButtonItem = new BarButtonItem();
                    barButtonItem.Caption = Pantalla.Descripcion;
                    ribbonPageGroup.ItemLinks.Add(barButtonItem);
                    barButtonItem.ItemClick += new ItemClickEventHandler(barButtonItem_ItemClick);
                }
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            barraInferior();//copy
            
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Si sale se cerrará su sesión, esta seguro que desea salir del programa? ", "TECA™", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
           //ultraSplitter1.Collapsed = false;
          //  Thread Hilo = new Thread(new ThreadStart(ColapsarPanel));
            //Hilo.Start();
            ribbonControl1.Pages.Clear();
            c = 0;
            BanderaCrecer = true;
            timer1.Start();           
        }
        void ColapsarPanel() 
        {
            //for (int i = 0; i < 1424; i++)
            //{
            //    this.panelControl1.Size.Height = i;
            //    Thread.Sleep(new TimeSpan(0, 0, 0, 0, 300));
            //}           
        }
        int c = 0;
        private Boolean BanderaCrecer = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (Asemby.Remove(0, 6) == "CuentasxCobrar.frm_CajaApertura")
                //    timer1.Enabled = false;
                //else
                //    timer1.Enabled = true;

                if (BanderaCrecer)
                    c = c + 100;
                else
                    c = c - 100;
                panelControl1.Size = new Size(c, this.Size.Width);
                if (c >= 1424)
                    timer1.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                //throw;
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmSesion"] != null)
            {
                ofrmSesion.Visible = true;
                ofrmSesion.Activate();
            }
        }
    }
}
