using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class FrmConProductos : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public FrmConProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
    //         
                this.Close();
            }
            catch (Exception ex)
            { }

        }

        private void FrmConProductos_Load(object sender, EventArgs e)
        {
            try { 

            //var produc =
            //    from a in da.Articulo
            //     join  b in da.TipoMotor on a.IdTipoMotor equals b.IdTipoMotor
            //    join c in da.Color on a.IdColor equals c.IdColor
            //    join d in da.Marca on a.IdMarca equals d.IdMarca
            //    join es in da.Modelo on a.IdModelo equals es.IdModelo
            //    select new { Codigo = a.IdArticulo,Nombre = a.Descripcion, Marca= d.Descripcion, Modelo = es.Descripcion,
            //                 SerieChasis = a.SerieChasis,
            //                 TipoMotor = b.Descripcion,
            //                 Color = c.Descripcion,
            //                 Stock = a.CantidadActual,
            //                 precio = 25000
            //    };


                var produc =
               from a in da.Articulo
               join b in da.TipoMotor on a.IdTipoMotor equals b.IdTipoMotor into tmptipomotor
               join c in da.Color on a.IdColor equals c.IdColor into tmpColor
               join d in da.Marca on a.IdMarca equals d.IdMarca into tmpMarca
               join es in da.Modelo on a.IdModelo equals es.IdModelo into tmpModelo
               join odc in  da.OrdenCompraDet on a.IdArticulo equals odc.IdArticulo into tmporden
               join ing in da.IngresoEgresoDet on a.IdArticulo equals ing.IdArticulo into tmpingreso
               from fdmotor in tmptipomotor.DefaultIfEmpty()
               from fdcolor in tmpColor.DefaultIfEmpty()
               from fdmarca in tmpMarca.DefaultIfEmpty()
               from fdmodelo in tmpModelo.DefaultIfEmpty()
               from fdcosto in tmpingreso.DefaultIfEmpty() // ingreso de tablas de inventario
               from fdprecio in tmporden.DefaultIfEmpty() 
               where a.IdTipoArticulo ==3
               select new
               {
                   Codigo = a.IdArticulo,
                   Nombre = a.Descripcion,
                   Marca = (fdmarca == null) ? "" : fdmarca.Descripcion,
                   Modelo = (fdmodelo == null) ? "" : fdmodelo.Descripcion,
                   SerieChasis = a.SerieChasis,
                   TipoMotor = (fdmotor == null) ? "" : fdmotor.Descripcion,
                   Color = (fdcolor == null) ? "" : fdcolor.Descripcion,
                   Stock = a.CantidadActual,
                   precio = (fdprecio == null) ? 25000 : fdprecio.Precio,
                   Costo = (fdcosto == null) ? 15000 : fdcosto.Costo

               };

                this.dataGridView1.DataSource = produc.ToList();
                } catch (Exception ex){

            }
        }

        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public double  precio { get; set; }
        public double costo { get; set; }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                stock = Int32.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                precio = Double .Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                costo  = Double.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            }
            catch (Exception ex)
            { }
            this.Close();
        }
    }
}
