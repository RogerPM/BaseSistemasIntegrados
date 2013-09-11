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
    public partial class frmPromocion1 : Form
    {
        private FacturacionEntities da = new FacturacionEntities();
        public frmPromocion1()
        {
            InitializeComponent();
        }

        
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            this.txtNumero.Text = generarmaximo().ToString();

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

        void limpiar()
        {
            this.txtNumero.Text = "";
            this.txtdescripcion.Text = "";
            this.txtdescuento.Text = "";
            this.btnguardar.Enabled = true;
        }

        private void frmPromocion1_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cargarpromociones();
        }

        private void cargarpromociones()
        {
            try
            {
                var Estado = da.Promocion;
                this.dgvregistros.DataSource = Estado.ToList();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            cargarpromociones();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarpromociones();
        }

        private int generarmaximo()
        {
            try
            {
                System.Nullable<Int32> maxUnitsInStock =
         (from prod in da.Promocion
          select prod.IdPromocion).Max() + 1;

                return Int32.Parse(maxUnitsInStock.ToString());
            }
            catch (Exception ex) {
                return 1;
            }


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtdescuento.Text == "")
                {
                    MessageBox.Show("Ingrese Descuento.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtdescripcion.Text == "")
                {
                    MessageBox.Show("Ingrese Ingrese una descripcion para el registro.", "Modulo de Facturacion",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
                Promocion obj = new Promocion();
                obj.IdPromocion = Int32.Parse(txtNumero.Text);
                obj.descripcion = this.txtdescripcion.Text;
                obj.tipoPromocion = cmbtipopromicion.SelectedItem.ToString();
                obj.pordescuento = Decimal.Parse(this.txtdescuento.Text);
                obj.FechaFin = dtpfechafin.Value;
                obj.FechaInicio = dtpfechainicio.Value;

                obj.IdEmpresa = Seguridad.empresa;
                obj.idUsuario = Seguridad.usuario;
                obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                da.AddToPromocion(obj);
                int respuesta = da.SaveChanges();
                if (respuesta > 0)
                {
                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarpromociones();
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
                //PorcentajeComision obj = new PorcentajeComision();

                int codigo = Int32.Parse(txtNumero.Text);
                var obj = da.Promocion.Single(a => a.IdPromocion == codigo);
                if (obj != null)
                {


                    obj.IdPromocion = Int32.Parse(txtNumero.Text);
                    obj.descripcion = this.txtdescripcion.Text;
                    obj.tipoPromocion = cmbtipopromicion.SelectedItem .ToString();
                    obj.pordescuento = Decimal.Parse(this.txtdescuento.Text);
                    obj.FechaFin = dtpfechafin.Value;
                    obj.FechaInicio = dtpfechainicio.Value;

                    obj.IdEmpresa = Seguridad.empresa;
                    obj.idUsuario = Seguridad.usuario;
                    obj.idEstado = Int32.Parse(cmbestado.SelectedValue.ToString());
                    da.SaveChanges();
                    int respuesta = da.SaveChanges();

                    MessageBox.Show("Registro Ingresado con exito.", "Modulo de Facturacion",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarpromociones();
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
                int codigo = Int32.Parse(txtNumero.Text);
                var obj = da.Promocion.Single(a => a.IdPromocion == codigo);
                if (obj != null)
                {
                    da.DeleteObject(obj);
                    da.SaveChanges();
                    MessageBox.Show("Registro Eliminado con Exito.", "Modulo de Facturacion",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarpromociones();
                    limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Correctamente los valores. " + ex.Message, "Modulo de Facturacion",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvregistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                this.txtNumero.Text = dgvregistros.CurrentRow.Cells[2].Value.ToString();
                this.txtdescripcion.Text = dgvregistros.CurrentRow.Cells[3].Value.ToString();
                this.dtpfechainicio.Value = DateTime.Parse(dgvregistros.CurrentRow.Cells[4].Value.ToString());
                this.dtpfechafin.Value = DateTime.Parse(dgvregistros.CurrentRow.Cells[5].Value.ToString());
                this.cmbtipopromicion.SelectedItem = dgvregistros.CurrentRow.Cells[6].Value.ToString();
                this.txtdescuento.Text = dgvregistros.CurrentRow.Cells[7].Value.ToString();
                this.cmbestado.SelectedValue = Int32.Parse(dgvregistros.CurrentRow.Cells[8].Value.ToString());
                
                this.btnmodificar.Enabled = true;
                this.btneliminar.Enabled = true;
                this.btnguardar.Enabled = false;

            }
            catch (Exception ex)
            { }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
