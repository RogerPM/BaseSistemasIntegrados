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
using DevExpress.XtraGrid.Columns;


namespace forms.Taller
{
    public partial class frmPresupuesto : Form
    {
        clsPresupuesto oPresupuesto = new clsPresupuesto();
        clsConsultaClienteP oclsConsultaClienteP = new clsConsultaClienteP();
        datPresupuesto oDatPresupuesto = new datPresupuesto();
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsPresupuestoMO oPresupuestoMO = new clsPresupuestoMO();
        DataTable table = new DataTable();
        int IdArticulo = 0;

        decimal cachesubtotalpresupuesto = 0;
        decimal cachesubtotalpresupuesto2 = 0;

        decimal cachesubtotaltiempo = 0;
        decimal cachesubtotaltiempo2 = 0;

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            btnBuscarCliente.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
           // btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frmPresupuesto()
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "" || gridControl1.DataSource == null || txtObservaciones.Text == "" ||
                txtTotalTiempo.Text == "" || txtSubTotal.Text == "" || txtIva.Text == "" ||
                txtTotalPresupuesto.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if ((oDatPresupuesto.Guardar(oPresupuesto)))
                {
                    getValoresTrabajos();
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                    txtCodigo.Text = Convert.ToString(oPresupuesto.IdPresupuesto);
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
                oPresupuesto.IdPresupuesto = 0;//PK
            }
            else
            {
                oPresupuesto.IdPresupuesto = Convert.ToInt32(txtCodigo.Text);
            }
            oPresupuesto.IdPersona = Convert.ToInt32(oDatPresupuesto.getIdSegunDescripcionPersona(txtCliente.Text));
            oPresupuesto.IdArticulo = IdArticulo;
            oPresupuesto.Fecha = Convert.ToDateTime(cbxFecha.Text);
            oPresupuesto.TotalTiempoTrabajo = Convert.ToInt32(txtTotalTiempo.Text);
            oPresupuesto.Subtotal = Convert.ToDecimal(txtSubTotal.Text);
            oPresupuesto.Iva = Convert.ToDecimal(txtIva.Text);
            oPresupuesto.TotalPresupuesto = Convert.ToDecimal(txtTotalPresupuesto.Text);
            oPresupuesto.Observacion = txtObservaciones.Text;

            if (cbxEstado.SelectedItem == "Activo")
            {
                oPresupuesto.IdEstado = 1;
            }
            else if (cbxEstado.SelectedItem == "Inactivo")
            {
                oPresupuesto.IdEstado = 2;
            }
            oPresupuesto.IdEmpresa = 1;
        }

        public void getValoresTrabajos()
        {
            try
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                oPresupuestoMO.IdPresupuestoMO = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdPresupuestoMO));
                oPresupuestoMO.IdPresupuesto = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdPresupuesto));
                oPresupuestoMO.IdManoObra = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdManoObra));
                oPresupuestoMO.IdTrabajo = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdTrabajo));
                oPresupuestoMO.NroHoras = Convert.ToInt32(gridView1.GetRowCellValue(i, colNroHoras));
                oPresupuestoMO.PrecioHora = Convert.ToDecimal(gridView1.GetRowCellValue(i, colPrecioHora));
                oPresupuestoMO.Total = Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotal));
                oDatPresupuesto.GuardarTrabajos(oPresupuestoMO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }


        public void getValoresParaEliminar()
        {
            try
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    oPresupuestoMO.IdPresupuestoMO = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdPresupuestoMO));
                    oPresupuestoMO.IdPresupuesto = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdPresupuesto));
                    oPresupuestoMO.IdManoObra = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdManoObra));
                    oPresupuestoMO.IdTrabajo = Convert.ToInt32(gridView1.GetRowCellValue(i, colIdTrabajo));
                    oPresupuestoMO.NroHoras = Convert.ToInt32(gridView1.GetRowCellValue(i, colNroHoras));
                    oPresupuestoMO.PrecioHora = Convert.ToInt32(gridView1.GetRowCellValue(i, colPrecioHora));
                    oPresupuestoMO.Total = Convert.ToInt32(gridView1.GetRowCellValue(i, colTotal));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
            }
        }



        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClienteVehiculo f = new frmConsultarClienteVehiculo();
            f.ShowDialog();
            oclsConsultaClienteP = f.e;
            txtCliente.Text = oclsConsultaClienteP.Nombre + " " + oclsConsultaClienteP.Apellido;
            IdArticulo = oclsConsultaClienteP.IdArticulo;
            txtPlaca.Text = oclsConsultaClienteP.NroPlaca;
            txtMarca.Text = oclsConsultaClienteP.Marca;
            txtModelo.Text = oclsConsultaClienteP.Modelo;
        }



        private void btnBuscarMO_Click(object sender, EventArgs e)
        {
     
            frmConsultarManoObra f = new frmConsultarManoObra();
            f.ShowDialog();
            oPresupuestoMO = f.pmo;

            if (oPresupuestoMO.IdManoObra == 0)
            {
                gridControl1.DataSource = null;
                table.Clear();
                txtTotalTiempo.Text = "";
                txtSubTotal.Text = "";
                txtIva.Text = "";
                txtTotalPresupuesto.Text = "";
            }
            else
            {
                cachesubtotalpresupuesto2 = cachesubtotalpresupuesto;
                cachesubtotaltiempo2 = cachesubtotaltiempo;

                DataRow dr = table.NewRow();

                if (Convert.ToInt32(colIdPresupuestoMO.SummaryItem.SummaryValue) == 0
                    || Convert.ToInt32(colIdPresupuestoMO.SummaryItem.SummaryValue) < oDatPresupuesto.getIdSiguientePMO())
                {
                    dr[0] = oDatPresupuesto.getIdSiguientePMO();
                }

                else
                {
                    dr[0] = Convert.ToInt32(colIdPresupuestoMO.SummaryItem.SummaryValue) + 1;
                }


                if (txtCodigo.Text == "" || txtCodigo.Text == "0")
                {
                    dr[1] = oDatPresupuesto.getIdSiguiente();
                }
                else
                {
                    dr[1] = Convert.ToInt32(txtCodigo.Text);
                }

                dr[2] = oPresupuestoMO.IdManoObra;
                dr[3] = oPresupuestoMO.IdTrabajo;
                dr[4] = oDatPresupuesto.getDescripcionSegunIdTipoTrabajo(oPresupuestoMO.IdTrabajo);
                dr[5] = oPresupuestoMO.PrecioHora;
                dr[6] = oPresupuestoMO.NroHoras;
                dr[7] = oPresupuestoMO.Total;

                table.Rows.Add(dr);
                gridControl1.DataSource = table;

                txtTotalTiempo.Text = Convert.ToString(cachesubtotaltiempo2 + Convert.ToInt32(colNroHoras.SummaryItem.SummaryValue));
                txtSubTotal.Text = Convert.ToString(cachesubtotalpresupuesto2 + Convert.ToDecimal(colTotal.SummaryItem.SummaryValue));
                decimal iva = Convert.ToDecimal(txtSubTotal.Text) * Convert.ToDecimal(0.12);
                txtIva.Text = Convert.ToString(Math.Round(iva, 2));
                txtTotalPresupuesto.Text = Convert.ToString(Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtIva.Text));
            }
        }



        private void frmPresupuesto_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            Seguridad();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cachesubtotalpresupuesto = 0;
            cachesubtotalpresupuesto2 = 0;

            cachesubtotaltiempo = 0;
            cachesubtotaltiempo2 = 0;

            table.Clear();
            frmConsultarPresupuesto f = new frmConsultarPresupuesto();
            f.ShowDialog();
            oPresupuesto = f.e;

            if (oPresupuesto.IdPresupuesto == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oPresupuesto.IdPresupuesto);
                cbxFecha.Text = Convert.ToString(oPresupuesto.Fecha.ToShortDateString());
                txtCliente.Text = oDatPresupuesto.getDescripcionSegunIdPersona(oPresupuesto.IdPersona);
                IdArticulo = oPresupuesto.IdArticulo;
                txtPlaca.Text = oPresupuesto.NroPlaca;
                txtMarca.Text = oPresupuesto.Marca;
                txtModelo.Text = oPresupuesto.Modelo;

                gridControl1.DataSource = oDatPresupuesto.ConsultarPresupuestoMO(oPresupuesto.IdPresupuesto);

                txtTotalTiempo.Text = Convert.ToString(oPresupuesto.TotalTiempoTrabajo);
                txtSubTotal.Text = Convert.ToString(oPresupuesto.Subtotal);

                cachesubtotaltiempo = oPresupuesto.TotalTiempoTrabajo;
                cachesubtotalpresupuesto = oPresupuesto.Subtotal;

                txtIva.Text = Convert.ToString(oPresupuesto.Iva);
                txtTotalPresupuesto.Text = Convert.ToString(oPresupuesto.TotalPresupuesto);
                txtObservaciones.Text = oPresupuesto.Observacion;

                if (oPresupuesto.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oPresupuesto.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }

                oPresupuesto.IdEmpresa = 1;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            getValores();
            if ((oDatPresupuesto.Modificar(oPresupuesto)))
            {
                getValoresTrabajos();
                oDatPresupuesto.ModificarTrabajo(oPresupuestoMO);
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
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            txtCliente.Text = "";
            IdArticulo = 0;
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            gridControl1.DataSource = null;
            table.Clear();
            txtTotalTiempo.Text = "";
            txtSubTotal.Text = "";
            txtIva.Text = "";
            txtTotalPresupuesto.Text = "";
            txtObservaciones.Text = "";
            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;

            oPresupuesto.TotalTiempoTrabajo = 0;
            oPresupuesto.Subtotal = 0;
            oPresupuesto.Iva = 0;
            oPresupuesto.TotalPresupuesto = 0;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            getValoresParaEliminar();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatPresupuesto.EliminarTrabajo(oPresupuestoMO))
                {
                    getValores();
                    oDatPresupuesto.Eliminar(oPresupuesto);
                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            borrar();
        }
    }
}
