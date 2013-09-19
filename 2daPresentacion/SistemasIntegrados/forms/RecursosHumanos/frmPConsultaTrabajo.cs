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
    public partial class frmPConsultaTrabajo : Form
    {
        public frmPConsultaTrabajo()
        {
            InitializeComponent();
        }
 #region Instancia
        public clsTrabajoDiario  claseTdc = new clsTrabajoDiario ();

        clsDatosTrabajoDiario DatoTdc = new clsDatosTrabajoDiario ();
#endregion

#region Metodos

        public void Cargar()
        {
            gcTrabajoDiario.DataSource = DatoTdc.ConsultaTrabajoDiario();
            

        }

        public void getSeleccion()
        {
            claseTdc.NumTrabajo = Convert.ToInt32(gvTrabajoDiario.GetFocusedRowCellValue(colNumTrabajo ));
            claseTdc .FechaDesde =Convert.ToDateTime (gvTrabajoDiario.GetFocusedRowCellValue(colFechaDesde));
            claseTdc.FechaHasta = Convert.ToDateTime(gvTrabajoDiario.GetFocusedRowCellValue(colFechaHasta));
            claseTdc.IdPersona = Convert.ToInt32(gvTrabajoDiario.GetFocusedRowCellValue(colIdPersona ));
            claseTdc.Identificacion = Convert.ToInt64(gvTrabajoDiario.GetFocusedRowCellValue(colIdentificacion ));
            claseTdc.Nombre = Convert.ToString (gvTrabajoDiario.GetFocusedRowCellValue(colNombre));
           claseTdc .Apellido =  Convert.ToString (gvTrabajoDiario.GetFocusedRowCellValue(colApellido));
           claseTdc.HoraEntrada1 = Convert.ToDateTime (gvTrabajoDiario.GetFocusedRowCellValue(colHoraEntrada1 ));
           claseTdc.HoraSalida2 = Convert.ToDateTime (gvTrabajoDiario.GetFocusedRowCellValue(colHoraSalida2 ));
            claseTdc.Observacion =Convert.ToString (gvTrabajoDiario.GetFocusedRowCellValue(colObservacion ));
            

        }
#endregion
        private void frmPConsultaTrabajo_Load(object sender, EventArgs e)
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
