using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos;
using forms.Facturacion.Consultas;
using datos.Facturacion;

namespace forms.Facturacion
{
    public partial class frmDevolucionVentas : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DataTable tbldetalle;
        public frmDevolucionVentas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumeroDevolucion.Text = generarmaximo().ToString();
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
                (from prod in da.DevolucionVenta
                select prod.IdNumeroDevolucion).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        void limpiar()
        {
            this.txtNumeroDevolucion.Text = "";
            this.txtNumeroFactura.Text = "";
            this.txtFacturaDescripcion.Text = "";
            this.txtcodarticulo.Text = "";
            this.txtdesarticulo.Text = "";
            this.txtObservaciones.Text = "";
   
            this.btnGenerar.Enabled = true;
            tbldetalle.Rows.Clear();
            dgvVehiculoDevolver.DataSource = tbldetalle;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNumeroFactura.Text == "")
                {
                    MessageBox.Show("Ingrese Numero Factura.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtcodarticulo.Text == "")
                {
                    MessageBox.Show("Ingrese Numero Factura.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbestado.SelectedValue == "")
                {
                    MessageBox.Show("Seleccione un Estado.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.tbldetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Favor ingrese datos para su devolucion.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DevolucionVenta  obj = new DevolucionVenta();
               // obj.cabecera_comprobante = Int32.Parse(txtNumeroDevolucion.Text);
                obj.IdNumeroDevolucion  = Int32.Parse(txtNumeroDevolucion.Text);
                obj.IdNumeroFactura = Int32.Parse(txtNumeroFactura.Text);
                obj.Fecha = this.dtpFecha.Value;
                            
                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                da.AddToDevolucionVenta(obj);
                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    int i = 0;
                    while (i < tbldetalle.Rows.Count)
                    {
                        DevolucionDet objdet = new DevolucionDet();
                        objdet.IdEmpresa = Seguridad.empresa;
                        objdet.idUsuario = Seguridad.usuario;
                        objdet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());

                        objdet.Linea = i + 1;
                        objdet.IdNumeroDevolucion = Int32.Parse(txtNumeroDevolucion.Text);
                        objdet.IdArticulo = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.Observacion =(tbldetalle.Rows[i][2].ToString());
                        objdet.cantidad =Int32.Parse(tbldetalle.Rows[i][3].ToString());
                      
                        da.AddToDevolucionDet (objdet);
                        // Incrementar inventario

                        da.SaveChanges();
                        i++;

                    }


                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cargarpromociones();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmDevolucionVentas_Load(object sender, EventArgs e)
        {
            cargarEstados();
            tbldetalle = new DataTable();
            tbldetalle.Columns.Add("Cod. Articulo");
            tbldetalle.Columns.Add("Articulo");            
            tbldetalle.Columns.Add("Observacion");
            tbldetalle.Columns.Add("Cantidad");
            dgvVehiculoDevolver.DataSource = tbldetalle;

        }
        
        private void cargarEstados()
        {
            try
            {
                var Estado = da.Estado;
                this.cmbestado.DataSource = Estado.ToList();
                cmbestado.ValueMember = "IdEstado";
                cmbestado.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow fila;
                fila = tbldetalle.NewRow();
                fila[0] = this.txtcodarticulo.Text;
                fila[1] = this.txtdesarticulo.Text;
                fila[2] = listboxTipo.SelectedItem.ToString() + ' '+ txtObservaciones.Text;
                fila[3] = txtcantidad.Text;
                tbldetalle.Rows.Add(fila);
                dgvVehiculoDevolver.DataSource = tbldetalle;

            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                tbldetalle.Rows.RemoveAt(this.dgvVehiculoDevolver.CurrentCell.RowIndex);
                dgvVehiculoDevolver.DataSource = tbldetalle;
            }
            catch (Exception ex) { }
        }

        //private void btnConsultaVeh_Click(object sender, EventArgs e)
        //{
        //    FrmConProductos obj = new FrmConProductos();
        //    obj.ShowDialog();
        //    this.txtcodarticulo.Text = obj.codigo;
        //    this.txtdesarticulo.Text = obj.descripcion;
        //    this.txtprecio.Text = obj.precio.ToString();
        //}

        private void btnconsultarticulo_Click(object sender, EventArgs e)
        {
            FrmConFacturasDet obj = new FrmConFacturasDet(Int32.Parse(this.txtNumeroFactura.Text));
            obj.ShowDialog();
            this.txtcodarticulo.Text = obj.Codigo;
            this.txtdesarticulo.Text = obj.desarticulo;
            this.txtcantidad.Text = obj.cantidad.ToString();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmconDevolucion obj = new FrmconDevolucion();
                obj.ShowDialog();
                txtNumeroDevolucion.Text = obj.Codigo.ToString ();
                dtpFecha.Value = DateTime.Parse(obj.Fecha);
                txtNumeroFactura.Text = obj.codigoFact.ToString();
                txtFacturaDescripcion.Text =obj.Cliente;
                cmbestado.SelectedValue = Int32.Parse(obj.codEstado);

                //Consultar detalle
                int cod = Int32.Parse(obj.Codigo); ;

                var detdevolucion =
                    from a in da.DevolucionDet
                    join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                    join c in da.Marca on b.IdMarca equals c.IdMarca
                    join d in da.Estado on a.idEstado equals d.IdEstado
                    join es in da.Modelo on b.IdModelo equals es.IdModelo
                    where a.IdNumeroDevolucion == cod
                    select new
                    {
                        a.Linea,
                        a.IdNumeroDevolucion,
                        //a.precio,
                        a.cantidad,
                        b.IdArticulo,
                        b.Descripcion,
                        a.Observacion,
                        marca = c.Descripcion,
                        modelo = es.Descripcion,
                        chasis = b.Chasis.Descripcion,
                        color = b.Color.Descripcion

                    };
                this.dgvVehiculoDevolver.DataSource = detdevolucion.ToList();

                   int i = 0;
                    tbldetalle.Rows.Clear();
                    while (i < dgvVehiculoDevolver.Rows.Count)
                    {
                       
                        DataRow fila;
                        fila = tbldetalle.NewRow();
                        fila[0] = dgvVehiculoDevolver.Rows[i].Cells["IdArticulo"].Value.ToString();
                        fila[1] = dgvVehiculoDevolver.Rows[i].Cells["Descripcion"].Value.ToString();
                        fila[2] = dgvVehiculoDevolver.Rows[i].Cells["Observacion"].Value.ToString();                        
                        fila[3] = dgvVehiculoDevolver.Rows[i].Cells["Cantidad"].Value.ToString();
                        tbldetalle.Rows.Add(fila);                       
                        i++;
                    }

                    dgvVehiculoDevolver.DataSource = tbldetalle;

                    btnAnular.Enabled = true;
                    btnImprimir.Enabled = true;
                    btnGenerar.Enabled = false;


            }
            catch (Exception ex)
                {

                }
        

        }
        
        private void btnConsultaFact_Click(object sender, EventArgs e)
        {
            FrmConFacturas obj = new FrmConFacturas();
            obj.ShowDialog();
            this.txtNumeroFactura.Text = obj.Codigo.ToString();
            txtFacturaDescripcion.Text = obj.Cliente;
            
        }
    }
}
