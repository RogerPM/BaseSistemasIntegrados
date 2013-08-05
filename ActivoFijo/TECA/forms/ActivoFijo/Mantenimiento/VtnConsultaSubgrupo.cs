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

namespace forms.ActivoFijo.Mantenimiento
{
    public partial class VtnConsultaSubgrupo : Form
    {
        public clsSubgrupoActivoFijo cls;
        public VtnConsultaSubgrupo()
        {
            InitializeComponent();
        }
       

        private void VtnConsultaSubgrupo_Load(object sender, EventArgs e)
        {
            cargar();
        }


        public void cargar()
        {
           clsClaseDatosSubgrupoActivoFijo  clas = new clsClaseDatosSubgrupoActivoFijo();
           GridConsultaGrupo.DataSource = clas.consulta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      //  clsSubgrupoActivoFijo clasperso = new clsSubgrupoActivoFijo();

        public void get(clsSubgrupoActivoFijo clasperso)
        {
            clasperso.Codigo =Convert.ToInt32 (gridView1 .GetFocusedRowCellValue(colCodigo));
            clasperso.Grupo  = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colGrupo));
            clasperso.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldescripcion));
            clasperso.Fecha = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFecha));
            clasperso.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));
            clasperso.Empresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colCodigo));

        }
        
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //mntActivoFIjo frm = new mntActivoFIjo();
            //get();
            //frm.clas = clasperso;//raro
            //frm.accion = 'M';
            //frm.ShowDialog();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls=getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
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


    }
}
