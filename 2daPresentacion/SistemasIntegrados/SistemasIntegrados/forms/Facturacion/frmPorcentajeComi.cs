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
    public partial class frmPorcentajeComi : Form
    {
        private FacturacionEntities da = new FacturacionEntities ();
        public frmPorcentajeComi()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtmontoventa.Text == ""  )
                {
                    MessageBox.Show("Ingrese Monto de Venta.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtporcomision.Text == "")
                {
                    MessageBox.Show("Ingrese Porcentaje de Comision.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            //    if (this.txtformaPago.Text == "")
            //    {
            //        MessageBox.Show("Ingrese Forma de Pago.", "Modulo de Facturacion",
            //MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


                PorcentajeComision obj = new PorcentajeComision();
                obj.IdNumeroPorcComision = Int32.Parse(txtNumero.Text);
                obj.descripcion = this.txtdescripcion.Text;
                obj.Fecha = this.dtfecha.Value;
                obj.IdFormaPago = Int32.Parse(cmbFormaPago.SelectedValue.ToString());
                obj.MontoVenta = Decimal.Parse(this.txtmontoventa.Text);
                obj.Porcentaje = Decimal.Parse(this.txtporcomision.Text);

                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                da.AddToPorcentajeComision(obj);
                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarPorcentajescomisiones();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message , "Modulo de Facturacion",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

        }

        private void frmPorcentajeComi_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cargarPorcentajescomisiones();
            cargarFormaPagos();
        }

        private void cargarPorcentajescomisiones()
        {
            try
            {
                var Estado = da.PorcentajeComision;
                this.dgvporcomision.DataSource = Estado.ToList();
                
            }
            catch (Exception ex)
            {

            }
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
                this.cmbFormaPago.DataSource = FormaPago.ToList();
                cmbFormaPago.ValueMember = "IdFormaPago";
                cmbFormaPago.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

            }

        }
        //private void btnformapago_Click(object sender, EventArgs e)
        //{
        //    FrmConFormaPago obj = new FrmConFormaPago();
        //    obj.ShowDialog();
        //    this.txtformaPago .Text = obj.codigo;
        //    //this.txtdesformapago.Text = obj.descripcion;
        //}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumero.Text = generarmaximo().ToString();


        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
         (from prod in da.PorcentajeComision
          select prod.IdNumeroPorcComision).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex)
            {
                return 1;
            }

        }

        void limpiar() {
            this.txtNumero.Text = "";
            this.txtdescripcion.Text = "";
            //this.txtdesformapago.Text = "";
            //this.txtformaPago.Text = "";
            this.txtmontoventa.Text = "";
            this.txtporcomision.Text = "";
            this.btnguardar.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cargarPorcentajescomisiones();
        }

        private void dgvporcomision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                

                this.txtNumero.Text = dgvporcomision.CurrentRow.Cells[2].Value.ToString();
                this.txtdescripcion.Text = dgvporcomision.CurrentRow.Cells[4].Value.ToString();
                //this.txtdesformapago.Text = "";
                //this.txtformaPago.Text = dgvporcomision.CurrentRow.Cells[5].Value.ToString();
                this.cmbFormaPago.SelectedItem = dgvporcomision.CurrentRow.Cells[6].Value.ToString();
                this.txtmontoventa.Text = dgvporcomision.CurrentRow.Cells[7].Value.ToString();
                this.txtporcomision.Text = dgvporcomision.CurrentRow.Cells[6].Value.ToString();

                this.cmbestado.SelectedValue = Int32.Parse(dgvporcomision.CurrentRow.Cells[8].Value.ToString());

                this.btnmodificar.Enabled = true;
                this.btneliminar.Enabled = true;
                this.btnguardar.Enabled = false;

            }
            catch (Exception ex)
            { }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                //PorcentajeComision obj = new PorcentajeComision();

                int codigo = Int32.Parse(txtNumero.Text);
                var obj = da.PorcentajeComision.Single(a => a.IdNumeroPorcComision == codigo);
                if (obj != null)
                {

                
                obj.IdNumeroPorcComision = Int32.Parse(txtNumero.Text);
                obj.descripcion = this.txtdescripcion.Text;
                obj.Fecha = this.dtfecha.Value;
                //obj.FormaPago = this.txtformaPago.Text;
                obj.IdFormaPago = Int32.Parse(cmbFormaPago.SelectedValue.ToString());
                obj.MontoVenta = Decimal.Parse(this.txtmontoventa.Text);
                obj.Porcentaje = Decimal.Parse(this.txtporcomision.Text);

                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                da.SaveChanges();
                int respuesta = da.SaveChanges();
                
                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarPorcentajescomisiones();
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
                int codigo  = Int32.Parse(txtNumero.Text);
                var obj = da.PorcentajeComision.Single(a => a.IdNumeroPorcComision == codigo);
                if (obj != null)
                {
                    da.DeleteObject(obj);
                    da.SaveChanges();
                    MessageBox.Show("Registro Eliminado con Exito.", "Modulo de Facturacion",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarPorcentajescomisiones();
                    limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       


    }
}
