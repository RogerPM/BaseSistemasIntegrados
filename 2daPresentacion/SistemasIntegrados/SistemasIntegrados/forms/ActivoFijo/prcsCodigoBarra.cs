using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using datos.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class prcsCodigoBarra : Form
    {
        clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();
        clsClaseDatosCodigoBarra datoCodBarra = new clsClaseDatosCodigoBarra();
        public prcsCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prcsCodigoBarra_Load(object sender, EventArgs e)
        {
            GDActFij.DataSource = datoActivo.consulta();
            GDCodBarra.DataSource = datoCodBarra.consulta();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo Codigo");
            MessageBox.Show("Impresion Terminada");
            this.Close();
        }


    }
}
