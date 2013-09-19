using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using datos.RecursosHumanos;


namespace forms.RecursosHumanos
{
    public partial class frmPConsultaPrestamo : Form
    {
        public frmPConsultaPrestamo()
        {
            InitializeComponent();
        }
#region Instancia
        public clsPrestamo p = new clsPrestamo();

        clsDatosPrestamo Prestamo = new clsDatosPrestamo();
#endregion
#region Metodos

        public void Cargar()
        {
            gcPrestramo.DataSource = Prestamo .ConsultPrestamo();

        }


        public void getSeleccion()
        {
            p.IdPrestamo = Convert.ToInt32(gvPrestamo.GetFocusedRowCellValue(colIdPrestamo ));
            p.IdPersona = Convert.ToInt32(gvPrestamo.GetFocusedRowCellValue(colIdPersona ));
            p.Identificacion = Convert.ToInt64 (gvPrestamo.GetFocusedRowCellValue(colIdentificacion ));
            p.Nombre = Convert.ToString  (gvPrestamo.GetFocusedRowCellValue(colNombre));
            p.Apellido = Convert.ToString(gvPrestamo.GetFocusedRowCellValue(colApellido));
            p.FechaModificacion = Convert.ToDateTime  (gvPrestamo.GetFocusedRowCellValue(colFechaModificacion ));
            p.Monto = Convert.ToDecimal  (gvPrestamo.GetFocusedRowCellValue(colMonto));
            p.Interes = Convert.ToDecimal(gvPrestamo.GetFocusedRowCellValue(colInteres));
            p.Pago = Convert.ToDecimal (gvPrestamo.GetFocusedRowCellValue(colPago));
            p.Periodos = Convert.ToInt32(gvPrestamo.GetFocusedRowCellValue(colPeriodos ));
            p.Total = Convert.ToDecimal(gvPrestamo.GetFocusedRowCellValue(colTotal));
            p .IdEstado = Convert.ToInt32(gvPrestamo.GetFocusedRowCellValue(colIdEstado ));
            p.TotalPagado = Convert.ToDecimal(gvPrestamo.GetFocusedRowCellValue(colTotalPagado));
            p.IdEmpresa =Convert.ToInt32(gvPrestamo.GetFocusedRowCellValue(colIdEmpresa ));

           

        }

        #endregion

        private void frmPConsultaPrestamo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

#region Botones
        private void tsbConsultado_Click_1(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }
       
        #endregion

        
    }
}
