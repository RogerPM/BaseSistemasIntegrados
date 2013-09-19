using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos;
using Microsoft.VisualBasic;
using datos.Facturacion;
using datos.Contabilidad;
using clases.Contabilidad;

namespace forms.Facturacion
{
    public partial class frmFacturacion : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DataTable tbldetalle;
        private DataTable tblcutoas;
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumeroFactura.Text = generarmaximo().ToString();
            
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
         (from prod in da.Factura 
          select prod.IdNumeroFactura).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        void limpiar()
        {
            this.txtNumeroFactura.Text = ""; 
            this.txtNumSRI .Text = "";
            this.txtVendedor.Text = "";
            this.txtNumeroCliente.Text = "";
            this.txtNombreCliente.Text = "";
            //this.txtDireccionCliente.Text = "";
            //this.txtTelefonoCliente.Text = "";
            //this.txtCelularCliente.Text= "";
            this.txtNumeroCotizacion.Text = "";
            this.cbxFormaPago.SelectedItem = -1;
            this.txtNumeroPromocion.Text = "";
            this.txtPromocion.Text = "";
            //this.txtNumeroVehiculo.Text = "";
            //this.cbxMarcaVehiculo.SelectedItem = -1;
            //this.cbxModeloVehiculo.SelectedItem = -1;
            //this.cbxAnioVehiculo.SelectedItem = -1;
            //this.txtCilindrajeVehiculo.Text="";
            //this.cbxColorVehiculo.SelectedItem = -1;
            this.txtValorVehiculo.Text = "";
            this.txtPorcentajeEntrada.Text = "";
            this.txtValorEntrada.Value=0;
            this.txtValorFinanciar.Value = 0;
            this.txtTasaFija.Value  = 15;
            this.txtTotalPagar.Value = 0;
            //this.cbxNumMeses.SelectedItem = -1;
            this.txtNumeroCuotaMensual.Value = 60;
            this.txtiva.Value = 0;
            this.txtice.Value = 0;
            this.txtdescuento.Value = 0;
            this.txtsubtotal.Value = 0;
            this.txtTotalPagar.Value = 0;
                         
            this.toolStripGenerar.Enabled = true;
            toolStripAnular.Enabled = false ;
            toolStripImprimir.Enabled = false;
            

            tbldetalle.Rows.Clear();
            dataGridView1.DataSource = tbldetalle;
            tblcutoas.Rows.Clear();
            dataGridView2.DataSource = tblcutoas;
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNumeroCliente.Text == "")
                {
                    MessageBox.Show("Ingrese Cliente.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtNumSRI.Text == "")
                {
                    MessageBox.Show("Ingrese Numero SRI.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtNumeroCotizacion.Text == "")
                {
                    MessageBox.Show("Ingrese Cotizacion.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtNumeroPromocion.Text == "")
                {
                    MessageBox.Show("Ingrese Promocion.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtPromocion.Text == "")
                {
                    MessageBox.Show("Ingrese Promocion.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbxFormaPago.SelectedValue == "")
                {
                    MessageBox.Show("Seleccione Forma de Pago.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.tbldetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Favor ingrese un articulo para su factura.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Factura obj = new Factura();
                obj.IdNumeroFactura = Int32.Parse(txtNumeroFactura.Text);
               // obj.cabecera_comprobante = Int32.Parse(txtNumSRI.Text);
                obj.IdNumeroCotizacion = Int32.Parse(txtNumeroCotizacion.Text);
                obj.IdPromocion = Int32.Parse(txtNumeroPromocion.Text);
                obj.IdFormaPago = Int32.Parse(cbxFormaPago.SelectedValue.ToString());
                obj.IdNumeroCliente = Int32.Parse(txtNumeroCliente.Text);
                obj.Fecha = this.dtpFecha.Value;
                obj.ValorEntrada = Decimal.Parse (txtValorEntrada.Text);
                obj.NumeroCuotaMensual = Int32.Parse(txtNumeroCuotaMensual.Text);
                obj.Subtotal = txtsubtotal.Value;
                obj.Iva = txtiva.Value;
                obj.Ice = txtice.Value;
                obj.Descuento = txtdescuento.Value;
                obj.TotalPagar = txtTotalPagar.Value;
                                            
                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                
                da.AddToFactura(obj);
                int respuesta = da.SaveChanges();
                double totalcosto = 0;

                if (respuesta > 0)
                {
                    // registrar en contabilidad
                    clsDatoComprobante objcontabilidad = new clsDatoComprobante();
                    clsCabeceraComprobante objcontdet = new clsCabeceraComprobante();
                    //objcontdet.fecha = 

                    objcontdet.fecha = DateTime.Now;
                    objcontdet.glosa = "Venta Modulo de Facturacion ";
                    objcontdet.IdEmpresa = Seguridad.empresa;

                    List<clsDetalleComprobante> Detalleconta = new List<clsDetalleComprobante>();

                    int i = 0;
                    while (i < tbldetalle.Rows.Count)
                    {
                        FacturaDet objdet = new FacturaDet ();
                        objdet.IdEmpresa = Seguridad.empresa;
                        objdet.idUsuario = Seguridad.usuario;
                        objdet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());

                        objdet.Linea = i + 1;
                        objdet.IdNumeroFactura = Int32.Parse(txtNumeroFactura.Text);                        
                        objdet.IdArticulo = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.CuotaMensual = Decimal.Parse(tbldetalle.Rows[i][2].ToString());
                        objdet.FechaPago = DateTime.Parse(tbldetalle.Rows[i][3].ToString());
                        objdet.FechaMaximaPago = DateTime.Parse(tbldetalle.Rows[i][4].ToString());
                        objdet.precio = Decimal.Parse(tbldetalle.Rows[i][5].ToString());
                        objdet.cantidad = Int32.Parse(tbldetalle.Rows[i][6].ToString());
                        objdet.costo = Decimal.Parse(tbldetalle.Rows[i][7].ToString());
                        da.AddToFacturaDet (objdet);
                        da.SaveChanges();
                        i++;
                        totalcosto = totalcosto + Double.Parse(objdet.costo.ToString());
                    }

                    if (obj.IdFormaPago == 1)
                    {
                        clsDetalleComprobante obcontdet = new clsDetalleComprobante();
                        obcontdet.cuenta = "11101001"; // caja
                        obcontdet.debe = Decimal.Parse(obj.TotalPagar.ToString());
                        obcontdet.haber = 0;
                        Detalleconta.Add(obcontdet);

                        clsDetalleComprobante obcontdet1 = new clsDetalleComprobante();
                        obcontdet1.cuenta = "11401001"; // iva
                        obcontdet1.debe = 0;
                        obcontdet1.haber = Decimal.Parse(obj.Iva.ToString());
                        Detalleconta.Add(obcontdet1);

                        clsDetalleComprobante obcontdet2 = new clsDetalleComprobante();
                        obcontdet2.cuenta = "11401003"; // ice
                        obcontdet2.debe = 0;
                        obcontdet2.haber = Decimal.Parse(obj.Ice.ToString()); ;
                        Detalleconta.Add(obcontdet2);

                        clsDetalleComprobante obcontdet3 = new clsDetalleComprobante();
                        obcontdet3.cuenta = "41101001"; // ingreso por venta
                        obcontdet3.debe = 0;
                        obcontdet3.haber = Decimal.Parse(obj.Subtotal.ToString());
                        Detalleconta.Add(obcontdet3);

                        clsDetalleComprobante obcontdet4 = new clsDetalleComprobante();
                        obcontdet4.cuenta = "51101001"; // costo de venta
                        obcontdet4.debe = Decimal.Parse(totalcosto.ToString());
                        obcontdet4.haber = 0;
                        Detalleconta.Add(obcontdet4);

                        clsDetalleComprobante obcontdet5 = new clsDetalleComprobante();
                        obcontdet5.cuenta = "11301001"; // costo de venta
                        obcontdet5.debe = 0;
                        obcontdet5.haber = Decimal.Parse(totalcosto.ToString());
                        Detalleconta.Add(obcontdet5);

                    }
                    else {

                        clsDetalleComprobante obcontdet0 = new clsDetalleComprobante();
                        obcontdet0.cuenta = "11101001"; // caja
                        obcontdet0.debe = Decimal.Parse(txtValorEntrada.Value.ToString());
                        obcontdet0.haber = 0;
                        Detalleconta.Add(obcontdet0);

                        clsDetalleComprobante obcontdet = new clsDetalleComprobante();
                        obcontdet.cuenta = "11201001"; // credito
                        obcontdet.debe = Decimal.Parse((txtTotalPagar.Value - txtValorEntrada.Value).ToString());
                        obcontdet.haber = 0;
                        Detalleconta.Add(obcontdet);

                        clsDetalleComprobante obcontdet1 = new clsDetalleComprobante();
                        obcontdet1.cuenta = "11401001"; // iva
                        obcontdet1.debe = 0;
                        obcontdet1.haber = Decimal.Parse(obj.Iva.ToString());
                        Detalleconta.Add(obcontdet1);

                        clsDetalleComprobante obcontdet2 = new clsDetalleComprobante();
                        obcontdet2.cuenta = "11401003"; // ice
                        obcontdet2.debe = 0;
                        obcontdet2.haber = Decimal.Parse(obj.Ice.ToString()); ;
                        Detalleconta.Add(obcontdet2);

                        clsDetalleComprobante obcontdet3 = new clsDetalleComprobante();
                        obcontdet3.cuenta = "41101001"; // ingreso por venta
                        obcontdet3.debe = 0;
                        obcontdet3.haber = Decimal.Parse(obj.Subtotal.ToString());
                        Detalleconta.Add(obcontdet3);

                        clsDetalleComprobante obcontdet4 = new clsDetalleComprobante();
                        obcontdet4.cuenta = "51101001"; // costo de venta
                        obcontdet4.debe = Decimal.Parse(totalcosto.ToString());
                        obcontdet4.haber = 0;
                        Detalleconta.Add(obcontdet4);

                        clsDetalleComprobante obcontdet5 = new clsDetalleComprobante();
                        obcontdet5.cuenta = "11301001"; // costo de venta
                        obcontdet5.debe = 0;
                        obcontdet5.haber = Decimal.Parse(totalcosto.ToString());
                        Detalleconta.Add(obcontdet5);
                    
                    }
                    objcontdet.Detalle = Detalleconta;

                    objcontabilidad.GuardarCabecera(ref objcontdet);

                    //guardar cuentas por cobrar
                   Int32 maxUnitsInStock=0;
                    try
                    {
                     maxUnitsInStock =
                    (from prod in da.Factura 
                    select prod.IdNumeroFactura).Max() + 1;

                    ;
                    }
                    catch (Exception ex)
                    {
                    maxUnitsInStock= 1;
                    }

                    CuentaxCobrar objcxc = new CuentaxCobrar();
                    objcxc.idCuentaxCobrar  =  Int32.Parse(maxUnitsInStock.ToString());
                    //objcxc.numero_comprobante =
                    //objcxc.idTransaccion =
                    objcxc.idNumeroFactura =Int32.Parse(this.txtNumeroFactura.Text);
                    //objcxc.idCabeceraComprobante =
                    objcxc.TotalCuotas =Int32.Parse(txtNumeroCuotaMensual.Text);
                    objcxc.porcentaje_interes=Decimal.Parse(this.txtTasaFija.Text);
                    objcxc.Modulo =1;


                    objcxc.idEmpresa = Seguridad.empresa;
                    objcxc.idUsuario = Seguridad.usuario;
                    //objcxc.estado = Int32.Parse(cmbestado.SelectedValue.ToString());
                    objcxc.estado = cmbestado.SelectedValue.ToString();

                    da.AddToCuentaxCobrar(objcxc);
                     respuesta = da.SaveChanges();
                    if (respuesta > 0)
                    {
                         i = 0;
                        while (i < tblcutoas.Rows.Count)
                        {
                            CuentaxCobrarDet objdetcxc = new CuentaxCobrarDet ();
                            objdetcxc.idCuentaxCobrar = objcxc.idCuentaxCobrar;
                            
                            //objdetcxc.idEmpresa = Seguridad.empresa;
                            //objdetcxc.idUsuario = Seguridad.usuario;
                            //objdetcxc.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                            objdetcxc.estado = cmbestado.SelectedValue.ToString();

                            objdetcxc.Numero = i + 1;
                            objdetcxc.numero_cuota = i + 1;

                            objdetcxc.valor_cuota = Decimal.Parse(tblcutoas.Rows[i][0].ToString());
                            objdetcxc.valor_interes = Decimal.Parse(tblcutoas.Rows[i][1].ToString());
                            objdetcxc.valor_mora = 0;
                            objdetcxc.fecha_cobro = DateTime.Parse(tblcutoas.Rows[i][2].ToString());
                            objdetcxc.fecha_vencimiento = DateTime.Parse(tblcutoas.Rows[i][3].ToString());
                            objdetcxc.FechaModificacion  =  DateTime.Parse(DateAndTime.Now.ToShortDateString());

                            da.AddToCuentaxCobrarDet (objdetcxc);
                            da.SaveChanges();
                            i++;

                        }
                    }

                    


                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cargarpromociones();
                    ImprimirReporte();


                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ImprimirReporte()
        {

            Formview obj = new Formview(Int32.Parse(txtNumeroFactura.Text));
            obj.ShowDialog();
        }

       

        private void frmFacturacion_Load(object sender, EventArgs e)
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

            tblcutoas = new DataTable();
            tblcutoas.Columns.Add("Valor de Cuota");
            tblcutoas.Columns.Add("Valor Interes");
            tblcutoas.Columns.Add("Fecha de Cobro");
            tblcutoas.Columns.Add("Fecha de Vencimiento");
            dataGridView2.DataSource = tblcutoas;

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

        private void cargarFormaPagos()
        {
            try
            {
                var FormaPago = da.FormaPago;
                this.cbxFormaPago.DataSource = FormaPago.ToList();
                cbxFormaPago.ValueMember = "IdFormaPago";
                cbxFormaPago.DisplayMember = "Descripcion";
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
                fila[2] = txtNumeroCuotaMensual .Text;
                fila[3] = dtpFechaInicioPago.Text;
                fila[4] = dtpFechaFinPago.Text;
                fila[5] = txtprecio.Text;
                fila[6] = txtcantidad.Value;
                fila[7] = txtcosto.Text;
                tbldetalle.Rows.Add(fila);
                dataGridView1.DataSource = tbldetalle;

                double valortotal = 0;
                int i = 0;
                while (i < tbldetalle.Rows.Count)
                {
                    valortotal = Double.Parse(tbldetalle.Rows[i][5].ToString()) * Double.Parse(tbldetalle.Rows[i][6].ToString());
                    i++;
                }

                this.txtValorVehiculo.Text = valortotal.ToString();

            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                tbldetalle.Rows.RemoveAt(this.dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = tbldetalle;

                double valortotal = 0;
                int i = 0;
                while (i < tbldetalle.Rows.Count)
                {
                    valortotal = Double.Parse(tbldetalle.Rows[i][5].ToString()) * Double.Parse(tbldetalle.Rows[i][6].ToString());
                    i++;
                }

                this.txtValorVehiculo.Text = valortotal.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            FrmConClientes obj = new FrmConClientes();
            obj.ShowDialog();
            this.txtNumeroCliente.Text = obj.codigo;
            this.txtNombreCliente.Text = obj.descripcion;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConFacturas obj = new FrmConFacturas();
                obj.ShowDialog();
                this.txtNumeroFactura.Text = obj.Codigo.ToString ();
                dtpFecha.Value = DateTime.Parse(obj.Fecha);
                txtNumeroCotizacion.Text = obj.CodCotizacion.ToString ();
                cbxFormaPago.SelectedItem = obj.FormaDePago;
                txtNumeroPromocion.Text = obj.codPromocion.ToString();
                txtPromocion.Text = obj.DesPromocion.ToString();
                txtNumeroCliente.Text = obj.codcliente.ToString ();
                txtNombreCliente.Text =obj.Cliente;
                txtPorcentajeEntrada.Value = Decimal.Parse(obj.PorcentajeEntrada); 
                txtValorEntrada.Value = Decimal.Parse(obj.ValorEntrada);
                //txtentra.Value = Decimal.Parse(obj.EntradaMinimaRequerida);
                dtpFechaInicioPago.Value = DateTime.Parse(obj.FechaInicialPago);
                dtpFechaFinPago.Value = DateTime.Parse(obj.FechaFinalPago);
                txtsubtotal.Value = Decimal.Parse(obj.Subtotal);
                txtiva.Value = Decimal.Parse(obj.Iva);
                txtice.Value = Decimal.Parse(obj.Ice);
                txtdescuento.Value = Decimal.Parse(obj.Descuento);
                txtTotalPagar.Value =Decimal.Parse(obj.ValorCancelar);
                cmbestado.SelectedValue = Int32.Parse(obj.codEstado);

                //CONSULTAR DETALLE
                int cod = Int32.Parse(obj.Codigo); ;

                var detfactura =
                    from a in da.FacturaDet
                    join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                    join c in da.Marca on b.IdMarca equals c.IdMarca
                    join d in da.Estado on a.idEstado equals d.IdEstado
                    join es in da.Modelo on b.IdModelo equals es.IdModelo
                    where a.IdNumeroFactura == cod
                    select new
                    {
                        a.Linea,
                        a.IdNumeroFactura,
                        a.precio,
                        a.cantidad,
                        b.IdArticulo,
                        b.Descripcion,
                        marca = c.Descripcion,
                        modelo = es.Descripcion,
                        chasis = b.Chasis.Descripcion,
                        color = b.Color.Descripcion,
                        a.costo
                    };


                var DetalleCuotas =
                  from a in da.Factura
                  join b in da.ClienteDefactura on a.IdNumeroCliente equals b.IdNumeroCliente
                  join c in da.Empresa on a.IdEmpresa equals c.IdEmpresa
                  join d in da.Estado on a.idEstado equals d.IdEstado
                  join es in da.Usuario on a.idUsuario equals es.IdUsuario
                  join f in da.FormaPago on a.IdFormaPago equals f.IdFormaPago
                  join g in da.CuentaxCobrar on a.IdNumeroFactura equals g.idNumeroFactura
                  join h in da.CuentaxCobrarDet on g.idCuentaxCobrar equals h.idCuentaxCobrar
                  where g.Modulo == 1 && a.IdNumeroFactura == cod
                  select new
                  {
                      empresa = c.Descripcion,
                      formaPago = f.Descripcion,
                      cliente = b.NombreRazonSocial,
                      total = a.TotalPagar,
                      iva = a.Iva,
                      ice = a.Ice,
                      subtotal = a.Subtotal,
                      Fecha = a.Fecha,
                      cuotas = a.NumeroCuotaMensual,
                      estado = d.Descripcion,
                      usuario = es.NombreUsuario,
                      c.RazonSocial,
                      c.Ruc,
                      c.Direccion,
                      b.Identificacion,
                      h.idCuentaxCobrar,
                      h.Numero,
                      h.numero_cuota,
                      h.valor_cuota,
                      h.valor_mora,
                      h.valor_interes,
                      h.fecha_cobro,
                      h.fecha_vencimiento
                  };

                this.dataGridView1.DataSource = detfactura.ToList();

                try
                {

                    double valortotal = 0;
                    int i = 0;
                    tbldetalle.Rows.Clear();
                    while (i < dataGridView1.Rows.Count)
                    {
                        //dataGridView1.Rows[0].Cells[0].Value
                        valortotal = Double.Parse(dataGridView1.Rows[i].Cells["precio"].Value.ToString()) * Double.Parse(dataGridView1.Rows[i].Cells["cantidad"].Value.ToString());
                        DataRow fila;
                        fila = tbldetalle.NewRow();
                        fila[0] = dataGridView1.Rows[i].Cells["IdArticulo"].Value.ToString();
                        fila[1] = dataGridView1.Rows[i].Cells["Descripcion"].Value.ToString();
                        fila[2] = txtNumeroCuotaMensual.Text;
                        fila[3] = dtpFechaInicioPago.Text;
                        fila[4] = dtpFechaFinPago.Text;
                        fila[5] = dataGridView1.Rows[i].Cells["precio"].Value.ToString();
                        fila[6] = dataGridView1.Rows[i].Cells["cantidad"].Value.ToString();
                        fila[7] = dataGridView1.Rows[i].Cells["costo"].Value.ToString();
                        tbldetalle.Rows.Add(fila);
                        


                        i++;
                    }
                    dataGridView1.DataSource = tbldetalle;
                    this.txtValorVehiculo.Text = valortotal.ToString();
                    this.dataGridView1.DataSource = tbldetalle;
                    i = 0;

                    dataGridView2.DataSource = DetalleCuotas.ToList();

                    tblcutoas.Rows.Clear();
                    while (i < dataGridView2.Rows.Count)
                    {
                        //dataGridView1.Rows[0].Cells[0].Value
                       
                        DataRow fila;
                        fila = tblcutoas.NewRow();
                        fila[0] = dataGridView2.Rows[i].Cells["valor_cuota"].Value.ToString();
                        fila[1] = dataGridView2.Rows[i].Cells["valor_interes"].Value.ToString();
                        fila[2] = dataGridView2.Rows[i].Cells["fecha_cobro"].Value.ToString();
                        fila[3] = dataGridView2.Rows[i].Cells["fecha_vencimiento"].Value.ToString();
                        tblcutoas.Rows.Add(fila);                       
                        i++;
                    }

                    dataGridView2.DataSource = tblcutoas;
                    toolStripAnular.Enabled = true;
                    toolStripImprimir.Enabled = true;
                    toolStripGenerar.Enabled = false;

                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex) { }
        }

        private void btnConsCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConCotizacion obj = new FrmConCotizacion();
                obj.ShowDialog();
                this.txtNumeroCotizacion.Text = obj.codigo.ToString();
                cbxFormaPago.SelectedItem = obj.FormaPago;
                txtNumeroCliente.Text = obj.codcliente.ToString();
                txtNombreCliente.Text = obj.Cliente;
                //dateTimePicker1.Value = DateTime.Parse(obj.Fecha);
                txtTotalPagar.Text = obj.ValorCancelar.ToString ();
                txtPorcentajeEntrada.Text = obj.PorcentajeEntrada.ToString ();
                txtValorEntrada.Text = obj.ValorEntrada.ToString ();
                //entradaMinimaRequeridaSpinEdit.Value = Decimal.Parse(obj.EntradaMinimaRequerida);
                dtpFechaInicioPago.Text = (obj.FechaInicialPago);
                dtpFechaFinPago.Text = (obj.FechaFinalPago);

                //CONSULTAR DETALLE
                int cod = Int32.Parse(obj.codigo); 

                var produc =
                        from a in da.CotizacionDet
                        join b in da.Articulo on a.IdArticulo equals b.IdArticulo
                        where a.IdNumeroCotizacion == cod
                        select new
                        {
                            b.IdArticulo,
                            b.Descripcion,
                            a.CuotaMensual,
                            a.FechaPago,
                            a.FechaMaximaPago,
                            a.precio,
                            a.cantidad,
                            a.costo
                        };

                this.dataGridView1.DataSource = produc.ToList();

                try
                {

                    double valortotal = 0;
                    int i = 0;

                    tbldetalle.Rows.Clear();
                    while (i < dataGridView1.Rows.Count)
                    {
                        //dataGridView1.Rows[0].Cells[0].Value
                        valortotal = Double.Parse(dataGridView1.Rows[i].Cells["precio"].Value.ToString()) * Double.Parse(dataGridView1.Rows[i].Cells["cantidad"].Value.ToString());
                        DataRow fila;
                        fila = tbldetalle.NewRow();
                        fila[0] = dataGridView1.Rows[i].Cells["IdArticulo"].Value.ToString();
                        fila[1] = dataGridView1.Rows[i].Cells["Descripcion"].Value.ToString();
                        fila[2] = txtNumeroCuotaMensual .Text;
                        fila[3] = dtpFechaInicioPago.Text;
                        fila[4] = dtpFechaFinPago.Text;
                        fila[5] = dataGridView1.Rows[i].Cells["precio"].Value.ToString();
                        fila[6] = dataGridView1.Rows[i].Cells["cantidad"].Value.ToString();
                        fila[7] = dataGridView1.Rows[i].Cells["costo"].Value.ToString();
                        tbldetalle.Rows.Add(fila);
                      i++;
                    }

                    this.txtValorVehiculo.Text = valortotal.ToString();
                    this.dataGridView1.DataSource = tbldetalle;
                }
                catch (Exception ex)
                {

                }

            }
            catch (Exception ex) { }
        }

        private void btnConsultaPromocion_Click(object sender, EventArgs e)
        {
            FrmConPromociones obj = new FrmConPromociones();
            obj.ShowDialog();
            this.txtNumeroPromocion.Text = obj.codigo;
            this.txtPromocion.Text = obj.descripcion;
        }

        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {
            try
            {
                // generamos amortizaciones
                tblcutoas.Rows.Clear();
                double Payment = 0;
                int cutoasnum = Int32.Parse(this.txtNumeroCuotaMensual.Text);
                Payment = Financial.Pmt((Double.Parse(this.txtTasaFija.Text) / 100) / 12, cutoasnum, -Double.Parse(this.txtValorFinanciar.Text), 0, DueDate.EndOfPeriod);
                

                int i = 0;
                DataRow fila;
                DateTime fecha;
                fecha = dtpFechaInicioPago.Value;
                while (i < Int32.Parse(this.txtNumeroCuotaMensual.Text))
                {
                    

                    double presente = Financial.PV((Double.Parse(this.txtTasaFija.Text) / 100) / 12, cutoasnum, Payment, 0, DueDate.EndOfPeriod);
                    double valorinteres = Financial.Rate(cutoasnum, Payment, presente, 0, DueDate.EndOfPeriod);
                    

                    fila = tblcutoas.NewRow();
                    fila[0] = Payment;
                    fila[1] = (presente * -1) * valorinteres;
                    fila[2] = fecha;
                    fila[3] = fecha.AddDays(1);
                    tblcutoas.Rows.Add(fila);
                    i++;
                    fecha = fecha.AddMonths(1);
                    cutoasnum = cutoasnum - 1;
                }
                dataGridView2.DataSource = tblcutoas;

            }
            catch (Exception ex) {
                MessageBox.Show("Ingrese la Tasa de Interes correctamente. " + ex.Message, "Modulo de Facturacion",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                double valortotal = 0;
                int i = 0;
                while (i < tbldetalle.Rows.Count)
                {
                    valortotal = Double.Parse(tbldetalle.Rows[i][5].ToString()) * Double.Parse(tbldetalle.Rows[i][6].ToString());
                    i++;
                }

                this.txtValorVehiculo.Text = valortotal.ToString();
            }
            catch (Exception ex) { 
            
            }
        }

        private void txtPorcentajeEntrada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorEntrada.Value = txtValorVehiculo.Value * (txtPorcentajeEntrada.Value / 100);
                txtValorFinanciar.Value = txtValorVehiculo.Value - txtValorEntrada.Value;
                this.txtsubtotal.Value = txtValorVehiculo.Value;
                this.txtiva.Value = this.txtsubtotal.Value * Decimal.Parse("0.12");
                this.txtice.Value = this.txtsubtotal.Value * Decimal.Parse("0.10");
                this.txtdescuento.Value = 0;
                this.txtTotalPagar.Value = txtsubtotal.Value + txtiva.Value + txtice.Value - txtdescuento.Value;

            }
            catch (Exception ex) { }
        }

        private void txtValorEntrada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorEntrada.Value = txtValorVehiculo.Value * (txtPorcentajeEntrada.Value / 100);
                txtValorFinanciar.Value = txtValorVehiculo.Value - txtValorEntrada.Value;
                this.txtsubtotal.Value = txtValorVehiculo.Value;
                this.txtiva.Value = this.txtsubtotal.Value * Decimal.Parse("0.12");
                this.txtice.Value = this.txtsubtotal.Value * Decimal.Parse("0.10");
                this.txtdescuento.Value = 0;
                this.txtTotalPagar.Value = txtsubtotal.Value + txtiva.Value + txtice.Value - txtdescuento.Value;

            }
            catch (Exception ex) { }
        }

        private void txtValorVehiculo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorEntrada.Value = txtValorVehiculo.Value * (txtPorcentajeEntrada.Value / 100);
                txtValorFinanciar.Value = txtValorVehiculo.Value - txtValorEntrada.Value;
                this.txtsubtotal.Value = txtValorVehiculo.Value;
                this.txtiva.Value = this.txtsubtotal.Value * Decimal.Parse("0.12");
                this.txtice.Value = this.txtsubtotal.Value * Decimal.Parse("0.10");
                this.txtdescuento.Value = 0;
                this.txtTotalPagar.Value = txtsubtotal.Value + txtiva.Value + txtice.Value - txtdescuento.Value;

            }
            catch (Exception ex) { }
        }

        private void txtdescuento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorEntrada.Value = txtValorVehiculo.Value * (txtPorcentajeEntrada.Value / 100);
                txtValorFinanciar.Value = txtValorVehiculo.Value - txtValorEntrada.Value;
                this.txtsubtotal.Value = txtValorVehiculo.Value;
                this.txtiva.Value = this.txtsubtotal.Value * Decimal.Parse("0.12");
                this.txtice.Value = this.txtsubtotal.Value * Decimal.Parse("0.10");
                
                this.txtTotalPagar.Value = txtsubtotal.Value + txtiva.Value + txtice.Value - txtdescuento.Value;

            }
            catch (Exception ex) { }
        }

        private void toolStripImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
          

        }

        private void toolStripAnular_Click(object sender, EventArgs e)
        {
            Inactivarfacturacxcinventario();
        }

        private void Inactivarfacturacxcinventario()
        {
            try
            {
                int numerofactura = Int32.Parse(txtNumeroFactura.Text);
                var obj = da.Factura.Single(a => a.IdNumeroFactura == numerofactura);
                if (obj != null)
                {
                    if (obj.idEstado == Int32.Parse(cmbestado.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Para Anular la Factura Favor cambiar de Estado.", "Modulo de Facturacion",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }                   
                    obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());                    
                    int respuesta = da.SaveChanges();
                }

                var objdet = from a in da.FacturaDet 
                             where  a.IdNumeroFactura == numerofactura
                    select  a;
                foreach (FacturaDet ord in objdet)
                {
                    ord.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());                                       
                }
                da.SaveChanges();

                var objcabCuota = da.CuentaxCobrar.Single(a => a.idNumeroFactura == numerofactura && a.Modulo ==1 );
                if (objcabCuota != null)
                {
                    objcabCuota.estado = cmbestado.SelectedValue.ToString();
                    //objcabCuota.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());                    
                    int respuesta = da.SaveChanges();
                }

                //var objcabCuotadet = da.CuentaxCobrarDet.Single(a => a.idCuentaxCobrar == objcabCuota.idCuentaxCobrar );
                //if (objcabCuotadet != null)
                //{
                //    objcabCuotadet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                //    da.SaveChanges();
                //    int respuesta = da.SaveChanges();
                //}

                var objcabCuotadet = from a in da.CuentaxCobrarDet
                                     where a.idCuentaxCobrar == objcabCuota.idCuentaxCobrar 
                             select a;
                foreach (CuentaxCobrarDet ord in objcabCuotadet)
                {
                    //ord.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                    ord.estado = cmbestado.SelectedValue.ToString().Substring(0,1);
                }
                da.SaveChanges();

                MessageBox.Show("Registro actualizado con exito.", "Modulo de Facturacion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            { }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtsubtotal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtice_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtiva_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
     
    }
}
