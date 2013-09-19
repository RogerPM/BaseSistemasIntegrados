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
    public partial class frmProcesoTrabajoDiario : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            btnBuscarCedula.Visible = frmPrincipal.Lectura;
            //escrituras
            tsbNuevo.Visible = frmPrincipal.Escritura;
            tsbGuardar.Visible = frmPrincipal.Escritura;
        }

        #endregion

        public frmProcesoTrabajoDiario()
        {
            InitializeComponent();
        }

#region variables
        int NumLinea;
        int cont;
        int id;
        int ban;
        int ban1;
#endregion

        void frmProcesoTrabajoDiario_event_Click(object sender, EventArgs e)
        {

        }

#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsTrabajoDiario clasTdc = new clsTrabajoDiario();
        public clsPersona clasEmpleado = new clsPersona();
        //public clsAsistencia clasAsistencia = new clsAsistencia ();
       

        //***************DATOS******************

        clsDatosPersona Empleado = new clsDatosPersona();
        clsDatosTrabajoDiario DatosTdc = new clsDatosTrabajoDiario();
      
        
        
#endregion

#region Metodos

        public void Cargar()
        {

            //gcAsis .DataSource= DatosTdd .ConsultaTrabajoDet ( );
           

        }

        private string accion { get; set; }

        //**************SET****************
        public void Set()
        {
            
            txtNumero.Text = Convert.ToString(clasTdc .NumTrabajo );
            txtObservacion.Text = clasTdc.Observacion;
            deDesde.DateTime = clasTdc.FechaDesde;
            deHasta.DateTime = clasTdc.FechaHasta;
            teIngreso.Time = clasTdc.HoraEntrada1;
            teSalida.Time = clasTdc.HoraSalida2;
            txtCedula.Text = Convert.ToString(clasTdc.Identificacion);
            txtNombres.Text = clasTdc.Nombre;
            txtApellidos.Text = clasTdc.Apellido;
            id = clasTdc.IdPersona;

        }


        //**************GET****************

        public void Get()
        {
            if (txtNumero.Text == "")
            {

                clasTdc .NumTrabajo  = 0;

            }
            else
            {
                clasTdc.NumTrabajo = Convert.ToInt32(txtNumero.Text);
                clasTdc.FechaDesde  = Convert.ToDateTime(deDesde .DateTime);
                clasTdc.FechaHasta = Convert.ToDateTime(deHasta.DateTime);
                clasTdc.Observacion = txtObservacion.Text;
                clasTdc .IdEmpresa =1;
                clasTdc.IdEstado = 1;
                clasTdc.IdPersona = id;
                clasTdc.HoraInicio =Convert .ToString ( teIngreso.Time);
                clasTdc.HoraSalida = Convert.ToString(teSalida.Time);
         
            }

        }

        //*************LIMPIAR*************
        public void Limpiar()
        {
           
            txtNumero.Text = "";
            txtObservacion.Text = "";
            deDesde.DateTime = DateTime .Today;
            deHasta.DateTime = DateTime .Today ;
            teIngreso.Time = DateTime.Now;
            teSalida.Time = DateTime .Now;
            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            id = 0;
          
        }
#endregion

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

#region Botones

        //********************* NUEVO ************************

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            tsbGuardar.Enabled = true;
            txtNumero.Text = Convert.ToString(DatosTdc .getIdSiguiente());

        }

        //******************* GUARDAR *************************

         private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "G";
                if (accion == "G")
                {
                    if (DatosTdc.Guardar(clasTdc))
                    {

                        
                            MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
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
                        frmProcesoTrabajoDiario_event_Click(sender, e);
                        throw;
                    }

                }


            }
        }

        //*****************************LOAD *********************************
         private void frmProcesoTrabajoDiario_Load(object sender, EventArgs e)
         {
             Cargar();


             int a = DatosTdc.getIdSiguiente();
             txtNumero.Text = Convert.ToString(a);
             deDesde.DateTime = DateTime.Today;
             deHasta.DateTime = DateTime .Today;


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

         //*****************************BUSCAR *********************************
         private void btnBuscar_Click(object sender, EventArgs e)
         {
            
             frmPConsultaTrabajo cTrab = new frmPConsultaTrabajo();
             cTrab.ShowDialog();
             clasTdc = cTrab.claseTdc;
             txtNumero.Text = Convert.ToString(clasTdc.NumTrabajo);
             deDesde.DateTime = Convert.ToDateTime(clasTdc.FechaDesde);
             deHasta.DateTime = Convert.ToDateTime(clasTdc.FechaHasta);
             txtObservacion.Text = clasTdc.Observacion;
             txtCedula.Text =Convert .ToString ( clasTdc.Identificacion);
             txtNombres.Text = clasTdc.Nombre;
             txtApellidos.Text = clasTdc.Apellido;
             deDesde.DateTime = clasTdc.FechaDesde;
             deHasta.DateTime = clasTdc.FechaHasta;
             teIngreso.Time = clasTdc.HoraEntrada1 ;
             teSalida.Time = clasTdc.HoraSalida2 ;
             
             tsbGuardar.Enabled = false;

    
         }

#endregion

         private void btnBuscarCedula_Click(object sender, EventArgs e)
         {
             frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
             cPer.band = 2;
             cPer.ShowDialog();
             clasEmpleado  = cPer.p;
             id = clasEmpleado .IdPersona;
             txtCedula.Text = Convert.ToString(clasEmpleado .Identificacion);
             txtNombres.Text = clasEmpleado .NombreRazonSocial;
             txtApellidos.Text = clasEmpleado .Apellido;
         }
       
    }      
}
