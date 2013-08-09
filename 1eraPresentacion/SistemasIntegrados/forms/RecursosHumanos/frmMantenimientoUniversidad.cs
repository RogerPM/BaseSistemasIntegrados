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
    public partial class frmMantenimientoUniversidad : Form
    {
        public frmMantenimientoUniversidad()
        {
            InitializeComponent();
            clsMensaje msj = new clsMensaje();
            event_Click +=new delegate_Click(frmMantenimientoUniversidad_event_Click);
        }

        clsUsuario user = new clsUsuario();
        int solo = 1;

        void frmMantenimientoUniversidad_event_Click(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsUniversidad clas = new clsUniversidad();
        clsDatosUniversidad dato = new clsDatosUniversidad();
        private string accion { get; set; }

        public void Set()
        {

            txtCodigo.Text = Convert.ToString(clas.IdUniversidad);
            txtNombre.Text = clas.Nombre;
            
            solo = clas.IdEmpresa;
            
        }

        public void Get() 
        {
            if (txtCodigo.Text == "")
            {
                clas.IdUniversidad = 0;
            }
            else
            {
                clas.IdEmpresa = solo;
                clas.IdUniversidad = Convert.ToInt32(txtCodigo.Text);

            }

            clas.Nombre = txtNombre.Text;
        }

        


        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

        

       
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
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
                frmMantenimientoUniversidad_event_Click(sender, e);
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
                frmMantenimientoUniversidad_event_Click(sender, e);
                MessageBox.Show(men.Exito_mod,men.Titulo,MessageBoxButtons.OK);
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
                frmMantenimientoUniversidad_event_Click(sender, e);    
            } 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaUniversidad cUni = new frmConsultaUniversidad();
            cUni.ShowDialog();
            clas = cUni.un;
            txtCodigo.Text= Convert.ToString(clas.IdUniversidad);
            solo = clas.IdEmpresa;
            txtNombre.Text = clas.Nombre;
        }

        private void frmMantenimientoUniversidad_Load_1(object sender, EventArgs e)
        {
            int a = dato.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);


            clsDatosUniversidad uni = new clsDatosUniversidad();

            if (accion == "M")
            {
                Set();
            }
            if (accion == "E")
            {
                Set();
            }
        }
    }
}
