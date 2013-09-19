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

namespace clases.Cuentasxpagar
{
    public partial class frmConsultaCuentaPorPagar : Form
    {
        clsCuentaPorPagarDAT datCXP = new clsCuentaPorPagarDAT();
        public clsCuentaPorPagar ctaxpag = new clsCuentaPorPagar();

        public frmConsultaCuentaPorPagar()
        {
            InitializeComponent();
        }

        private void frmConsultaCuentaPorPagar_Load(object sender, EventArgs e)
        {
            gdcConsultaCtaxPag.DataSource = datCXP.consulta();
        }

        public clsCuentaPorPagar GetSelection()
        {
            ctaxpag._NumCuentaPorPagar = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_NumCuentaPorPagar));
            ctaxpag._Descuento = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Descuento));
            ctaxpag._Detalle = Convert.ToString(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Detalle));
            ctaxpag._Factura = Convert.ToString(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Factura));
            ctaxpag._FechaIngreso = Convert.ToDateTime(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_FechaIngreso));
            ctaxpag._FechaTransaccion = Convert.ToDateTime(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_FechaTransaccion));
            ctaxpag._FormaPago = Convert.ToString(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_FormaPago));
            ctaxpag._IdEmpresa = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_IdEmpresa));
            ctaxpag._IdEmpresaServicio = Convert.ToString(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_IdEmpresaServicio));
            ctaxpag._IdFrecuencia = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_IdFrecuencia));
            ctaxpag._IdProveedor = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_IdProveedor));
            ctaxpag._IdUsuario = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_IdUsuario));
            ctaxpag._Motivo = Convert.ToString(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Motivo));
            ctaxpag._NumeroLetra = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_NumeroLetra));
            ctaxpag._NumIngresoEgreso = Convert.ToInt32(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_NumIngresoEgreso));
            ctaxpag._SaldoDeuda = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_SaldoDeuda));
            ctaxpag._Subtotal = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Subtotal));
            ctaxpag._Total = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_Total));
            ctaxpag._ValorEntrada = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_ValorEntrada));
            ctaxpag._ValorLetra = Convert.ToDecimal(gdvConsultaCtaxPag.GetFocusedRowCellValue(col_ValorLetra));

            ctaxpag._DetCredito = datCXP.consultaDetalle(ctaxpag._NumCuentaPorPagar);

            ctaxpag._ImpuestoCuenta = datCXP.consultaImpuesto(ctaxpag._NumCuentaPorPagar);
            
            return ctaxpag;
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            GetSelection();
            this.Close();
        }

    }
}
