using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_Busqueda : Form
    {
        public DataGridViewRow FilaSeleccionada { get; set; }
        public Boolean Seleccion = false;

        public frm_Busqueda()
        {
            InitializeComponent();
        }

        private void frm_busquedaBanco_Load(object sender, EventArgs e)
        {
            this.dgvBusqueda.ReadOnly = true;
        }
        
        public void CargarBanco(List<object> Lista) 
        {
            dgvBusqueda.DataSource= Lista;
        }

        public void EstablecerPropiedades(String Titulo, String[] NombresColumnas)
        {
            int a = 0;
            this.Text = Titulo;
            while (a < NombresColumnas.Length)
            {
                dgvBusqueda.Columns[a].HeaderText = NombresColumnas[a];
                a = a + 1;
            }
         }

        public void OcultarColumna(int Columna)
        {
            dgvBusqueda.Columns[Columna].Visible = false;
        }

        private void grdConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Seleccion = true;
            this.FilaSeleccionada = dgvBusqueda.CurrentRow;
            this.Close();
        }
     }
}
