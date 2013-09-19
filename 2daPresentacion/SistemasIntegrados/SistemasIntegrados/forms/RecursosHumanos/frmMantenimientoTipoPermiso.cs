using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using clases.Seguridad;
using datos.RecursosHumanos;

namespace forms.RecursosHumanos
{
    public partial class frmMantenimientoTipoPermiso : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            tsbNuevo.Visible = frmPrincipal.Escritura;
            tsbGuardar.Visible = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            tsbEliminar.Visible = frmPrincipal.Eliminacion;
        }

        #endregion

        public frmMantenimientoTipoPermiso()
        {
            InitializeComponent();
            clsMensaje men = new clsMensaje();
            event_Click += new delegate_Click(frmMantenimientoTipoPermiso_event_Click);
        }

        clsUsuario user = new clsUsuario();
        int solo = 1;

        void frmMantenimientoTipoPermiso_event_Click(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsTipoPermiso clas = new clsTipoPermiso();
        clsDatosTipoPermiso dato = new clsDatosTipoPermiso();
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;
        private string accion { get; set; }

        public void Set()
        {

            txtCodigo.Text = Convert.ToString(clas.IdTipoPermiso);
            txtDescripcion.Text = clas.Descripcion;
            solo = clas.IdEmpresa;
            cbeEstado.SelectedIndex = clas.IdEstado;


        }

        public void Get()
        {
            if (txtCodigo.Text == "")
            {
                clas.IdTipoPermiso = 0;
            }
            else
            {
                clas.IdTipoPermiso = Convert.ToInt32(txtCodigo.Text);
                //clas.Nombre = txtNombre.Text;
                clas.IdEmpresa = solo;
                clas.IdEstado = cbeEstado.SelectedIndex;
                
                
            }

            clas.Descripcion = txtDescripcion.Text;
        }

        private void frmMantenimientoPermiso_Load(object sender, EventArgs e)
        {
            int a = dato.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);
            
            clsDatosTipoPermiso tiP = new clsDatosTipoPermiso();

            if (accion == "M")
            {
                Set();
            }
            if (accion == "E")
            {
                Set();
            }
            Seguridad();
        }

        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "G";
                if (accion == "G")
                {
                    if (dato.Guardar(clas))
                    {
                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                event_Click(sender, e);
                frmMantenimientoTipoPermiso_event_Click(sender, e);
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCodigo.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                dato.Modificar(clas);
                event_Click(sender, e);
                frmMantenimientoTipoPermiso_event_Click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                Limpiar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCodigo.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "E";
                if (accion == "E")
                {
                    if (dato.Eliminar(clas))
                    {
                        MessageBox.Show(men.Exito_eli, men.Titulo, MessageBoxButtons.OK);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(men.Error_eli, men.Titulo, MessageBoxButtons.OK);
                    }

                }
                event_Click(sender, e);
                frmMantenimientoTipoPermiso_event_Click(sender, e);
            } 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPermiso cTiP = new frmConsultaTipoPermiso();
            cTiP.ShowDialog();
            clas = cTiP.tiP;
            txtCodigo.Text = Convert.ToString(clas.IdTipoPermiso);
            txtDescripcion.Text = clas.Descripcion;
            solo = clas.IdEmpresa;
            cbeEstado.EditValue = clas.IdEstado;
           
        }
    }
}
