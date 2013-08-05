using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.ActivoFijo.Mantenimiento
{
    public partial class mntCodigoBarra : Form
    {
        public mntCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mntCodigoBarra_Load(object sender, EventArgs e)
        {

        }

        private void dtFormato_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            if (bandera ==0)
	        {
                HabilitaMetodoUno();
                bandera = 1;
	        }else{
                HabilitaMetodoDos();
                bandera = 0;
	        }

        }

        public void HabilitaMetodoUno()
        {
            txtFormato.Enabled = true;
            dtFormato.Enabled = false;
        }

        public void HabilitaMetodoDos()
        {
            txtFormato.Enabled = false ;
            dtFormato.Enabled = true;
        }

    }
}
