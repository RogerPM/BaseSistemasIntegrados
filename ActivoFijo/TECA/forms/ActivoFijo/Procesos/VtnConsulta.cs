using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;
namespace forms.ActivoFijo.Mantenimiento
{
    public partial class VtnConsulta : Form
    {
        public VtnConsulta()
        {
            InitializeComponent();
        }

        private void VtnConsulta_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            
 
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
