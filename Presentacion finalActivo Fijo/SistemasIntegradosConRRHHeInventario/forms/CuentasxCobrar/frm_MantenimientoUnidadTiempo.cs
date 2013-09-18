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
    public partial class frm_MantenimientoUnidadTiempo : Form
    {
        public clsUnidadTiempo objUnidadTiempo = new clsUnidadTiempo();
        int idEmpresa = 1;
        String AccionBotonAplastado;

        public frm_MantenimientoUnidadTiempo()
        {
            InitializeComponent();
        }

        private void frm_MantenimientoUnidadTiempo_Load(object sender, EventArgs e)
        {
            this.Inactivar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

            clsDatosUnidadTiempo objDatosUnidadTiempo = new clsDatosUnidadTiempo();
            String[] NombresColumnas = new String[4];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "Codigo";
            NombresColumnas[2] = "Descripcion";
            NombresColumnas[3] = "Estado";

            List<object> lista = new List<object>(objDatosUnidadTiempo.consultaUnidadTiempoGeneral()); ;
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
                    objUnidadTiempo.idEmpresa = Convert.ToInt32(Fila.Cells[0].Value);
                    objUnidadTiempo.idUnidadTiempo = Convert.ToInt32(Fila.Cells[1].Value);
                    objUnidadTiempo.Descripcion = Convert.ToString(Fila.Cells[2].Value);
                    objUnidadTiempo.Estado = Convert.ToString(Fila.Cells[3].Value);
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
            this.txtCodigo.Text = Convert.ToString(objUnidadTiempo.idUnidadTiempo);
            this.txtDescripcion.Text = objUnidadTiempo.Descripcion;
            if (this.objUnidadTiempo.Estado.Equals("A"))
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
            objUnidadTiempo.idEmpresa = idEmpresa;
            objUnidadTiempo.idUnidadTiempo = Convert.ToInt32(this.txtCodigo.Text);
            objUnidadTiempo.Descripcion = this.txtDescripcion.Text;
            if (ckbActivo.Checked)
            {
                objUnidadTiempo.Estado = "A";
            }
            else
            {
                objUnidadTiempo.Estado = "I";
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
            this.ckbActivo.Properties.ReadOnly = true;
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.ckbActivo.Checked = true;
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtDescripcion.Properties.ReadOnly = false;
            this.ckbActivo.Properties.ReadOnly = false;

            this.Limpiar();

            clsDatosUnidadTiempo objDatosUnidadTiempo = new clsDatosUnidadTiempo();
            this.txtCodigo.Text = Convert.ToString(objDatosUnidadTiempo.getIdSiguiente());
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosUnidadTiempo objDatosUnidadTiempo = new clsDatosUnidadTiempo();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();

            if (this.Get())
            {
                if (AccionBotonAplastado == "N")
                {
                    this.Get();
                    if (objDatosUnidadTiempo.guardar(objUnidadTiempo))
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
                    this.Get();
                    if (objDatosUnidadTiempo.modificar(objUnidadTiempo))
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
            this.ckbActivo.Properties.ReadOnly = false;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosUnidadTiempo objDatosUnidadTiempo = new clsDatosUnidadTiempo();
            clsMensajeCCobrar objMensaje = new clsMensajeCCobrar();
            this.Get();

            if (AccionBotonAplastado == "B")
            {
                if (objDatosUnidadTiempo.eliminar(objUnidadTiempo))
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
