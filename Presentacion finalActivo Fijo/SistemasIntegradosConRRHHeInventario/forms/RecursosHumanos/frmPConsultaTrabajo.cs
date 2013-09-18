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
        public clsTrabajoDiarioCab  claseTdc = new clsTrabajoDiarioCab ();

        clsDatosTrabajoDiarioCab  DatoTdc = new clsDatosTrabajoDiarioCab ();
#endregion

#region Metodos

        public void Cargar()
        {
            gcTrabajoDiario.DataSource = DatoTdc.ConsultaTrabajoDiarioCab();
            

        }

        public void getSeleccion()
        {
            claseTdc.NumTrabajo = Convert.ToInt32(gvTrabajoDiario.GetFocusedRowCellValue(colNumTrabajo ));
            claseTdc .Fecha =Convert.ToDateTime (gvTrabajoDiario.GetFocusedRowCellValue(colFecha));
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
