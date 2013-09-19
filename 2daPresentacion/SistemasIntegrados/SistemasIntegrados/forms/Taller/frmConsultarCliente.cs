using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Taller;
using clases.Taller;

namespace forms.Taller
{
    public partial class frmConsultarCliente : Form
    {
        public clsCliente e = new clsCliente();
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        public void getSeleccion()
        {
            e.IdPersona = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdPersona));
            e.Identificacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colIdentificacion));
            e.IdTipoPersona = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoPersona));
            e.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));
            e.Apellido = Convert.ToString(gridView1.GetFocusedRowCellValue(colApellido));
            e.FechaNacimiento = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaNacimiento));
            e.Genero = Convert.ToString(gridView1.GetFocusedRowCellValue(colGenero));
            e.TipoIdentificacion = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoIdentificacion));
            e.Direccion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDireccion));
            e.Telefono = Convert.ToString(gridView1.GetFocusedRowCellValue(colTelefono));
            e.Mail = Convert.ToString(gridView1.GetFocusedRowCellValue(colMail));
            e.idEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEstado));
            e.idEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEmpresa));
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datCliente odatCliente = new datCliente();
            gridControl1.DataSource = odatCliente.Consultar();
        }
    }
}
