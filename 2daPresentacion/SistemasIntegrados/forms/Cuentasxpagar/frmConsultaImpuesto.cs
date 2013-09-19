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
    public partial class frmConsultaImpuesto : Form
    {
        public clsImpuestos mp = new clsImpuestos();
        public frmConsultaImpuesto()
        {
            InitializeComponent();
        }


        public void cargar()
        {

            datosImpuestos Impu = new datosImpuestos();
            gdcConsultaImpuesto.DataSource = Impu.consulta();

        }



        public void getSeleccion()
        {
            mp.IdImpuesto = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdImpuesto));
            mp.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            mp.Porcentaje = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colPorcentaje));
            mp.FechaRegistro = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaRegistro));
            mp.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            mp.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            mp.IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));



        }



        private void tsbOk_Click_1(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }


        private void frmConsultaImpuesto_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {

        }
    }
}
