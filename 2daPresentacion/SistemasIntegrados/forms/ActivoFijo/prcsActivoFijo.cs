using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using clases.Inventario;
using clases.Seguridad;
using datos.ActivoFijo;
using datos.Inventario;
using datos.Seguridad;

namespace forms.ActivoFijo
{
    public partial class prcsActivoFijo : Form
    {
        clsClaseDatosSubgrupoActivoFijo datoSubgrupo = new clsClaseDatosSubgrupoActivoFijo();
        datGrupo datGrupo = new datGrupo();
        clsClaseDatosBajaActivo datoProvePerso = new clsClaseDatosBajaActivo();
        datEstado datoEstado = new datEstado();
        datEmpresa datoEmpresa = new datEmpresa();

        DetArticulo frm = new DetArticulo();
        DetVehiculo frm1 = new DetVehiculo();
        DetMueblesEnseres frm2 = new DetMueblesEnseres();
        DetEdificios frm3 = new DetEdificios();
        DetTerrenos frm4 = new DetTerrenos();
        DetMaquinariasEquipos frm5 = new DetMaquinariasEquipos();


        public prcsActivoFijo()
        {
            InitializeComponent();
        }

        private void prcsActivoFijo_Load(object sender, EventArgs e)
        {
            //Llenamos el combo grupo de inventario en la pantalla 
            // cbxGrupo.Properties.DataSource = datGrupo.consulta();

            //Llenamos el combo de Estado de Seguridad en la pantalla
            cbxEstado.Properties.DataSource = datoEstado.ConsultaTodos();

            //Llenamos el combo de Empresa de Seguridad en la pantalla
            cbxEmpresa.Properties.DataSource = datoEmpresa.Consultar();

            //llenamos el combo de Subgrupo de ActivoFijo en la pantalla
            cbxSubGrupo.Properties.DataSource = datoSubgrupo.consulta();

            //llenamos el combo de la Persona que es Proveedor
            //cbxProveedor.Properties.DataSource = datoProvePerso.consultaEspecial();
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
            pnlCargar.Controls.Remove(frm);
            pnlCargar.Controls.Remove(frm1);
            pnlCargar.Controls.Remove(frm2);
            pnlCargar.Controls.Remove(frm3);
            pnlCargar.Controls.Remove(frm4);
            pnlCargar.Controls.Remove(frm5);

            switch (num)
            {

                case 0:

                    pnlCargar.Controls.Add(frm);
                    break;

                case 1:

                    pnlCargar.Controls.Add(frm1);
                    break;

                case 2:

                    pnlCargar.Controls.Add(frm2);

                    break;
                case 3:

                    pnlCargar.Controls.Add(frm3);
                    break;

                case 4:

                    pnlCargar.Controls.Add(frm4);

                    break;
                case 5:

                    pnlCargar.Controls.Add(frm5);

                    break;
                case 6:

                    pnlCargar.Controls.Add(frm5);

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
