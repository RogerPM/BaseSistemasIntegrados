using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using datos.Seguridad;
using datos.RecursosHumanos;
namespace forms.Seguridad
{
    public partial class frmConsultaGeneral : Form
    {
        public frmConsultaGeneral()
        {
            InitializeComponent();
        }
        private string codigo;
        public string Codigo { 
            set{
                codigo = value;
            }
            get{
                return codigo;
            } 
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string TipoPersona { get; set; }
        private void frmConsultaGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var query = from c in ent.Persona select c;
                dgvConsulta.DataSource = query.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("No Hay registros", "Información", MessageBoxButtons.OK);
            }
            
        }
        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Codigo = dgvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();
                Nombre = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                Apellido = dgvConsulta.Rows[e.RowIndex].Cells[5].Value.ToString();
                Genero = dgvConsulta.Rows[e.RowIndex].Cells[7].Value.ToString();
                TipoPersona = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                Close();
            }
        }
    }
}
