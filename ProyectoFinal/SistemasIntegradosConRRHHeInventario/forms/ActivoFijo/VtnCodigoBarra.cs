using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;


namespace forms.ActivoFijo
{
    public partial class VtnCodigoBarra : Form
    {
        public VtnCodigoBarra()
        {
            InitializeComponent();
        }

        private void VtnCodigoBarra_Load(object sender, EventArgs e)
        {

        }


        public void cargar()
        {
            //clsClaseDatosCodigoBarra clas = new clsClaseDatosCodigoBarra ();
            // GridConsultaCodigoBarra.DataSource = clas.consulta();
        }
    }
}
