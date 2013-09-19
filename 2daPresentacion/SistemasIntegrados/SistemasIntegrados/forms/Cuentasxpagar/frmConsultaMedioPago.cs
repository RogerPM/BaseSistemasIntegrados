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
    public partial class frmConsultaMedioPago : Form
    {
        public clsMedioPago mp = new clsMedioPago();
        public frmConsultaMedioPago()
        {
            InitializeComponent();
        }

        private void frmConsultaMedioPago_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {

            datosMedioPago MedPago = new datosMedioPago();
            gdcConsultaMedioPago.DataSource = MedPago.consulta();

        }

          private void tsbOk_Click(object sender, EventArgs e)
        {

            getSeleccion();
            this.Close();

        }
        public void getSeleccion()
        {
            mp.IdMedioPago = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdMedioPago));
            mp.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            mp.Estado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            mp.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            mp.IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
            mp.FechaRegistro = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaRegistro));

        }
     
    }
}
