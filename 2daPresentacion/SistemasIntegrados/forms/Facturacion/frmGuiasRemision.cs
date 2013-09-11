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
    public partial class frmGuiasRemision : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        private DataTable tbldetalle;
        public frmGuiasRemision()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumeroGuiaRemision.Text = generarmaximo().ToString();
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
                (from prod in da.GuiaRemision 
                 select prod.IdNumeroGuiaRemision).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        void limpiar()
        {
            this.txtNumeroGuiaRemision.Text = "";
            this.txtSitioPartida.Text = "";
            this.txtSitioLlegada.Text = "";
            this.txtRemitEmpresa.Text = "";
            this.txtRemitNRUC.Text ="";
            this.txtDestiNombre.Text = "";
            this.txtDestiNRUC.Text = "";
            this.txtNumeroConductor.Text = "";
            this.txtNombreConductor.Text = "";
            this.txtTranspMarca.Text = "";
            this.txtTranspPlaca.Text = "";
            this.txtTranspLicencia.Text = "";
            this.txtTranspInscVehi.Text = "";
            this.txtNumeroFactura.Text = "";
            this.txtNumeroVehiculo.Text = "";


            this.btnGenerar.Enabled = true;
            tbldetalle.Rows.Clear();
            dgvVehiculoTransportar.DataSource = tbldetalle;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNumeroGuiaRemision.Text == "")
                {
                    MessageBox.Show("Ingrese Numero Guia de Remision.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.tbldetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Favor ingrese un articulo para su transporte.", "Modulo de Facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GuiaRemision obj = new GuiaRemision();
                obj.IdNumeroGuiaRemision = Int32.Parse(txtNumeroGuiaRemision.Text);
                obj.FechaEmision = this.dtpFechaEmision.Value;
                obj.SitioSalida = this.txtSitioPartida.Text;
                obj.Sitiollegada = this.txtSitioLlegada.Text;
                obj.FechaTraslado = this.dtpInicioTraslado.Value;
                obj.IdPesonaNatural = Int32.Parse(txtNumeroConductor.Text);

                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                
                da.AddToGuiaRemision(obj);
                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    int i = 0;
                    while (i < tbldetalle.Rows.Count)
                    {
                        GuiaRemisionDet objdet = new GuiaRemisionDet();
                        objdet.IdEmpresa = Seguridad.empresa;
                        objdet.idUsuario = Seguridad.usuario;
                        objdet.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());

                        objdet.Linea = i + 1;
                        objdet.IdNumeroGuiaRemision = Int32.Parse(txtNumeroFactura.Text);
                        objdet.IdNumeroFactura = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.FechaEntrega = DateTime.Parse(tbldetalle.Rows[i][1].ToString());


                        da.AddToGuiaRemisionDet(objdet);

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

        private void frmGuiasRemision_Load(object sender, EventArgs e)
        {
            cargarEstados();
            tbldetalle = new DataTable();
            tbldetalle.Columns.Add("Numero Factura");
            tbldetalle.Columns.Add("Fecha Entrega");
            dgvVehiculoTransportar.DataSource = tbldetalle;

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
                fila[0] = this.txtNumeroFactura.Text;
                fila[1] = dtpInicioTraslado.Value;
                tbldetalle.Rows.Add(fila);
                dgvVehiculoTransportar.DataSource = tbldetalle;

            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                tbldetalle.Rows.RemoveAt(this.dgvVehiculoTransportar.CurrentCell.RowIndex);
                dgvVehiculoTransportar.DataSource = tbldetalle;
            }
            catch (Exception ex) { }
        }

        private void btnConsultVehiculo_Click(object sender, EventArgs e)
        {
            FrmConProductos obj = new FrmConProductos();
            obj.ShowDialog();
            this.txtNumeroVehiculo.Text = obj.codigo;
            //this.txtdesarticulo.Text = obj.descripcion;
            //this.txtprecio.Text = obj.precio.ToString();
        }
    }
}
