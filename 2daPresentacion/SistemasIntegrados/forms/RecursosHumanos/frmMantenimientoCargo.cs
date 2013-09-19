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
    public partial class frmMantenimientoCargo : Form
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


        public frmMantenimientoCargo()
        {
            InitializeComponent();
            clsMensaje men = new clsMensaje();
            event_click += new delegate_Click(frmCargo_event_click);
 
        }

        //int solo = 1;

        void frmCargo_event_click(object sender, EventArgs e)
        {

        }
        public clsMensaje men = new clsMensaje();
        public clsCargo clas = new clsCargo();
        clsDatosCargo dato = new clsDatosCargo();

        public string accion { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaCargo fre = new frmConsultaCargo();
            fre.ShowDialog();
            clas = fre.mp;
            txtCodigo.Text = Convert.ToString(clas.IdCargo);
            txtDescripcion.Text = clas.Descripcion;
            txtSueldo.Text = Convert.ToString(clas.Sueldo); 
            cmbEstado.EditValue = clas.IdEstado;
            
        }

        private void frmMantenimientoCargo_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            clsDatosCargo  fre = new clsDatosCargo ();
            
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

        public void Set()
        {
            txtCodigo.Text = Convert.ToString(clas.IdCargo);
            txtDescripcion.Text = clas.Descripcion;
            txtSueldo.Text = Convert.ToString(clas.Sueldo);
            cmbEstado.SelectedIndex  = clas.IdEstado;
            

        }
        public void get()
        {
            if (txtCodigo.Text == "")
            {
                clas.IdCargo = 0;

            }
            else
            {
                clas.IdCargo = Convert.ToInt32(txtCodigo.Text);
            }
            clas.Descripcion = txtDescripcion.Text;
            clas.Sueldo = Convert.ToDouble(txtSueldo.Text);
            clas.IdEstado = Convert.ToInt32(cmbEstado.SelectedIndex);
     


        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK);
            }

            else
            {
                get();
                accion = "G";
                if (accion == "G")
                {
                    if (dato.Guardar(clas))
                    {
                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                event_click(sender, e);
                frmCargo_event_click(sender, e);

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

                get();
                dato.Modificar(clas);
                event_click(sender, e);
                frmCargo_event_click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);

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
                get();
                accion = "E";
                if (accion == "E")
                {
                    if (dato.Eliminar(clas))
                    {
                        MessageBox.Show(men.Exito_eli, men.Titulo, MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(men.Error_eli, men.Titulo, MessageBoxButtons.OK);
                    }
                }

                event_click(sender, e);
                frmCargo_event_click(sender, e);
            }
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtSueldo.Text = "";
            cmbEstado.Text  = "";


        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
           
        }

       
    }
}
