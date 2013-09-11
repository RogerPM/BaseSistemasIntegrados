using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using datos.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class VtnConsultaDepreciacion : Form
    {
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 
        public clsDepreciacion cls;

        public VtnConsultaDepreciacion()
        {
            InitializeComponent();
        }

        private void VtnConsultaDepreciacion_Load(object sender, EventArgs e)
        {

            seleccion = true;
            cargar();
        }

        public void cargar()
        {
            clsClaseDatosDepreciacion clas = new clsClaseDatosDepreciacion();
            GridDepreciacion.DataSource = clas.consultaDepreciacionDet();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccion = false;
            Cancelar();
        }
        public void getForDepreciacion(clsActivoFijo clasActivoFIjo)
        {
            clasActivoFIjo.Codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colActivoFijo));
            clasActivoFIjo.valor_actualserie = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colActivoFijo));
        }

        public Boolean Cancelar()
        {
            if (seleccion == true)
            {
                return seleccion;
            }
            else
            {
                this.Close();
                return seleccion;
            }
        }

        private clsDepreciacion getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsDepreciacion)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }



    }
}
