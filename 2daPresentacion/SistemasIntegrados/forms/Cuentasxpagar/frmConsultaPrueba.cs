using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmConsultaPrueba : Form
    {
        public frmConsultaPrueba()
        {
            InitializeComponent();
        }

        private void frmConsultaPrueba_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            datosPagoDetalle  frepagos = new datosPagoDetalle ();

            gdclocura .DataSource = frepagos.consulta();

        }
    }
}
