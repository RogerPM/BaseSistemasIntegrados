using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;
using clases.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class RptInventarioDisponible : Form
    {
        public RptInventarioDisponible()
        {
            InitializeComponent();
        }

        private void InventarioDisponible_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            clsClaseDatosActivoFijo clas = new clsClaseDatosActivoFijo();

            rpActivoFijo reprt = new rpActivoFijo();
            clsReporte rpt = new clsReporte();

            rpt.ReporActivo = clas.consulta();

            List<clsReporte> listaReporte = new List<clsReporte>();

            listaReporte.Add(rpt);
            reprt.loadReport(listaReporte);
            reprt.ShowPreview();

        }

        private void btnCOnsultaEspecifica_Click(object sender, EventArgs e)
        {
            clsClaseDatosActivoFijo clas = new clsClaseDatosActivoFijo();//

            rpActivoFijoEspecifico reprt = new rpActivoFijoEspecifico();//
            clsReporte rpt = new clsReporte();

            rpt.ReporActivo = clas.consulta();//

            List<clsReporte> listaReporte = new List<clsReporte>();

            listaReporte.Add(rpt);
            reprt.loadReport(listaReporte);
            reprt.ShowPreview();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            VtnConsultaActivoFijo consulActivo = new VtnConsultaActivoFijo();
            consulActivo.ShowDialog();

            //txtGrupo.Text = consulActivo.cls.grupo; 


        }

       
    }
}
