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
    public partial class frmPConsultaNomina : Form
    {
        public frmPConsultaNomina()
        {
            InitializeComponent();
        }

#region Instancia
        public clsNominaCab  claseNc = new clsNominaCab ();

        clsDatosNominaCab  DatoNc = new clsDatosNominaCab ();
#endregion

#region Metodos

        public void Cargar()
        {
            gcConsultaNomina .DataSource = DatoNc .ConsultaNominaCab();

        }

        public void getSeleccion()
        {
            claseNc.NumNomina = Convert.ToInt32(gvConsultaNomina .GetFocusedRowCellValue(colNumNomina));
            claseNc.Fecha = Convert.ToDateTime  (gvConsultaNomina .GetFocusedRowCellValue(colFecha ));
            claseNc .FechaModificacion = Convert.ToDateTime  (gvConsultaNomina .GetFocusedRowCellValue(colFechaModificacion  ));
            claseNc .Periodo =Convert .ToInt32 ( gvConsultaNomina .GetFocusedRowCellValue(colPeriodo ));
            claseNc .Total =Convert .ToDouble  ( gvConsultaNomina .GetFocusedRowCellValue(colTotal ));
            claseNc.IdEstado =Convert .ToInt32 ( gvConsultaNomina .GetFocusedRowCellValue(colIdEstado ));
            claseNc .IdEmpresa =  Convert .ToInt32 ( gvConsultaNomina .GetFocusedRowCellValue(colIdEmpresa));
            claseNc .Observacion =Convert.ToString  ( gvConsultaNomina .GetFocusedRowCellValue(colObservacion  ));

         


        }
        #endregion
        private void frmPConsultaNomina_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        #region Botones
        private void tsbConsultado_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        #endregion

       
    }
}
