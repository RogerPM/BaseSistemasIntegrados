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
    public partial class frmProcesoNominaEmpleado : Form
    {
        public frmProcesoNominaEmpleado()
        {
            InitializeComponent();
        }

#region variables
        DateTime FechaModificacion;
        int IdEmpresa;
        int NumLinea;
        int var;
        int ban;
        int ban1;
        int sumT;//GUARDA HORAS EXTRAS 100%
        int sumM;//GUARDA HORAS EXTRAS 50%
        int sumR;//GUARDA HORAS RANGO
        Decimal  Tothe;//TOTAL HORAS EXTRAS
        Decimal ValHe;//VALOR HORAS EXTRAS
        Decimal SuelG;//SUELDO GANADO
        Decimal sn;//SUELDO NOMINAL
        Decimal ti; //TOTAL DE INGRESO
        Decimal iess;//IESS
        Decimal ant;//ANTICIPO
        Decimal pres;//PRESTAMO
        Decimal totdesc;//TOTAL DE DESCUENTO
        Decimal valiq;//VALOR LIQUIDO
        Decimal total;//TOTAL
#endregion


        void frmProcesoNominaEmpleado_event_Click(object sender, EventArgs e)
        {

        }
#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsNominaCab  clasNc = new clsNominaCab ();
        public clsNominaDet clasNd = new clsNominaDet();

        //***************DATOS******************

        clsDatosNominaCab  DatosNc = new clsDatosNominaCab ();
        clsDatosNominaDet DatosNd = new clsDatosNominaDet();

#endregion

#region Metodos

        public void Cargar()
        {
            //gcNomina.DataSource = DatosNc.ConsultaNominaCab();
           
        }

        private string accion { get; set; }

        //**************SET****************
        public void Set()
        {
            //------------Datos de Nomina Cabecera
            txtNumero .Text = Convert.ToString (clasNc .NumNomina ); 
            deFecha .DateTime = clasNc .Fecha ;
            FechaModificacion =clasNc .FechaModificacion ;
            cmbPeriodo .SelectedIndex =clasNc .Periodo ;
            txtTotalPagar.Text = Convert.ToString(clasNc.Total);
            cmbEstado.SelectedIndex = clasNc.IdEstado;
            IdEmpresa = clasNc.IdEmpresa;
            txtObservacion.Text = clasNc.Observacion;
            

        }


        //**************GET****************

        public void Get(int vars)
        {
            if (txtNumero.Text == "")
            {

                clasNc .NumNomina  = 0;

            }
            else
            {
                //------------Datos de Nomina Cabecera
                clasNc.NumNomina = Convert.ToInt32(txtNumero.Text);
                clasNc.Fecha = deFecha.DateTime;
                clasNc.FechaModificacion = DateTime.Today ;
                clasNc.Periodo = cmbPeriodo.SelectedIndex;
                clasNc.Total = Convert.ToDouble(txtTotalPagar.Text);
                clasNc.IdEstado = cmbEstado.SelectedIndex;
                clasNc.IdEmpresa = 1;
                clasNc.Observacion = txtObservacion.Text;
               

                if (DatosNc .Guardar(clasNc ))
                {
                    ban1 = 1;
                }

              //-------------Datos de Nomina Detalle
                for (int i = 0; i < gvNomina.RowCount; i++)
                {

                    clasNd.NumLinea = DatosNd .getIdSiguiente();
                    clasNd.IdEmpresa = 1;
                    clasNd.NumNomina = Convert.ToInt32(txtNumero.Text);
                    clasNd .IdPersona =Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona));
                    clasNd .SueldoNominal =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colSueldoNominal ));
                    clasNd.SueldGanado =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colSueldGanado   ));
                    clasNd .Iess =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colIess));
                    clasNd .PrestamoPago =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colPrestamoPago ));
	                clasNd .Anticipo =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colAnticipo));
                    clasNd .ValorLiquido =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colValorLiquido));
                    //clasNd .IdEmpresa =Convert .ToInt32  (gvNomina .GetRowCellValue (i,colIdEmpresa  ));

                    if (vars==1) {
                        if (DatosNd.Guardar(clasNd))
                        {
                            ban = 1;
                        }
                    }
                    

                }


            }

        }

        //*************LIMPIAR*************
        public void Limpiar()
        {
            //Datos de Nomina Cabecera
            txtNumero.Text = "";
            deFecha.DateTime =DateTime .Today ;
            FechaModificacion = DateTime.Today;
            cmbPeriodo.SelectedIndex = 2;
            txtTotalPagar.Text = "";
            cmbEstado.SelectedIndex = 1;
            IdEmpresa = 1;
            txtObservacion.Text = "";

            //Datos de Nomina Detalle
           // gcNomina  .DataSource = DatosNd.ConsultaNominaDet();
            List<clsNominaDet> vacia = new List<clsNominaDet>();
            gvNomina .OptionsBehavior.Editable = true;
            gcNomina.DataSource = vacia;

        }
#endregion
        
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_Click;

#region Botones
        //********************* NUEVO ************************

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            tsbGenerarNomina .Enabled = true;
            tsbModificar.Enabled = false;
           
            btnGenerarNomina.Enabled = true;
            txtNumero.Text = Convert.ToString(DatosNc .getIdSiguiente());

        }

        //********************* GENERAR NOMINA ************************
        private void tsbGenerarNomina_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show(men.Error_Nom, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                var = 1;
                Get(var);
                accion = "G";
                if (accion == "G")
                {
                    if (ban1 == 1)
                    {

                        if (ban == 1)
                        {
                            MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                            tsbGenerarNomina  .Enabled = false;
                            tsbNuevo.Enabled = true;
                            Limpiar();
                        }
                        else
                        {
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
                        frmProcesoNominaEmpleado_event_Click(sender, e);
                        throw;
                    }

                }


            }

        }
        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            
            tsbNuevo.Enabled = false;
            tsbModificar.Enabled = false;
            tsbGenerarNomina.Enabled = true;
            gcNomina.DataSource = DatosNd.ConsultaNomDet ();
            

            for (int i = 0; i < gvNomina.RowCount; i++)
            {

                clasNd.NumNomina = Convert.ToInt32(txtNumero.Text);
                clasNd .IdPersona = Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona));
                sumT = DatosNd.consultaHorasT(clasNd.IdPersona);
                sumM = DatosNd.consultaHorasM(clasNd.IdPersona);
                sumR = DatosNd.consultaHorasR  (clasNd.IdPersona);
                Tothe = clasNd.TotalHorasExtras(sumT, sumM);
                sn=DatosNd.consultaSueldoN(clasNd.IdPersona, Tothe);
                ValHe = clasNd.ValHorasExtras(sn,Tothe);
                SuelG = clasNd.SGanado(sn ,sumR );
                ti = clasNd.Ingresos(SuelG, ValHe);
                iess = clasNd.Seguro(ti);
                ant = DatosNd.consultaAnticipo(clasNd.IdPersona);
                pres = DatosNd.consultaPrestamo(clasNd.IdPersona);
                totdesc = clasNd.TotDescuento(iess, ant, pres);
                valiq = clasNd.Liquido(ti,totdesc );
                total = total + valiq;

                gvNomina.SetRowCellValue(i, colIdPersona, clasNd.IdPersona);
                gvNomina.SetRowCellValue(i, colValorHorasExtras, ValHe);
                gvNomina.SetRowCellValue(i, colSueldoNominal , sn);
                gvNomina.SetRowCellValue(i, colSueldGanado , SuelG );
                gvNomina.SetRowCellValue(i, colIess, iess );
                gvNomina.SetRowCellValue(i, colPrestamoPago, pres );
                gvNomina.SetRowCellValue(i, colAnticipo, ant);
                gvNomina.SetRowCellValue(i, colValorLiquido , valiq );
                gvNomina.SetRowCellValue(i, colIdEmpresa, clasNd.IdEmpresa);
                
               
            }
            txtTotalPagar.Text = Convert.ToString(total);
          
        }

         private void frmNominaEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();

            
             int a = DatosNc .getIdSiguiente();
             txtNumero.Text = Convert.ToString(a);
             cmbPeriodo.SelectedIndex = 2;
             cmbPeriodo.Enabled = false;
             cmbEstado.SelectedIndex = 1;
             cmbEstado .Enabled = false;


             if (accion == "M")
             {
                 Set();
             }
             if (accion == "E")
             {
                 Set();
             }
         }
         private void btnBuscar_Click(object sender, EventArgs e)
         {
             btnGenerarNomina.Enabled = false;
             tsbNuevo.Enabled = true;
             tsbGenerarNomina.Enabled = false;
             tsbModificar.Enabled = true;


             int numNomina;
             frmPConsultaNomina cNom = new frmPConsultaNomina();
             cNom.ShowDialog();
             clasNc = cNom.claseNc;
             txtNumero.Text = Convert.ToString(clasNc.NumNomina);
             numNomina = Convert.ToInt32(txtNumero.Text);
             cmbPeriodo.SelectedIndex = clasNc.Periodo;
             txtObservacion.Text = Convert.ToString(clasNc.Observacion);
             deFecha.DateTime = Convert.ToDateTime(clasNc.Fecha);
             txtTotalPagar.Text = Convert.ToString(clasNc.Total);
             gcNomina.DataSource = DatosNd.ConsultaNominaDet(numNomina);


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
                     var = 2;
                     Get(var);
                     DatosNc.Modificar(clasNc);

                     frmProcesoNominaEmpleado_event_Click(sender, e);
                     MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                     Limpiar();
                 }
                 catch (Exception)
                 {

                     event_Click(sender, e);
                 }
                 
            // }
         }

         private void deFecha_EditValueChanged(object sender, EventArgs e)
         {

         }

#endregion

        

       
       

        }
    
        
      

       
    }

