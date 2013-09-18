using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using clases.Seguridad;
using datos.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaTipoPermiso : Form
    {
        public clsTipoPermiso tiP = new clsTipoPermiso();
        public frmConsultaTipoPermiso()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            clsDatosTipoPermiso titulo = new clsDatosTipoPermiso();
            gdcConsultaTipoPermiso.DataSource = titulo.ConsultaTipoPermiso();
        }

        private void frmConsultaTipoPermiso_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void getSeleccion()
        {
            tiP.IdTipoPermiso = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoPermiso));
            tiP.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion));
            tiP.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            tiP.IdEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }

        private void tsConsultaTipoPermiso_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            getSeleccion();
            this.Close();
        }

    }
}
