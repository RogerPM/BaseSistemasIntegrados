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
    public partial class frmConsultaMaternidad : Form
    {

        public clsMaternidad mat = new clsMaternidad();

        public frmConsultaMaternidad()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            clsDatosMaternidad maternidad = new clsDatosMaternidad();
            gdcConsultaMaternidad.DataSource = maternidad.ConsultaMaternidad();
        }
        private void frmMConsultaMaternidad_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void getSeleccion()
        {
            mat.NumMaternidad = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNumMaternidad));
            mat.IdEmpleado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpleado));
            mat.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            mat.FechaParto = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaParto));
            mat.FechaInicio = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaInicio));
            mat.FechaInicio = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaFin));
            mat.FechaModificacion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaModificacion));
            mat.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            
            
        }

        private void tsbConsultado_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }
    }
}
