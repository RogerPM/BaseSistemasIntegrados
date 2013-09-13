using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Contabilidad;

namespace forms.Contabilidad
{
    public partial class frmBusquedaComprobante : Form
    {
        public frmBusquedaComprobante()
        {
            InitializeComponent();
        }
        public string NumCom { get; set; }
        private void frmBusquedaComprobante_Load(object sender, EventArgs e)
        {
            clsDatoComprobante dat = new clsDatoComprobante();
            gcConsulta.DataSource = dat.ListaCom();
        }

        private void gcConsulta_Click(object sender, EventArgs e)
        {

        }

        private void gvConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                NumCom = Convert.ToString(gvConsulta.GetFocusedRowCellValue(colnumero_comprobante));
                this.Close();
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
