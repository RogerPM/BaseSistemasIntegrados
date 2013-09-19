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
    public partial class frm_MantenimientoTipoInversion : Form
    {
        public clsTipoInversion objTipoInversion = new clsTipoInversion();
        int idEmpresa = 1;
        String AccionBotonAplastado;


        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Enabled = frmPrincipal.Escritura;
            btnGrabar.Enabled = frmPrincipal.Escritura;
            btnModificar.Enabled = frmPrincipal.Escritura;
            //eliminacion
            btnEliminar.Enabled = frmPrincipal.Eliminacion;
        }
        #endregion

        public frm_MantenimientoTipoInversion()
        {
            InitializeComponent();
        }

        private void frm_MantenimientoTipoInversion_Load(object sender, EventArgs e)
        {
            this.Inactivar();
            Seguridad();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensaje objMensaje = new clsMensaje();

            clsDatosTipoInversion objDatosTipoInversion = new clsDatosTipoInversion();
            String[] NombresColumnas = new String[4];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "Codigo";
            NombresColumnas[2] = "Descripcion";
            NombresColumnas[3] = "Estado";

            List<object> lista = new List<object>(objDatosTipoInversion.consultaTipoInversionGeneral()); ;
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
                    objTipoInversion.idEmpresa = Convert.ToInt32(Fila.Cells[0].Value);
                    objTipoInversion.idTipoInversion = Convert.ToInt32(Fila.Cells[1].Value);
                    objTipoInversion.Descripcion = Convert.ToString(Fila.Cells[2].Value);
                    objTipoInversion.Estado = Convert.ToString(Fila.Cells[3].Value);
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
            this.txtCodigo.Text = Convert.ToString(objTipoInversion.idTipoInversion);
            this.txtDescripcion.Text = objTipoInversion.Descripcion;
            if (this.objTipoInversion.Estado.Equals("A"))
            {
                this.ckbActivo.Checked = true;
            }
            else
            {
                this.ckbActivo.Checked = false;
            }
        }

        public void Get()
        {
            objTipoInversion.idEmpresa = idEmpresa;
            objTipoInversion.idTipoInversion = Convert.ToInt32(this.txtCodigo.Text);
            objTipoInversion.Descripcion = this.txtDescripcion.Text;
            if (ckbActivo.Checked)
            {
                objTipoInversion.Estado = "A";
            }
            else
            {
                objTipoInversion.Estado = "I";
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

            clsDatosTipoInversion objDatosTipoInversion = new clsDatosTipoInversion();
            this.txtCodigo.Text = Convert.ToString(objDatosTipoInversion.getIdSiguiente());
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosTipoInversion objDatosTipoInversion = new clsDatosTipoInversion();
            clsMensaje objMensaje = new clsMensaje();


            if (AccionBotonAplastado == "N")
            {
                this.Get();
                if (objDatosTipoInversion.guardar(objTipoInversion))
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
                if (objDatosTipoInversion.modificar(objTipoInversion))
                {
                    string variable = objMensaje.Titulo;
                    MessageBox.Show(objMensaje.Modificar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(objMensaje.Modificar_error, objMensaje.Titulo, MessageBoxButtons.OK);
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
            clsDatosTipoInversion objDatosTipoInversion = new clsDatosTipoInversion();
            clsMensaje objMensaje = new clsMensaje();
            this.Get();

            if (AccionBotonAplastado == "B")
            {
                if (objDatosTipoInversion.eliminar(objTipoInversion))
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
