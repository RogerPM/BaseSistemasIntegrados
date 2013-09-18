using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms._Otro;

namespace forms
{
    public partial class Practica : Form
    {
        public Practica()
        {
            InitializeComponent();
        }

        private void Practica_Load(object sender, EventArgs e)
        {
            UCMenuTreeLsto uc = new UCMenuTreeLsto();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            
        }
    }
}
