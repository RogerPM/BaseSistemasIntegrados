using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Cuentasxpagar;
using datos.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmConsultaEmpresaServicio : Form
    {
        public clsEmpresaServicio Es = new clsEmpresaServicio();

        public frmConsultaEmpresaServicio()
        {
            InitializeComponent();
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();


        }
        public void getSeleccion()
        {
            Es._IdEmpresaServicio = Convert.ToString(gridView1.GetFocusedRowCellValue(colIdEmpresaServicio));
            Es._FechaRegistro = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colfechaRegistro));
            Es._RazonSocial = Convert.ToString(gridView1.GetFocusedRowCellValue(colRazonSocial));
            Es._Direccion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDireccion));
            Es._Email = Convert.ToString(gridView1.GetFocusedRowCellValue(colemail));
            Es._Website = Convert.ToString(gridView1.GetFocusedRowCellValue(colwebpage));
            Es._Estado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            Es._TipoPersona = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoPersona));
            Es._IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            Es._IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
                    
        }

        private void frmConsultaEmpresaServicio_Load(object sender, EventArgs e)
        {
            cargar();

        }
        public void cargar()
        {
            datosEmpresaServicio EmpSer = new datosEmpresaServicio();
            gdcEmpresaServicio.DataSource = EmpSer.consulta();



        }


    }
}
