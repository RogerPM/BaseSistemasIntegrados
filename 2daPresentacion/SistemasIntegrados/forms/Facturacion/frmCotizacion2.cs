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
    public partial class frmCotizacion2 : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DataTable tbldetalle;
        public frmCotizacion2()
        {
            InitializeComponent();
        }

       private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.idNumeroCotizacionSpinEdit.Value = Decimal.Parse(generarmaximo().ToString());
            this.porcentajeEntradaSpinEdit.Value = 30;
            this.txtcantidad.Value = 1;
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
         (from prod in da.Cotizacion
          select prod.IdNumeroCotizacion).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }


        }

        void limpiar()
        {
            this.idNumeroCotizacionSpinEdit.Value = 0;
            this.cmbformapago.SelectedIndex = -1;
            this.txtcliente.Text = "";
            this.txtdescripcioncliente.Text = "";
            this.porcentajeEntradaSpinEdit.Value = 0;
            this.valorEntradaSpinEdit.Value = 0;
            this.entradaMinimaRequeridaSpinEdit.Value = 0;
            this.valorCancelarSpinEdit.Value = 0;
            this.txtcodarticulo.Text = "";
            this.txtdesarticulo.Text = "";

            this.btnguardar.Enabled = true;
            tbldetalle.Rows.Clear();
            dataGridView1.DataSource = tbldetalle;
        }

        private void cargarFormaPagos()
        {
            try
            {
                var FormaPago = da.FormaPago;
                this.cmbformapago.DataSource = FormaPago.ToList();
                cmbformapago.ValueMember = "IdFormaPago";
                cmbformapago.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

            }

        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbestado.SelectedValue == "")
                {
                    MessageBox.Show("Seleccione un Estado.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbformapago.SelectedValue == "")
                {
                    MessageBox.Show("Seleccione Forma de Pago.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                if (this.txtcliente.Text == "")
                {
                    MessageBox.Show("Ingrese Cliente.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtcodarticulo.Text == "")
                {
                    MessageBox.Show("Ingrese Articulo.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (this.porcentajeEntradaSpinEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Porcentaje de Entrada.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.porcentajeEntradaSpinEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Porcentaje de Entrada.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.entradaMinimaRequeridaSpinEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Entrada Minima Requerida.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.fechaInicialPagoDateEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Fecha Inicio de Pago.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbpagos.SelectedValue == "")
                {
                    MessageBox.Show("Seleccione Numero de Cuotas.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.valorEntradaSpinEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Porcentaje de Entrada.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.valorCancelarSpinEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Entrada Minima Requerida.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.fechaFinalPagoDateEdit.Text == "")
                {
                    MessageBox.Show("Ingrese Fecha Inicio de Pago.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtcantidad.Text == "")
                {
                    MessageBox.Show("Ingrese Entrada Minima Requerida.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.tbldetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Favor ingrese datos para su cotización.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cotizacion  obj = new Cotizacion();
                obj.IdNumeroCotizacion  = Int32.Parse(idNumeroCotizacionSpinEdit.Text);
                obj.IdFormaPago = Int32.Parse(cmbformapago.SelectedValue.ToString());
                obj.IdNumeroCliente  = Int32.Parse(txtcliente.Text) ;
                obj.Fecha = dateTimePicker1.Value;
                obj.PorcentajeEntrada = porcentajeEntradaSpinEdit.Value;
                obj.ValorEntrada  = valorEntradaSpinEdit .Value;
                obj.EntradaMinimaRequerida  = entradaMinimaRequeridaSpinEdit .Value;
                obj.ValorCancelar  = valorCancelarSpinEdit .Value;
                obj.FechaInicialPago  = DateTime.Parse(fechaInicialPagoDateEdit.DateTime.ToString());
                obj.FechaFinalPago = DateTime.Parse(fechaFinalPagoDateEdit.DateTime.ToString());
                obj.Seguro = seguroCheckEdit.Checked;


                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                da.AddToCotizacion(obj);
                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    int i = 0;
                    while (i < tbldetalle.Rows.Count)
                    {
                        CotizacionDet objdet = new CotizacionDet();
                        objdet.IdEmpresa = Seguridad.empresa;
                        objdet.idUsuario = Seguridad.usuario;
                        objdet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());

                        objdet.Linea = i + 1;
                        objdet.IdNumeroCotizacion = Int32.Parse(idNumeroCotizacionSpinEdit.Text);

                        objdet.IdArticulo = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.CuotaMensual = Int32.Parse(tbldetalle.Rows[i][2].ToString());
                        objdet.FechaPago = DateTime.Parse(tbldetalle.Rows[i][3].ToString());
                        objdet.FechaMaximaPago = DateTime.Parse(tbldetalle.Rows[i][4].ToString());
                        objdet.precio = Decimal.Parse(tbldetalle.Rows[i][5].ToString());
                        objdet.cantidad = Int32.Parse(tbldetalle.Rows[i][6].ToString());
                        objdet.costo = Decimal.Parse(tbldetalle.Rows[i][7].ToString());
                        da.AddToCotizacionDet(objdet);
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

        private void frmCotizacion2_Load(object sender, EventArgs e)
        {

            cargarEstados();
            cargarFormaPagos();
            tbldetalle = new DataTable();
            tbldetalle.Columns.Add("Cod. Articulo");
            tbldetalle.Columns.Add("Articulo");
            tbldetalle.Columns.Add("Cuota Mensual");
            tbldetalle.Columns.Add("Fecha Inicio de Pago");
            tbldetalle.Columns.Add("Fecha Maximo de pago");
            tbldetalle.Columns.Add("Precio");
            tbldetalle.Columns.Add("Cantidad");
            tbldetalle.Columns.Add("Costo");
            dataGridView1.DataSource = tbldetalle;

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

        private void btnmas_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow fila;
                fila = tbldetalle.NewRow();
                fila[0] = this.txtcodarticulo.Text;
                fila[1] = this.txtdesarticulo.Text;
                fila[2] = cmbpagos.SelectedItem;
                fila[3] = fechaInicialPagoDateEdit .DateTime;
                fila[4] = fechaFinalPagoDateEdit.DateTime;
                fila[5] = this.txtprecio.Text;
                fila[6] = this.txtcantidad.Text;
                fila[7] = this.txtcosto.Text;
                tbldetalle.Rows.Add(fila);
                dataGridView1.DataSource = tbldetalle;

            }
            catch (Exception ex) { }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {

            try
            {
                tbldetalle.Rows.RemoveAt(this.dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = tbldetalle;
            }
            catch (Exception ex) { }
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            FrmConClientes obj = new FrmConClientes();
            obj.ShowDialog();
            this.txtcliente .Text = obj.codigo;
            this.txtdescripcioncliente.Text = obj.descripcion;

        }

        private void btnconsultarticulo_Click(object sender, EventArgs e)
        {
            FrmConProductos obj = new FrmConProductos();
            obj.ShowDialog();
            this.txtcodarticulo.Text = obj.codigo;
            this.txtdesarticulo.Text = obj.descripcion;
            this.txtprecio.Text = obj.precio.ToString();
            this.txtcosto.Text = obj.costo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConCotizacion obj = new FrmConCotizacion();
                obj.ShowDialog();
                this.idNumeroCotizacionSpinEdit.Value = Int32.Parse(obj.codigo);
                cmbformapago.SelectedItem = obj.FormaPago;
                txtcliente.Text = obj.codcliente.ToString();
                txtdescripcioncliente.Text = obj.Cliente;
                dateTimePicker1.Value = DateTime.Parse(obj.Fecha);
                valorCancelarSpinEdit.Value = Decimal.Parse(obj.ValorCancelar);
                porcentajeEntradaSpinEdit.Value = Decimal.Parse(obj.PorcentajeEntrada);
                valorEntradaSpinEdit.Value = Decimal.Parse(obj.ValorEntrada);
                entradaMinimaRequeridaSpinEdit.Value = Decimal.Parse(obj.EntradaMinimaRequerida);
                fechaInicialPagoDateEdit.DateTime = DateTime.Parse(obj.FechaInicialPago);
                fechaFinalPagoDateEdit.DateTime = DateTime.Parse(obj.FechaFinalPago);
                cmbestado.SelectedValue = Int32.Parse(obj.codEstado);

                //CONSULTAR DETALLE
                int cod = Int32.Parse(obj.codigo); ;

                var produc =
                        from a in da.CotizacionDet
                        join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                        where a.IdNumeroCotizacion == cod
                        select new
                        {
                            a.IdNumeroCotizacion,
                            b.Descripcion,
                            a.CuotaMensual,
                            a.FechaPago,
                            a.FechaMaximaPago,
                            a.precio,
                            a.cantidad,
                            a.costo
                        };

                this.dataGridView1.DataSource = produc.ToList();
            }
            catch (Exception ex) { }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.entradaMinimaRequeridaSpinEdit.Value = Decimal.Parse(this.txtprecio.Text) * (this.porcentajeEntradaSpinEdit.Value / 100);
            }
            catch (Exception ex)
            { 
            }
        }

        private void porcentajeEntradaSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.entradaMinimaRequeridaSpinEdit.Value = Decimal.Parse(this.txtprecio.Text) * (this.porcentajeEntradaSpinEdit.Value / 100);
            }
            catch (Exception ex)
            {
            }
        }

        private void entradaMinimaRequeridaSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.valorEntradaSpinEdit.Value = this.entradaMinimaRequeridaSpinEdit.Value;
        }

        private void fechaInicialPagoDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fechaFinalPagoDateEdit.DateTime = fechaInicialPagoDateEdit.DateTime.AddMonths(Int32.Parse(cmbpagos.SelectedItem.ToString()));
            }
            catch (Exception ex) { }
        }

        private void cmbpagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fechaFinalPagoDateEdit.DateTime = fechaInicialPagoDateEdit.DateTime.AddMonths(Int32.Parse(cmbpagos.SelectedItem.ToString()));
            }
            catch (Exception ex) { }
        }

        private void valorEntradaSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
             try
            {
            valorCancelarSpinEdit.Value = Decimal.Parse(this.txtprecio.Text ) - this.valorEntradaSpinEdit.Value;
            }
             catch (Exception ex) { }
        }
    }
}
