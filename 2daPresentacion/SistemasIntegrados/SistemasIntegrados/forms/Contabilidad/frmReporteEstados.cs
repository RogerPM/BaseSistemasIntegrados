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

namespace forms.Contabilidad
{
    public partial class frmReporteEstados : Form
    {
        public frmReporteEstados()
        {
            InitializeComponent();
        }
        
        //private void ckbTodasCuentas_CheckedChanged(object sender, EventArgs e)
        //{
           
        //}

        private void frmReporteEstados_Load(object sender, EventArgs e)
        {
            dateDesde.EditValue = DateTime.Now;
            dateHasta.EditValue = DateTime.Now.AddDays(30);
            cargar();
        }

        public void cargar()
        {
            clsDatoLibroDiario lb = new clsDatoLibroDiario();
            //gridControl1.DataSource = lb.Consulta();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rdlibrodiario.Checked)
                 {
                     
                     frmlibrodiario ld = new frmlibrodiario();
                     ld.lbfechaini1 = this.dateDesde.DateTime.Date; //dateDesde.DateTime.Date;
                     ld.lbfechafin1 = this.dateHasta.DateTime.Date;
                     ld.ShowDialog();
                }
            else
                 {
                     frmEstadoResultado frm = new frmEstadoResultado();
                     frm.ShowDialog();

                                     }

        }
      
        private void rdbFlujoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbEstadoResultados_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
