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
    public partial class frmComisiones : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DataTable tbldetalle;
        public frmComisiones()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumeroComision.Text = generarmaximo().ToString();
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
                (from prod in da.Comision
                 select prod.IdNumeroComision).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        void limpiar()
        {
            this.txtNumeroComision.Text = "";
            this.txtNumeroPorComision.Text = "";
            this.cbxMarca.SelectedItem = -1;
            this.cbxModelo.SelectedItem = -1;
            this.txtNumeroEmpleado.Text = "";
            this.txtNombreEmpleado.Text = "";
            this.txtMontoVenta.Text = "";
            this.txtMontoComision.Text = "";
            this.txtNumeroFactura.Text = "";
            this.txtFacturaDescripcion.Text = "";
                             
            this.btnGenerar.Enabled = true;
            tbldetalle.Rows.Clear();
            dgvComisionesPagar.DataSource = tbldetalle;
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
                    MessageBox.Show("Ingrese Numero Comision.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.tbldetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Favor ingrese todos los datos.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Comision obj = new Comision();
                // obj.cabecera_comprobante = Int32.Parse(.Text); ES UN CAMPO DE CONTABILIDAD
                obj.IdNumeroComision = Int32.Parse(txtNumeroComision.Text);
                obj.FechaInicial = this.dtpFechaDesde.Value;
                obj.FechaFinal = this.dtpFechaHasta.Value;
                obj.IdNumeroPorcComision = Int32.Parse (this.txtNumeroPorComision.Text);
                obj.MontoVenta = Decimal.Parse (this.txtMontoVenta.Text);

                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                
                da.AddToComision(obj);

                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    int i = 0;
                    while (i < tbldetalle.Rows.Count)
                    {
                        ComisionDet objdet = new ComisionDet();
                        objdet.IdEmpresa = Seguridad.empresa;
                        objdet.idUsuario = Seguridad.usuario;
                        objdet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());

                        objdet.Linea = i + 1;
                        objdet.IdNumeroComision = Int32.Parse(txtNumeroComision.Text);
                        objdet.idEmpleado = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.IdNumeroFactura = Int32.Parse(tbldetalle.Rows[i][2].ToString());
                        objdet.MontoComision = Decimal.Parse(tbldetalle.Rows[i][3].ToString());
                        objdet.FechaPago = DateTime.Parse(tbldetalle.Rows[i][4].ToString());


                        da.AddToComisionDet(objdet);

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

        private void frmComisiones_Load(object sender, EventArgs e)
        {
            cargarEstados();
            tbldetalle = new DataTable();
            tbldetalle.Columns.Add("Cod. Empleado");
            tbldetalle.Columns.Add("Nombre Empleado");
            tbldetalle.Columns.Add("Numero Factura");
            tbldetalle.Columns.Add("Monto Comision");
            tbldetalle.Columns.Add("Fecha Pago");
            dgvComisionesPagar.DataSource = tbldetalle;

        }
        private void cargarEstados()
        {
            try
            {
                var Estado = da.Estado;
                this.cmbestado.DataSource = Estado.ToList();
                cmbestado.ValueMember = "idestado";
                cmbestado.DisplayMember = "descripcion";
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
                fila[0] = this.txtNumeroEmpleado.Text;
                fila[2] = txtNumeroFactura.Text;
                fila[3] = txtMontoComision.Text;
                fila[4] = dtpFechaFormaPagCom.Value;
                tbldetalle.Rows.Add(fila);
                dgvComisionesPagar.DataSource = tbldetalle;

            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                tbldetalle.Rows.RemoveAt(this.dgvComisionesPagar.CurrentCell.RowIndex);
                dgvComisionesPagar.DataSource = tbldetalle;
            }
            catch (Exception ex) { }
        }

       
    }
}
