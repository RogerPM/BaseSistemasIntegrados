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
    public partial class frmProcesoAnticiposEmpleado : Form
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
            //tsbGenerarNomina.Visible = frmPrincipal.Escritura;
            btnGenerarNomina.Enabled = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;
        }

        #endregion

        public frmProcesoAnticiposEmpleado()
        {
            InitializeComponent();
        }

       
#region variables
        DateTime FechaModificacion;
        int IdEmpresa;
        int persona;
        int NumLinea;
        int var;
        int ban;
        int ban1;
        int ban2;
        int ban3;
        int mes;
        String  meses;
        String  dia;
        String  año;
        String diau;
        DateTime desde;
        DateTime hasta;
        String  desde1;
        String  hasta1;

       
        Decimal valiq;//VALOR LIQUIDO
        Decimal suelnom;//TOTAL
        Decimal total;
        int porc;
        
#endregion


        void frmProcesoAnticiposEmpleado_event_Click(object sender, EventArgs e)
        {

        }
#region Instancia

        //*******************CLASES**************
        public clsMensaje men = new clsMensaje();
        public clsNominaCab  clasNc = new clsNominaCab ();
        public clsNominaDet clasNd = new clsNominaDet();
        public clsPrestamo clasPres = new clsPrestamo();
        public clsOrdenPagCabRH clasOpc = new clsOrdenPagCabRH();
        public clsOrdenPagoEmpleadoDetalle  clasOpe=new clsOrdenPagoEmpleadoDetalle ();
        public clsAnticipoCabecera clasAc=new clsAnticipoCabecera ();
        public clsAnticipoDetalle clasAd = new clsAnticipoDetalle();


        //***************DATOS******************

        clsDatosNominaCab  DatosNc = new clsDatosNominaCab ();
        clsDatosNominaDet DatosNd = new clsDatosNominaDet();
        clsDatosPrestamo DatosPres = new clsDatosPrestamo();
        clsDatosOrdenPagCabRH  DatosOpc=new clsDatosOrdenPagCabRH ();
        clsDatosOrdenPagoEmpleadoDetalle DatosOpe =new clsDatosOrdenPagoEmpleadoDetalle();
        clsDatosAnticipoCabecera  DatosAc=new clsDatosAnticipoCabecera ();
        clsDatosAnticipoDetalle DatosAd = new clsDatosAnticipoDetalle();
        

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
            txtNumero .Text = Convert.ToString (clasAc  .NumAnticipo ); 
            deFecha .DateTime = clasAc .Fecha ;
            FechaModificacion =clasAc .FechaModificacion ;
            txtPorcentaje .Text  =Convert .ToString ( clasAc .Porcentaje)  ;
            txtTotalPagar.Text = Convert.ToString(clasAc.Total);
            cmbEstado.SelectedIndex = clasNc.IdEstado;
            IdEmpresa = clasAc.IdEmpresa;
            txtObservacion.Text = clasAc.Observacion;
            

        }


        //**************GET****************

        public void Get(int vars)
        {
            if (txtNumero.Text == "")
            {

                clasAc .NumAnticipo = 0;

            }
            else
            {
                //------------Datos de Nomina Cabecera
                clasAc.NumAnticipo = Convert.ToInt32(txtNumero.Text);
                clasAc.Fecha = deFecha.DateTime;
                clasAc.FechaModificacion = DateTime.Today;
                clasAc.Porcentaje = Convert .ToInt32 (txtPorcentaje .Text );
                clasAc.Total = Convert.ToDouble(txtTotalPagar.Text);
                clasAc.IdEstado = cmbEstado.SelectedIndex;
                clasAc.IdEmpresa = 1;
                clasAc.Observacion = txtObservacion.Text;
               

                if (DatosAc .Guardar(clasAc ))
                {
                    ban1 = 1;
                }

              //-------------Datos de Nomina Detalle
                for (int i = 0; i < gvNomina .RowCount; i++)
                {

                    clasAd.NumLinea  = DatosAd .getIdSiguiente ();
                    clasOpc .NumOrdenPago =DatosOpc .getIdSiguiente ();
                    clasOpe .NumOrdenPago =clasOpc .NumOrdenPago ;
                    clasOpe .Linea =DatosOpe .getIdSiguiente ();
                    clasOpc .FechaEmision =deFecha .DateTime;
                    clasOpc .Estado =1;
                    clasAc.IdEmpresa = 1;
                    clasAd.IdEmpresa = 1;
                    clasAd.NumAnticipo = Convert.ToInt32(txtNumero.Text);
                    clasAd .IdPersona =Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona ));
                    clasOpc .IdPersona =Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona));
                    clasOpe .IdPersona =Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona));;
                    clasAd .SueldoNominal =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colSueldoNominal ));
                    clasOpe .SueldoTotal =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colValorLiquido  ));
                    clasAd .ValorLiquido =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colValorLiquido));
                    clasOpc .TotalPagar =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colValorLiquido));
                    clasOpe .PagoNeto =Convert .ToDecimal (gvNomina .GetRowCellValue (i,colValorLiquido));
                    clasOpc .TipoOrdenPago ='E';
                    clasOpc .IdUsuario =11;
                    clasOpc .IdEmpresa =1;
                    clasOpe .IdEmpresa =1;
                    clasOpe.IngresosAdicional=clasNd .TotalIngresos ;
                    clasOpe .DescuentoTotal =clasNd .TotalDescuento;
               

                    if (vars==1) {
                        if (DatosAd.Guardar(clasAd))
                        {
                            if (DatosOpc.Guardar(clasOpc))
                            {
                                if (DatosOpe.Guardar(clasOpe))
                                {
                                    ban = 1;
                                    ban2 = 1;
                                    ban3 = 1;
                                }
                              
                            }
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
            cmbPeriodo.SelectedIndex = 1;
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



         
         

    

         private void deFecha_EditValueChanged(object sender, EventArgs e)
         {

         }



         private void frmProcesoAnticiposEmpleado_Load(object sender, EventArgs e)
         {
             Cargar();


             int a = DatosAc.getIdSiguiente();
             txtNumero.Text = Convert.ToString(a);
             cmbPeriodo.SelectedIndex = 1;
             cmbPeriodo.Enabled = false;
             cmbEstado.SelectedIndex = 1;
             cmbEstado.Enabled = false;
             deFecha.DateTime = DateTime.Today;

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

         private void btnGenerarNomina_Click_1(object sender, EventArgs e)
         {
             tsbNuevo.Enabled = false;
             tsbModificar.Enabled = false;
             tsbGenerarNomina.Enabled = true;
             mes = cmbMes.SelectedIndex;
            /* diau = "15";
             dia = "1";
             año = Convert.ToString(DateTime.Today.Year);
             meses = Convert.ToString(mes);
             desde1 = año + "-" + meses + "-" + dia;
             hasta1 = año + "-" + meses + "-" + diau;
             desde = Convert.ToDateTime(desde1);
             try
             {
                 hasta = Convert.ToDateTime(hasta1);
             }
             catch (Exception)
             {

                 diau = "15";
                 hasta1 = diau + "-" + meses + "-" + año;
                 hasta = Convert.ToDateTime(hasta1);
             }*/

             gcNomina.DataSource = DatosAd.ConsultaAntDet();


             for (int i = 0; i < gvNomina.RowCount; i++)
             {

                 clasAd.NumAnticipo = Convert.ToInt32(txtNumero.Text);
                 clasAd.IdPersona = Convert.ToInt32(gvNomina.GetRowCellValue(i, colIdPersona));
                 suelnom = DatosAd.consultaSueldoN (clasAd .IdPersona );
                 porc = Convert.ToInt32(txtPorcentaje.Text);
                 valiq = clasAd.Liquido(suelnom, porc);
                 total = total + valiq;

                 gvNomina.SetRowCellValue(i, colIdPersona, clasAd.IdPersona);
                 gvNomina.SetRowCellValue(i, colSueldoNominal, suelnom);
                 gvNomina.SetRowCellValue(i, colValorLiquido, valiq);
                 gvNomina.SetRowCellValue(i, colIdEmpresa, clasAd.IdEmpresa);


             }
             txtTotalPagar.Text = Convert.ToString(total);

         }
         //********************* GENERAR NOMINA ************************

         private void tsbGenerarNomina_Click_1(object sender, EventArgs e)
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
                             if (ban2 == 1)
                             {
                                 MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                                 tsbGenerarNomina.Enabled = false;
                                 tsbNuevo.Enabled = true;
                                 Limpiar();
                             }

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
                         frmProcesoAnticiposEmpleado_event_Click(sender, e);
                         throw;
                     }

                 }


             }
         }

         //********************* NUEVO ************************
        
         private void tsbNuevo_Click_1(object sender, EventArgs e)
         {
             Limpiar();
             tsbGenerarNomina.Enabled = true;
             tsbModificar.Enabled = false;

             btnGenerarNomina.Enabled = true;
             txtNumero.Text = Convert.ToString(DatosNc.getIdSiguiente());

         }

         private void tsbModificar_Click_1(object sender, EventArgs e)
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
                 DatosAc.Modificar(clasAc);

                 frmProcesoAnticiposEmpleado_event_Click(sender, e);
                 MessageBox.Show(men.Exito_mod, men.Titulo, MessageBoxButtons.OK);
                 Limpiar();
             }
             catch (Exception)
             {

                 event_Click(sender, e);
             }

             // }
         }

         private void btnBuscar_Click_1(object sender, EventArgs e)
         {
             btnGenerarNomina.Enabled = false;
             tsbNuevo.Enabled = true;
             tsbGenerarNomina.Enabled = false;
             tsbModificar.Enabled = true;


             int numNomina;
             frmPConsultaNomina cNom = new frmPConsultaNomina();
             cNom.ShowDialog();
             clasNc = cNom.claseNc;
             txtNumero.Text = Convert.ToString(clasAc.NumAnticipo);
             numNomina = Convert.ToInt32(txtNumero.Text);
             txtPorcentaje.Text = Convert.ToString(clasAc.Porcentaje);
             txtObservacion.Text = Convert.ToString(clasNc.Observacion);
             deFecha.DateTime = Convert.ToDateTime(clasAc.Fecha);
             txtTotalPagar.Text = Convert.ToString(clasAc.Total);
             gcNomina.DataSource = DatosAd.ConsultaAnticipoDet(numNomina);
         }

         private void txtPorcentaje_EditValueChanged(object sender, EventArgs e)
         {
             btnGenerarNomina.Enabled = true;
         }

        

       
       

        }
    }

