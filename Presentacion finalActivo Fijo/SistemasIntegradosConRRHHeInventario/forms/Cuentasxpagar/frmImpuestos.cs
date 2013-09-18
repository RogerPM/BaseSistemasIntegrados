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
    public partial class frmImpuestos : Form
    {
        public frmImpuestos()
        {
            InitializeComponent();
            event_click += new delegate_Click(frmImpuestos_event_click);
        }

        clsUsuario usar = new clsUsuario();
        int solo = 1;
        int solo2 = 2;

        void frmImpuestos_event_click(object sender, EventArgs e)
        {

        }
        public clsMensaje men = new clsMensaje();
        public clsImpuesto clas = new clsImpuesto();
        datosImpuesto dato = new datosImpuesto();
        public string accion { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaImpuesto fr = new frmConsultaImpuesto();
            fr.ShowDialog();
         
            clas = fr.mp;
            txtCodigo.Text = Convert.ToString(clas.IdImpuesto);
            txtDescripcion.Text = clas.Descripcion;
            txtPorcentaje.Text = Convert.ToString(clas.Porcentaje);
            deFechaRegistro.EditValue = clas.FechaRegistro;
            cbxEstado.SelectedIndex  = clas.Estado;
            solo = clas.IdEmpresa;
            solo = clas.IdUsuario;

        }
        private void frmImpuestos_Load(object sender, EventArgs e)
        {
            deFechaRegistro.EditValue = DateTime.Today;
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            datosImpuesto fre = new datosImpuesto();
            
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
            txtCodigo.Text = Convert.ToString(clas.IdImpuesto);
            txtDescripcion.Text = clas.Descripcion;
            txtPorcentaje.Text = Convert.ToString(clas.Porcentaje);
            deFechaRegistro.EditValue = clas.FechaRegistro;
            if (clas.Estado == 1)
            {
                cbxEstado.Text  = "Activo";
            }
            else
            {
                cbxEstado.Text ="Inactivo";
            }

            solo2 = clas.IdEmpresa;
            solo = clas.IdUsuario;

        }

        public void get()
        {
            if (txtCodigo.Text == "")
            {
               

            }
            else
            {
                clas.IdImpuesto = Convert.ToInt32(txtCodigo.Text);
            }
            clas.Descripcion = txtDescripcion.Text;
            clas.Porcentaje =Convert.ToDouble  (txtPorcentaje.Text);
            clas.FechaRegistro = Convert.ToDateTime(deFechaRegistro.EditValue);
            if (cbxEstado.Text == "Activo")
                clas.Estado = 1;
            else
                clas.Estado = 0;
          
            clas.IdEmpresa = 2;
            clas.IdUsuario = solo;
        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;
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
                event_click(sender, e);
                frmImpuestos_event_click(sender, e);

            }
        }
        

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            //  deFechaRegistro.EditValue ="";
            txtPorcentaje.EditValue = "";

            //gleEstado.EditValue = "";

        }

       
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmConsultaImpuesto Imp = new frmConsultaImpuesto();
            Imp.ShowDialog();
            clas = Imp.mp;
            if (clas.IdImpuesto == 0)
            {
                limpiar();
                txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            }
            else
            {
                Set();
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
                event_click(sender, e);
                frmImpuestos_event_click(sender, e);
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

                event_click(sender, e);
                frmImpuestos_event_click(sender, e);
            }
        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        



    }
}
