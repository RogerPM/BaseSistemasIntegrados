using System;
using System.Windows.Forms;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmConsultaFrecuenciaPago : Form
    {
        public clsFrecuencia fp = new clsFrecuencia();
        public frmConsultaFrecuenciaPago()
        {
            InitializeComponent();
         
        }

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
            fp._IdFrecuenciaPago = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdFrecuenciaPago));
            fp._Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            fp._Estado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            fp._IdEmpresa=Convert.ToInt32 (gridView1.GetFocusedRowCellValue(colIdEmpresa));
            fp._IdUsuario=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
            fp._FechaActual=Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaActual));
           
        }
    }
}
