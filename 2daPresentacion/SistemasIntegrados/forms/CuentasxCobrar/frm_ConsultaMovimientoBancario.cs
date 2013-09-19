using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.CuentasxCobrar;
using datos.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_ConsultaMovimientoBancario : Form
    {
        public clsMovimientobancario mb = new clsMovimientobancario();

        public frm_ConsultaMovimientoBancario()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            clsDatosMovimientoBancario datos = new clsDatosMovimientoBancario();
            gdcMovimientoBancario.DataSource = datos.consulta();
        }

        private void tsbOK_Click(object sender, EventArgs e)
        {
            getseleccion();
            this.Close();            

        }

        public void getseleccion()
        {
            mb.idMovimientoBancario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdmovimiento));
            mb.idTransaccion = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTransaccion));
            mb.idBanco = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdBanco));
            mb.NumeroDocumento = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colnumero));
            mb.Observacion = Convert.ToString(gridView1.GetFocusedRowCellValue(colobservacion));
            mb.Fecha = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFecha));
            mb.FechaModificacion = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colFechaModificacion));
            mb.Valor = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colValor));
            mb.idEstado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEstado));
        }

        private void FrmConsultaMovimientoBancario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {   

        }
    }
}
