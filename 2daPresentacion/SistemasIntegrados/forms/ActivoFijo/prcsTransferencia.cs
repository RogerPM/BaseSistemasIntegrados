using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace forms.ActivoFijo
{
    public partial class prcsTransferencia : Form
    {
        public prcsTransferencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }


        private void pnlCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prcsTransferencia_Load(object sender, EventArgs e)
        {

            userPrincipal frm = new userPrincipal();
            pnlCargar.Controls.Add(frm);
        }

        private void cbxTraspaso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var num = cbxTraspaso.SelectedIndex;
            switch (num)
            {
                case 0: SeteoBodega(true);
                    SeteoDepartamento(false);
                    SeteoResponsable(true);
                    SeteoEmpresa(false);
                    SeteoObservacion(true);
                    break;

                case 1: SeteoDepartamento(true);
                    SeteoBodega(false);
                    SeteoResponsable(true);
                    SeteoEmpresa(false);
                    SeteoObservacion(true);
                    break;

                case 2: SeteoDepartamento(true);
                    SeteoBodega(true);
                    SeteoResponsable(true);
                    SeteoEmpresa(true);
                    SeteoObservacion(true);

                    break;

                default: break;
            }
        }


        public void SeteoDepartamento(Boolean prm)
        {
            cbxDepartamento.Enabled = prm;
        }

        public void SeteoBodega(Boolean prm)
        {
            cbxBodegaFutura.Enabled = prm;
        }

        public void SeteoResponsable(Boolean prm)
        {
            btneResponsable.Enabled = prm;
        }

        public void SeteoEmpresa(Boolean prm)
        {
            cbxEmpresa.Enabled = prm;
        }

        public void SeteoObservacion(Boolean prm)
        {
            rtbxDetalle.Enabled = prm;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
