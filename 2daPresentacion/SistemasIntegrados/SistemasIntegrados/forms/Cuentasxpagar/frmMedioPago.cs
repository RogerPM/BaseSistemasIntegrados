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
    public partial class frmMedioPago : Form
    {
        public frmMedioPago()
        {
            InitializeComponent();
        }

        int solo = 11;

        void frmMedioPago_event_click(object sender, EventArgs e)
        {

        }
        public clsMensajeCxP men = new clsMensajeCxP();
        public clsMedioPago clas = new clsMedioPago();
        datosMedioPago dato = new datosMedioPago();
        public string accion { get; set; }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaMedioPago fre = new frmConsultaMedioPago();
            fre.ShowDialog();
            clas = fre.mp;
            if (clas.IdMedioPago == 0)
            {
                limpiar();

            }
            else
            {
                Set();

            }



        }


        private void frmMedioPago_Load(object sender, EventArgs e)
        {
            dtpFechaRegistro.EditValue = DateTime.Today;
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            datosMedioPago fre = new datosMedioPago();

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
            txtCodigo.Text = Convert.ToString(clas.IdMedioPago);
            txtDescripcion.Text = clas.Descripcion;
            dtpFechaRegistro.EditValue = clas.FechaRegistro;
            if (clas.Estado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            solo = clas.IdEmpresa;
            solo = clas.IdUsuario;

        }
        public void get()
        {
            if (txtCodigo.Text == "")
            {
                clas.IdMedioPago = 0;

            }
            else
            {
                clas.IdMedioPago = Convert.ToInt32(txtCodigo.Text);
            }
            clas.Descripcion = txtDescripcion.Text;
            clas.FechaRegistro = Convert.ToDateTime(dtpFechaRegistro.EditValue);
            if (cbxEstado.Text == "Activo")
                clas.Estado = 1;
            else
                clas.Estado = 0;


            clas.IdEmpresa = 1;
            clas.IdUsuario = 11;


        }
        
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            //  deFechaRegistro.EditValue ="";
            cbxEstado.SelectedIndex = 0;


        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
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
            }
        }

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCodigo.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {

                get();
                dato.Modificar(clas);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);

            }
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
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
            }
        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
