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
    public partial class prcsActivoFijo : Form
    {
        public prcsActivoFijo()
        {
            InitializeComponent();
        }

        private void prcsActivoFijo_Load(object sender, EventArgs e)
        {

        }

        private void pnlCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            prcsResponsables clss = new prcsResponsables();
            clss.ShowDialog();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

            var num = cbxGrupo.SelectedIndex;
            switch (num)
            {
                case 0: DetArticulo frm = new DetArticulo();
                    pnlCargar.Controls.Add(frm);
                    break;

                case 1: DetVehiculo frm1 = new DetVehiculo();
                    pnlCargar.Controls.Add(frm1);
                    break;

                case 2: DetMueblesEnseres frm2 = new DetMueblesEnseres();
                    pnlCargar.Controls.Add(frm2);
                    break;

                case 3: DetEdificios frm3 = new DetEdificios();
                    pnlCargar.Controls.Add(frm3);
                    break;

                case 4: DetTerrenos frm4 = new DetTerrenos();
                    pnlCargar.Controls.Add(frm4);
                    break;

                case 5: DetMaquinariasEquipos frm5 = new DetMaquinariasEquipos();
                    pnlCargar.Controls.Add(frm5);
                    break;

                case 6: DetMaquinariasEquipos frm6 = new DetMaquinariasEquipos();
                    pnlCargar.Controls.Add(frm6);
                    break;
                default: break;
            }
        }

        private void btnGenerarCodBarra_Click(object sender, EventArgs e)
        {
            prcsCodigoBarra frm = new prcsCodigoBarra();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
