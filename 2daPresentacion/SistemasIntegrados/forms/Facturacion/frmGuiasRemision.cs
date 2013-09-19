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
using clases.RecursosHumanos;


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
            btnGenerar.Enabled = true;
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
            //this.txtRemitEmpresa.Text = "";
            //this.txtRemitNRUC.Text ="";
            this.txtDestiNombre.Text = "";
            //this.txtDestiNRUC.Text = "";
            this.txtNumeroConductor.Text = "";
            this.txtNombreConductor.Text = "";
            //this.txtTranspMarca.Text = "";
            //this.txtTranspPlaca.Text = "";
            //this.txtTranspLicencia.Text = "";
            //this.txtTranspInscVehi.Text = "";
            this.txtNumeroFactura.Text = "";
           // this.txtNumeroVehiculo.Text = "";


            this.btnGenerar.Enabled = true;
            tbldetalle.Rows.Clear();
            dgvVehiculoTransportar.DataSource = tbldetalle;

            this.btnGenerar.Enabled = true;
            btnAnular.Enabled = false;
            btnImprimir.Enabled = false;
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
                        objdet.IdNumeroGuiaRemision = Int32.Parse(txtNumeroGuiaRemision.Text);
                        objdet.IdNumeroFactura = Int32.Parse(tbldetalle.Rows[i][0].ToString());
                        objdet.FechaEntrega = DateTime.Parse(tbldetalle.Rows[i][2].ToString());


                        da.AddToGuiaRemisionDet(objdet);
                        da.SaveChanges();
                        i++;

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

            FormviewGuiaRemision obj = new FormviewGuiaRemision(Int32.Parse(txtNumeroGuiaRemision.Text));
            obj.ShowDialog();
        }


        private void frmGuiasRemision_Load(object sender, EventArgs e)
        {
            cargarEstados();
            tbldetalle = new DataTable();
            tbldetalle.Columns.Add("Numero Factura");
            tbldetalle.Columns.Add("Cliente");
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
                fila[1] = txtDestiNombre.Text;
                fila[2] = dtpfechallega.Value;
                tbldetalle.Rows.Add(fila);
                dgvVehiculoTransportar.DataSource = tbldetalle;

                this.txtDestiNombre.Text = "";
                this.txtNumeroFactura.Text = "";
                dtpfechallega.Value = DateTime.Now;


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
            FrmConFacturas obj = new FrmConFacturas();
            obj.ShowDialog();
            //this.txtNumeroVehiculo.Text = obj..ToString();
            //this.txtdesarticulo.Text = obj.descripcion;
            //this.txtprecio.Text = obj.precio.ToString();
        }

        private void btnConsultFactura_Click(object sender, EventArgs e)
        {
            FrmConFacturas obj = new FrmConFacturas();
            obj.ShowDialog();
            this.txtNumeroFactura.Text = obj.Codigo.ToString();
            txtDestiNombre.Text = obj.Cliente;

        }

        private void btnConsultarConductor_Click(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            clsPersona clas = new clsPersona();
            cPer.ShowDialog();
            clas = cPer.p;
            txtNumeroConductor.Text = Convert.ToString(clas.IdPersona);           
            txtNombreConductor.Text = clas.NombreRazonSocial + ' ' + clas.Apellido;
           
        }

        private void btnConsultarGuiaRemision_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConGuiaRemision obj = new FrmConGuiaRemision();
                obj.ShowDialog();
                this.txtNumeroGuiaRemision.Text = obj.Codigo.ToString();
                dtpFechaEmision.Value = obj.Fecha;
                dtpInicioTraslado.Value = obj.fechaTraslado;
                txtSitioLlegada.Text = obj.Sitiollegada;
                txtSitioPartida.Text = obj.SitioPartida;
                cmbestado.SelectedValue = obj.codestado;
                txtNumeroConductor.Text = obj.conductor;
                txtNombreConductor.Text = obj.NombreConductor;

                int cod = Int32.Parse(obj.Codigo); 

                var detfactura =
                    from a in da.GuiaRemisionDet
                    join b in da.Factura on a.IdNumeroFactura equals b.IdNumeroFactura
                    join c in da.ClienteDefactura on b.IdNumeroCliente equals c.IdNumeroCliente                    
                    where a.IdNumeroGuiaRemision == cod
                    select new
                    {                                            
                        a.IdNumeroFactura,
                        c.NombreRazonSocial,
                        a.FechaEntrega

                    };

                    try
                    {
                    this.dgvVehiculoTransportar.DataSource = detfactura.ToList();
                    int i = 0;
                    tbldetalle.Rows.Clear();
                   
                    while (i < dgvVehiculoTransportar.Rows.Count)
                    {                       
                    DataRow fila;
                    fila = tbldetalle.NewRow();
                    fila[0] = dgvVehiculoTransportar.Rows[i].Cells["IdNumeroFactura"].Value.ToString();
                    fila[1] = dgvVehiculoTransportar.Rows[i].Cells["NombreRazonSocial"].Value.ToString();                       
                    fila[2] = dgvVehiculoTransportar.Rows[i].Cells["FechaEntrega"].Value.ToString();
                    tbldetalle.Rows.Add(fila);                        
                    i++;
                    }
                    dgvVehiculoTransportar.DataSource = tbldetalle;
                    }
                    catch (Exception ex)
                    { }

            }
            catch (Exception ex)
            { }
            btnAnular.Enabled = true;
            btnImprimir.Enabled = true;
            btnGenerar.Enabled = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Inactivarfacturacxcinventario();
        }

        private void Inactivarfacturacxcinventario()
        {
            try
            {
                int numerofactura = Int32.Parse(txtNumeroGuiaRemision.Text);
                var obj = da.GuiaRemision.Single(a => a.IdNumeroGuiaRemision == numerofactura);
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

                var objdet = from a in da.GuiaRemisionDet
                             where a.IdNumeroGuiaRemision == numerofactura
                             select a;
                foreach (GuiaRemisionDet ord in objdet)
                {
                    ord.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                }
                da.SaveChanges();
                
                MessageBox.Show("Registro actualizado con exito.", "Modulo de Facturacion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            { }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }
    }
}
