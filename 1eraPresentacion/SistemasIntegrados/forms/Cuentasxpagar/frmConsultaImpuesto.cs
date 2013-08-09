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
    public partial class frmConsultaImpuesto : Form
    {
        public clsImpuesto mp = new clsImpuesto();
        public frmConsultaImpuesto()
        {
            InitializeComponent();
        }
       

        public void cargar()
        {

            datosImpuesto Impu = new datosImpuesto();
            gdcConsultaImpuesto.DataSource = Impu.consulta();

        }

       

        public void  getSeleccion()
        {
            mp.IdImpuesto = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdImpuesto ));
            mp.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion ));
            mp.Porcentaje =Convert.ToDouble (gridView1.GetFocusedRowCellValue(colPorcentaje ));
            mp.FechaRegistro = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaRegistro));
            mp.Estado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
            mp.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            mp.IdUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdUsuario));
          

           
        }

      

        private void tsbOk_Click_1(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        
        private void frmConsultaImpuesto_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     
       
       
    }
}
