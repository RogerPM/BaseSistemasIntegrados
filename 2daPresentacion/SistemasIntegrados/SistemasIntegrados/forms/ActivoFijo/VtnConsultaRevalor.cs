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
    public partial class VtnConsultaRevalor : Form
    {
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 
        public clsRevalorizacion cls;

        public VtnConsultaRevalor()
        {
            InitializeComponent();
        }

        private void VtnConsultaRevalor_Load(object sender, EventArgs e)
        {
            seleccion = true;
            cargar();
        }

        public void cargar()
        {
            clsClaseDatosRevalorizacion clas = new clsClaseDatosRevalorizacion();
            GridConsultaRevaloriza.DataSource = clas.consulta();
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }

        private clsRevalorizacion getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsRevalorizacion)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {

                return null;
            }
        }



    }
}
