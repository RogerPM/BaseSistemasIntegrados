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
        public frmProcesoTrabajoDiario()
        {
            InitializeComponent();
        }

#region variables
        int NumLinea;
       
        int ban;
        int ban1;
#endregion

        void frmProcesoTrabajoDiario_event_Click(object sender, EventArgs e)
        {

        }

#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsTrabajoDiarioCab clasTdc = new clsTrabajoDiarioCab();
        public clsTrabajoDiarioDet clasTdd = new clsTrabajoDiarioDet();
        public clsPersona clasEmpleado = new clsPersona();
        //public clsAsistencia clasAsistencia = new clsAsistencia ();
       

        //***************DATOS******************

        clsDatosPersona Empleado = new clsDatosPersona();
        clsDatosTrabajoDiarioCab DatosTdc = new clsDatosTrabajoDiarioCab();
        clsDatosTrabajoDioarioDet DatosTdd = new clsDatosTrabajoDioarioDet();
        
        
#endregion

#region Metodos

        public void Cargar()
        {

            gcAsis .DataSource= DatosTdd .ConsultaTrabajoDet ( );
           

        }

        private string accion { get; set; }

        //**************SET****************
        public void Set()
        {
            //------------Datos de Trabajo Diario Cabecera
            txtNumero.Text = Convert.ToString(clasTdc .NumTrabajo );
            txtObservacion.Text = clasTdc.Observacion;
            deFecha.DateTime = clasTdc.Fecha;

            //---------Datos de Trabajo Diario Detalle
            NumLinea = clasTdd.NumLinea;
            
            
            

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
                //------------Datos de  Trabajo Diario Cabecera
                clasTdc.NumTrabajo = Convert.ToInt32(txtNumero.Text);
                clasTdc.Fecha = Convert.ToDateTime(deFecha.DateTime);
                clasTdc.Observacion = txtObservacion.Text;
                clasTdc .IdEmpresa =1;
                clasTdc.IdEstado = 1;
                if (DatosTdc .Guardar (clasTdc ))
                {
                    ban1 = 1;
                }
                
                //-------------Datos de Trabajo Diario Detalle
                for (int i = 0; i < gvAsistencia.RowCount ; i++)
                {
                    
                    clasTdd.NumLinea = DatosTdd.getIdSiguiente();
                    clasTdd.IdEmpresa = 1;
                    clasTdd.NumTrabajo = Convert.ToInt32(txtNumero.Text);
                    clasTdd.IdPersona = Convert.ToInt32(gvAsistencia.GetRowCellValue(i,colIdPersona ));
                    clasTdd.HoraInicio = Convert.ToString  (gvAsistencia.GetRowCellValue(i, colHoraEntrada1  ));
                    clasTdd.HoraSalida = Convert.ToString(gvAsistencia.GetRowCellValue(i, colHoraSalida2 ));

                    if (DatosTdd .Guardar (clasTdd))
                    {
                        ban = 1;
                    }
                   
                }

                
            }

        }

        //*************LIMPIAR*************
        public void Limpiar()
        {
            //Datos de Trabajo Diario Cabecera
            txtNumero.Text = "";
            deFecha.DateTime = DateTime.Now;
            txtObservacion.Text = "";

            //Datos de Trabajo Diario Detalle
            gcAsis.DataSource = DatosTdd .ConsultaTrabajoDet() ;
            gvAsistencia.OptionsBehavior.Editable =true ;
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
                    if (ban1 ==1)
                    {

                        if (ban == 1)
                        {
                            MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                            tsbGuardar.Enabled = false;
                            Limpiar();
                        }
                        else {
                            MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                        
                        }
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
             deFecha.DateTime = DateTime.Now;
             deFecha.Enabled = false;


             if (accion == "M")
             {
                 Set();
             }
             if (accion == "E")
             {
                 Set();
             }
         }

         //*****************************BUSCAR *********************************
         private void btnBuscar_Click(object sender, EventArgs e)
         {
             int numTrabajo;
             frmPConsultaTrabajo cTrab = new frmPConsultaTrabajo();
             List<clsPersona> Lista = new List<clsPersona>();
             List<clsTrabajoDiarioDet> Lista1 = new List<clsTrabajoDiarioDet>();
             cTrab.ShowDialog();
             clasTdc = cTrab.claseTdc;
             txtNumero.Text = Convert.ToString(clasTdc.NumTrabajo);
             deFecha.DateTime = Convert.ToDateTime(clasTdc.Fecha);
             txtObservacion.Text = clasTdc.Observacion;
             numTrabajo = Convert.ToInt32(txtNumero.Text);
             gcAsis   .DataSource = DatosTdd .ConsultaTrabajoDiarioDet (numTrabajo );
             gvAsistencia.OptionsBehavior.Editable = false;
             tsbGuardar.Enabled = false;

    
         }

#endregion
       
    }      
}
