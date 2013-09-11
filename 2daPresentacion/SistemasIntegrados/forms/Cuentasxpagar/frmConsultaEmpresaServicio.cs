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
            Es.IdEmpresaServicio = Convert.ToString (gridView1.GetFocusedRowCellValue(colIdEmpresaServicio));
            Es.fechaRegistro= Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colfechaRegistro));
            Es.RazonSocial= Convert.ToString(gridView1.GetFocusedRowCellValue(colRazonSocial));
            Es.Direccion=Convert.ToString(gridView1.GetFocusedRowCellValue(colDireccion));
            Es.email=Convert.ToString(gridView1.GetFocusedRowCellValue(colemail));
            Es.webpage=Convert.ToString(gridView1.GetFocusedRowCellValue(colwebpage));
            Es.Estado=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            Es.IdTipoPersona=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoPersona));
            Es.IdEmpresa=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            Es.IdUsuario=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
                    
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
