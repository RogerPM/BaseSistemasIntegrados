using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Contabilidad;
using clases.Contabilidad;
using System.Data.SqlClient;

namespace forms.Contabilidad
{
    public partial class frmlibrodiario : Form
    {
        public frmlibrodiario()
        {
            InitializeComponent();
        }
        public DateTime lbfechaini1;
        public DateTime lbfechafin1;

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        public void cargar()
        {
            clsDatoLibroDiario lb = new clsDatoLibroDiario();
            gridControl1.DataSource = lb.Consulta(lbfechaini1, lbfechafin1);
            this.txtfechaini.Text = lbfechaini1.ToString();
            this.txtfechafin.Text = lbfechafin1.ToString();
            //gridControl1.DataSource = lb.Consulta(frmld.lbfechaini.Date , frmld.lbfechafin);
                //lb.Consulta(frmld.dateDesde.DateTime.Date, frmld.dateHasta.DateTime.Date);
        }


        private void frmlibrodiario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            clsDatoLibroDiario clas = new clsDatoLibroDiario();
            rptLibroDiario reprt = new rptLibroDiario();            
            clsReporteLB rpt = new clsReporteLB();
            // Asigno la fecha para el reporte
            frmlibrodiario ld = new frmlibrodiario();
            reprt.lbfechaini1 = lbfechaini1; 
            reprt.lbfechafin1 = lbfechafin1;
            rpt.lista = clas.Consulta(lbfechaini1, lbfechafin1);
            List<clsReporteLB> listareport = new List<clsReporteLB>();
            listareport.Add(rpt);
            reprt.loadData(listareport.ToArray(), rpt.lista.ToArray());
            reprt.ShowPreview();
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
