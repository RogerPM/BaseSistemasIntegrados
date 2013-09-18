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
    public partial class frmConsultarTipoTrabajo : Form
    {
        public clsTiposTrabajos e = new clsTiposTrabajos();
        public frmConsultarTipoTrabajo()
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
            e.idTipoTrabajo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidTipoTrabajo));
            e.Descripcion= Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            e.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colObservacion));
            e.idEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidEstado));
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            datTiposTrabajos datTipoTrabajo = new datTiposTrabajos();
            gridControl1.DataSource = datTipoTrabajo.Consultar();
        }
    }
}
