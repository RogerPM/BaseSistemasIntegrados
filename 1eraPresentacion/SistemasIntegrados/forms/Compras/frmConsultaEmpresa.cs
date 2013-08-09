using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Compras
{
    public partial class frmConsultaEmpresa : Form
    {
        public static string nombre_empresa = "";
        public static int id_empresa = 0;

        public frmConsultaEmpresa()
        {
            InitializeComponent();
        }

        private void frmConsultaEmpresa_Load(object sender, EventArgs e)
        {
            datos.Seguridad.datEmpresa oEmpresa = new datos.Seguridad.datEmpresa();
            List<clases.Seguridad.clsEmpresa> listaEmpresa = new List<clases.Seguridad.clsEmpresa>();
            listaEmpresa = oEmpresa.Consultar();
            dtgEmpresa.DataSource = listaEmpresa;   
        }

        private void dtgEmpresa_Click(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(EmpresaDatos.SelectedRowsCount) >= 1)
            {
                nombre_empresa = Convert.ToString(EmpresaDatos.GetFocusedRowCellValue(colnombreComercial));
                id_empresa = Convert.ToInt32(EmpresaDatos.GetFocusedRowCellValue(colidEmpresa));

            }
            Dispose();
        }
    }
}
