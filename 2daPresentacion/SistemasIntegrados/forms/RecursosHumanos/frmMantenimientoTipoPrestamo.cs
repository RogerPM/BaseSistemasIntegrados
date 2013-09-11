using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.RecursosHumanos;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace forms.RecursosHumanos
{
    public partial class frmMantenimientoTipoPrestamo : Form
    {
        
        public frmMantenimientoTipoPrestamo()
        {
            InitializeComponent();
            event_click += new delegate_Click(frmMantenimientoTipoPrestamo_event_click);

        }

        int solo = 1;
        

        void frmMantenimientoTipoPrestamo_event_click(object sender, EventArgs e)
        { 
        }

        public clsMensaje men = new clsMensaje();
        public clsTipoPrestamo clas = new clsTipoPrestamo();
        clsDatosTipoPrestamo dato = new clsDatosTipoPrestamo();
        public string accion { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPrestamo fre = new frmConsultaTipoPrestamo();
            fre.ShowDialog();
            clas = fre.mp;
            txtCodigo.Text = Convert.ToString(clas.IdTipoPrestamo);
            txtDescripcion.Text = clas.Nombre;
            solo = clas.IdEmpresa;
            cmbEstado.SelectedIndex   = clas.IdEstado;
        }

        private void frmMantenimientoTipoPrestamo_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            clsDatosTipoPrestamo fre = new clsDatosTipoPrestamo();
            if (accion == "M")
            {
                Set();
            }
            if (accion == "E")
            {
                Set();
            }
        }

        public void Set()
        {
            txtCodigo.Text = Convert.ToString(clas.IdTipoPrestamo);
            txtDescripcion.Text = clas.Nombre;
            cmbEstado.SelectedIndex   = clas.IdEstado;
            solo = clas.IdEmpresa;
        }

        public void get()
        {
            if (txtCodigo.Text == "")
            {
                clas.IdTipoPrestamo = 0;
            }
            else {
                clas.IdTipoPrestamo = Convert.ToInt32(txtCodigo.Text);
                clas.IdEmpresa = solo;
                clas.Nombre = txtDescripcion.Text;
                clas.IdEstado = Convert.ToInt32(cmbEstado.SelectedIndex); 
            }
            //clas.Nombre = txtDescripcion.Text;
        }

        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text  = "";
            cmbEstado.Text = "";
        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK );
            }
            else {
                get();
                accion = "G";
                if (accion == "G")
                {
                    if (dato.Guardar(clas))
                    {
                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        Limpiar();
                    }
                    else {
                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                event_click (sender, e);
                frmMantenimientoTipoPrestamo_event_click(sender, e);
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
                frmMantenimientoTipoPrestamo_event_click(sender, e);
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
                get();
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
                event_click(sender, e);
                frmMantenimientoTipoPrestamo_event_click(sender, e);
            } 
        }






    }
}
