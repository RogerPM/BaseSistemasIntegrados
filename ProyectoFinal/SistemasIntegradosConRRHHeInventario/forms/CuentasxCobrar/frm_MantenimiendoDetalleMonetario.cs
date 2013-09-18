using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_MantenimientoDetalleMonetario : Form
    {
        public clsMonetarioDetalle objMonetarioDetalle = new clsMonetarioDetalle();
        int idEmpresa = 1;
        String AccionBotonAplastado;

        public frm_MantenimientoDetalleMonetario()
        {
            InitializeComponent();
        }

        private void frm_DetalleMonetario_Load(object sender, EventArgs e)
        {
            this.Inactivar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

            clsDatosMonetarioDetalle objDatosMonetarioDetalle = new clsDatosMonetarioDetalle();
            String[] NombresColumnas = new String[5];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "Codigo";
            NombresColumnas[2] = "Descripcion";
            NombresColumnas[3] = "Valor";
            NombresColumnas[4] = "Estado";

            List<object> lista = new List<object>(objDatosMonetarioDetalle.consultaMonetarioDetalleGeneral()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Busqueda de Unidad de Tiempo", NombresColumnas);
                FormularioBusqueda.OcultarColumna(0);
                FormularioBusqueda.ShowDialog();

                if (FormularioBusqueda.Seleccion)
                {
                    DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                    objMonetarioDetalle.idEmpresa = Convert.ToInt32(Fila.Cells[0].Value);
                    objMonetarioDetalle.idDetalleMonetario= Convert.ToInt32(Fila.Cells[1].Value);
                    objMonetarioDetalle.Descripcion = Convert.ToString(Fila.Cells[2].Value);
                    objMonetarioDetalle.Valor = Convert.ToDecimal(Fila.Cells[3].Value);
                    objMonetarioDetalle.Estado = Convert.ToString(Fila.Cells[4].Value);
                    this.Set();
                }
            }
            else
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }

            this.Inactivar();
        }

        public void Set()
        {
            this.txtCodigo.Text = Convert.ToString(objMonetarioDetalle.idDetalleMonetario);
            this.txtDescripcion.Text = objMonetarioDetalle.Descripcion;
            this.txtValor.Text = Convert.ToString(objMonetarioDetalle.Valor);
            if (this.objMonetarioDetalle.Estado.Equals("A"))
            {
                this.ckbActivo.Checked = true;
            }
            else
            {
                this.ckbActivo.Checked = false;
            }
        }

        public Boolean Get()
        {
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            try
            {
                objMonetarioDetalle.idEmpresa = idEmpresa;
                objMonetarioDetalle.idDetalleMonetario = Convert.ToInt32(this.txtCodigo.Text);
                objMonetarioDetalle.Descripcion = this.txtDescripcion.Text;
                objMonetarioDetalle.Valor = Convert.ToDecimal(this.txtValor.Text);
                if (ckbActivo.Checked)
                {
                    objMonetarioDetalle.Estado = "A";
                }
                else
                {
                    objMonetarioDetalle.Estado = "I";
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }

        }

        public void Inactivar()
        {
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtDescripcion.Properties.ReadOnly = true;
            this.txtValor.Properties.ReadOnly = true;
            this.ckbActivo.Properties.ReadOnly = true;
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtValor.Text = "";
            this.ckbActivo.Checked = true;
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtDescripcion.Properties.ReadOnly = false;
            this.txtValor.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;

            this.Limpiar();

            clsDatosMonetarioDetalle objDatosMonetarioDetalle = new clsDatosMonetarioDetalle();
            this.txtCodigo.Text = Convert.ToString(objDatosMonetarioDetalle.getIdSiguiente());
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosMonetarioDetalle objDatosMonetarioDetalle = new clsDatosMonetarioDetalle();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

            if (this.Get())
            {
                if (AccionBotonAplastado == "N")
                {

                    if (objDatosMonetarioDetalle.guardar(objMonetarioDetalle))
                    {
                        string variable = objMensaje.Titulo;
                        MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                }
                else if (AccionBotonAplastado == "M")
                {

                    if (objDatosMonetarioDetalle.modificar(objMonetarioDetalle))
                    {
                        string variable = objMensaje.Titulo;
                        MessageBox.Show(objMensaje.Modificar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(objMensaje.Modificar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                }
            }

            this.Limpiar();
            this.Inactivar();
            AccionBotonAplastado = "G";
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "M";

            this.txtCodigo.Properties.ReadOnly = true;
            this.txtDescripcion.Properties.ReadOnly = false;
            this.txtValor.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosMonetarioDetalle objDatosMonetarioDetalle = new clsDatosMonetarioDetalle();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            this.Get();

            if (AccionBotonAplastado == "B")
            {
                if (objDatosMonetarioDetalle.eliminar(objMonetarioDetalle))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Eliminar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Eliminar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                }
            }
            this.Limpiar();
            this.Inactivar();
            AccionBotonAplastado = "E";
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "S";
            this.Close();
        }
    }
}
