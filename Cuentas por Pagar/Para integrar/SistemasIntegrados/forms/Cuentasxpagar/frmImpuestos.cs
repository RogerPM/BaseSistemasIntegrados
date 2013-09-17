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
        }

        int solo = 1;
        int solo2 = 2;

        
        public clsMensajeCxP men = new clsMensajeCxP();
        public clsImpuestos clas = new clsImpuestos();
        datosImpuestos dato = new datosImpuestos();
        public string accion { get; set; }

        private void frmImpuestos_Load(object sender, EventArgs e)
        {
            dtpFechaRegistro.EditValue = DateTime.Today;
            txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
            datosImpuestos fre = new datosImpuestos();
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
            dtpFechaRegistro.EditValue = clas.FechaRegistro;
            cbxEstado.EditValue = clas.IdEstado;
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
            clas.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
            if (Convert.ToBoolean(ckbAcreedor.EditValue) != false)
                clas.naturAcree = 2;
            else
                clas.naturAcree = 1;
            clas.FechaRegistro = Convert.ToDateTime(dtpFechaRegistro.EditValue);
            clas.IdEstado = cbxEstado.SelectedIndex;
            clas.IdEmpresa = 2;
            clas.IdUsuario = 11;
        }


        public void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            //  deFechaRegistro.EditValue ="";
            txtPorcentaje.EditValue = "";

            //gleEstado.EditValue = "";

        }


        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    frmConsultaImpuesto Imp = new frmConsultaImpuesto();
        //    Imp.ShowDialog();
        //    clas = Imp.mp;
        //    if (clas.IdImpuesto == 0)
        //    {
        //        limpiar();
        //        txtCodigo.Text = Convert.ToString(dato.getIdSiguiente());
        //    }
        //    else
        //    {
        //        Set();
        //    }

        //}

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
                //frmImpuestos_event_click(sender, e);
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
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaImpuesto fr = new frmConsultaImpuesto();
            fr.ShowDialog();

            clas = fr.mp;
            txtCodigo.Text = Convert.ToString(clas.IdImpuesto);
            txtDescripcion.Text = clas.Descripcion;
            txtPorcentaje.Text = Convert.ToString(clas.Porcentaje);
            dtpFechaRegistro.EditValue = clas.FechaRegistro;
            cbxEstado.SelectedIndex = 1;
            solo = clas.IdEmpresa;
            solo = clas.IdUsuario;
        }
    }
}
