using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using clases.RecursosHumanos;
using datos.Seguridad;
using datos.RecursosHumanos;
namespace forms.Seguridad
{
    public partial class frmConsultaGeneral : Form
    {
        public clsPersona oPersona = new clsPersona();
        public frmConsultaGeneral()
        {
            InitializeComponent();
        }                        
        private void frmConsultaGeneral_Load(object sender, EventArgs e)
        {
            LlenarGrid();       
        }
        public void LlenarGrid(){
            try
            {                
                clsDatosPersona datPer = new clsDatosPersona();
                gcConsulta.DataSource = datPer.ConsultaPersona();                
            }
            catch (Exception)
            {
                MessageBox.Show("No Hay registros", "Información", MessageBoxButtons.OK);
            }
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            
        }
        private clsPersona getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsPersona)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            oPersona = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }
    }
}
