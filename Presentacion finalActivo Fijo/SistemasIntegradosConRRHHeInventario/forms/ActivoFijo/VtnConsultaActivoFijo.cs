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
    public partial class VtnConsultaActivoFijo : Form
    {
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 
        public clsActivoFijo cls;

        public VtnConsultaActivoFijo()
        {
            InitializeComponent();
        }

        private void VtnConsultaActivoFijo_Load(object sender, EventArgs e)
        {
            seleccion = true;
            cargar();
        }

        public void cargar()
        {
            clsClaseDatosActivoFijo clas = new clsClaseDatosActivoFijo();
            gridConsultaActivoFijo.DataSource = clas.consulta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccion = false;
            Cancelar();
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

        public void getForRevalorizaion(clsActivoFijo clasActivoFIjo)
        {
            clasActivoFIjo.Codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));
            clasActivoFIjo.valor_actualserie = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colvalor_actualserie));
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsActivoFijo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsActivoFijo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
