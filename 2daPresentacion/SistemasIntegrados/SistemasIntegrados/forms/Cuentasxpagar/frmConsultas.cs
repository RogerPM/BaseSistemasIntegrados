using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmConsultas : DevExpress.XtraEditors.XtraForm
    {
        clsEmpresaServicio empserv = new clsEmpresaServicio();
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            clsEmpresaServicioDAT1 consulta = new clsEmpresaServicioDAT1();
            gdcConsulta.DataSource = consulta.ConsultaEmpresaServicio();
        }

         public clsEmpresaServicio GetSelection()
         {
             empserv._IdEmpresa = Convert.ToInt32(gdvConsulta.GetFocusedRowCellValue(col_IdEmpresa));
             empserv._IdEmpresaServicio = Convert.ToString(gdvConsulta.GetFocusedRowCellValue(col_IdEmpresaServicio));
             empserv._RazonSocial = Convert.ToString(gdvConsulta.GetFocusedRowCellValue(col_RazonSocial));
             empserv._FechaRegistro = Convert.ToDateTime(gdvConsulta.GetFocusedRowCellValue(col_FechaRegistro));
             empserv._TipoPersona = Convert.ToInt32(gdvConsulta.GetFocusedRowCellValue(col_TipoPersona));
             empserv._Direccion = Convert.ToString(gdvConsulta.GetFocusedRowCellValue(col_Direccion));
             empserv._Email = Convert.ToString(gdvConsulta.GetFocusedRowCellValue(col_Email));

             return empserv;
         }

         private void tsbAceptar_Click(object sender, EventArgs e)
         {
             GetSelection();
             this.Close();
         }
    }
}