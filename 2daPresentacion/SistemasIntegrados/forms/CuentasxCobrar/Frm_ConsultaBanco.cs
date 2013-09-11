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
    public partial class Frm_ConsultaBanco : Form
    {

        public clsBanco banc = new clsBanco();
        public Frm_ConsultaBanco()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            clsDatosBanco datos = new clsDatosBanco();
            gdcBanco.DataSource = datos.consultaBancoGeneral();
        }
        private void tsbOk_Click(object sender, EventArgs e)
        {
            getseleccion();
            this.Close();
        }
      

        public void getseleccion()
        {
            banc.idBanco = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidBanco));
            banc.Nombre = Convert.ToString(gridView1.GetFocusedRowCellValue(colNombre));
            banc.idEmpresa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdEmpresa));
            //banc.idestado = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidestado));
            //banc.idUsuario = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colidUsuario));

        }

        private void Frm_ConsultaBanco_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

    }
}
