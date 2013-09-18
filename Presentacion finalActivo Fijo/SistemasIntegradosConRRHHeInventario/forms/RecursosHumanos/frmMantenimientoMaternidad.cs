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
    public partial class frmMantenimientoMaternidad : Form
    {
        public frmMantenimientoMaternidad()
        {
            InitializeComponent();
            clsMensaje men = new clsMensaje();
            event_Click += new delegate_Click(frmMantenimientoMaternidad_event_Click);
        }

        clsUsuario user = new clsUsuario();

        
        int solo = 1;

        void frmMantenimientoMaternidad_event_Click(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsMaternidad clas = new clsMaternidad();
        clsDatosMaternidad dato = new clsDatosMaternidad();
        private string accion { get; set; }

        public void Set()
        {

            txtNumero.Text = Convert.ToString(clas.NumMaternidad);
            gluEmpleado.EditValue = clas.IdEmpleado;
            solo = clas.IdEmpresa;
            deInicioLicencia.EditValue = clas.FechaInicio;
            deFinLicencia.EditValue = clas.FechaFin;
            deFParto.EditValue = clas.FechaParto;
            deFModificacion.EditValue = clas.FechaModificacion;
            cbeEstado.SelectedIndex = clas.IdEstado;
        }

        public void Get()
        {
            if (txtNumero.Text == "")
            {
                clas.NumMaternidad = 0;
            }
            else
            {
                clas.NumMaternidad = Convert.ToInt32(txtNumero.Text);
                //clas.Nombre = txtNombre.Text;
                clas.IdEmpresa = solo;
                clas.FechaParto = Convert.ToDateTime(deFParto.EditValue);
                clas.FechaInicio = Convert.ToDateTime(deInicioLicencia.EditValue);
                clas.FechaFin = Convert.ToDateTime(deFinLicencia.EditValue);
                clas.FechaModificacion = Convert.ToDateTime(deFModificacion.EditValue);
                clas.IdEstado = cbeEstado.SelectedIndex;

            }

            clas.IdEmpleado = Convert.ToInt32(gluEmpleado.EditValue);

        }

        private void frmMantenimientoMaternidad_Load(object sender, EventArgs e)
        {
            
            
            int a = dato.getIdSiguiente();
            txtNumero.Text = Convert.ToString(a);

            clsDatosPersona perso = new clsDatosPersona();
            gluEmpleado.Properties.DataSource = perso.ConsultaPersona();

            clsDatosMaternidad mat = new clsDatosMaternidad();

            if (accion == "M")
            {
                Set();
            }
            if (accion == "E")
            {
                Set();
            }
            
            
            // TODO: This line of code loads data into the 'tECAv8DataSet6.Estado' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tECADataSet3.Estado' table. You can move, or remove it, as needed.
          
            
        }

        public void Limpiar()
        {
            txtNumero.Text = "";

        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNumero.Text = Convert.ToString(dato.getIdSiguiente());

        }


        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (gluEmpleado.EditValue == null)
            {
                MessageBox.Show(men.Error_Emp, men.Titulo, MessageBoxButtons.OK);
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
                frmMantenimientoMaternidad_event_Click(sender, e);
            }
        }

        

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtNumero.Text == Convert.ToString(dato.getIdSiguiente()))
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
                frmMantenimientoMaternidad_event_Click(sender, e);
            }
        }


        private void btnBuscarNumero_Click_1(object sender, EventArgs e)
        {
            frmConsultaMaternidad cMa = new frmConsultaMaternidad();
            cMa.ShowDialog();
            clas = cMa.mat;
            txtNumero.Text = Convert.ToString(clas.NumMaternidad);
            gluEmpleado.EditValue = clas.IdEmpleado;
            solo = clas.IdEmpresa;
            deFParto.EditValue = clas.FechaParto;
            deInicioLicencia.EditValue = clas.FechaInicio;
            deFinLicencia.EditValue = clas.FechaFin;
            deFModificacion.EditValue = clas.FechaModificacion;
            cbeEstado.EditValue = clas.IdEstado;
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtNumero.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                dato.Modificar(clas);
                event_Click(sender, e);
                frmMantenimientoMaternidad_event_Click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                Limpiar();
            }
        }

    }
        
}
