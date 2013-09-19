using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using clases.Taller;
using datos.Taller;


namespace forms.Taller
{
    public partial class frmRptHistorialdeReparaciones : Form
    {
        clsConsultaClienteP oclsConsultaClienteP = new clsConsultaClienteP();

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            btnGenerar.Visible = frmPrincipal.Lectura;
        }
        #endregion


        public frmRptHistorialdeReparaciones()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            if (txtPlaca.Text == "")
            {
                rpt.Load(Application.StartupPath + "//Taller//crptHistorialReparacionesG.rpt");
                rptHistorialReparaciones report = new rptHistorialReparaciones(rpt);
                report.ShowDialog();
            }
            else
            {
                rpt.Load(Application.StartupPath + "//Taller//crptHistorialReparaciones.rpt");
                rpt.SetParameterValue("Placa", txtPlaca.Text);
                rpt.SetParameterValue("FechaInicio", cbxFechaInicio.Text);
                rpt.SetParameterValue("FechaFin", cbxFechaFin.Text);
                rptHistorialReparaciones report = new rptHistorialReparaciones(rpt);
                report.ShowDialog();
            }
        }

        private void frmRptHistorialdeReparaciones_Load(object sender, EventArgs e)
        {
            cbxFechaInicio.Text = DateTime.Today.ToShortDateString();
            cbxFechaFin.Text = DateTime.Today.ToShortDateString();
            Seguridad();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarClienteVehiculo f = new frmConsultarClienteVehiculo();
            f.ShowDialog();
            oclsConsultaClienteP = f.e;

            if (oclsConsultaClienteP.IdArticulo == 0)
            {
                borrar();
            }
            else
            {
                txtPlaca.Text = oclsConsultaClienteP.NroPlaca;
                txtCliente.Text = oclsConsultaClienteP.Nombre + " " + oclsConsultaClienteP.Apellido;
            }
        }

        public void borrar()
        {
            txtPlaca.Text = "";
            txtCliente.Text = "";
            cbxFechaInicio.Text = DateTime.Today.ToShortDateString();
            cbxFechaFin.Text = DateTime.Today.ToShortDateString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
