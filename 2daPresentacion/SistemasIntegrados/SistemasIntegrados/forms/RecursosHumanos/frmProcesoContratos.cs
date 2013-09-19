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
    public partial class frmProcesoContratos : Form
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
            txbGuardar.Visible = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;
        }

        #endregion

        public frmProcesoContratos()
        {
            InitializeComponent();
        }

#region variables
        int IdPersona;
        string g;

#endregion
       
        void frmProcesoContratos_event_Click(object sender, EventArgs e)
        {

        }

#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsPersona clas = new clsPersona();
        public clsContrato cont = new clsContrato();
        public clsTipoContrato TipCont = new clsTipoContrato();
        //public clsJornada Jor = new clsJornada();


        //***************DATOS******************

        clsDatosContrato Contrato = new clsDatosContrato();
        clsDatosPersona dato = new clsDatosPersona();
        clsDatosCargo Cargo = new clsDatosCargo();
        clsDatosTipoContrato datosTipCont = new clsDatosTipoContrato();
        //clsDatosJornada datosJornada = new clsDatosJornada();


#endregion

#region Metodos

        //***********CARGAR****************

        public void Cargar()
        {

            cmbCargo.Properties.DataSource = Cargo.ConsultaCargo();
            cmbTipoContrato.Properties.DataSource = datosTipCont.ConsultaTipoContrato();
            //cmbJornada.Properties.DataSource = datosJornada.ConsultaJornada();


        }

        private string accion { get; set; }

        //**************SET****************
        public void Set()
        {
            //------------Datos de Contrato
            txtNumero.Text = Convert.ToString(cont.NumContrato);
            cmbCargo.EditValue = cont.IdCargo;

            deFecha.DateTime = cont.Fecha;
            cmbTipoContrato.EditValue = cont.IdTipoContrato;
            txtRemuneracion.Text = Convert.ToString(cont.Remuneracion);
            chePeriodo.Checked = Convert.ToBoolean(cont.PeriodoPrueba);
            //cmbJornada.EditValue = Convert.ToString(cont.IdJornada);
            chkDiscapacidad.Checked = Convert.ToBoolean(cont.Discapacidad);
            cmbGrado.EditValue = cont.grado;
            cmbTipoDiscapacidad.EditValue = cont.TipoDiscapacidad;
            txtCarnet.Text = Convert.ToString(cont.Carnet);

            //---------Datos de Persona
            IdPersona = clas.IdPersona;
            txtCedula.Text = Convert.ToString(clas.Identificacion);
            txtApellidos.Text = Convert.ToString(clas.Apellido);
            txtNombres.Text = Convert.ToString(clas.NombreRazonSocial);
            deFechaNacimiento.DateTime = clas.FechaNacimiento;
            if (clas.genero == "M")
            {
                rdgGenero.SelectedIndex = 0;

            }
            else
            {
                rdgGenero.SelectedIndex = 1;
            }

        }


        //**************GET****************

        public void Get()
        {
            if (txtNumero.Text == "")
            {

                cont.NumContrato = 0;

            }
            else
            {
                //------------Datos de Contrato

                cont.NumContrato = Convert.ToInt32(txtNumero.Text);
                cont.IdEmpresa = 1;
                cont.IdCargo = Convert.ToInt32(cmbCargo.EditValue);
                cont.IdEstado = Convert.ToInt32(cmbEstado.SelectedIndex);
                cont.Fecha = deFecha.DateTime;
                cont.FechaModificacion = DateTime.Now;
                cont.IdTipoContrato = Convert.ToInt32(cmbTipoContrato.EditValue);
                cont.Remuneracion = Convert.ToDouble(txtRemuneracion.Text);
                cont.PeriodoPrueba = Convert.ToInt32(chePeriodo.Checked);
                cont.IdJornada =1;
                cont.Discapacidad = Convert.ToInt32(chkDiscapacidad.Checked);
                cont.grado = Convert.ToInt32(cmbGrado.SelectedIndex);
                cont.TipoDiscapacidad = Convert.ToInt32(cmbTipoDiscapacidad.SelectedIndex);
                if (txtCarnet.Text == "")
                {
                    cont.Carnet = 0;
                }
                else {
                    cont.Carnet = Convert.ToInt32(txtCarnet.Text);
                }
              
                cont.IdPersona = IdPersona;


            }

        }

        //*************VALIDAR*************
        private void Validar()
        {
            if (chkDiscapacidad.Checked)
                cmbGrado.Enabled = true;
            cmbTipoDiscapacidad.Enabled = true;
            txtCarnet.Enabled = true;
        }

        //*************LIMPIAR*************
        public void Limpiar()
        {
            //Datos de contrato
            txtNumero.Text = "";
            deFecha.DateTime = DateTime.Now;
            cmbCargo.ItemIndex = 0;
            cmbEstado.SelectedIndex = 1;
            cmbTipoContrato.EditValue = 0;
            txtRemuneracion.Text = "";
            chePeriodo.Checked = false;
            //cmbJornada.ItemIndex = 0;

            //Datod de empleado
            txtCedula.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            deFechaNacimiento.DateTime = DateTime.Now;
            rdgGenero.SelectedIndex = 0;
            chkDiscapacidad.Checked = false;
            cmbGrado.EditValue = 0;
            cmbTipoDiscapacidad.EditValue = 0;
            txtCarnet.Text = "";
        }


#endregion

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

#region Botones

        //***************** NUEVO ****************************

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbEstado.SelectedIndex = 1;
            cmbEstado.Enabled = false;
            tsbModificar.Enabled  = false;
            txtRemuneracion.Enabled = true;
            txbGuardar.Enabled = true;
            txtNumero.Text = Convert.ToString(Contrato.getIdSiguiente());

        }

        //*************** GUARDAR *********************************

        private void txbGuardar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            if (txtNombres.Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "G";
                if (accion == "G")
                {
                    if (Contrato.Guardar(cont))
                    {

                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        Limpiar();
                        txbGuardar.Enabled = false; 

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
                        frmProcesoContratos_event_Click(sender, e);
                        throw;
                    }

                }


            }
        }


        //********************** BUSCAR CONTRATO ********************

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmPConsultaContrato cCon = new frmPConsultaContrato();
            cCon.ShowDialog();
            cont = cCon.c;
            List<clsPersona> Lista = new List<clsPersona>();
            txtNumero.Text = Convert.ToString(cont.NumContrato);
            deFecha.DateTime = Convert.ToDateTime(cont.Fecha);
            cmbCargo.EditValue = cont.IdCargo;
            cmbEstado.SelectedIndex = cont.IdEstado;
            cmbTipoContrato.EditValue = cont.IdTipoContrato;
            txtRemuneracion.Text = Convert.ToString(cont.Remuneracion);
            chePeriodo.Checked = Convert.ToBoolean(cont.PeriodoPrueba);
            //cmbJornada.EditValue = cont.IdJornada;
            chkDiscapacidad.Checked = Convert.ToBoolean(cont.Discapacidad);
            cmbGrado.SelectedIndex = cont.grado;
            cmbTipoDiscapacidad.SelectedIndex = cont.TipoDiscapacidad;
            txtCarnet.Text = Convert.ToString(cont.Carnet);
            txtNumero.Enabled = false;
            deFecha.Enabled = false;
            IdPersona = cont.IdPersona;
            
            txtCedula.Text =Convert .ToString ( Contrato .ConsultContratoIdentificacion (IdPersona ));
            txtNombres.Text = Contrato.ConsultContratoNombre(IdPersona);
            txtApellidos.Text = Contrato.ConsultContratoApellido(IdPersona);
            deFechaNacimiento.DateTime = Contrato.ConsultContratoFecha(IdPersona);
            g =Contrato .ConsultaContratoGenero  (IdPersona );
            if (g == "M")
            {
                rdgGenero.SelectedIndex = 0;

            }
            else {
                rdgGenero.SelectedIndex = 1;
            }

            txbGuardar.Enabled = false;
            tsbModificar.Enabled = true;
            tsbNuevo.Enabled = true;
            txtRemuneracion.Enabled = false;
            cmbEstado.Enabled = true;

        }

        // ******************** BUSCAR PERSONA **********************

        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            cPer.band = 1;
            cPer.ShowDialog();
            clas = cPer.p;
            IdPersona = clas.IdPersona;
            txtCedula.Text = Convert.ToString(clas.Identificacion);
            txtNombres.Text = clas.NombreRazonSocial;
            txtApellidos.Text = clas.Apellido;
            if (clas.genero == "M")
            {
                rdgGenero.SelectedIndex = 0;

            }
            else
            {
                rdgGenero.SelectedIndex = 1;
            }

            deFechaNacimiento.DateTime = clas.FechaNacimiento;

        }


        //********************* LOAD ****************************

        private void frmContratos_Load(object sender, EventArgs e)
        {
            Cargar();

            int a = Contrato.getIdSiguiente();
            txtNumero.Text = Convert.ToString(a);
            deFecha.DateTime = DateTime.Now;

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

         //*************************** MODIFICAR *******************************

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            if (txtNumero.Text == "" || txtNumero.Text == Convert.ToString(Contrato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {

                try
                {

                    Get();
                    Contrato.Modificar(cont);
                }
                catch (Exception)
                {
                    event_Click(sender, e);
                    frmProcesoContratos_event_Click(sender, e);

                    throw;
                }
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                Limpiar();

            }
        }

        //************************* ELIMINAR ********************************+

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtNumero.Text == Convert.ToString(Contrato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "E";
                if (accion == "E")
                {
                    if (Contrato.Eliminar(cont))
                    {
                        MessageBox.Show(men.Exito_eli, men.Titulo, MessageBoxButtons.OK);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(men.Error_eli, men.Titulo, MessageBoxButtons.OK);
                    }

                }
                try
                {

                }
                catch (Exception)
                {
                    event_Click(sender, e);
                    frmProcesoContratos_event_Click(sender, e);
                    throw;
                }

            }

        }

#endregion

      
      

        private void chkDiscapacidad_CheckedChanged(object sender, EventArgs e)
        {
            Validar();
        }

       
        
    }

    
}
