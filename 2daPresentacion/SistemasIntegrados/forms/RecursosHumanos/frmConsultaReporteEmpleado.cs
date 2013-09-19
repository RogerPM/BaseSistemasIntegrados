using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.RecursosHumanos ;
using clases.RecursosHumanos ;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaReporteEmpleado : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Seguridad()
        {
            //lecturas
            toolStripButton4.Visible = frmPrincipal.Lectura;
        }

        #endregion

        public frmConsultaReporteEmpleado()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clsDatosPersona clas = new clsDatosPersona();


            rptEmpleado  reprt = new rptEmpleado  ();
            clsReporte rpt = new clsReporte();
            rpt.PERSONA  = clas.ConsultaPersona ();
            //rpt.abc = "as";
            List<clsReporte> listaReporte = new List<clsReporte>();
           
            listaReporte.Add(rpt);
            
            //reprt.loadReport(listaReporte.ToArray(), rpt.PERSONA.ToArray());
            //reprt.ShowPreviewDialog();

            //REPORTE rpt = new REPORTE();

            //REPORTECLASE clasRe = new REPORTECLASE();

            //List<REPORTECLASE> listare = new List<REPORTECLASE>();

            //clasRe.PERSONA = dat.consulta();
            //clasRe.NombreEmpresa = "HECTOR ROMERO SA";


            //listare.Add(clasRe);
            reprt.loadReport(listaReporte);


           reprt.ShowPreview();
        }

        private void frmConsultaReporteEmpleado_Load(object sender, EventArgs e)
        {
            Seguridad();
        }
    }
}
