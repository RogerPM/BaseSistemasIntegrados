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
    public partial class VtnConsultaSubgrupo : Form
    {
        public clsSubgrupoActivoFijo cls;
        public Boolean seleccion;//Esta variable sera para ver si el cancelar ha sido selecionado 

        public VtnConsultaSubgrupo()
        {
            InitializeComponent();
        }


        private void VtnConsultaSubgrupo_Load(object sender, EventArgs e)
        {
            seleccion = true;
            cargar();
        }

        #region "Funciones de Programa"
        public void cargar()
        {
            clsClaseDatosSubgrupoActivoFijo clas = new clsClaseDatosSubgrupoActivoFijo();
            GridConsultaGrupo.DataSource = clas.consulta();
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



        public void get(clsSubgrupoActivoFijo clasperso)
        {
            clasperso.Codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));
            clasperso.Grupo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colGrupo));
            clasperso.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldescripcion));
            clasperso.Fecha = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFecha));
            clasperso.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));
            clasperso.Empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));

        }


        #endregion


        #region "Funciones del Grid"
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);//Aqui lo que hace es pasar los datos de la pantalla consulta a la variable de la calse
            //de SUbgrupo con la ayuda de la variable cls la cual  se les
            //pasa todos los datos que posee el gridView al momento de dar clic en la operacion 
            //GridView_RowClick en la funcion GetROw(....)
            Close();
        }

        private clsSubgrupoActivoFijo getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsSubgrupoActivoFijo)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {

                return null;
            }

        }

        private void GridConsultaGrupo_Click(object sender, EventArgs e)
        {

        }


        #endregion

    }
}
