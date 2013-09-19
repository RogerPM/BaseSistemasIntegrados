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
    public partial class frm_ReporteCobro : Form
    {

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            barButtonItem1.Enabled = frmPrincipal.Lectura;
        }
        #endregion
        public frm_ReporteCobro()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ConsultaReporteCobro fcr = new frm_ConsultaReporteCobro();
            fcr.ShowDialog();
        }

        private void frm_ReporteCobro_Load(object sender, EventArgs e)
        {
            Seguridad();
        }
    }
}
