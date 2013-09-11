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
    public partial class frmCliente : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumeroCliente .Text = generarmaximo().ToString();

        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
         (from prod in da.ClienteDefactura
          select prod.IdNumeroCliente ).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }


        }


        private void cargarEstados()
        {
            try
            {
                var Estado = da.Estado;
                this.cmbEstado .DataSource = Estado.ToList();
                cmbEstado.ValueMember = "IdEstado";
                cmbEstado.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

            }

        }   
            
            void limpiar()
        {
            this.txtNumeroCliente.Text = ""; 
            this.txtIdentificacion.Text = "";
            this.txtNombreRazonSocial.Text = "";
            this.txtApellido.Text = "";
            this.txtTelefono.Text = "";
            this.txtCelular.Text= "";
            this.txtCorreo .Text = "";
            this.txtDireccion.Text = "";
            this.btnguardar.Enabled = true;
        
        }

            private void frmCliente_Load(object sender, EventArgs e)
            {
                cargarEstados();
                cargarClientes();               
            }

            private void cargarClientes()
            {
                try
                {
                    var Estado = da.ClienteDefactura;
                    this.dgvRegistroClientes.DataSource = Estado.ToList();

                }
                catch (Exception ex)
                {

                }
            }

            private void btnconsultar_Click(object sender, EventArgs e)
            {
                cargarClientes();
            }

            private void btnConsulta2_Click(object sender, EventArgs e)
            {
                cargarClientes();
            }

            private void btnguardar_Click(object sender, EventArgs e)
            {
                try
                {
                    if (this.txtIdentificacion .Text == "")
                    {
                        MessageBox.Show("Ingrese Identificaion.", "Modulo de Facturacion",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (this.txtNombreRazonSocial.Text == "")
                    {
                        MessageBox.Show("Ingrese Ingrese Nombre o Razón social para el registro.", "Modulo de Facturacion",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (this.txtDireccion.Text == "")
                    {
                        MessageBox.Show("Ingrese Ingrese la direccion para el registro.", "Modulo de Facturacion",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    ClienteDefactura obj = new ClienteDefactura();
                    obj.IdNumeroCliente = Int32.Parse(txtNumeroCliente.Text);
                    obj.Identificacion = Int32.Parse(txtIdentificacion.Text);
                    obj.Fecha = this.dtpFecha.Value;
                    obj.FechaNacimiento = this.dtpFechaNacimiento.Value;
                    obj.NombreRazonSocial = this.txtNombreRazonSocial.Text;
                    obj.Apellido = this.txtApellido.Text;
                    obj.Genero = cmbGenero.SelectedItem.ToString();
                    obj.Direccion = this.txtDireccion.Text;
                    obj.Telefono = Int32.Parse(txtTelefono.Text);
                    obj.Celular = Int32.Parse(txtCelular.Text);
                    obj.CorreoElectronico = this.txtCorreo.Text;
                    
                    obj.IdEmpresa = Seguridad.empresa;
                    obj.idUsuario = Seguridad.usuario;
                    obj.idEstado = Int32.Parse(cmbEstado.SelectedValue.ToString());
                    
                    da.AddToClienteDefactura(obj);
                    int respuesta = da.SaveChanges();
                    if (respuesta > 0)
                    {
                        MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarClientes();
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void btnmodificar_Click(object sender, EventArgs e)
            {
                try
                {
                    int numeroCliente = Int32.Parse(txtNumeroCliente.Text);
                    var obj = da.ClienteDefactura.Single(a => a.IdNumeroCliente  == numeroCliente);
                    if (obj != null)
                    {

                        obj.IdNumeroCliente = Int32.Parse(txtNumeroCliente .Text);
                        obj.Identificacion  = Int32.Parse(txtIdentificacion.Text);
                        obj.Fecha = this.dtpFecha.Value;
                        obj.NombreRazonSocial = this.txtNombreRazonSocial.Text;
                        obj.Apellido = this.txtApellido.Text;
                        obj.FechaNacimiento = this.dtpFechaNacimiento.Value;
                        obj.Genero = cmbGenero.SelectedItem.ToString();
                        obj.Direccion = this.txtDireccion.Text;
                        obj.Telefono = Int32.Parse(txtTelefono.Text);
                        obj.Celular = Int32.Parse(txtCelular.Text);
                        obj.CorreoElectronico = this.txtCorreo.Text;
                        
                        obj.IdEmpresa = Seguridad.empresa;
                        obj.idUsuario = Seguridad.usuario;
                        obj.idEstado = Int32.Parse(cmbEstado.SelectedValue.ToString());
                        da.SaveChanges();
                        int respuesta = da.SaveChanges();

                        MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarClientes();
                        limpiar();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btneliminar_Click(object sender, EventArgs e)
            {
                try
                {
                    int identificacion = Int32.Parse(txtIdentificacion.Text);
                    var obj = da.ClienteDefactura.Single(a => a.Identificacion == identificacion);
                    if (obj != null)
                    {
                        da.DeleteObject(obj);
                        da.SaveChanges();
                        MessageBox.Show("Registro Eliminado con Exito.", "Modulo de Facturacion",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarClientes();
                        limpiar();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            private void btnsalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void frmCliente_Load_1(object sender, EventArgs e)
            {
                cargarEstados();

            }

            private void btnnuevo_Click_1(object sender, EventArgs e)
            {
                limpiar();
                this.txtNumeroCliente.Text = generarmaximo().ToString();
            }

            private void dgvRegistroClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    this.txtNumeroCliente.Text = dgvRegistroClientes.CurrentRow.Cells[2].Value.ToString();
                    this.dtpFecha.Value = DateTime.Parse(dgvRegistroClientes.CurrentRow.Cells[4].Value.ToString());
                    this.txtIdentificacion.Text = dgvRegistroClientes.CurrentRow.Cells[3].Value.ToString();
                    this.cmbEstado.SelectedValue = Int32.Parse(dgvRegistroClientes.CurrentRow.Cells[13].Value.ToString());
                    this.txtNombreRazonSocial.Text = dgvRegistroClientes.CurrentRow.Cells[5].Value.ToString();
                    this.txtApellido.Text = dgvRegistroClientes.CurrentRow.Cells[6].Value.ToString();
                    this.dtpFechaNacimiento.Value = DateTime.Parse(dgvRegistroClientes.CurrentRow.Cells[7].Value.ToString());
                    this.cmbGenero.SelectedItem = dgvRegistroClientes .CurrentRow.Cells[8].Value.ToString();
                    this.txtTelefono.Text = dgvRegistroClientes.CurrentRow.Cells[10].Value.ToString();
                    this.txtCelular.Text = dgvRegistroClientes.CurrentRow.Cells[11].Value.ToString();
                    this.txtDireccion.Text = dgvRegistroClientes.CurrentRow.Cells[9].Value.ToString();
                    this.txtCorreo.Text = dgvRegistroClientes.CurrentRow.Cells[12].Value.ToString();

                    this.btnmodificar.Enabled = true;
                    this.btneliminar.Enabled = true;
                    this.btnguardar.Enabled = false;

                }
                catch (Exception ex)
                { }
            }

            private void txtDireccion_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnsalir_Click_1(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnmodificar_Click_1(object sender, EventArgs e)
            {
                try
                {
                    int numeroCliente = Int32.Parse(txtNumeroCliente.Text);
                    var obj = da.ClienteDefactura.Single(a => a.IdNumeroCliente == numeroCliente);
                    if (obj != null)
                    {

                        obj.IdNumeroCliente = Int32.Parse(txtNumeroCliente.Text);
                        obj.Identificacion = Int32.Parse(txtIdentificacion.Text);
                        obj.Fecha = this.dtpFecha.Value;
                        obj.NombreRazonSocial = this.txtNombreRazonSocial.Text;
                        obj.Apellido = this.txtApellido.Text;
                        obj.FechaNacimiento = this.dtpFechaNacimiento.Value;
                        obj.Genero = cmbGenero.SelectedItem.ToString();
                        obj.Direccion = this.txtDireccion.Text;
                        obj.Telefono = Int32.Parse(txtTelefono.Text);
                        obj.Celular = Int32.Parse(txtCelular.Text);
                        obj.CorreoElectronico = this.txtCorreo.Text;

                        obj.IdEmpresa = Seguridad.empresa;
                        obj.idUsuario = Seguridad.usuario;
                        obj.idEstado = Int32.Parse(cmbEstado.SelectedValue.ToString());
                        da.SaveChanges();
                        int respuesta = da.SaveChanges();

                        MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarClientes();
                        limpiar();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnconsultar_Click_1(object sender, EventArgs e)
            {
                cargarClientes();
            }

           

           

       
            
          

           

    }
}
