using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using datos.Compras;
using System.IO;

namespace forms.Compras
{
    public partial class frmConsultaArticulo : Form
    {

        public static int id_tipo_articulo;
        public static int grupo;
        public static int id_articulo;
        public static string nombre_articulo;
        public static int id_empresa;
        public static string nombre_empresa;
        


        public frmConsultaArticulo()
        {
            InitializeComponent();
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            LlenaGrupo(id_tipo_articulo);
            if (id_tipo_articulo != 4)
            {
                lblsubgrupo.Visible = false;
                cbxSubgrupo.Visible = false;
            }
            //LenarSubgrupo(id_tipo_articulo);
        }

        private void LlenaGrupo(int tipo_articulo)
        {
            datcompras_grupo grupos = new datcompras_grupo();
            cbxgrupo.Properties.DataSource = grupos.ListarGrupos(tipo_articulo);
        }

        private void LlenaSubgrupo(int tipo_articulo)
        {
            datcompras_grupo grupos = new datcompras_grupo();
            //cbxgrupo.Properties.DataSource = grupos.ListarSubgrupo(tipo_articulo);
            
        }

        private void cbxgrupo_EditValueChanged(object sender, EventArgs e)
        {
            datcompras_articulo articulo = new datcompras_articulo();
            int grupo1 = Convert.ToInt32(cbxgrupo.Properties.View.GetFocusedRowCellValue(colidGrupo));
            grupo = grupo1;
            dtg_articulo.DataSource = articulo.ListarArticulos(grupo1);

        }

        private void dtg_articulo_Click(object sender, EventArgs e)
        {
            id_articulo = Convert.ToInt32(listaarticulo_datos.GetFocusedRowCellValue(colidarticulo));
            nombre_articulo = Convert.ToString(listaarticulo_datos.GetFocusedRowCellValue(coldescripcion));
            id_empresa = Convert.ToInt32(listaarticulo_datos.GetFocusedRowCellValue(colid_empresa));
            nombre_empresa = Convert.ToString(listaarticulo_datos.GetFocusedRowCellValue(colNombreComercial));
            Dispose();
        }


    }
}
