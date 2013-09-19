using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using datos.RecursosHumanos;
using clases.Seguridad;

namespace forms.RecursosHumanos
{
    public partial class frmMantenimientoDepartamento : Form
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

        public frmMantenimientoDepartamento()
        {
            InitializeComponent();
            clsMensaje msj = new clsMensaje();
            event_Click += new delegate_Click(frmMantenimientoDepartamento_event_click);
            
        }

        clsUsuario user = new clsUsuario();
        void frmMantenimientoDepartamento_event_click(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsDepartamento clas = new clsDepartamento();
        clsDatosDepartamento dato = new clsDatosDepartamento();
        public string accion { get; set; }


        public void Set(){
        
            txtCodigo.Text=Convert.ToString(clas.IdDepartamento);
            txtDescripcion.Text=clas.Descripcion;
            cbeEstado.SelectedIndex = clas.IdEstado;

        }

        public void Get() 
        {

            if (txtCodigo.Text == "")
            {
                clas.IdDepartamento = 0;
            }
            else
            {
                clas.IdDepartamento = Convert.ToInt32(txtCodigo.Text);
                clas.IdEstado = cbeEstado.SelectedIndex;
            }

            clas.Descripcion = txtDescripcion.Text;
            
        }

        private void frmMantenimientoDepartamento_Load(object sender, EventArgs e)
        {


            int a = dato.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(a);


            // TODO: This line of code loads data into the 'tECADataSet2.Estado' table. You can move, or remove it, as needed.
            
           
            // TODO: This line of code loads data into the 'tECAv8DataSet.Estado' table. You can move, or remove it, as needed.
            //this.estadoTableAdapter.Fill(this.tECAv8DataSet.Estado);

            clsDatosDepartamento dep = new clsDatosDepartamento();

            if (accion == "M")//M de modificar
            {
                Set();
            }
            if (accion == "E")//cargar antes de eliminar
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

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK);
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
                frmMantenimientoDepartamento_event_click(sender, e);
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
                frmMantenimientoDepartamento_event_click(sender, e);
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
                frmMantenimientoDepartamento_event_click(sender, e);
            } 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento cDep = new frmConsultaDepartamento();
            cDep.ShowDialog();
            clas = cDep.de;
            txtCodigo.Text = Convert.ToString(clas.IdDepartamento);
            txtDescripcion.Text = clas.Descripcion;
            cbeEstado.EditValue = clas.IdDepartamento;

        }
    }
}
