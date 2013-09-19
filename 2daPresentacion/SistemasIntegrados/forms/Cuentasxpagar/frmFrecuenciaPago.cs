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
            clsMensajeCxP ms = new clsMensajeCxP();
        }
        int solo = 11;
        int solo2 = 1;

        public clsMensajeCxP men = new clsMensajeCxP();
        public clsFrecuencia clas = new clsFrecuencia();
        datosFrecuenciaPago dato = new datosFrecuenciaPago();
        private  string accion { get; set; }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaFrecuenciaPago fre = new frmConsultaFrecuenciaPago();
            fre.ShowDialog();

            clas = fre.fp;
            if (clas._IdFrecuenciaPago == 0)
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
            
           
            txtCodigo.Text = Convert.ToString(clas._IdFrecuenciaPago);
            txtDescripcion.Text = clas._Descripcion;
            deFechaActual.EditValue = clas._FechaActual;
            if (clas._Estado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            solo2 = clas._IdEmpresa;
            solo= clas._IdUsuario;

                   }


        public void get()
        {
            if (txtCodigo.Text == "")
            {
               clas._IdFrecuenciaPago= 0;//PK
            }
            else
            {
                clas._IdFrecuenciaPago = Convert.ToInt32(txtCodigo.Text); 
                
            } 
           
            clas._Descripcion = txtDescripcion.Text;
            clas._FechaActual = Convert.ToDateTime (deFechaActual.EditValue);
            if (cbxEstado.Text == "Activo")
                clas._Estado = 1;
            else
                clas._Estado = 0;
          
            clas._IdEmpresa=solo2;
            clas._IdUsuario =solo;


        }

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
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                limpiar();
            }
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
            }
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            deFechaActual.EditValue = "";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
