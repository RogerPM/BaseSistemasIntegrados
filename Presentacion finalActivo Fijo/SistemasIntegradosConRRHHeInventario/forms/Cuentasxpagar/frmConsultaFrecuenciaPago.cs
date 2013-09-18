using System;
using System.Windows.Forms;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmConsultaFrecuenciaPago : Form
    {
        public clsFrecuenciaPago fp = new clsFrecuenciaPago();
        public frmConsultaFrecuenciaPago()
        {
            InitializeComponent();
         
        }
        //imprimir  Me.GridControl1.ShowPrintPreview()

        private void frmConsultaFrecuenciaPago_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            datosFrecuenciaPago frepagos = new datosFrecuenciaPago();

            gcdFrecuenciaPago.DataSource = frepagos.consulta();




        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();

        }
        public void getSeleccion()
        {
            fp.IdFrecuenciaPago = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdFrecuenciaPago));
            fp.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            fp.Estado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            fp.IdEmpresa=Convert.ToInt32 (gridView1.GetFocusedRowCellValue(colIdEmpresa));
            fp.IdUsuario=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
            fp.FechaActual=Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaActual));
           
        }

       
      
       
    }
}
