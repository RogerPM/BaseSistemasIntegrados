using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using clases.RecursosHumanos;
using clases.Seguridad;
using datos.RecursosHumanos;
using DevExpress.Utils;

namespace forms.RecursosHumanos
{


    public partial class frmMantenimientoEmpleado : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Seguridad()
        {
            //lecturas
            btnBuscarCedula.Visible = frmPrincipal.Lectura;
            //escrituras
            tsbNuevo.Visible = frmPrincipal.Escritura;
            tsbGuardar.Visible = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            tsbEliminar.Visible = frmPrincipal.Eliminacion;
        }

        #endregion

        public frmMantenimientoEmpleado()
        {
            InitializeComponent();
            clsMensaje msj = new clsMensaje();
         
        }

        
        clsPersona user = new clsPersona();
        int solo = 1;
        int acad;
        int tper;
        int tiden;
        int ides;
        int ban1;
        int ban2;
        
        void frmMantenimientoEmpleado_event_Click(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsPersona clas = new clsPersona();
        public clsPersonaxCargo claspc = new clsPersonaxCargo();
        public clsCargoxDepartamento clascd = new clsCargoxDepartamento();
        public clsDepartamento clasdep = new clsDepartamento();
        public clsPersonaxTitulo claspt = new clsPersonaxTitulo(); 
        public clsAcademico clasac = new clsAcademico();

        clsDatosPersona dato = new clsDatosPersona();
        clsDatosPersonaxCargo datopc = new clsDatosPersonaxCargo();
        clsDatosCargoxDepartamento datocd = new clsDatosCargoxDepartamento();
        clsDatosDepartamento datdep = new clsDatosDepartamento();
        clsDatosPersonaxTitulo datpt = new clsDatosPersonaxTitulo();
        clsDatosAcademico datoaca = new clsDatosAcademico();


        public void Cargar()
        {
            clsDatosDepartamento Departamento = new clsDatosDepartamento();
            clsDatosCargo Cargo = new clsDatosCargo();
            clsDatosTitulo Titulo = new clsDatosTitulo();
            clsDatosUniversidad Universidad = new clsDatosUniversidad();
            
           
            cmbDepartamento.Properties.DataSource = Departamento.ConsultaDepartamento();
            cmbCargo.Properties.DataSource = Cargo.ConsultaCargo();
            cmbTitulo.DataSource = Titulo.ConsultaTitulo();
            cmbInstitucion.DataSource = Universidad.ConsultaUniversidad();
            
            
        }


        private string accion { get; set; }

        public void Set()
        {
            txtid.Text = Convert.ToString(clas.IdPersona);
           
           txtCedula .Text = Convert.ToString(clas.Identificacion );
            tper =clas .IdTipoPersona ;
          
            txtNombre.Text = clas.NombreRazonSocial ;
            txtApellido.Text = clas.Apellido;
            deFNacimiento.DateTime = clas.FechaNacimiento;
            if (clas.genero == "M")
            {
                rgGenero.SelectedIndex = 0;

            }
            else
            {
                rgGenero.SelectedIndex = 1;

            }
             tiden =clas .TipoIdentificacion ;
            txtDireccion.Text = clas.direccion;
            txtGeneral.Text =Convert .ToString ( clas.General);
            txtMovil.Text = Convert.ToString(clas.Movil);
            txtCasa.Text = Convert.ToString(clas.Casa);
            txtOtro.Text = Convert.ToString(clas.Otros);
            txtCorreo.Text = clas.mail;
            deFechaIngreso.DateTime = claspc.FechaIngreso;
            cmbDepartamento.EditValue = clascd.IdDepartamento;
            cmbCargo.EditValue = claspc.IdCargo;
            cmbEstado.SelectedIndex = claspc.IdEstado;
            
           /* foreach(DataGridViewRow row in dgvAcademico.Rows){

                cmbTitulo.ValueMember= Convert .ToString ( claspt .IdTitulo) ;
               // txtAno.ValueType = Convert.ToString ( claspt .ano) ;

                //v1 += Convert.ToInt32(row.Cells[0].Value) / 10

            }*/
            
            solo = clas.IdEmpresa;
            ides =clas .IdEstado; 
            
         

        }

        public void Get()
        {
            if (txtid  .Text == "")
            {
                if (acad == 0)
                {    
                    clas.IdPersona   = 0;
                    clasac.IdAcademico = 0;
                }
            }
            else
            {
                clas.IdPersona = Convert.ToInt32(txtid.Text);
                claspc.IdPersona = Convert.ToInt32(txtid.Text);
                clas.IdEmpresa = solo;
                claspc.IdEmpresa = solo;
                clasac.IdAcademico = acad;
                clas.Identificacion  = Convert.ToInt32(txtCedula  .Text);
                clas.TipoIdentificacion = 1;
                clas.IdTipoPersona = 1;
                clas.NombreRazonSocial = txtNombre.Text;
                clas.Apellido = txtApellido.Text;
                if (rgGenero.SelectedIndex == 0)
                {
                    clas.genero = "M";
                }
                else
                {
                    clas.genero = "F";
                }

                clas.FechaNacimiento = deFNacimiento.DateTime;
                clas.direccion = txtDireccion.Text;
                clas.mail = txtCorreo.Text;
                clas.General = Convert.ToInt32(txtGeneral.Text);
                clas.Movil = Convert.ToInt32(txtMovil.Text);
                clas.Casa = Convert.ToInt32(txtCasa.Text);
                clas.Otros = Convert.ToInt32(txtOtro.Text);
                claspc.FechaIngreso = deFechaIngreso.DateTime;
                clascd.FechaCreación = deFechaIngreso.DateTime;
                claspc.FechaModificacion = DateTime.Now ;
                clascd.FechaModificacion = DateTime.Now;
                claspc.IdCargo = Convert .ToInt32 ( cmbCargo.EditValue);
                clascd.IdCargo = Convert.ToInt32(cmbCargo.EditValue);
                clascd.IdDepartamento = Convert.ToInt32(cmbDepartamento.EditValue);
                claspc.IdEstado = cmbEstado.SelectedIndex;
                clascd.IdEstado = 1;
                if (dato.Guardar(clas))
                {
                    ban1=1;
                }
            

                            

                foreach (DataGridViewRow row in dgvAcademico.Rows)
                {
                    acad = datoaca.getIdSiguiente();
                    clasac.IdAcademico = acad ;
                    clasac.IdPersona = Convert.ToInt32(txtid.Text); 
                    clasac.IdTitulo = Convert.ToInt32(row.Cells[0].Value);  
                    clasac.IdEmpresa = solo;
                    clasac.IdUniversidad = Convert.ToInt32(row.Cells[1].Value);
                    claspt.IdEstado = 1;
                    if (row.Cells[0].Value == null) {
                        break;
                    } 
                    if (datoaca .Guardar (clasac ))
                    {
                        ban2 = 1;
                    }
                                       //claspt.ano = Convert.ToDateTime(row.Cells[2].Value);
                    //cmbTitulo.ValueMember = Convert.ToString(claspt.IdTitulo);
                    // txtAno.ValueType = Convert.ToString ( claspt .ano) ;

                    //v1 += Convert.ToInt32(row.Cells[0].Value) / 10

                }
            



            }

 
        }

        


        public void Limpiar()
        {
            txtCedula .Text = "";
            txtNombre.Text = "";
            txtid.Text = "";
            txtCorreo.Text = "";
            txtApellido.Text = "";
            txtCasa.Text = "";
            txtDireccion.Text = "";
            txtGeneral.Text = "";
            txtMovil.Text = "";
            txtOtro.Text = "";
            deFechaIngreso.DateTime = DateTime.Now;
            deFNacimiento.DateTime = DateTime.Now;
            rgGenero.SelectedIndex = 0;
            cmbCargo.EditValue = 0;
            cmbDepartamento.EditValue = 0;
            cmbEstado.EditValue = 0;
            
            

        }

        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;




        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            txtid.Text = Convert.ToString(dato.getIdSiguiente());

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo , MessageBoxButtons.OK);
            }
            else
            {
                Get();
                accion = "G";
                if (accion == "G")
                {
                    if (ban1==1 )
                    {
                        if (datopc.Guardar(claspc))
                        {
                            
                                if (ban2==1 )
                                {
                                 
                                MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                                Limpiar();
                                }
                            
                           
                        }
                        
                    }
                    else
                    {
                        try
                        {
                            MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);

                        }
                        catch (Exception)
                        {
                            event_Click(sender, e);
                            frmMantenimientoEmpleado_event_Click(sender, e);

                            throw;
                        }
                       

                    }
                }
              
              
            }
            
        }

        

       
        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            frmMConsultaEmpleado cPer = new frmMConsultaEmpleado();
            cPer.band = 1;
            cPer.ShowDialog();
            clas = cPer.p ;
           
            txtid.Text = Convert.ToString(clas.IdPersona  );
            txtCedula.Text = Convert.ToString(clas.Identificacion);
            solo = clas.IdEmpresa;
            txtNombre.Text = clas.NombreRazonSocial ;
            txtApellido.Text = clas.Apellido;
            if (clas.genero == "M")
            {
                rgGenero.SelectedIndex = 0;

            }
            else
            {
                rgGenero.SelectedIndex = 1;
            }
           
            deFNacimiento.DateTime = clas.FechaNacimiento;
            txtDireccion.Text = clas.direccion;
            txtCorreo.Text = clas.mail;
            txtGeneral.Text =Convert .ToString  ( clas.General);
            txtMovil.Text = Convert.ToString(clas.Movil);
            txtCasa.Text = Convert.ToString(clas.Casa);
            txtOtro.Text = Convert.ToString(clas.Otros);
            cmbEstado.SelectedIndex = clas.IdEstado;
        }

        private void frmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
          
            int a = dato.getIdSiguiente();
            txtid.Text = Convert.ToString(a);
            

            clsDatosPersona pers = new clsDatosPersona();

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

        private void tsbModificar_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtid.Text == Convert.ToString(dato.getIdSiguiente()))
            {
                MessageBox.Show(men.Error_cod, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                Get();
                dato.Modificar(clas);
                event_Click(sender, e);
                frmMantenimientoEmpleado_event_Click(sender, e);
                MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                Limpiar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtid.Text == Convert.ToString(dato.getIdSiguiente()))
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
                frmMantenimientoEmpleado_event_Click(sender, e);
            }
        }

        private void txtid_EditValueChanged(object sender, EventArgs e)
        {

        }

       

     

         
    }
}