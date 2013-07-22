using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//otros
using datos.Seguridad;
using clases.Seguridad;

namespace forms.Seguridad
{
    public partial class FrmConsultar : Form
    {
        public clsEmpresa e = new clsEmpresa();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datEmpresa datEmp = new datEmpresa();
            gridControl1.DataSource = datEmp.Consultar();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void getSeleccion()
        {
            e.idEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEmpresa));
            e.razonSocial = Convert.ToString(gridView1.GetFocusedRowCellValue(colrazonSocial));
            e.nombreComercial = Convert.ToString(gridView1.GetFocusedRowCellValue(colnombreComercial));
            e.ruc = Convert.ToString(gridView1.GetFocusedRowCellValue(colruc));
            e.direccion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldireccion));
            //e.idImagen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidImagen));
            e.logo = Convert.ToString(gridView1.GetFocusedRowCellValue(collogo));
            e.fondo = Convert.ToString(gridView1.GetFocusedRowCellValue(colfondo));
          //  e.logotipo=gridView1.GetFocusedRowCellValue(collogotipo);
            e.fechaInicioSistema = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colfechaInicioSistema));
            e.correo = Convert.ToString(gridView1.GetFocusedRowCellValue(colcorreo));
            e.sitioWeb = Convert.ToString(gridView1.GetFocusedRowCellValue(colsitioWeb));
            e.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldescripcion));
            e.idEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEstado));
        }

    }
}
