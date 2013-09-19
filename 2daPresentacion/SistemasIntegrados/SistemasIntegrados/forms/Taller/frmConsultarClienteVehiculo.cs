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
    public partial class frmConsultarClienteVehiculo : Form
    {
        public clsConsultaClienteP e = new clsConsultaClienteP();
        public frmConsultarClienteVehiculo()
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
            e.IdArticulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdArticulo));
            e.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));
            e.Apellido = Convert.ToString(gridView1.GetFocusedRowCellValue(colApellido));
            e.NroPlaca = Convert.ToString(gridView1.GetFocusedRowCellValue(colNroPlaca));
            e.Marca = Convert.ToString(gridView1.GetFocusedRowCellValue(colMarca));
            e.Modelo = Convert.ToString(gridView1.GetFocusedRowCellValue(colModelo));
        }

        public void FillGrid()
        {
            datPresupuesto odatPresupuesto = new datPresupuesto();
            gridControl1.DataSource = odatPresupuesto.ConsultarCliente();
        }

        private void frmConsultarPlaca_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
