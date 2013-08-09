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
    public partial class frmConsultaDepartamento : Form
    {

        public clsDepartamento de = new clsDepartamento();   
        public frmConsultaDepartamento()
        {
            InitializeComponent();
        }

        private void frmMConsultaDepartamento_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            clsDatosDepartamento departamento = new clsDatosDepartamento();
            gdcConsultaDepartamento.DataSource = departamento.ConsultaDepartamento();
        }

        public void getSeleccion()
        {
            de.IdDepartamento = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdDepartamento));
            de.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            de.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));

        }

        private void tsbConsultado_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }


    }
}
