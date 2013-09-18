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
    public partial class frmConsultaCargo : Form
    {
        public clsCargo mp = new clsCargo();
        public frmConsultaCargo()
        {
            InitializeComponent();
        }

        private void frmConsultaCargo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {

            clsDatosCargo  cargo = new clsDatosCargo ();
            gdcConsultaCargo.DataSource = cargo.ConsultaCargo();

        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void getSeleccion()
        {
            mp.IdCargo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdCargo));
            mp.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            mp.Sueldo = Convert.ToDouble(gridView1.GetFocusedRowCellValue(colSueldo));
            mp.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
           

        }

    }
}
