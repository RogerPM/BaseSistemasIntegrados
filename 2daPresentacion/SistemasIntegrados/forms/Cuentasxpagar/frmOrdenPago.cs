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
using clases.Compras;

namespace forms.Cuentasxpagar
{
    public partial class frmOrdenPago : Form
    {
        int error = 0; // parametro para buscar mensaje
        string msj = "", elemento = "Éxito"; //variables de datos a presentar en mensajes
        List<clsOrdenPagoDet> det = new List<clsOrdenPagoDet>();


        public frmOrdenPago()
        {
            InitializeComponent();
            //event_click += new delegate_Click(frmOrdenPago_event_click);
        }

        int solo=1;
        int solo2;
        string llamar;
        decimal suma = 0;
        string consulta;
        //decimal acum = 0;

        List<clsCuentaPorPagarDetalle> CtasXPgDet = new List<clsCuentaPorPagarDetalle>();
        List<clsCuentaPorPagarDetalle> CtasXPgDet2 = new List<clsCuentaPorPagarDetalle>();
        List<clsCuentaPorPagar> CxPg = new List<clsCuentaPorPagar>();
        datosOrdenPagoCab OrPag = new datosOrdenPagoCab();
        clsEmpresaServicioDAT1 ProES = new clsEmpresaServicioDAT1();
        clsCuentaPorPagarDAT CxP = new clsCuentaPorPagarDAT();
        datosOrdenPagoDet OrPagDet = new datosOrdenPagoDet();
        clsOrdenPagoCab clas = new clsOrdenPagoCab();
        List<lista> lst = new List<lista>();
        List<clsEmpresaServicio> EmpresaServicio = new List<clsEmpresaServicio>();
        List<clsProveedor> Proveedor = new List<clsProveedor>();
        clsCuentaPorPagarDetalle datCtasXPagDet = new clsCuentaPorPagarDetalle();
        public clsMensajeCxP men = new clsMensajeCxP();

        private void frmOrdenPago_Load(object sender, EventArgs e)
        {
            deFechaActual.EditValue = DateTime.Today;
            textEdit1.Text = Convert.ToString(OrPag.getIdSiguiente());
            cbxProveed.Properties.DataSource = CxP.consulta();
            txtEfectivoDisponible.Text = Convert.ToString(OrPag.ConsultaSaldo());
            consulta = Convert.ToString(OrPag.ConsultaSaldo());
            txtEfectivoDisponible.Text = consulta;
            txtEstado.Text = "En proceso";
            CtasXPgDet = CxP.consultaDetalle2();
            CxPg = CxP.consulta();
            //txtTotalPagar.Text = Convert.ToString(acum);
        }

        public void limpiarGrid()
        {
            try
            {
                int x = gvOrden.RowCount;
                for (int i = 0; i <= x; i++)
                {
                    gvOrden.DeleteRow(0);
                }
            }
            catch (Exception)
            {
            }
        }
        public void get()
        {
            if (textEdit1.Text == "")
            {
                clas.NumOrdenPago = 0;//PK
            }
            else
            {
                clas.NumOrdenPago = Convert.ToInt32(textEdit1.Text);
            }
            clas.fechadeEmision = Convert.ToDateTime(deFechaActual.EditValue);
            clas.IdPersona =Convert.ToInt32(cbxProveed.EditValue );
            clas.Estado = 1;
            clas.TotalPagar = Convert.ToDecimal(txtTotalPagar.Text);
            clas.TipoOrdenPago='p';
            clas.IdUsuario =11;
            clas.IdEmpresa =1;
            cargarLista();
            clas._CuentaPorPagarDetalle = det;


        }
        public void set()
        {
            textEdit1.Text = Convert.ToString(clas.NumOrdenPago);
            (deFechaActual.EditValue) = (clas.fechadeEmision);
            (cbxProveed.EditValue) = (clas.IdEmpresa);
            txtTotalPagar.Text = Convert.ToString(clas.TotalPagar);
            solo = clas.IdUsuario;
            solo = clas.IdEmpresa;
            solo = clas.Estado;

        }
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
            get();
            if (OrPag.Guardar(clas))
            {
                MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                limpiar();
            }
            else
            {
                MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
            }
        }



        private void cargarLista()
        {
            
            for (int i = 0; i < gvOrden.RowCount; i++)
            {
                clsOrdenPagoDet clasd = new clsOrdenPagoDet();
                Boolean a = Convert.ToBoolean(gvOrden.GetRowCellValue(i,colAutorizarPago));
                if (a != false)
                {
                    clasd.NumLinea = OrPagDet.getIdSiguiente();
                    clasd.NumCuentaPorPagar = Convert.ToInt32(gvOrden.GetRowCellValue(i, colNúmeroRegistroCXP));
                    clasd.NumDetalleDeuda = Convert.ToInt32(gvOrden.GetRowCellValue(i, colNumCuentaPorPagarDetalle));
                    clasd.SaldoDeuda = Convert.ToDecimal(gvOrden.GetRowCellValue(i, colSaldoDeuda));
                    clasd.NumeroPagosRealizar = Convert.ToInt32(gvOrden.GetRowCellValue(i, colNroPagosRealizar));
                    clasd.NumOrdenPagoCab = Convert.ToInt32(textEdit1.Text);
                    clasd.TotalPagar = Convert.ToInt32(gvOrden.GetRowCellValue(i, colTotalPagar));
                    clasd.IdEmpresa = 1;
                    clasd.AutorizarPago = true;
                }
                det.Add(clasd);
            }
        }

        public void limpiar()
        {
            textEdit1.Text = Convert.ToString(OrPag.getIdSiguiente());
            cbxProveed.EditValue = " ";
            deFechaActual.EditValue = DateTime.Today;
            txtTotalPagar.Text = "";
            limpiarGrid();
        }


        //private void cbxProveedor_EditValueChanged(object sender, EventArgs e)
        //{
        //    clsCuentaPorPagarDetalle obj = new clsCuentaPorPagarDetalle();

        //    llamar = Convert.ToString(cbxProveed.EditValue);
        //    for (int i = 0; i < CxPg.Count; i++)
        //    {
        //        if (CxPg[i]._IdEmpresaServicio == llamar)
        //        {
        //            solo2 = CxPg[i]._NumCuentaPorPagar;

        //            for (int j = 0; j < CtasXPgDet.Count; j++)
        //            {
        //                if (CtasXPgDet[j]._NumCuentaPorPagar == solo2)
        //                {
        //                    obj = CtasXPgDet[j];
        //                    CtasXPgDet2.Add(obj);
        //                }
        //            }
        //        }
        //    }

        //    gdcOrdenPago.DataSource = CtasXPgDet2;

        //}


        private void txtEfectivoDisponible_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                List<clsCuentaPorPagarDetalle> lista = new List<clsCuentaPorPagarDetalle>();
                lista = (List<clsCuentaPorPagarDetalle>)gdcOrdenPago.DataSource;
                lista.ForEach(q => q._totalPagar = q._ValorLetra * q._numeroPagos);
                gdcOrdenPago.DataSource = lista;
            }
            catch (Exception)
            {
            }

        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

        }

        private void txtTotalPagar_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxProveed_EditValueChanged(object sender, EventArgs e)
        {
            gdcOrdenPago.DataSource = OrPagDet.ConsultaDetalleCuentas();
        }

        private void gdcOrdenPago_Click(object sender, EventArgs e)
        {
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            decimal acum = 0;
            bool autorizar = false;
            for (int i = 0; i < gvOrden.RowCount; i++)
            {
                autorizar = Convert.ToBoolean(gvOrden.GetRowCellValue(i, colAutorizarPago));
                if (autorizar == true)
                {
                    decimal valor = Convert.ToDecimal(gvOrden.GetRowCellValue(i, colTotalPagar));

                    acum = acum + valor;
                }
                txtTotalPagar.Text = Convert.ToString(acum);
            }
        }

        
    }
}

