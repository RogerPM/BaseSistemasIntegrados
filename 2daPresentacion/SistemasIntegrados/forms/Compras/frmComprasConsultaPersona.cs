using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using datos.Compras;

namespace forms.Compras
{
    public partial class frmComprasConsultaPersona : Form
    {
        public static string razonsocial = "";
        public static int id_persona = 0;


        public frmComprasConsultaPersona()
        {
            InitializeComponent();
        }

        private void dtgPersona_Click(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(PersonaDatos.SelectedRowsCount) >= 1)
            {
                razonsocial = Convert.ToString(PersonaDatos.GetFocusedRowCellValue(colNombreRazonSocial));
                id_persona = Convert.ToInt32(PersonaDatos.GetFocusedRowCellValue(colIdPersona));

            }
            this.Close();
            //Dispose();
        }

        private void frmComprasConsultaPersona_Load(object sender, EventArgs e)
        {
            datos.Compras.datComprasPersona oPersona = new datos.Compras.datComprasPersona();
            List<clases.Compras.clsComprasPersona> listaPersona = new List<clases.Compras.clsComprasPersona>();
            listaPersona = oPersona.ConsultarPersona();
            dtgPersona.DataSource = listaPersona;   
        }
    }
}
