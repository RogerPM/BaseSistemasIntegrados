using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Cuentasxpagar;
using datos.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmOrdenPago : Form
    {
        public frmOrdenPago()
        {
            InitializeComponent();
            //event_click += new delegate_Click(frmOrdenPago_event_click);
        }

        string solo;
        int solo2;
        decimal suma = 0;
        int identificador;
        bool resultado = false;
        string consulta;

        List<clsCuentaPorPagarDetalle> CtasXPgDet = new List<clsCuentaPorPagarDetalle>();
        List<clsCuentaPorPagarDetalle> CtasXPgDet2 = new List<clsCuentaPorPagarDetalle>();
        List<clsCuentaPorPagar> CxPg = new List<clsCuentaPorPagar>();

        private void frmOrdenPago_Load(object sender, EventArgs e)
        {
            datosOrdenPagoCab OrPag = new datosOrdenPagoCab();
            clsEmpresaServicioDAT1 ProES = new clsEmpresaServicioDAT1();
            clsCuentaPorPagarDAT CxP = new clsCuentaPorPagarDAT();
            datosOrdenPagoDet OrPagDet = new datosOrdenPagoDet();

            dtpFechaEmisión.MaxDate = DateTime.Today;
            textEdit1.Text = Convert.ToString(OrPag.getIdSiguiente());
            cbxProveedor.Properties.DataSource = ProES.ConsultaEmpresaServicio();
            txtEfectivoDisponible.Text = Convert.ToString(OrPag.ConsultaSaldo());
            consulta = Convert.ToString(OrPag.ConsultaSaldo());
            txtEfectivoDisponible.Text = consulta;
            txtEstado.Text = "Inactivo";
            CtasXPgDet = CxP.consultaDetalle();
            CxPg = CxP.consulta();



        }

        //void frmOrdenPago_event_click(object sender, EventArgs e)
        //{
        //}

        //public delegate void delegate_Click(object sender, EventArgs e);
        //public event delegate_Click event_click;


        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

        }


        public void limpiar()
        {
            cbxProveedor.EditValue = " ";
            txtTotalPagar.Text = "";
        }

        private void cbxProveedor_EditValueChanged(object sender, EventArgs e)
        {
            clsCuentaPorPagarDetalle obj = new clsCuentaPorPagarDetalle();

            solo = Convert.ToString(cbxProveedor.EditValue);
            for (int i = 0; i < CxPg.Count; i++)
            {
                if (CxPg[i]._IdEmpresaServicio == solo)
                {
                    solo2 = CxPg[i]._NumCuentaPorPagar;

                    for (int j = 0; j < CtasXPgDet.Count; j++)
                    {
                        if (CtasXPgDet[j]._NumCuentaPorPagar == solo2)
                        {
                            obj = CtasXPgDet[j];
                            CtasXPgDet2.Add(obj);
                        }
                    }
                }
            }

            gdcOrdenPago.DataSource = CtasXPgDet2;

        }


        private void txtEfectivoDisponible_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
