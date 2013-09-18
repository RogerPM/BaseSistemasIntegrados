using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.ActivoFijo
{
    public partial class mntCodigoBarra : Form
    {
        public mntCodigoBarra()
        {
            InitializeComponent();
        }

        public Boolean Temp { get; set; }

        private void mntCodigoBarra_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SentidoLectur()
        {
            if (cbxSentidoLectura.SelectedIndex == 0)
            {
                Temp = true;
            }
            else
            {
                if (cbxSentidoLectura.SelectedIndex == 1)
                    Temp = false;

            }
        }
    }
}
