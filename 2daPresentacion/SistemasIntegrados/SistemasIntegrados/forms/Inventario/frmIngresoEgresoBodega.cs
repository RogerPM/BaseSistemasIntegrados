using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;
using clases.Seguridad;
using datos.Seguridad;
using clases.RecursosHumanos;
using datos.RecursosHumanos;


namespace forms.Inventario
{
    public partial class txtPrecio1 : Form
    {
        int EU = 1;
        frmConsultaIngresoEgresoCAB consulta = new frmConsultaIngresoEgresoCAB();
        public clsIngresoEgresoCAB  oIngresoEgreso = new clsIngresoEgresoCAB ();
        public clsIngresoEgresoDET oIngresoEgreso1 = new clsIngresoEgresoDET();
        datIngresoEgresoBodegaCAB  oIngresoEgresoB = new datIngresoEgresoBodegaCAB ();
        datIngresoEgresoDET oIngresoEgresoB1 = new datIngresoEgresoDET();
        public clsOrdenCompraDET oOrdenCompra = new clsOrdenCompraDET();
        datOrdenCompraDET oOrdenCompraDet = new datOrdenCompraDET();

        clsInventario dat = new clsInventario();

        public txtPrecio1()
        {
            InitializeComponent();
        }

        public void set()
        {
            oIngresoEgreso.empresa = EU;
            oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text );
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.ordenCompra = Convert.ToInt32 ( txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.Value);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.Text);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.Text);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.Text);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
        }


        public void get()
        {
            try
            {
                gwIE.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                List<clsIngresoEgresoDET> lst = new List<clsIngresoEgresoDET>();
                for (int i = 0; i < gwIE.RowCount; i++)
                {
                    clsIngresoEgresoDET cls = new clsIngresoEgresoDET();
                    cls.articulo = Convert.ToInt32(gwIE.GetRowCellValue(i,colarticulo));
                    cls.percha = Convert.ToInt32(gwIE.GetRowCellValue(i, colpercha));
                    cls.cantidadPedida = Convert.ToInt32(gwIE.GetRowCellValue(i, colcantidadPedida));
                    lst.Add(cls);
                }
                oIngresoEgreso.detalle = lst;
                gwIE.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            oIngresoEgreso.empresa = EU;
            try
            {
                oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text);

            }
            catch (Exception)
            {
            }
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.EditValue);
            //oIngresoEgreso.ordenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.EditValue);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.Value);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.EditValue);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.EditValue);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.EditValue);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
            if (cbxTipoMovimiento.SelectedText == "Ingreso" && cbxMotivo.SelectedText == "Compra")
            {
                TabControl_IngEg.Show();
                Compra.PageEnabled = true;
                oIngresoEgreso1.articulo = Convert.ToInt32(cbxArticulo.EditValue);
                oIngresoEgreso1.percha = Convert.ToInt32(cbxPercha.EditValue);
                oIngresoEgreso1.cantidadPedida = Convert.ToInt32(txtCanPedida.Text);
                oIngresoEgreso1.cantidadLlegada = Convert.ToInt32(txtCantLlegada.Text);
                oIngresoEgreso1.costo = Convert.ToInt32(txtPrecio.Text);
                oIngresoEgreso1.subTotal = Convert.ToDecimal(txtSubtotal.Text);
                oIngresoEgreso1.valorIVA = Convert.ToDecimal(txtValorIVA.Text);
                oIngresoEgreso1.valorTotal = Convert.ToDecimal(txtValorTotal.Text);
            }
            if (cbxTipoMovimiento.SelectedText == "Ingreso" && cbxMotivo.SelectedText == "Donacion")
            {
                Donacion.PageEnabled = false;
                oIngresoEgreso1.articulo = Convert.ToInt32(cbxArt1.EditValue);
                oIngresoEgreso1.percha = Convert.ToInt32(cbxPercha1.EditValue);
                oIngresoEgreso1.cantidadLlegada = Convert.ToInt32(txtCantidad.Text);

            }
            if (cbxTipoMovimiento.SelectedText == "Egreso" && cbxMotivo.SelectedText == "Robo/Perdida")
            {
                RoboPerdida.PageEnabled = false;
                oIngresoEgreso1.articulo = Convert.ToInt32(cbxArticulo2.EditValue);
                oIngresoEgreso1.percha = Convert.ToInt32(cbxPercha2.EditValue);
                oIngresoEgreso1.cantidadLlegada = Convert.ToInt32(txtCant.Text);

            }
            }
            catch (Exception)
            {
            }
        }

        public bool  getDatos()
        {
            oIngresoEgreso.empresa = EU;
            oIngresoEgreso.nroMovimiento = Convert.ToInt32(txtNoMovimiento.Text);
            oIngresoEgreso.tipoMovimiento = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.ordenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            oIngresoEgreso.motivo = Convert.ToInt32(cbxTipoMovimiento.Text);
            oIngresoEgreso.fechaMovimiento = Convert.ToDateTime(dateFecmov.Value);
            oIngresoEgreso.bodega = Convert.ToInt32(cbxBodega.Text);
            oIngresoEgreso.responsable = Convert.ToInt32(cbxResponsable.Text);
            oIngresoEgreso.estado = Convert.ToInt32(cbxEstado.Text);
            oIngresoEgreso.observacion = txtObservacion.Text;
            oIngresoEgreso.totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
            return true;
        }

        public void limpiar()
        {
            clsIngresoEgresoDETBindingSource.Clear();
            gcIE.DataSource = clsIngresoEgresoDETBindingSource;

            int a = datos.getIdSiguiente();
            txtNoMovimiento.Text = Convert.ToString(a);
            cbxTipoMovimiento.Text = "";
            txtOrdenCompra.Text = "";
            cbxTipoMovimiento.Text = "";
            txtObservacion.Text = "";
            dateFecmov.Text  = "";
            cbxBodega.Text = "";
            cbxResponsable.Text = "";
            cbxEstado.Text = "";
            txtTotalPagar.Text = "";
            cbxArticulo.Text = "";
            cbxArt1.Text = "";
            cbxArticulo2.Text = "";
            cbxPercha.Text = "";
            cbxPercha1.Text = "";
            cbxPercha2.Text = "";
            txtCanPedida.Text = "";
            txtCant.Text = "";
            txtCantidad.Text = "";
            txtCantLlegada.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
            txtValorTotal .Text = "";
            txtValorIVA.Text = "";


        }



        datIngresoEgresoBodegaCAB datos = new datIngresoEgresoBodegaCAB();
        private void frmIngresoEgresoBodega_Load(object sender, EventArgs e)
        {
            try
            {
                List<clsIngresoEgresoDET> lst = new List<clsIngresoEgresoDET>();
                //gcIE.DataSource=lst;
                //clsIngresoEgresoDETBindingSource.Clear();
                //gcIE.DataSource = clsIngresoEgresoDETBindingSource;

                cmbArticulo.DataSource = dat.consultainventario();
                cmbPercha.DataSource = dat.consultapercha();
            
            int a = datos.getIdSiguiente();
            //txtNoMovimiento.Text = Convert.ToString(a);
            
            datEstado data1 = new datEstado();
            cbxEstado.Properties.DataSource = data1.ConsultaTodos();
            datBodega data2 = new datBodega();
            cbxBodega.Properties.DataSource = data2.consulta();
            clsDatosPersona data3 = new clsDatosPersona();
            cbxResponsable.Properties.DataSource = data3.ConsultaPersona();
            datTipoMovimiento data4 = new datTipoMovimiento();
            cbxTipoMovimiento.Properties.DataSource = data4.consulta();
            datMotivo data5 = new datMotivo();
            cbxMotivo.Properties.DataSource = data5.consulta();
            datPercha data6 = new datPercha();
            cbxPercha.Properties.DataSource = data6.consulta();
            cbxPercha1.Properties.DataSource = data6.consulta();
            cbxPercha2.Properties.DataSource = data6.consulta();

            datArticulo data7 = new datArticulo();
            cbxArticulo.Properties.DataSource = data7.consultaArt();
            cbxArt1.Properties.DataSource = data7.consultaArt();
            cbxArticulo2.Properties.DataSource = data7.consultaArt();
            }
            catch (Exception)
            {
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnNvo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            get();
            string Mensaje = "";
            if (oIngresoEgresoB.guardar (ref oIngresoEgreso, ref Mensaje ))
                      
                MessageBox.Show("Guardado Exitosamente Movimiento # "+oIngresoEgreso.nroMovimiento.ToString(),"TECA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(Mensaje);
            //if (oIngresoEgresoB1.GuardarDet(oIngresoEgreso1, ref Mensaje))
            //    MessageBox.Show("Guardado Exitosamente");
            //else
            //    MessageBox.Show(Mensaje);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        void consulta_Event_frmConsultaIngresoEgresoCAB_FormClosing(object sender, EventArgs e)
        {
            clsIngresoEgresoCAB IngEg = (clsIngresoEgresoCAB)sender;
            txtNoMovimiento.Text = IngEg.nroMovimiento.ToString();
            cbxTipoMovimiento.Text = IngEg.tipoMovimiento.ToString();
            dateFecmov.Value = IngEg.fechaMovimiento;
            txtOrdenCompra.Text = IngEg.ordenCompra.ToString();
            cbxMotivo.Text = IngEg.motivo.ToString();
            cbxBodega.Text = IngEg.bodega.ToString();
            cbxResponsable.Text = IngEg.responsable.ToString();
            txtTotalPagar.Text = IngEg.totalPagar.ToString();
            txtObservacion.Text = IngEg.observacion;
            cbxEstado.TabIndex = IngEg.estado;
            consulta.Visible = false;
        }

        private void btnBuscarMovmiento_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaIngresoEgresoCAB consulta = new frmConsultaIngresoEgresoCAB();
                consulta.ShowDialog();
                oIngresoEgreso = consulta.cls;
                txtNoMovimiento.Text = Convert.ToString(oIngresoEgreso.nroMovimiento);
                gcIE.DataSource = dat.consultaIEDetalle(oIngresoEgreso.nroMovimiento);
                cbxTipoMovimiento.EditValue = oIngresoEgreso.tipoMovimiento;
                try
                {
                    dateFecmov.Value = Convert.ToDateTime(oIngresoEgreso.fechaMovimiento);
                }
                catch (Exception)
                {
                }
                txtOrdenCompra.Text = Convert.ToString(oIngresoEgreso.ordenCompra);
                cbxMotivo.EditValue = oIngresoEgreso.motivo;
                cbxBodega.EditValue = oIngresoEgreso.bodega;
                cbxResponsable.EditValue = oIngresoEgreso.responsable;
                txtTotalPagar.Text = Convert.ToString(oIngresoEgreso.totalPagar);
                txtObservacion.Text = oIngresoEgreso.observacion;
                cbxEstado.EditValue = oIngresoEgreso.estado;
            }
            catch (Exception)
            {
            }
         }

        private void cbxMotivo_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoMovimiento.SelectedText == "Ingreso")
            {
                if (cbxMotivo.SelectedText == "Compra")
                {
                    TabControl_IngEg.Enabled = true;
                    Compra.PageEnabled = true;
                    Donacion.PageEnabled = false;
                    RoboPerdida.PageEnabled = false;
                    txtOrdenCompra.Enabled = true;
                }
                else
                {
                    if (cbxMotivo.SelectedText == "Donacion")
                    {
                        TabControl_IngEg.Enabled = true;
                        Donacion.PageEnabled = true;
                        Compra.PageEnabled = false;
                        RoboPerdida.PageEnabled = false;
                        txtOrdenCompra.Text = "1";
                        txtOrdenCompra.Enabled = false; 
                    }
                    else
                    {
                        TabControl_IngEg.Enabled = false;
                    }
                }
            }
            else
                if (cbxTipoMovimiento.SelectedText == "Egreso")
                {
                    if (cbxMotivo.SelectedText == "Robo/Perdida")
                    {
                        TabControl_IngEg.Enabled = true;
                        RoboPerdida.PageEnabled = true;
                        Donacion.PageEnabled = false;
                        Compra.PageEnabled = false;
                        txtOrdenCompra.Text = "1";
                        txtOrdenCompra.Enabled = false;
                    }
                    else
                    {
                        TabControl_IngEg.Enabled = false;
                    }

                }
        }

        private void btnCargarNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            frmConsultaOrdenCompra consulta = new frmConsultaOrdenCompra();
            consulta.ShowDialog();
            oOrdenCompra = consulta.clsOC;
            txtOrdenCompra.Text = Convert.ToString(oOrdenCompra.numero);
            cbxArticulo.EditValue = oOrdenCompra.articulo;
            txtCanPedida.Text = Convert.ToString(oOrdenCompra.cantidad);
            txtPrecio.Text = Convert.ToString(oOrdenCompra.precio);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No se pudo Modificar Faltan Permisos","TECA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

    }
}
