using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Inventario;
using datos.Seguridad;
using datos.RecursosHumanos;

namespace forms.Inventario
{
    public partial class frmTransferenciaBodega : Form
    {
        public frmTransferenciaBodega()
        {
            InitializeComponent();
        }

        private void frmTransferenciaBodega_Load(object sender, EventArgs e)
        {
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
            datBodega data2 = new datBodega();
            cbxOrigen.Properties.DataSource = data2.consulta();

        }
    }
}
