using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;
using clases.Seguridad;

namespace forms.Cuentasxpagar
{
    public partial class frmFrecuenciaPago : Form
    {
        public frmFrecuenciaPago()
        {
            InitializeComponent();
            event_click += new delegate_Click(frmFrecuenciaPago_event_click);
            clsMensajeCxP ms = new clsMensajeCxP();
        }
        clsUsuario usar = new clsUsuario();
        int solo = 1;
        int solo2 = 2;

        void frmFrecuenciaPago_event_click(object sender, EventArgs e)
        {

        }

        public clsMensajeCxP men = new clsMensajeCxP();
        public clsFrecuenciaPago clas = new clsFrecuenciaPago();
        datosFrecuenciaPago dato = new datosFrecuenciaPago();
        private  string accion { get; set; }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaFrecuenciaPago fre = new frmConsultaFrecuenciaPago();
            fre.ShowDialog();

            clas = fre.fp;
            if (clas.IdFrecuenciaPago == 0)
            {
                limpiar();
                txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
                deFechaActual.EditValue = DateTime.Today;
            }
            else
            {
                Set();

            }

        }

        private void frmFrecuenciaPago_Load(object sender, EventArgs e)
        {
            deFechaActual.EditValue = DateTime.Today;
            txtCodigo.Text =Convert.ToString  (dato.getIdSiguiente());
            datosFrecuenciaPago fre = new datosFrecuenciaPago();
            //gleEstado.Properties.DataSource = fre.consultaEstado();
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
            
           
            txtCodigo.Text = Convert.ToString(clas.IdFrecuenciaPago);
            txtDescripcion.Text = clas.Descripcion;
            deFechaActual.EditValue = clas.FechaActual;
            if (clas.Estado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            solo2 = clas.IdEmpresa;
            solo= clas.IdUsuario;

                   }


        public void get()
        {
            if (txtCodigo.Text == "")
            {
               clas.IdFrecuenciaPago= 0;//PK
            }
            else
            {
                clas.IdFrecuenciaPago = Convert.ToInt32(txtCodigo.Text); 
                
            } 
           
            clas.Descripcion = txtDescripcion.Text;
            clas.FechaActual = Convert.ToDateTime (deFechaActual.EditValue);
            if (cbxEstado.Text == "Activo")
                clas.Estado = 1;
            else
                clas.Estado = 0;
          
            clas.IdEmpresa=solo2;
            clas.IdUsuario =solo;


        }
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == " ")
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
                frmFrecuenciaPago_event_click(sender, e);



            }
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            deFechaActual.EditValue = DateTime.Today;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == ""||txtCodigo.Text==Convert.ToString ( dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                get();
                dato.Modificar(clas);
                event_click(sender, e);
                frmFrecuenciaPago_event_click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                limpiar();
            }
           // event_click(sender, e);
           // frmFrecuenciaPago_event_click(sender, e);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCodigo.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK);
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
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(men.Error_eli, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                event_click(sender, e);
                frmFrecuenciaPago_event_click(sender, e);
            }
        }
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            deFechaActual.EditValue = "";
        //gleEstado.EditValue = "";
      
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
