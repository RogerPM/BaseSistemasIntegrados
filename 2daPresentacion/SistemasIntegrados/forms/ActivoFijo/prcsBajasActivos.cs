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
    public partial class prcsBajasActivos : Form
    {
        public prcsBajasActivos()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prcsBajasActivos_Load(object sender, EventArgs e)
        {
            userPrincipal clss = new userPrincipal();
            pnlCargar.Controls.Add(clss);
        }
    }
}
