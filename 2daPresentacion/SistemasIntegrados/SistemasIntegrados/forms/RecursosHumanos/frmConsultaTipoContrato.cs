using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.RecursosHumanos;
using clases.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmConsultaTipoContrato : Form
    {
        public clsTipoContrato un = new clsTipoContrato();
        public frmConsultaTipoContrato()
        {
            InitializeComponent();
        }

        private void frmConsultaTipoContrato_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            clsDatosTipoContrato contrato = new clsDatosTipoContrato();
            gdcTipoContrato.DataSource = contrato.ConsultaTipoContrato();
        }

        public void getSeleccion()
        {
            un.IdTipoContrato = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTipoContrato ));
            un.Descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(colDescripcion ));
            un.Periodo = Convert.ToString(gridView1.GetFocusedRowCellValue(colPeriodo ));
            un.IdEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa ));
            un.IdEstado  = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado ));
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }


       
    }
}
