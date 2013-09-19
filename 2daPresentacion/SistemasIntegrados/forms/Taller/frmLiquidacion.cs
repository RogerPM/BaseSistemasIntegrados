using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Taller;
using datos.Taller;
using clases.Seguridad;
using clases.Contabilidad;
using clases.CuentasxCobrar;

namespace forms.Taller
{
    public partial class frmLiquidacion : Form
    {
        clsLiquidacion oLiquidacion = new clsLiquidacion();
        datLiquidacion oDatLiquidacion = new datLiquidacion();
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsOrdenTrabajo oOrdenTrabajo = new clsOrdenTrabajo();
        clsCabeceraComprobante oCabeceraComprobante = new clsCabeceraComprobante();
        clsDetalleComprobante oDetalleComprobante = new clsDetalleComprobante();
        clsCuentaxCobrar oCuentaxCobrar = new clsCuentaxCobrar();
        clsCuentaxCobrarDet oCuentaxCobrarDet = new clsCuentaxCobrarDet();
        DataTable table = new DataTable();

        decimal IvaTrabajos;
        decimal IvaRepuestos;
        decimal IvaOtros;

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
           // btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frmLiquidacion()
        {
            InitializeComponent();
            table.Columns.Add("IdEmpresa", typeof(int));
            table.Columns.Add("cabecera_comprobante", typeof(int));
            table.Columns.Add("linea_comprobante", typeof(int));
            table.Columns.Add("cuenta", typeof(string));
            table.Columns.Add("debe", typeof(decimal));
            table.Columns.Add("haber", typeof(decimal));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroOrden.Text == "" || txtObservacion.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if ((oDatLiquidacion.Guardar(oLiquidacion)))
                {
                    oDatLiquidacion.GuardarCabecera(oCabeceraComprobante);
                    getValoresDetalleComprobante();
                    getValoresCuentaxCobrar();
                    getValoresCuentaxCobrarDet();
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                    txtCodigo.Text = Convert.ToString(oLiquidacion.IdLiquidacion);
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
                }
            }
        }

        public void getValores()
        {
            if (txtCodigo.Text == "")
            {
                oLiquidacion.IdLiquidacion = 0;//PK
            }
            else
            {
                oLiquidacion.IdLiquidacion = Convert.ToInt32(txtCodigo.Text);
            }

            oLiquidacion.IdOrdenTrabajo = Convert.ToInt32(txtNroOrden.Text);
            oLiquidacion.Fecha = Convert.ToDateTime(cbxFecha.Text);
            oLiquidacion.TotalPagar = Convert.ToDecimal(txtTotalPagar.Text);
            oLiquidacion.IdFormaPago = oDatLiquidacion.getIdSegunDescripcionFormaPago(cbxFormaPago.Text);
            oLiquidacion.NumeroCuotaMensual = Convert.ToInt32(speNroMeses.Value);
            oLiquidacion.CuotaMensual = Convert.ToDecimal(txtCuotaMensual.Text);
            oLiquidacion.FechaInicialPago = Convert.ToDateTime(cbxFechaInicialPago.Text);
            oLiquidacion.FechaFinalPago = Convert.ToDateTime(cbxFechaFinalPago.Text);
            oLiquidacion.Observacion = txtObservacion.Text;

            if (cbxEstado.SelectedItem == "Activo")
            {
                oLiquidacion.IdEstado = 1;
            }
            else if (cbxEstado.SelectedItem == "Inactivo")
            {
                oLiquidacion.IdEstado = 2;
            }
            oLiquidacion.IdEmpresa = 1;

            //Guarda asiento contable en cabecera comprobante
            oCabeceraComprobante.IdEmpresa = 1;
            oCabeceraComprobante.fecha = Convert.ToDateTime(cbxFecha.Text);
            oCabeceraComprobante.glosa = "Glosa Taller Servicios de Reparación";
            oCabeceraComprobante.periodo_contable = 9;
            oCabeceraComprobante.periodo_contable_IdAFiscal = DateTime.Today.Year;
            oCabeceraComprobante.IdUsuario = 31;
            oCabeceraComprobante.FechaModificacion = Convert.ToDateTime(cbxFecha.Text);
            oCabeceraComprobante.TipoTransaccion = 10;
        }

        public void getValoresDetalleComprobante()
        {
            //GUARDA ASIENTO POR VENTA DE REPUESTO
            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 1, "11101001",
                Convert.ToDecimal(txtTotalRepuestos.Text) - IvaRepuestos, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 2, "11401001",
                IvaRepuestos, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 3, "11301002",
                0, Convert.ToDecimal(txtTotalRepuestos.Text));

            //GUARDA ASIENTO PARA COBRO DE OTROS
            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 4, "11101001",
                Convert.ToDecimal(txtTotalOtros.Text) - IvaOtros, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 5, "11401001",
                IvaOtros, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 6, "11201002",
                0, Convert.ToDecimal(txtTotalOtros.Text));


            //GUARDA ASIENTO PARA COBRO DE SERVICIOS
            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 7, "11101001",
            Convert.ToDecimal(txtTotalTrabajos.Text) - IvaTrabajos, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 8, "11401001",
                IvaTrabajos, 0);

            table.Rows.Add(oCabeceraComprobante.IdEmpresa, oCabeceraComprobante.numero_comprobante, 9, "41201001",
                0, Convert.ToDecimal(txtTotalTrabajos.Text));

            //Guarda asiento contable en detalle comprobante
            for (int i = 0; i < table.Rows.Count; i++)
            {
                oDetalleComprobante.IdEmpresa = Convert.ToInt32(table.Rows[i][0]);
                oCabeceraComprobante.numero_comprobante = Convert.ToInt32(table.Rows[i][1]);
                oDetalleComprobante.linea_comprobante = Convert.ToInt32(table.Rows[i][2]);
                oDetalleComprobante.cuenta = Convert.ToString(table.Rows[i][3]);
                oDetalleComprobante.debe = Convert.ToDecimal(table.Rows[i][4]);
                oDetalleComprobante.haber = Convert.ToDecimal(table.Rows[i][5]);
                oDatLiquidacion.GuardarDetalleComprobante(oCabeceraComprobante, oDetalleComprobante);
            }
        }


        public void getValoresCuentaxCobrar()
        {
            oCuentaxCobrar.idEmpresa = 1;
            oCuentaxCobrar.idUsuario = 31;
            oCuentaxCobrar.numero_comprobante = Convert.ToInt32(oCabeceraComprobante.numero_comprobante);
            oCuentaxCobrar.idNumeroFactura = oLiquidacion.IdLiquidacion;
            oCuentaxCobrar.Modulo = 2;
            oCuentaxCobrar.TotalCuotas = Convert.ToInt32(speNroMeses.Value);
            oCuentaxCobrar.porcentaje_interes = 0;
            oCuentaxCobrar.estado = Convert.ToString(oLiquidacion.IdEstado);
            oDatLiquidacion.GuardarCuentaxCobrar(oCuentaxCobrar);
        }

        public void getValoresCuentaxCobrarDet()
        {
            oCuentaxCobrarDet.idCuentaxCobrar = oCuentaxCobrar.idCuentaxCobrar;
            oCuentaxCobrarDet.Numero = 1;
            oCuentaxCobrarDet.numero_cuota = Convert.ToInt32(speNroMeses.Value);
            oCuentaxCobrarDet.valor_cuota = Convert.ToDecimal(txtCuotaMensual.Text);
            oCuentaxCobrarDet.valor_mora = 0;
            oCuentaxCobrarDet.fecha_cobro = Convert.ToDateTime(cbxFechaInicialPago.Text);
            oCuentaxCobrarDet.fecha_vencimiento = Convert.ToDateTime(cbxFechaFinalPago.Text);
            oCuentaxCobrarDet.FechaModificacion = Convert.ToDateTime(cbxFecha.Text);
            oCuentaxCobrarDet.estado = Convert.ToString(oLiquidacion.IdEstado);
            oDatLiquidacion.GuardarCuentaxCobrarDet(oCuentaxCobrarDet);
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            frmConsultarOrdenTrabajo f = new frmConsultarOrdenTrabajo();
            f.ShowDialog();
            oOrdenTrabajo = f.e;

            if (oOrdenTrabajo.IdOrdenTrabajo == 0)
            {
                borrar();
            }
            else
            {
                txtNroOrden.Text = Convert.ToString(oOrdenTrabajo.IdOrdenTrabajo);
                txtCliente.Text = oDatLiquidacion.getDescripcionSegunIdPersona(oOrdenTrabajo.IdPersona);
                cbxFechaIngreso.Text = Convert.ToString(oOrdenTrabajo.FechaIngreso);
                cbxFechaSalida.Text = oOrdenTrabajo.FechaEntrega.ToShortDateString();
                txtPlaca.Text = oOrdenTrabajo.NroPlaca;
                txtMarca.Text = oOrdenTrabajo.Marca;
                txtModelo.Text = oOrdenTrabajo.Modelo;
                txtColor.Text = oOrdenTrabajo.Color;
                cbxFormaPago.EditValue = "Contado";
                IvaTrabajos = oOrdenTrabajo.IvaTrabajos;
                txtTotalTrabajos.Text = Convert.ToString(oOrdenTrabajo.TotalTrabajos);
                IvaRepuestos = oOrdenTrabajo.IvaRepuestos;
                txtTotalRepuestos.Text = Convert.ToString(oOrdenTrabajo.TotalRepuestos);
                IvaOtros = oOrdenTrabajo.IvaOtros;
                txtTotalOtros.Text = Convert.ToString(oOrdenTrabajo.TotalOtros);

                txtTotalPagar.Text = Convert.ToString(oOrdenTrabajo.TotalTrabajos + oOrdenTrabajo.TotalRepuestos + oOrdenTrabajo.TotalOtros);

                if (oOrdenTrabajo.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oOrdenTrabajo.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }
                cbxFormaPago.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            getValores();
            if ((oDatLiquidacion.Modificar(oLiquidacion)))
            {
                MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarLiquidacion f = new frmConsultarLiquidacion();
            f.ShowDialog();
            oLiquidacion = f.e;

            if (oLiquidacion.IdLiquidacion == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oLiquidacion.IdLiquidacion);
                txtNroOrden.Text = Convert.ToString(oLiquidacion.IdOrdenTrabajo);
                cbxFecha.Text = Convert.ToString(oLiquidacion.Fecha.ToShortDateString());
                txtCliente.Text = oLiquidacion.Cliente;
                cbxFechaIngreso.Text = Convert.ToString(oLiquidacion.FechaIngreso);
                cbxFechaSalida.Text = oLiquidacion.FechaEntrega.ToShortDateString();
                txtPlaca.Text = oLiquidacion.NroPlaca;
                txtMarca.Text = oLiquidacion.Marca;
                txtModelo.Text = oLiquidacion.Modelo;
                txtColor.Text = oLiquidacion.Color;
                txtTotalTrabajos.Text = Convert.ToString(oLiquidacion.TotalTrabajos);
                txtTotalRepuestos.Text = Convert.ToString(oLiquidacion.TotalRepuestos);
                txtTotalOtros.Text = Convert.ToString(oLiquidacion.TotalOtros);
                txtTotalPagar.Text = Convert.ToString(oLiquidacion.TotalPagar);
                cbxFormaPago.EditValue = oDatLiquidacion.getDescripcionSegunIdFormaPago(oLiquidacion.IdFormaPago);
                speNroMeses.Text = Convert.ToString(oLiquidacion.NumeroCuotaMensual);
                txtCuotaMensual.Text = Convert.ToString(oLiquidacion.CuotaMensual);
                cbxFechaInicialPago.Text = Convert.ToString(oLiquidacion.FechaInicialPago.ToShortDateString());
                cbxFechaFinalPago.Text = Convert.ToString(oLiquidacion.FechaFinalPago.ToShortDateString());
                txtObservacion.Text = oLiquidacion.Observacion;

                if (oLiquidacion.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oLiquidacion.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }
                oLiquidacion.IdEmpresa = 1;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
                cbxFormaPago.Enabled = true;
            }
        }


        public void borrar()
        {
            txtCodigo.Text = "";
            txtNroOrden.Text = "";
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            txtCliente.Text = "";
            cbxFechaIngreso.Text = "";
            cbxFechaSalida.Text = "";
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtTotalTrabajos.EditValue = 0;
            txtTotalRepuestos.EditValue = 0;
            txtTotalOtros.EditValue = 0;
            txtTotalPagar.EditValue = 0;
            cbxFormaPago.Text = "";
            speNroMeses.Value = 1;
            txtCuotaMensual.EditValue = 0;
            cbxFechaInicialPago.Text = DateTime.Today.ToShortDateString();
            cbxFechaFinalPago.Text = DateTime.Today.ToShortDateString();
            txtObservacion.Text = "";
            cbxEstado.SelectedIndex = 0;

            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            speNroMeses.Enabled = false;
            cbxFormaPago.Enabled = false;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatLiquidacion.Eliminar(oLiquidacion))
                {

                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            borrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            cbxFechaInicialPago.Text = DateTime.Today.ToShortDateString();
            cbxFechaFinalPago.Text = DateTime.Today.ToShortDateString();
            cbxFormaPago.Properties.DataSource = oDatLiquidacion.ConsultarFormaPago();
            Seguridad();

        }

        private void speNroMeses_EditValueChanged(object sender, EventArgs e)
        {
            decimal cuotas = Convert.ToDecimal(txtTotalPagar.Text) / Convert.ToInt32(speNroMeses.Value);
            txtCuotaMensual.Text = Convert.ToString(Math.Round(cuotas, 2));
        }

        private void txtTotalPagar_EditValueChanged(object sender, EventArgs e)
        {
            txtCuotaMensual.Text = txtTotalPagar.Text;
        }

        private void cbxFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxFormaPago.Properties.GetIndexByKeyValue(cbxFormaPago.EditValue) == 0)
            {
                speNroMeses.Enabled = false;
                speNroMeses.EditValue = 1;
            }
            else if (cbxFormaPago.Properties.GetIndexByKeyValue(cbxFormaPago.EditValue) == 1)
            {
                speNroMeses.Enabled = true;
            }
        }
    }
}
