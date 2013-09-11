using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.ActivoFijo;
using clases.ActivoFijo;
using clases.Inventario;

namespace forms.ActivoFijo
{
    public partial class VtnConsultaTipoBaja : Form
    {
        public clsBajaActivo cls;
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 


        public VtnConsultaTipoBaja()
        {
            InitializeComponent();
        }

        private void VtnConsultaTipoBaja_Load(object sender, EventArgs e)
        {
            seleccion = true;
            cargar();
        }

        #region "Funciones de Programa"
        public void cargar()
        {
            clsClaseDatosActivoFijo clas = new clsClaseDatosActivoFijo();
            gridConsultaTipoBaja.DataSource = clas.consulta();
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

        public void get(clsBajaActivo clasBajActi)
        {
            clasBajActi.ActivoFIjo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));
        }


        #endregion

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }



        private clsBajaActivo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsBajaActivo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {

                return null;
            }

        }




    }
}
