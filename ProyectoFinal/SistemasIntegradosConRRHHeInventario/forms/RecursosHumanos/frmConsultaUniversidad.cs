using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.RecursosHumanos;
using clases.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaUniversidad : Form
    {

        public clsUniversidad un = new clsUniversidad();   
        public frmConsultaUniversidad()
        {
            InitializeComponent();
        }

        private void frmMConsultaUniversidad_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            clsDatosUniversidad universidad = new clsDatosUniversidad();
            gdcUniversidad.DataSource = universidad.ConsultaUniversidad();
        }

        public void getSeleccion()
        {
            un.IdUniversidad = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUniversidad));
            un.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            un.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));

        }
        

        private void tsbConsultado_Click_1(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        private void gdcUniversidad_Click(object sender, EventArgs e)
        {

        }



    }
}
