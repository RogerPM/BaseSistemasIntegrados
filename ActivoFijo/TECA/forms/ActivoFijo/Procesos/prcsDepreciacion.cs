using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.ActivoFijo.UseControl;

namespace forms.ActivoFijo.Procesos
{
    public partial class prcsDepreciacion : Form
    {
        public prcsDepreciacion()
        {
            InitializeComponent();
        }

        private void prcsDepreciacion_Load(object sender, EventArgs e)
        {
            userPrincipal frm = new userPrincipal();
            pnlCargar.Controls.Add(frm);
        }
    }
}
