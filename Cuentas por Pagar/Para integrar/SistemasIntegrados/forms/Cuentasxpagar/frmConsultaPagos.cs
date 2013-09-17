using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;



namespace forms.Cuentasxpagar
{
    public partial class frmConsultaPagos : Form
    {
        public frmConsultaPagos()
        {
            InitializeComponent();
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
             datosPago dat = new datosPago();

            Reporte rpt = new Reporte();
            ReporteClase clasRe = new ReporteClase();
            List<ReporteClase> listare = new List<ReporteClase>();

            clasRe.pagocab = dat.consulta(1);
            clasRe.NombreEmpresa = "Pachy Potes";


            listare.Add(clasRe);
            rpt.loadReport(listare );

            rpt.ShowPreview();
        }
        }
    }

