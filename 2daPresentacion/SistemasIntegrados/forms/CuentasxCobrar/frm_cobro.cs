using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;
using clases.Cuentasxpagar;

namespace forms.CuentasxCobrar
{
    public partial class frm_cobro : Form
    {
        string AccionBotonAplastado;
        int modulo = 0;
        public clsCuentaxCobrar objCtaxCobrar = new clsCuentaxCobrar();
        public clsCobro objCobro = new clsCobro();
        public clsCobroDet cobroDet = new clsCobroDet();
        public clases.CuentasxCobrar.clsMensaje objMensaje = new clases.CuentasxCobrar.clsMensaje();
        public clsDatosCobro objDatosCobro = new clsDatosCobro();
        public clsDatosCuentaxCobrarDet ctaDet = new clsDatosCuentaxCobrarDet();
        public clsBanco objBanco = new clsBanco();
        public clsMedioPago medioPago = new clsMedioPago();
        public delegate void delegate_Click(object sender, EventArgs e);

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscaCtaxCobrar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Enabled = frmPrincipal.Escritura;
            btnGrabar.Enabled = frmPrincipal.Escritura;
            //eliminacion
            //btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frm_cobro()
        {
            InitializeComponent();
        }
        public void Inactivar()
        {
            this.txtNoCtaCobro.Properties.ReadOnly = true;
            this.txtNoCobro.Properties.ReadOnly = true;
            this.txtNoFactura.Properties.ReadOnly = true;
            this.txtNumeroCuota.Properties.ReadOnly = true;
            this.txtInteres.Properties.ReadOnly = true;
            this.txtMora.Properties.ReadOnly = true;
            this.dtFecha.Enabled = false;
            this.dtFechaVen.Enabled = false;
            this.txtModulo.Properties.ReadOnly = true;
        }

        public void Limpiar()
        {
            this.txtNoCobro.Text = "";
            this.txtNoCtaCobro.Text = "";
            this.txtNoFactura.Text = "";
            this.txtNumeroCuota.Text = "";
            this.txtInteres.Text = "";
            this.txtMora.Text = "";
            this.txtModulo.Text = "";
        }

        
        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtNoCtaCobro.Properties.ReadOnly = true;
            this.txtNoCobro.Properties.ReadOnly = true;
            this.txtNoFactura.Properties.ReadOnly = true;
            this.dtFecha.EditValue = DateTime.Today;
            this.dtFechaVen.Enabled = false;
            this.txtNumeroCuota.Properties.ReadOnly = true;
            this.txtValorCuota.Properties.ReadOnly = true;
            this.txtInteres.Properties.ReadOnly = true;

            clsDatosCobro objDatosCobro = new clsDatosCobro();
            this.txtNoCobro.Text = Convert.ToString(objDatosCobro.getIdSiguiente());
            
        }

        private void frm_cobro_Load(object sender, EventArgs e)
        {
            this.Inactivar();
            gluMedioPago.Properties.DataSource = objDatosCobro.consultaMedioPago();
            gluMedioPago.EditValue = 1;
            clsDatosBanco banco = new clsDatosBanco();
            this.gueBanco.Properties.DataSource = banco.consultaBancoGeneral();
            gueBanco.EditValue = 1;
            dtFecha.EditValue = DateTime.Today;
            dtFechaVen.EditValue = DateTime.Today;
            Seguridad();
        }

        public void Set()
        {
            this.txtNoCtaCobro.Text = Convert.ToString(objCtaxCobrar.idCuentaxCobrar);
            this.txtNoFactura.Text = Convert.ToString(objCtaxCobrar.idNumeroFactura);
        }

        public Boolean Get()
        {
            try
            {
                objCobro.idEmpresa = 1;
                objCobro.idUsuario = 1;
                objCobro.idCobro = Convert.ToInt32(this.txtNoCobro.EditValue);
                objCobro.idCuentaxCobrar = Convert.ToInt32(this.txtNoCtaCobro.EditValue);
                objCobro.idCabeceraComprobante = 1;
                objCobro.Fecha = Convert.ToDateTime(this.dtFecha.EditValue);
                objCobro.FechaModificacion = Convert.ToDateTime(this.dtFechaVen.EditValue);
                objCobro.NumeroCuota = Convert.ToInt32(txtNumeroCuota.Text);
                objCobro.ValorCuota = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colvalor_cuota));
                objCobro.Interes = Convert.ToInt32(txtInteres.Text);
                objCobro.Mora = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_mora));
                objCobro.ValorPagado = Convert.ToDecimal(txtValor.Text);
                objCobro.Saldo = Convert.ToDecimal(txtSaldo.Text);
                objCobro.idEstado = cbxEstado.Text;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }
        }
        decimal valorTotal = 0;
        public Boolean getDet()
        {
            try
            {
                cobroDet.idCobro = Convert.ToInt32(this.txtNoCobro.EditValue);
                cobroDet.numero =  objDatosCobro.getNumero();
                cobroDet.idBanco = Convert.ToInt32(gueBanco.EditValue);
                cobroDet.idMedioPago = Convert.ToInt32(gluMedioPago.EditValue);
                
                cobroDet.Valor = valorTotal;

                cobroDet.NumeroDocumento = 1;//Convert.ToInt32(txtNoComprobante.Text);
                cobroDet.Observacion = txtObservacion.Text;
                cobroDet.idEstado = cbxEstado.Text;
                cobroDet.idEmpresa = 1;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }
        }

        private void btnBuscaCtaxCobrar_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            datos.CuentasxCobrar.clsDatosCuentaxCobrar objDatosCtaxCobrar = new datos.CuentasxCobrar.clsDatosCuentaxCobrar();
            String[] NombresColumnas = new String[9];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "ID Usuario";
            NombresColumnas[2] = "ID Cuenta Por Cobrar";
            NombresColumnas[3] = "Numero de Comprobante";
            NombresColumnas[4] = "Modulo";
            NombresColumnas[5] = "Numero de Factura";
            NombresColumnas[6] = "Total Cuotas";
            NombresColumnas[7] = "Interes";
            NombresColumnas[8] = "Estado";

            List<object> lista = new List<object>(objDatosCtaxCobrar.consultaCuentaPorCobrarGeneral());
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Cuentas Por Cobrar", NombresColumnas);
                FormularioBusqueda.OcultarColumna(0);
                FormularioBusqueda.OcultarColumna(1);

                FormularioBusqueda.ShowDialog();

                  if (FormularioBusqueda.Seleccion)
                  {
                      DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                      objCtaxCobrar.idCuentaxCobrar = Convert.ToInt32(Fila.Cells[2].Value);
                      objCtaxCobrar.idNumeroFactura = Convert.ToInt32(Fila.Cells[5].Value);
                      objCtaxCobrar.TotalCuotas = Convert.ToInt32(Fila.Cells[6].Value);
                      objCtaxCobrar.porcentaje_interes = Convert.ToInt32(Fila.Cells[6].Value);
                      
                      this.cbxEstado.Text = Convert.ToString(Fila.Cells[8].Value);
                      objCtaxCobrar.estado = Convert.ToString(Fila.Cells[8].Value);

                      modulo = Convert.ToInt32(Fila.Cells[4].Value);
                      if (modulo == 1)
                      {
                          this.txtModulo.Text = "Facturacion";
                          txtIdCliente.Text = Convert.ToString(objDatosCobro.ConsultaIdFactura(objCtaxCobrar.idNumeroFactura));
                          int idCliente = Convert.ToInt32(txtIdCliente.Text);
                          txtNombreCliente.Text = Convert.ToString (objDatosCobro.ConsultaIdCliente(idCliente));
                          grvCtaDet.DataSource = ctaDet.consultaCuentaPorCobrarDetalleEspecifica(Convert.ToInt32(Fila.Cells[2].Value));
                          txtNumeroCuota.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colnumero_cuota));
                          this.txtInteres.Text = Convert.ToString(Fila.Cells[7].Value);
                          this.txtValorCuota.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colvalor_cuota));
                          this.txtMora.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colvalor_mora));
                          valorTotal = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_cuota)) + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_interes)) + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_mora));
                          txtValor.Text = Convert.ToString(valorTotal);
                      }
                      else
                          if (modulo == 2)
                          {
                              this.txtModulo.Text = "Taller";
                              int  ordenTrabajo = objDatosCobro.ConsultaIdFacturaTaller(objCtaxCobrar.idNumeroFactura);
                              txtIdCliente.Text = Convert.ToString(objDatosCobro.ConsultaClienteTaller(ordenTrabajo));
                              int idCliente = Convert.ToInt32(txtIdCliente.Text);
                              txtNombreCliente.Text = Convert.ToString(objDatosCobro.ConsultaNombreTaller(idCliente));
                              grvCtaDet.DataSource = ctaDet.consultaCuentaPorCobrarDetalleEspecifica(Convert.ToInt32(Fila.Cells[2].Value));
                              txtNumeroCuota.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colnumero_cuota));
                              this.txtInteres.Text = Convert.ToString(Fila.Cells[7].Value);
                              this.txtValorCuota.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colvalor_cuota));
                              this.txtMora.Text = Convert.ToString(gridView1.GetFocusedRowCellValue(colvalor_mora));
                              valorTotal = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_cuota)) + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_interes)) + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colvalor_mora));
                              txtValor.Text = Convert.ToString(valorTotal);
                          }
                
                        this.Set();
                    }
                }
                else
                {
                    MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
                }
            }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "G";
            if (AccionBotonAplastado == "G")
            {
                if (resultado == true)
                {

                    MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                    this.Limpiar();
                    
                }
                else
                {

                    MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                }
        }
        }

       

        bool resultado = false;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (resultado == false)
            {

                Get();
                resultado = objDatosCobro.guardar(objCobro);
            }
            getDet();

            

        if (objDatosCobro.guardarDetalle(cobroDet))
                    {

                        MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                      //  cargarDetalle();
                     
                    }
                    else
                    {

                        MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                    }



                }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        
                }

       
        

        
        
    }

