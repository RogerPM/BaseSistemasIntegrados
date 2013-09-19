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

namespace forms.Taller
{
    public partial class frmOrdendeTrabajo : Form
    {
        clsOrdenTrabajo oOrdenTrabajo = new clsOrdenTrabajo();
        datOrdenTrabajo oDatOrdenTrabajo = new datOrdenTrabajo();
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsPresupuesto oPresupuesto = new clsPresupuesto();
        datPresupuesto oDatPresupuesto = new datPresupuesto();
        clsPresupuestoMO oPresupuestoMO = new clsPresupuestoMO();
        clsArticuloTaller oArticulo = new clsArticuloTaller();
        clsOrdenTrabajoR oOrdenTrabajoR = new clsOrdenTrabajoR();
        clsOtros oOtros = new clsOtros();
        DataTable table = new DataTable();
        DataTable tableR = new DataTable();
        DataTable tableO = new DataTable();

        decimal cachesubtotalrepuesto = 0;
        decimal cachesubtotalrepuesto2 = 0;

        decimal cachesubtotalotros = 0;
        decimal cachesubtotalotros2 = 0;

        int IdArticulo = 0;

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            btnBuscarPresupuesto.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
           // btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frmOrdendeTrabajo()
        {
            InitializeComponent();

            table.Columns.Add("IdPresupuestoMO", typeof(int));
            table.Columns.Add("IdPresupuesto", typeof(int));
            table.Columns.Add("IdManoObra", typeof(int));
            table.Columns.Add("IdTrabajo", typeof(int));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("PrecioHora", typeof(decimal));
            table.Columns.Add("NroHoras", typeof(int));
            table.Columns.Add("Total", typeof(decimal));


            tableR.Columns.Add("IdRepuesto", typeof(int));
            tableR.Columns.Add("IdOrdenTrabajo", typeof(int));
            tableR.Columns.Add("IdArticulo", typeof(int));
            tableR.Columns.Add("DescripcionRepuesto", typeof(string));
            tableR.Columns.Add("Cantidad", typeof(int));
            tableR.Columns.Add("PrecioUnitario", typeof(decimal));
            tableR.Columns.Add("TotalRepuesto", typeof(decimal));


            tableO.Columns.Add("IdOtros", typeof(int));
            tableO.Columns.Add("IdOrdenTrabajo", typeof(int));
            tableO.Columns.Add("DescripcionOtros", typeof(string));
            tableO.Columns.Add("Precio", typeof(decimal));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroPresupuesto.Text == "" || txtSubTotalTrabajos.Text == "" || txtSubtotalRepuestos.Text == "" ||
                txtSubtotalOtros.Text == "" || txtObservacion.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if ((oDatOrdenTrabajo.Guardar(oOrdenTrabajo)))
                {
                    getValoresRepuestos();
                    getValoresOtros();
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                    txtCodigo.Text = Convert.ToString(oOrdenTrabajo.IdOrdenTrabajo);
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
                oOrdenTrabajo.IdOrdenTrabajo = 0;//PK
            }
            else
            {
                oOrdenTrabajo.IdOrdenTrabajo = Convert.ToInt32(txtCodigo.Text);
            }
            
            oOrdenTrabajo.IdPresupuesto = Convert.ToInt32(txtNroPresupuesto.Text);
            oOrdenTrabajo.IdPersona = Convert.ToInt32(oDatOrdenTrabajo.getIdSegunDescripcionPersona(txtCliente.Text));
            oOrdenTrabajo.IdArticulo = IdArticulo;
            oOrdenTrabajo.Kilometraje = Convert.ToInt32(speKilometraje.Text);
            oOrdenTrabajo.Deposito = tbcDeposito.Value;
            oOrdenTrabajo.FechaRecepcion = Convert.ToDateTime(cbxFechaRecepcion.Text);
            oOrdenTrabajo.InicioReparacion = Convert.ToDateTime(cbxInicioReparacion.Text);
            oOrdenTrabajo.FechaIngreso = Convert.ToDateTime(cbxFechaIngreso.Text);
            oOrdenTrabajo.FechaEntrega = Convert.ToDateTime(cbxFechaEntrega.Text);
            oOrdenTrabajo.IvaTrabajos = Convert.ToDecimal(txtIvaTrabajos.Text);
            oOrdenTrabajo.TotalTrabajos = Convert.ToDecimal(txtTotalTrabajos.Text);
            oOrdenTrabajo.IvaRepuestos = Convert.ToDecimal(txtIvaRepuestos.Text);
            oOrdenTrabajo.TotalRepuestos = Convert.ToDecimal(txtTotalRepuestos.Text);
            oOrdenTrabajo.IvaOtros = Convert.ToDecimal(txtIvaOtros.Text);
            oOrdenTrabajo.TotalOtros = Convert.ToDecimal(txtTotalOtros.Text);
            oOrdenTrabajo.Observacion = txtObservacion.Text;

            if (cbxEstado.SelectedItem == "Activo")
            {
                oOrdenTrabajo.IdEstado = 1;
            }
            else if (cbxEstado.SelectedItem == "Inactivo")
            {
                oOrdenTrabajo.IdEstado = 2;
            }
            oOrdenTrabajo.IdEmpresa = 1;
        }

        public void getValoresRepuestos()
        {
            try
            {
                for (int i = 0; i < gridView2.DataRowCount; i++)
                {
                    oOrdenTrabajoR.IdRepuesto = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdRepuesto));
                    oOrdenTrabajoR.IdOrdenTrabajo = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdOrdenTrabajo));
                    oOrdenTrabajoR.IdArticulo = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdArticulo));
                    oOrdenTrabajoR.DescripcionRepuesto = Convert.ToString(gridView2.GetRowCellValue(i, colDescripcionRepuesto));
                    oOrdenTrabajoR.Cantidad = Convert.ToInt32(gridView2.GetRowCellValue(i, colCantidad));
                    oOrdenTrabajoR.PrecioUnitario = Convert.ToDecimal(gridView2.GetRowCellValue(i, colPrecioUnitario));
                    oOrdenTrabajoR.TotalRepuesto = Convert.ToDecimal(gridView2.GetRowCellValue(i, colTotalRepuesto));
                    oDatOrdenTrabajo.GuardarRepuestos(oOrdenTrabajoR);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }


        public void getValoresRepuestosParaEliminar()
        {
            try
            {
                for (int i = 0; i < gridView2.DataRowCount; i++)
                {
                    oOrdenTrabajoR.IdRepuesto = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdRepuesto));
                    oOrdenTrabajoR.IdOrdenTrabajo = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdOrdenTrabajo));
                    oOrdenTrabajoR.IdArticulo = Convert.ToInt32(gridView2.GetRowCellValue(i, colIdArticulo));
                    oOrdenTrabajoR.DescripcionRepuesto = Convert.ToString(gridView2.GetRowCellValue(i, colDescripcionRepuesto));
                    oOrdenTrabajoR.Cantidad = Convert.ToInt32(gridView2.GetRowCellValue(i, colCantidad));
                    oOrdenTrabajoR.PrecioUnitario = Convert.ToDecimal(gridView2.GetRowCellValue(i, colPrecioUnitario));
                    oOrdenTrabajoR.TotalRepuesto = Convert.ToDecimal(gridView2.GetRowCellValue(i, colTotalRepuesto));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }


        public void getValoresOtros()
        {
            try
            {
                for (int i = 0; i < gridView3.DataRowCount; i++)
                {
                    oOtros.IdOtros = Convert.ToInt32(gridView3.GetRowCellValue(i, colIdOtros));
                    oOtros.IdOrdenTrabajo = Convert.ToInt32(gridView3.GetRowCellValue(i, colIdOrdenTrabajo1));
                    oOtros.DescripcionOtros = Convert.ToString(gridView3.GetRowCellValue(i, colDescripcionOtros));
                    oOtros.Precio = Convert.ToDecimal(gridView3.GetRowCellValue(i, colPrecio));
                    oDatOrdenTrabajo.GuardarOtros(oOtros);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }


        public void getValoresOtrosParaEliminar()
        {
            try
            {
                for (int i = 0; i < gridView3.DataRowCount; i++)
                {
                    oOtros.IdOtros = Convert.ToInt32(gridView3.GetRowCellValue(i, colIdOtros));
                    oOtros.IdOrdenTrabajo = Convert.ToInt32(gridView3.GetRowCellValue(i, colIdOrdenTrabajo1));
                    oOtros.DescripcionOtros = Convert.ToString(gridView3.GetRowCellValue(i, colDescripcionOtros));
                    oOtros.Precio = Convert.ToDecimal(gridView3.GetRowCellValue(i, colPrecio));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }


        private void btnBuscarPresupuesto_CheckedChanged(object sender, EventArgs e)
        {
            frmConsultarPresupuesto f = new frmConsultarPresupuesto();
            f.ShowDialog();
            oPresupuesto = f.e;
            txtNroPresupuesto.Text = Convert.ToString(oPresupuesto.IdPresupuesto);
            txtCliente.Text = oDatPresupuesto.getDescripcionSegunIdPersona(oPresupuesto.IdPersona);
            IdArticulo = oPresupuesto.IdArticulo;
            txtPlaca.Text = oPresupuesto.NroPlaca;
            txtMarca.Text = oPresupuesto.Marca;
            txtModelo.Text = oPresupuesto.Modelo;
            txtColor.Text = oPresupuesto.Color;
            txtCombustible.Text = oPresupuesto.Combustible;
            txtChasis.Text = oPresupuesto.Chasis;
            gridControl1.DataSource = oDatPresupuesto.ConsultarPresupuestoMO(oPresupuesto.IdPresupuesto);
            txtSubTotalTrabajos.Text = Convert.ToString(oPresupuesto.Subtotal);
            txtIvaTrabajos.Text = Convert.ToString(oPresupuesto.Iva);
            txtTotalTrabajos.Text = Convert.ToString(oPresupuesto.TotalPresupuesto);
        }

        private void btnBuscarRepuestos_Click(object sender, EventArgs e)
        { 
            frmConsultarRepuesto f = new frmConsultarRepuesto();
            f.ShowDialog();
            oArticulo = f.e;

            if (oArticulo.IdArticulo == 0)
            {
                gridControl2.DataSource = null;
                tableR.Clear();
                txtSubtotalRepuestos.Text = "";
                txtIvaRepuestos.Text = "";
                txtTotalRepuestos.Text = "";
            }
            else
            {
                cachesubtotalrepuesto2 = cachesubtotalrepuesto;

                DataRow dr = tableR.NewRow();

                if (Convert.ToInt32(colIdRepuesto.SummaryItem.SummaryValue) == 0
                    || Convert.ToInt32(colIdRepuesto.SummaryItem.SummaryValue) < oDatOrdenTrabajo.getIdSiguienteOTR())
                {
                    dr[0] = oDatOrdenTrabajo.getIdSiguienteOTR();
                }

                else
                {
                    dr[0] = Convert.ToInt32(colIdRepuesto.SummaryItem.SummaryValue) + 1;
                }


                if (txtCodigo.Text == "" || txtCodigo.Text == "0")
                {
                    dr[1] = oDatOrdenTrabajo.getIdSiguiente();
                }
                else
                {
                    dr[1] = Convert.ToInt32(txtCodigo.Text);
                }

                dr[2] = oArticulo.IdArticulo;
                dr[3] = oDatOrdenTrabajo.getDescripcionSegunIdArticulo(oArticulo.IdArticulo);
                dr[4] = 0;

                if (oArticulo.PrecioUnitario == null)
                {
                    dr[5] = 0;
                }
                else
                {
                    dr[5] = oArticulo.PrecioUnitario;
                }

                dr[6] = 0;

                tableR.Rows.Add(dr);
                gridControl2.DataSource = tableR;
            }

        }


        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView2.RefreshData();
            if (e.Column.FieldName == "Cantidad")
            {
                decimal total = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, colCantidad))
                    * Convert.ToDecimal(gridView2.GetRowCellValue(e.RowHandle, colPrecioUnitario));

                gridView2.SetRowCellValue(e.RowHandle, colTotalRepuesto, total);

                txtSubtotalRepuestos.Text = Convert.ToString(cachesubtotalrepuesto2 + Convert.ToDecimal(colTotalRepuesto.SummaryItem.SummaryValue));

                decimal iva = Convert.ToDecimal(txtSubtotalRepuestos.Text) * Convert.ToDecimal(0.12);
                txtIvaRepuestos.Text = Convert.ToString(Math.Round(iva, 2));
                txtTotalRepuestos.Text = Convert.ToString(Convert.ToDecimal(txtSubtotalRepuestos.Text) + Convert.ToDecimal(txtIvaRepuestos.Text));
            }
        }


        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView3.RefreshData();
            if (e.Column.FieldName == "Precio")
            {
                txtSubtotalOtros.Text = Convert.ToString(cachesubtotalotros2 + Convert.ToDecimal(colPrecio.SummaryItem.SummaryValue));
                decimal iva = Convert.ToDecimal(txtSubtotalOtros.Text) * Convert.ToDecimal(0.12);
                txtIvaOtros.Text = Convert.ToString(Math.Round(iva, 2));

                txtTotalOtros.Text = Convert.ToString(Convert.ToDecimal(txtSubtotalOtros.Text) + Convert.ToDecimal(txtIvaOtros.Text));
            }
        }



        private void btnBorrarRepuestos_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void btnAgregarOtro_Click(object sender, EventArgs e)
        {
            cachesubtotalotros2 = cachesubtotalotros;
            
            DataRow dr = tableO.NewRow();

            if (Convert.ToInt32(colIdOtros.SummaryItem.SummaryValue) == 0
                || Convert.ToInt32(colIdOtros.SummaryItem.SummaryValue) < oDatOrdenTrabajo.getIdSiguienteOTROS())
            {
                dr[0] = oDatOrdenTrabajo.getIdSiguienteOTROS();
            }

            else
            {
                dr[0] = Convert.ToInt32(colIdOtros.SummaryItem.SummaryValue) + 1;
            }

            if (txtCodigo.Text == "" || txtCodigo.Text == "0")
            {
                dr[1] = oDatOrdenTrabajo.getIdSiguiente();
            }
            else
            {
                dr[1] = Convert.ToInt32(txtCodigo.Text);
            }

            dr[3] = 0;

            tableO.Rows.Add(dr);
            gridControl3.DataSource = tableO;
        }

        private void btnBorrarOtro_Click(object sender, EventArgs e)
        {
            gridView3.DeleteSelectedRows();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cachesubtotalrepuesto = 0;
            cachesubtotalrepuesto2 = 0;

            cachesubtotalotros = 0;
            cachesubtotalotros2 = 0;
            
            tableR.Clear();
            tableO.Clear();
            frmConsultarOrdenTrabajo f = new frmConsultarOrdenTrabajo();
            f.ShowDialog();
            oOrdenTrabajo = f.e;


            if (oOrdenTrabajo.IdOrdenTrabajo == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oOrdenTrabajo.IdOrdenTrabajo);
                cbxFechaRecepcion.Text = Convert.ToString(oOrdenTrabajo.FechaRecepcion.ToShortDateString());
                cbxInicioReparacion.Text = Convert.ToString(oOrdenTrabajo.InicioReparacion.ToShortDateString());
                txtNroPresupuesto.Text = Convert.ToString(oOrdenTrabajo.IdPresupuesto);
                txtCliente.Text = oDatOrdenTrabajo.getDescripcionSegunIdPersona(oOrdenTrabajo.IdPersona);
                IdArticulo = oOrdenTrabajo.IdArticulo;
                txtPlaca.Text = oOrdenTrabajo.NroPlaca;
                txtMarca.Text = oOrdenTrabajo.Marca;
                txtModelo.Text = oOrdenTrabajo.Modelo;
                txtColor.Text = oOrdenTrabajo.Color;
                speKilometraje.Text = Convert.ToString(oOrdenTrabajo.Kilometraje);
                txtChasis.Text = oOrdenTrabajo.Chasis;
                txtCombustible.Text = oOrdenTrabajo.Combustible;
                tbcDeposito.Value = oOrdenTrabajo.Deposito;
                cbxFechaIngreso.Text = Convert.ToString(oOrdenTrabajo.FechaIngreso);
                cbxFechaEntrega.Text = Convert.ToString(oOrdenTrabajo.FechaEntrega.ToShortDateString());

                //Tabajos
                gridControl1.DataSource = oDatOrdenTrabajo.ConsultarPresupuestoMO(oOrdenTrabajo.IdPresupuesto);
                txtSubTotalTrabajos.Text = Convert.ToString(colTotal.SummaryItem.SummaryValue);
                decimal ivaT = Convert.ToDecimal(txtSubTotalTrabajos.Text) * Convert.ToDecimal(0.12);
                txtIvaTrabajos.Text = Convert.ToString(Math.Round(ivaT, 2));
                txtTotalTrabajos.Text = Convert.ToString(oOrdenTrabajo.TotalTrabajos);
                txtTotalRepuestos.Text = Convert.ToString(oOrdenTrabajo.TotalRepuestos);
                txtTotalOtros.Text = Convert.ToString(oOrdenTrabajo.TotalOtros);

                //Repuestos
                gridControl2.DataSource = oDatOrdenTrabajo.ConsultarRepuesto(oOrdenTrabajo.IdOrdenTrabajo);
                txtSubtotalRepuestos.Text = Convert.ToString(colTotalRepuesto.SummaryItem.SummaryValue);
                decimal ivaR = Convert.ToDecimal(txtSubtotalRepuestos.Text) * Convert.ToDecimal(0.12);
                txtIvaRepuestos.Text = Convert.ToString(Math.Round(ivaR, 2));

                cachesubtotalrepuesto = Convert.ToDecimal(colTotalRepuesto.SummaryItem.SummaryValue);

                //Otros
                gridControl3.DataSource = oDatOrdenTrabajo.ConsultarOtros(oOrdenTrabajo.IdOrdenTrabajo);
                txtSubtotalOtros.Text = Convert.ToString(colPrecio.SummaryItem.SummaryValue);
                decimal ivaO = Convert.ToDecimal(txtSubtotalOtros.Text) * Convert.ToDecimal(0.12);
                txtIvaOtros.Text = Convert.ToString(Math.Round(ivaO, 2));

                cachesubtotalotros = Convert.ToDecimal(colPrecio.SummaryItem.SummaryValue);

                txtObservacion.Text = oOrdenTrabajo.Observacion;

                if (oOrdenTrabajo.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oOrdenTrabajo.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }

                oOrdenTrabajo.IdEmpresa = 1;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            getValores();
            if ((oDatOrdenTrabajo.Modificar(oOrdenTrabajo)))
            {
                getValoresRepuestos();
                oDatOrdenTrabajo.ModificarRepuesto(oOrdenTrabajoR);
                getValoresOtros();
                oDatOrdenTrabajo.ModificarOtros(oOtros);
                MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        public void borrar()
        {
            txtCodigo.Text = "";
            txtNroPresupuesto.Text = "";
            txtCliente.Text = "";
            IdArticulo = 0;
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtCombustible.Text = "";
            txtChasis.Text = "";
            speKilometraje.Text = "";
            tbcDeposito.Value = 0;
            cbxFechaRecepcion.Text = DateTime.Today.ToShortDateString();
            cbxInicioReparacion.Text = DateTime.Today.ToShortDateString();
            cbxFechaIngreso.Text = DateTime.Now.ToString();
            cbxFechaEntrega.Text = DateTime.Today.ToShortDateString();

            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            gridControl3.DataSource = null;

            table.Clear();
            tableR.Clear();
            tableO.Clear();

            txtIvaTrabajos.Text = "";
            txtSubTotalTrabajos.Text = "";
            txtTotalTrabajos.Text = "";

            txtSubtotalRepuestos.Text = "";
            txtIvaRepuestos.Text = "";
            txtTotalRepuestos.Text = "";
            cachesubtotalrepuesto = 0;
            cachesubtotalrepuesto2 = 0;

            txtSubtotalOtros.Text = "";
            txtIvaOtros.Text = "";
            txtTotalOtros.Text = "";
            cachesubtotalotros = 0;
            cachesubtotalotros2 = 0;

            txtObservacion.Text = "";
            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;

            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            getValoresRepuestosParaEliminar();
            getValoresOtrosParaEliminar();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatOrdenTrabajo.EliminarRepuesto(oOrdenTrabajoR) && oDatOrdenTrabajo.EliminarOtros(oOtros))
                {
                    getValores();
                    oDatOrdenTrabajo.Eliminar(oOrdenTrabajo);
                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            borrar();
        }

        private void frmOrdendeTrabajo_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            cbxFechaRecepcion.Text = DateTime.Today.ToShortDateString();
            cbxInicioReparacion.Text = DateTime.Today.ToShortDateString();
            cbxFechaIngreso.Text = DateTime.Now.ToString();
            cbxFechaEntrega.Text = DateTime.Today.ToShortDateString();
            Seguridad();
        }
   
    }
}
