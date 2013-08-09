using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Seguridad;
using forms.Contabilidad;
using forms.Taller;
using forms.ActivoFijo;
using forms.Cuentasxpagar;
using forms.Compras;
using forms.RecursosHumanos;
using forms.CuentasxCobrar;

namespace forms
{
    public partial class frmSesion : Form
    {
        public string NombreModulo;
        public frmSesion()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (NombreModulo=="Seguridad")
            {
                frmPrincipalSeguridad f= new frmPrincipalSeguridad();
                f.ShowDialog();   
            }
            if (NombreModulo=="Contabilidad")
            {
                frmPrincipalContabilidad f = new frmPrincipalContabilidad();
                f.ShowDialog();
            }
            if (NombreModulo == "Taller")
            {
                frmPrincipalTaller f = new frmPrincipalTaller();
                f.ShowDialog();
            }
            if (NombreModulo == "ActivoFijo")
            {
                PantallaPrincipal f = new PantallaPrincipal();
                f.ShowDialog();
            }
            if (NombreModulo == "CuentasPorPagar")
            {
                frmMenuCtasXPagar f = new frmMenuCtasXPagar();
                f.ShowDialog();
            }
            if (NombreModulo == "Compras")
            {
                frmPrincipalCompras f = new frmPrincipalCompras();
                f.ShowDialog();
            }
            if (NombreModulo == "RecursosHumanos")
            {
                frmPrincipalRRHH f = new frmPrincipalRRHH();
                f.ShowDialog();
            }
            if (NombreModulo == "CuentasPorCobrar")
            {
                frmPrincipalCC f = new frmPrincipalCC();
                f.ShowDialog();
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
