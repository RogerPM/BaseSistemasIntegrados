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

namespace forms.RecursosHumanos
{
    public partial class frmProcesoPrestamoEmpleado : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Seguridad()
        {
            //lecturas
            btnNumero.Visible = frmPrincipal.Lectura;
            btnBuscarEmpleado.Visible = frmPrincipal.Lectura;
            //escrituras
            tsbNuevo.Visible = frmPrincipal.Escritura;
            tsbGuardar.Visible = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;

        }

        #endregion

        public frmProcesoPrestamoEmpleado()
        {
            InitializeComponent();
        }

        void frmProcesoPrestamoEmpleado_event_Click(object sender, EventArgs e)
        {

        }
#region Variable
        int id;
        Decimal  val;
#endregion
       
#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsPersona clas = new clsPersona();
        public clsPrestamo clasPrestamo = new clsPrestamo();
       // public clsPrestamo clasPrestamo = new clsPrestamo ();
        

        //***************DATOS******************

        clsDatosPersona dato = new clsDatosPersona();
        clsDatosPrestamo datoPrestamo = new clsDatosPrestamo();
        
#endregion

#region Metodos

        //***********CARGAR****************

        public void Cargar()
        {
            deFecha.DateTime = DateTime.Today;

        }

        private string accion { get; set; }

        //**************SET****************
        public void Set()
        {
            //------------Datos de Contrato
            txtNumero.Text = Convert.ToString(clasPrestamo .IdPrestamo );
            id=clasPrestamo .IdPersona ;
            txtCedula .Text =Convert .ToString (clasPrestamo .Identificacion );
            txtNombre .Text =clasPrestamo .Nombre + clasPrestamo .Apellido;
            deFecha .DateTime =Convert .ToDateTime ( clasPrestamo .FechaModificacion);
            txtPrestamo.Text =Convert .ToString (clasPrestamo .Monto);
            txtPagos .Text =Convert .ToString (clasPrestamo .Pago);
            txtTotalPrestamo .Text =Convert .ToString (clasPrestamo .Total );
            txtInteres .Text =Convert .ToString (clasPrestamo .Interes );
            txtPeriodo .Text =Convert .ToString (clasPrestamo .Periodos );
            txtTotalPagado.Text = Convert.ToString(clasPrestamo.TotalPagado);
            cmbEstado.SelectedIndex = clasPrestamo.IdEstado;
            val = Convert.ToDecimal(txtTotalPagado .Text) / Convert.ToDecimal(txtPagos.Text);
            lblcp.Text = Convert.ToString (val);
            lblct.Text = txtPeriodo.Text;
        }


        //**************GET****************

        public void Get()
        {
            if (txtNumero.Text == "")
            {
                clasPrestamo.IdPrestamo =0;
                 

            }
            else
            {
                clasPrestamo.IdPrestamo = Convert.ToInt32(txtNumero.Text);
                clasPrestamo.IdPersona = id;
                clasPrestamo.FechaModificacion = deFecha.DateTime;
                clasPrestamo.Monto = Convert.ToDecimal(txtPrestamo.Text);
                clasPrestamo.Pago = Convert.ToDecimal(txtPagos.Text);
                clasPrestamo.Total = Convert.ToDecimal(txtTotalPrestamo.Text);
                clasPrestamo.Interes = Convert.ToDecimal(txtInteres.Text);
                clasPrestamo.Periodos = Convert.ToInt32(txtPeriodo.Text);
                clasPrestamo.TotalPagado = Convert.ToDecimal(txtTotalPagado.Text);
                clasPrestamo.IdEstado = cmbEstado.SelectedIndex;
                clasPrestamo.IdEmpresa = 1;
               


            }

        }

      

      
        //*************LIMPIAR*************
        public void Limpiar()
        {
            txtNumero.Text = "";
            id=0;
            txtCedula .Text ="";
            txtNombre.Text = "";
            deFecha .DateTime =DateTime .Today ;
            txtPrestamo.Text = "";
            txtPagos.Text = "";
            txtTotalPrestamo.Text = "";
            txtInteres.Text = "";
            txtPeriodo.Text = "";
            txtTotalPagado.Text = "";
            cmbEstado.SelectedIndex = 1;
            val = 0;
            lblcp.Text ="0";
            lblct.Text = "0";

           
        }

#endregion

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnCalcular.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
            tsbGuardar.Enabled = true;
            txtNumero .Text = Convert.ToString(datoPrestamo  .getIdSiguiente());
        }
       
      
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
           
            tsbNuevo.Enabled = true;
            tsbModificar.Enabled = false;
            btnCalcular.Enabled = false;
            tsbGuardar.Enabled = false;
            if (txtNombre .Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "G";
                if (accion == "G")
                {
                    if (datoPrestamo .Guardar(clasPrestamo ))
                    {

                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        //Limpiar();
                        tsbGuardar.Enabled = false;
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);

                    }
                    try
                    {

                    }
                    catch (Exception)
                    {
                        event_Click(sender, e);
                        frmProcesoPrestamoEmpleado_event_Click(sender, e);
                        throw;
                    }

                }


            }
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            /* if (txtNumero.Text == "" || txtNumero.Text == Convert.ToString(DatosNc.getIdSiguiente()))
             {
                 MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
             }
             else
             {*/
            try
            {
                //var = 2;
                Get();
                datoPrestamo.Modificar(clasPrestamo );

                frmProcesoPrestamoEmpleado_event_Click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                Limpiar();
                tsbModificar.Enabled = false;
                tsbNuevo.Enabled = true;
            }
            catch (Exception)
            {

                event_Click(sender, e);
            }

            // }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            txtPagos.Text = Convert.ToString(clasPrestamo.TasaMensual(Convert.ToDecimal(txtInteres.Text), Convert.ToDecimal(txtPrestamo.Text), Convert.ToInt32(txtPeriodo.Text)));
            txtTotalPrestamo .Text =Convert .ToString (clasPrestamo .Tot (Convert .ToInt32 (txtPeriodo .Text),Convert .ToDecimal (txtPagos .Text )));
           
            lblct.Text = txtPeriodo.Text;
            txtTotalPagado.Text = "0";
        }


        private void frmProcesoPrestamoEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();

            int a = datoPrestamo .getIdSiguiente ();
            txtNumero.Text = Convert.ToString(a);
           deFecha.DateTime = DateTime.Today;
           cmbEstado.SelectedIndex = 1;

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

        private void txtInteres_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            cPer.band = 2;
            cPer.ShowDialog();
            clas = cPer.p;
            id = clas.IdPersona;
            txtCedula.Text = Convert.ToString(clas.Identificacion);
            txtNombre.Text = clas.NombreRazonSocial + " " + clas.Apellido;
           
            
        }

        private void btnNumero_Click_1(object sender, EventArgs e)
        {
            frmPConsultaPrestamo cPre = new frmPConsultaPrestamo();
            tsbGuardar.Enabled = false;
            btnCalcular.Enabled = false;
            tsbModificar.Enabled = true;
            cPre.ShowDialog();
            clasPrestamo = cPre.p;
            Set();
            txtNumero.Enabled = false;
            txtCedula.Enabled=false ;
            txtNombre.Enabled =false ;
            deFecha.Enabled=false;
            txtPrestamo.Enabled =false;
            txtPagos.Enabled=false;
            txtTotalPrestamo.Enabled=false;
            txtInteres.Enabled=false;
            txtPeriodo.Enabled=false;
            txtTotalPagado.Enabled =false;
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            btnBuscarEmpleado.Enabled = false;
           
        }

       
       
       
        

        

      



       

      
     

       

    }
}
