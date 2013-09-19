using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using clases.RecursosHumanos;
using datos.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaReporteRol : DevExpress.XtraEditors.XtraForm
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

        public frmConsultaReporteRol()
        {
            InitializeComponent();
        }
        int id;
        clsPersona clas1 = new clsPersona();

        clsDatosPersona datoper = new clsDatosPersona();

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clsDatosNominaDet  clas = new clsDatosNominaDet ();

            if (rgFiltro.SelectedIndex == 0)
            {
                rptNominaEspecifico reprt = new rptNominaEspecifico();
                clsReporte rpt = new clsReporte();
                rpt.NOMINA = clas.ConsultaNominaReporteEspecifico(id);
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
            else {

                rptNomina reprt = new rptNomina();
                clsReporte rpt = new clsReporte();
                rpt.NOMINA = clas.ConsultaNominaReporteDet();
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
           
                
        
           

               
            

            
        }

        

        private void rgFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgFiltro.SelectedIndex == 1)
            {
                txtCedula.Enabled = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                simpleButton1.Enabled = false;
            }
            else {
                txtCedula.Enabled = true ;
                txtNombre.Enabled = true ;
                txtApellido.Enabled = true ;
                simpleButton1.Enabled = true ;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            cPer.band = 1;
            cPer.ShowDialog();
            clas1 = cPer.p;

            id = clas1.IdPersona;
            txtCedula.Text = Convert.ToString(clas1.Identificacion);

            txtNombre.Text = clas1.NombreRazonSocial;
            txtApellido.Text = clas1.Apellido;
        }

        private void frmConsultaReporteRol_Load(object sender, EventArgs e)
        {
            Seguridad();
        }
    }
}