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
    public partial class frmConsultaTipoPrestamo : Form
    {
        public clsTipoPrestamo mp = new clsTipoPrestamo(); 
        public frmConsultaTipoPrestamo()
        {
            InitializeComponent();
        }

        private void frmConsultaTipoPrestamo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            clsDatosTipoPrestamo prestamo = new clsDatosTipoPrestamo();
            gdcTipoPrestamo.DataSource = prestamo.consultaTipoPrestamo (); 
        }

        public void getSeleccion()
        {
            mp.IdTipoPrestamo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoPrestamo));
            mp.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));
            mp.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            mp.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }

       

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }
        

    }
}
