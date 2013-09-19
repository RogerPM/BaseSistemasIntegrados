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
    public partial class frmConsultaPago : Form
    {
        public clsPago Pg = new clsPago();

        public frmConsultaPago()
        {
            InitializeComponent();
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        private void frmConsultaPago_Load(object sender, EventArgs e)
        {
            cargar();

        }
        public void cargar()
        {//aqui hay que poner la empresa que ingresa
            int Empresa = 1;
            datosPago pag = new datosPago();
            gcdConsultaPago.DataSource = pag.consulta(Empresa );


        }

        public void getSeleccion()
        {
            Pg.NumPago = Convert.ToInt32 (gridView1.GetFocusedRowCellValue(colNumPago));
            Pg.FechaIngreso = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaIngreso));
            Pg.NumOrdenPago = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNumOrdenPago ));
          
            Pg.TotalPagar = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colTotalPagar ));
            Pg.IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario ));
            Pg.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa ));
            Pg.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado ));
            Pg.NumComprobante  = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colNumComprobante ));





        }

        private void gcdConsultaPago_Click(object sender, EventArgs e)
        {

        }
    }
}
