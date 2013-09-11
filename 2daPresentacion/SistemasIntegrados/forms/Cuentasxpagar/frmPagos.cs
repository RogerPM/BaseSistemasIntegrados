using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;
using clases.CuentasxCobrar;

namespace forms.Cuentasxpagar
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
            event_click += new delegate_Click(frmPago_event_click);
        }
        int solo = 1;
        decimal suma = 0;
        int solito;
        int Empresa = 1;
        bool resultado=false;
        private void frmPagos_Load(object sender, EventArgs e)
        {
            datosPago pgo = new datosPago();


            deFechaActual.EditValue = DateTime.Today;
            cbxMedioPago.Properties.DataSource = pgo.consultaMedio();
            cbxNroOrdenPagoProveedores.Properties.DataSource = pgo.ConsultaOrden(Empresa);

            // gleBanco.DataSource = pgo.ConsultaBanco();
            cbxBanco.Properties.DataSource = pgo.ConsultaBanco();
            txtNumPago.Text = Convert.ToString(dato.getIdSiguiente());
            solito = datdet.getIdSiguiente();

            cbxcuenta.Properties.DataSource = pgo.ConsultaCuentaBancaria(Empresa );
            datosPagoDetalle pd = new datosPagoDetalle();
            //  gdcdetalle.DataSource = pd.consulta();
          
            gdcConsultaBancaria.DataSource = pgo.ConsultaCuentaBancaria(Empresa );
            gdcNomina.DataSource = datdet.consultaNomina(Empresa);


        }
        void frmPago_event_click(object sender, EventArgs e)
        {
            if (tbcPagos.SelectedIndex == 0)
            {
                cbxNroOrdenPagoProveedores.Enabled = true;
                gdcdetalle.Visible = true;
                gdcDetalleNomina.Visible = false;
            }
            if (tbcPagos.SelectedIndex == 1)
            {
                cbxNroOrdenPagoProveedores.Enabled = false;
                gdcdetalle.Visible = false;
                gdcDetalleNomina.Visible = true;
            }
            if (tbcPagos.SelectedIndex == 2)
            {
                cbxNroOrdenPagoProveedores.Enabled = false;
                gdcdetalle.Visible = false;
                gdcDetalleNomina.Visible = true;
            
            }

        }

        public clsPago clas = new clsPago();
        public clsPagoDos clasdos = new clsPagoDos();
        public clsMensajeCxP men = new clsMensajeCxP();
        datosPago dato = new datosPago();
        private string accion { get; set; }
        datosPagoDetalle datdet = new datosPagoDetalle();
       
        public clsPagoDetalle clasdet = new clsPagoDetalle();
        public clsPagoDetalleDos clasdetdos = new clsPagoDetalleDos();
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;


        private void tsbGuardar_Click(object sender, EventArgs e)
        {
                       
            accion = "G";
            if (accion == "G")
            {
                if (resultado == true )
                {

                    MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);

                }
                else
                {

                    MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                }


                event_click(sender, e);
                frmPago_event_click(sender, e);



            }

        }
        public void get()
        {
            if (txtNumPago.Text == "")
            {
                clas.NumPago = 0;//PK
            }
            else
            {
                clas.NumPago = Convert.ToInt32(txtNumPago.Text);

            }

            clas.FechaIngreso = Convert.ToDateTime(deFechaActual.EditValue);
            clas.NumOrdenPago = Convert.ToInt32(cbxNroOrdenPagoProveedores.EditValue);
           
            clas.TotalPagar = Convert.ToInt32(txtMonto.Text);
            clas.IdUsuario = solo;
            clas.IdEmpresa = solo;
            if (cbxEstado.Text == "Activo")
                clas.IdEstado = 1;
            else
                clas.IdEstado = 0;
            clas.NumComprobante = solo;
                       
        }
        public void set()
        {
            txtNumPago.Text = Convert.ToString(clas.NumPago);
            (deFechaActual.EditValue) = (clas.FechaIngreso);
            (cbxNroOrdenPagoProveedores.EditValue) = (clas.NumOrdenPago);
           


            txtTotalPagar.Text = Convert.ToString(clas.TotalPagar);
            solo = clas.IdUsuario;
            solo = clas.IdEmpresa;
            
            if (clas.IdEstado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }
            solo = Convert.ToInt32(clas.NumComprobante);

        }


        public void getDos()
        {
            if (txtNumPago.Text == "")
            {
                clasdos.NumPago = 0;//PK
            }
            else
            {
                clasdos.NumPago = Convert.ToInt32(txtNumPago.Text);

            }

            clasdos.FechaIngreso = Convert.ToDateTime(deFechaActual.EditValue);
            clasdos.TotalPagar = Convert.ToInt32(txtMonto.Text);
            clasdos.IdUsuario = solo;
            clasdos.IdEmpresa = solo;
            if (cbxEstado.Text == "Activo")
                clasdos.IdEstado = 1;
            else
                clasdos.IdEstado = 0;
            clasdos.NumComprobante = solo;

        }
        public void setDos()
        {
            txtNumPago.Text = Convert.ToString(clasdos.NumPago);
            (deFechaActual.EditValue) = (clasdos.FechaIngreso);
            txtTotalPagar.Text = Convert.ToString(clasdos.TotalPagar);
            solo = clasdos.IdUsuario;
            solo = clasdos.IdEmpresa;

            if (clasdos.IdEstado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }
            solo = Convert.ToInt32(clasdos.NumComprobante);

        }


        public void limpiar()
        {

            deFechaActual.Text = "";
            txtNumPago.Text = "";

            (txtTotalPagar.Text) = "";

        }

      

     
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            resultado = false;
            frmConsultaPago fre = new frmConsultaPago();
            fre.ShowDialog();
            clas = fre.Pg;
            if (clas.NumPago == 0)
            {
                limpiar();
                txtNumPago.Text = Convert.ToString(dato.getIdSiguiente());
                deFechaActual.EditValue = DateTime.Today;
            }
            else
            {
                datosPagoDetalle pgo = new datosPagoDetalle();
                set();
                cargar();

            }


        }
        public void cargar()
        {
            int numeroPago = Convert.ToInt32(txtNumPago.Text);

            gdcdetalle.DataSource = datdet.consultaNumPago(clas.NumPago);
            txtTotalPagar.Text = Convert.ToString(datdet.consultaPagoDETALLE(numeroPago));
            
        }
        public void cargarDos()
        {
            int numeroPago = Convert.ToInt32(txtNumPago.Text);

            gdcDetalleNomina.DataSource = datdet.consultaNumPagoDos (numeroPago);
            txtTotalPagar.Text = Convert.ToString(datdet.consultaPagoDETALLE(numeroPago));

        }
        private void cbxNroOrdenPagoProveedores_EditValueChanged(object sender, EventArgs e)
        {
            // cbxNroOrdenPagoProveedores.Properties.DataSource = pgo.ConsultaOrden();
            int numero;

            numero = Convert.ToInt32(cbxNroOrdenPagoProveedores.EditValue);
           txtProveedor.Text = dato.ConsultaNombre(numero);
          //
            
                          
                    cargarDetalle(numero);

                    txtTotalito.Text =Convert.ToString (datdet.consultaTotal(numero));
                    tbcPagos.SelectTab(0);
                   
                   
                   // txtTotalito.Text = Convert.ToString(datdet.consultaTotal(numero));
               
           
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (tbcPagos.SelectedIndex == 0)
            {
                //para obtener modificar el saldo
                int idbanco, cuenta, valor, numero;

                decimal saldo;
                idbanco = Convert.ToInt32(cbxBanco.EditValue);
                cuenta = Convert.ToInt32(cbxcuenta.EditValue);
              
                saldo = dato.ConsultaSaldo(cuenta);
                
                numero =Convert.ToInt32  (cbxNroOrdenPagoProveedores.EditValue);
                if(Convert.ToInt32 (saldo)>= Convert.ToInt32(txtMonto.Text))
                {
               
                //*********************************
                    if (resultado == false)
                    {
                       
                        get();
                        resultado = dato.Guardar(clas);
                    }
                getDet();
              //  accion = "A";
                //if (accion == "A")
               // {

                    if (datdet.Guardar(clasdet))
                    {

                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                      //  cargarDetalle();
                        valor = (Convert.ToInt32(saldo)) - (Convert.ToInt32(txtMonto.Text));
                        dato.ModificarSaldo(cuenta, valor);
                        dato.ModificarEstadoOrden(numero);
                        cargar();
                        
                      
                    }
                    else
                    {

                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                    }


                    event_click(sender, e);
                    frmPago_event_click(sender, e);

                }

                }
                if (tbcPagos.SelectedIndex == 1)
                {
                    int idbanco, cuenta, valor, numero;

                    decimal saldo;
                    idbanco = Convert.ToInt32(cbxBanco.EditValue);
                    cuenta = Convert.ToInt32(cbxcuenta.EditValue);
                    saldo = dato.ConsultaSaldo(cuenta);

                    if (Convert.ToInt32(saldo) >= Convert.ToInt32(txtMonto.Text))
                    {

                        //*********************************
                        if (resultado == false)
                        {
                            getDos();
                            resultado = dato.GuardarNomina(clasdos);
                        }
                        getDetNomina();
                        //  accion = "A";
                        //if (accion == "A")
                        // {

                        if (datdet.GuardarDetalleNomina(clasdetdos))
                        {

                            MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                            //  cargarDetalle();
                            valor = (Convert.ToInt32(saldo)) - (Convert.ToInt32(txtMonto.Text));
                            dato.ModificarSaldo(cuenta, valor);
                         //   dato.ModificarEstadoOrden(numero);
                            cargarDos();
                        }
                        else
                        {

                            MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                        }


                        event_click(sender, e);
                        frmPago_event_click(sender, e);





                    }
                    else
                        MessageBox.Show(men.Error_sal, men.Titulo, MessageBoxButtons.OK);
                }

                if (tbcPagos.SelectedIndex == 2)
                {
                    int idbanco, cuenta, valor, numero;

                    decimal saldo;
                    idbanco = Convert.ToInt32(cbxBanco.EditValue);
                    cuenta = Convert.ToInt32(cbxcuenta.EditValue);
                    saldo = dato.ConsultaSaldo(cuenta);

                    if (Convert.ToInt32(saldo) >= Convert.ToInt32(txtMonto.Text))
                    {

                        //*********************************
                        if (resultado == false)
                        {
                            getDos();
                            resultado = dato.GuardarNomina(clasdos);
                        }
                        getDetNomina();
                        //  accion = "A";
                        //if (accion == "A")
                        // {

                        if (datdet.GuardarDetalleNomina(clasdetdos))
                        {

                            MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                            //  cargarDetalle();
                            valor = (Convert.ToInt32(saldo)) - (Convert.ToInt32(txtMonto.Text));
                            dato.ModificarSaldo(cuenta, valor);
                            //   dato.ModificarEstadoOrden(numero);
                            cargarDos();
                        }
                        else
                        {

                            MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                        }


                        event_click(sender, e);
                        frmPago_event_click(sender, e);





                    }
                    else
                        MessageBox.Show(men.Error_sal, men.Titulo, MessageBoxButtons.OK);
                }



        }
        public void getDet()
        {
            if (solito == 0)
            {
                clasdet.NumLinea = 0;//PK
            }
            else
            {
                clasdet.NumLinea = solito;

            }

            clasdet.IdMedioPago = Convert.ToInt32(cbxMedioPago.EditValue);
            clasdet.Monto = Convert.ToInt32(txtMonto.Text);
            clasdet.NumeroCuenta = Convert.ToInt32(cbxcuenta.EditValue);
            clasdet.IdEmpresa = solo;
            clasdet.IdBanco = Convert.ToInt32(cbxBanco.EditValue);
            clasdet.NumComprobante = solo;
            //  clasdet.NumComision = 1;// Convert.ToInt32(null);
            //clasdet.NumNominaCab =1;//Convert.ToInt32(null);
            clasdet.NumPago = Convert.ToInt32(txtNumPago.Text);


        }

        public void getDetNomina()
        {
            if (solito == 0)
            {
                clasdetdos.NumLinea = 0;//PK
            }
            else
            {
                clasdetdos.NumLinea = solito;

            }

            clasdetdos.IdMedioPago = Convert.ToInt32(cbxMedioPago.EditValue);
            clasdetdos.Monto = Convert.ToInt32(txtMonto.Text);
            clasdetdos.NumeroCuenta = Convert.ToInt32(cbxcuenta.EditValue);
            clasdetdos.IdEmpresa = solo;
            clasdetdos.IdBanco = Convert.ToInt32(cbxBanco.EditValue);
            clasdetdos.NumComprobante = solo;
            clasdetdos.NumNominaCab = 1;//Convert.ToInt32(null);
            clasdetdos.NumPago = Convert.ToInt32(txtNumPago.Text);


        }
        public void setDet()
        {

            solito = (clasdet.NumLinea);
            cbxMedioPago.EditValue = clasdet.IdMedioPago;
            (txtMonto.EditValue) = (clasdet.Monto);
            (cbxcuenta.EditValue) = (clasdet.NumeroCuenta);
            solo = clasdet.IdEmpresa;
            (cbxBanco.EditValue) = clasdet.IdBanco;
            solo = Convert.ToInt32(clasdet.NumComprobante);
           
            (txtNumPago.EditValue) = clasdet.NumPago;

           // txtTotalPagar.Text = Convert.ToString(clas.TotalPagar);
          
        }

        public void setDetNomina()
        {

            solito = (clasdetdos.NumLinea);
            cbxMedioPago.EditValue = clasdetdos.IdMedioPago;
            (txtMonto.EditValue) = (clasdetdos.Monto);
            (cbxcuenta.EditValue) = (clasdetdos.NumeroCuenta);
            solo = clasdetdos.IdEmpresa;
            (cbxBanco.EditValue) = clasdetdos.IdBanco;
            solo = Convert.ToInt32(clasdetdos.NumComprobante);
            //   nulo   =Convert.ToString (clasdet.NumComision);
          //  txtlocura .Text  =Convert.ToString  (clasdetdos.NumNominaCab);
            (txtNumPago.EditValue) = clasdetdos.NumPago;

            // txtTotalPagar.Text = Convert.ToString(clas.TotalPagar);

        }

        public void cargarDetalle(int numero)
        {
            datosPago pgo = new datosPago();

            gdcDetalleOrdenPago.DataSource = pgo.ConsultaOrdenDetalle(numero);
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
                get();
                clas.IdEstado = 0;
                accion = "E";
                if (accion == "E")
                {
                    if (dato.EliminarEstado(clas))
                    {
                        MessageBox.Show(men.Exito_eli, men.Titulo, MessageBoxButtons.OK);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(men.Error_eli, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                event_click(sender, e);
                frmPago_event_click(sender, e);
            
        }

        private void gdcdetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtNumPago.Text = Convert.ToString(dato.getIdSiguiente());
            deFechaActual.EditValue = DateTime.Today;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       


    }  

    }

