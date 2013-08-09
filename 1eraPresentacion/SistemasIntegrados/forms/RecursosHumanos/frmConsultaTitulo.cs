using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using clases.Seguridad;
using datos.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaTitulo : Form
    {

        public clsTitulo tit = new clsTitulo();

        public frmConsultaTitulo()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            clsDatosTitulo titulo = new clsDatosTitulo();
            gdcConsultaTitulo.DataSource =titulo.ConsultaTitulo();
        }

        private void frmMConsultaTitulo_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        public void getSeleccion()
        {
            tit.IdTitulo= Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTitulo));
            tit.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));
            tit.FechaInicio = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaInicio));
            tit.FechaInicio = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaFinal));
            tit.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            tit.IdUniversidad = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUniversidad));
            tit.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
        }
        

        private void tsbConsultado_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }
    }
}
