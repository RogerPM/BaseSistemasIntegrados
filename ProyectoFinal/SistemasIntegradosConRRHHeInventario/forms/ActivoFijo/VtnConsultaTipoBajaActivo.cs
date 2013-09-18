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
    public partial class VtnConsultaTipoBajaActivo : Form
    {
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 
        public clsMotivoBaja cls;


        public VtnConsultaTipoBajaActivo()
        {
            InitializeComponent();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void VtnConsultaTipoBajaActivo_Load(object sender, EventArgs e)
        {
            seleccion = true;
            cargar();
        }

        public void cargar()
        {
            datosmotivobaja clas = new datosmotivobaja();
            gridConsultaTipoBajaActivo.DataSource = clas.Consultar();
        }

         private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccion = false;
            Cancelar();
        }

       

        public void getForRevalorizaion(clsMotivoBaja clasMotivoBaja)
        {
            clasMotivoBaja.idMotivoBaja = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidMotivoBaja));
            
        }


         private void btnCancelar_Click_1(object sender, EventArgs e)
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
         private clsMotivoBaja getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
         {
             try
             {
                 return (clsMotivoBaja)view.GetRow(view.FocusedRowHandle);
             }
             catch (Exception)
             {

                 return null;
             }
         }

         private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
         {
             cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
             Close();
         }



    }
}
