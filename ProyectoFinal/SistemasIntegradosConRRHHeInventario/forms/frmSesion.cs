using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Seguridad;
using forms._Otro;
using forms.Contabilidad;
using forms.Taller;
using forms.ActivoFijo;
using forms.Cuentasxpagar;
using forms.Compras;
using forms.RecursosHumanos;
using forms.CuentasxCobrar;
using datos.Seguridad;
using clases.Seguridad;


namespace forms
{
    public partial class frmSesion : Form
    {

        public string NombreModulo;
        public clsVwUsuarioPermisos ClasePermiso = new clsVwUsuarioPermisos();
        public static List<clsVwUsuarioPermisos> per = new List<clsVwUsuarioPermisos>();

        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        private datEmpresa oDatEmpresa=new datEmpresa();

        public frmSesion()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //IniciarSesion();
            if (vacio())
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                IntentoInicio(textEdit1.Text, textEdit2.Text, gridLookUpEdit1.EditValue.ToString());
            }
        }

        private void IntentoInicio(string nick, string contrasena, string empresa)
        {
            datVwUsuarioInformacion view = new datVwUsuarioInformacion();
            string pass = Validador.encriptarCadena(contrasena);
             //llena datos a clsVwUsuarioInformacion
            if (view.ValidarCredenciales(nick, empresa, pass))
            {
                if (clsVwUsuarioInformacion.idEstado != 1)
                {
                    MessageBox.Show(clsVwUsuarioInformacion.nombreUsuario+msj.ErrorUsuarioNoActivo, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (clsVwUsuarioInformacion.contrasena == pass)
                    {
                        //IniciarSesion();
                        cargarModulos();
                    }
                    else
                    {
                        MessageBox.Show(msj.ErrorLogin, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.NoExisteUsuario, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            //throw new NotImplementedException();
        }

        private void cargarModulos() {
            datModulosPorUsuario oMisModulos = new datModulosPorUsuario();
            var lst = oMisModulos.ConsultaModulosUsuario(clsVwUsuarioInformacion.idEmpresa, clsVwUsuarioInformacion.nombreUsuario, clsVwUsuarioInformacion.contrasena);
            datVwUsuarioPermisos permiso = new datVwUsuarioPermisos();
            per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario);
            frmPrincipal ofrm = new frmPrincipal(lst, clsVwUsuarioInformacion.idEmpresa, clsVwUsuarioInformacion.nombreUsuario, clsVwUsuarioInformacion.contrasena);
            
            ofrm.ShowDialog();
            this.Close();
            Visible = false;                    //MessageBox.Show("ok"); 
        }

        #region "distribuido por seguridad 1/3 (sin uso)"
        /*
        private void IniciarSesion(){
        if (NombreModulo=="Seguridad")
            {
                frmPrincipalSeguridad f = new frmPrincipalSeguridad();
                datVwUsuarioPermisos permiso = new datVwUsuarioPermisos();
                per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo=="Contabilidad")
            {
                frmPrincipalContabilidad f = new frmPrincipalContabilidad();
                datVwUsuarioPermisos permiso = new datVwUsuarioPermisos();
                per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "Taller")
            {
                frmPrincipalTaller f = new frmPrincipalTaller();
              //  per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "ActivoFijo")
            {
                PantallaPrincipal f = new PantallaPrincipal();
              //  per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "CuentasPorPagar")
            {
                frmMenuCtasXPagar f = new frmMenuCtasXPagar();
              //  per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "Compras")
            {
                frmPrincipalCompras f = new frmPrincipalCompras();
              //  per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "RecursosHumanos")
            {
                frmPrincipalRRHH f = new frmPrincipalRRHH();
             //   per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
            if (NombreModulo == "CuentasPorCobrar")
            {
                frmPrincipalCC f = new frmPrincipalCC();
             //   per = permiso.LeerPermisos(clsVwUsuarioInformacion.idUsuario, NombreModulo);
                this.Close();
                f.ShowDialog();
            }
        }
        */
        #endregion

        private bool vacio() {
            if ((string.IsNullOrWhiteSpace(textEdit1.Text))||
                (string.IsNullOrWhiteSpace(textEdit2.Text))||
                (gridLookUpEdit1.EditValue==null))
            {
                return true;
            }
            return false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void frmSesion_Load(object sender, EventArgs e)
        {
            try
            {
                this.gridLookUpEdit1.Properties.DataSource = oDatEmpresa.Consultar();
                gridLookUpEdit1.EditValue = "XYZ";
            }            catch (Exception ex)            {            }
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
          //  this.gridLookUpEdit1.Properties.DataSource = oDatEmpresa.Consultar();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            forms.Seguridad.frmCambiarContrasena f = new forms.Seguridad.frmCambiarContrasena();
            f.ShowDialog();
        }
    }
}
