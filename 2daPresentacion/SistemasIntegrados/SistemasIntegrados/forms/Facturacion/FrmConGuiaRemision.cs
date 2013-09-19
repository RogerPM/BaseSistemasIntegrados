using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class FrmConGuiaRemision : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public  string Codigo;
        public DateTime Fecha;
        public int codestado;
        public string SitioPartida;
        public string Sitiollegada;
        public DateTime fechaTraslado;
        public string conductor;
        public string NombreConductor;

        public FrmConGuiaRemision()
        {
            InitializeComponent();
        }

        private void FrmConGuiaRemision_Load(object sender, EventArgs e)
        {
            try
            {

                var produc =
                    from a in da.GuiaRemision   
                    join b in da.Persona on a.IdPesonaNatural equals b.IdPersona                                  
                    join es in da.Estado on a.idEstado equals es.IdEstado                    
                    select new
                    {
                        Codigo = a.IdNumeroGuiaRemision,
                        fecha = a.FechaEmision,
                        codestado = a.idEstado,
                        Estado = es.Descripcion,
                        SitioPartida = a.SitioSalida,
                        Sitiollegada = a.Sitiollegada,
                        fechaTraslado = a.FechaTraslado,
                        conductor = b.IdPersona,
                        NombreConductor = b.NombreRazonSocial                                              
                    };

                dataGridView1.DataSource = produc.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Fecha = DateTime.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                codestado = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                
                SitioPartida = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Sitiollegada = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                fechaTraslado =DateTime.Parse( dataGridView1.CurrentRow.Cells[6].Value.ToString());
                conductor = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                NombreConductor = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                
            }
            catch (Exception ex)
            { }
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
