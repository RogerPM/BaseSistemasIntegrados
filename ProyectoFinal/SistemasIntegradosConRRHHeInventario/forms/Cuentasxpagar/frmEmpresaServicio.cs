using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Cuentasxpagar;
using datos.Cuentasxpagar;
using clases.Seguridad;

namespace forms.Cuentasxpagar
{
    public partial class frmEmpresaServicio : Form
    {
        public frmEmpresaServicio()
        {
            InitializeComponent();
            event_click += new delegate_click(frmEmpresaServicio_event_cllick);
            clsMensaje ms = new clsMensaje();
 
        }
        int solo = 1;
        int solo2 = 2;
        void frmEmpresaServicio_event_cllick(object sender, EventArgs e)
        {

        }

        public clsMensaje men = new clsMensaje();
        public clsCuentaBancaria bancaria = new clsCuentaBancaria();
        public clsEmpresaServicio clas = new clsEmpresaServicio ();
        datosEmpresaServicio dato = new datosEmpresaServicio();
        private string accion { get; set; }
        
       
        private void tsbConsultar_Click(object sender, EventArgs e)
        {
       
          
               
                    
        }
        //

      
        
        private clsEmpresaServicio GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)

        {
        try
        {
            return (clsEmpresaServicio )view.GetRow(view.FocusedRowHandle);
        }
        catch (Exception ex)
        {

        return null;
        }
        }
        //public clsEmpresaServicio class = new clsEmpresaServicio();
        private void frmEmpresaServicio_Load(object sender, EventArgs e)
        {
             deFechaActual.EditValue = DateTime.Today;
            
            datosEmpresaServicio Ser = new datosEmpresaServicio();
          
            
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == " ")
            {
                MessageBox.Show(men.Error_Des, men.Titulo, MessageBoxButtons.OK);
            }
            else
            {   
                get();
                getSeleccion();
               
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
                frmEmpresaServicio_event_cllick(sender, e);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaEmpresaServicio Ser = new frmConsultaEmpresaServicio();
            Ser.ShowDialog();
            clas = Ser.Es;
            clsCuentaBancaria cli = new clsCuentaBancaria();
           
            Set();
            


        }
        datosCuentaBancaria datosbancaria = new datosCuentaBancaria();
        public void Set()
        {
            txtNroIdentificacion.Text =Convert.ToString (clas.IdEmpresaServicio);
            deFechaActual.EditValue = clas.fechaRegistro;
            txtRazonSocial.Text = clas.RazonSocial;
            txtDirección.Text = clas.Direccion;
            txtMail.Text = clas.email;
            txtWebSite.Text = clas.webpage;
            if (clas.Estado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            cbxTipoPersona.EditValue = clas.IdTipoPersona;
            solo2 = clas.IdEmpresa;
            solo = clas.IdUsuario;
            
            gdcDetalleBancario.DataSource = datosbancaria.consultaPorEmpresa(txtNroIdentificacion.Text);
            


        }

        public void getSeleccion()
        {
          
            int bandera = 2;
            while (bandera != 1)
            {
                if (Convert.ToInt32(gridView1.GetFocusedRowCellValue(colSerie)) != 0)
                {
                    bancaria.Serie = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colSerie));
                    bancaria.TipoCuenta = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoCuenta));
                    bancaria.NroCta = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNroCta));
                    bancaria.IdBanco = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdBanco));
                    bancaria.IdEmpresa = solo2;
                    bancaria.IdEmpresaServicio = Convert.ToString(txtNroIdentificacion.Text);

                    if (datosbancaria.Guardar(bancaria))
                    {

                        MessageBox.Show(men.Guardar_ok, men.Titulo, MessageBoxButtons.OK);
                        limpiar();
                     }
                    else
                    {

                        MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                    }
                }
                else
                {
                    bandera = 1;
                    MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);
                }
              
            }

        }

        public void get()
        {
            clas.IdEmpresaServicio = Convert.ToString(txtNroIdentificacion.Text);
            clas.fechaRegistro=Convert.ToDateTime(deFechaActual.EditValue);
            clas.RazonSocial=txtRazonSocial.Text ;
             clas.Direccion=txtDirección.Text;
             clas.email=txtMail.Text;
            clas.webpage=txtWebSite.Text;
            if (cbxEstado.Text == "Activo")
                clas.Estado = 1;
            else
                clas.Estado = 0;
          

             clas.IdTipoPersona = solo;// Convert.ToInt32(cbxTipoPersona.EditValue);
             clas.IdEmpresa = solo2;//solo;
            clas.IdUsuario=solo;

           
        }

        public delegate void delegate_click(object sender, EventArgs e);
        public event delegate_click event_click;

        public void limpiar()
        {
            txtNroIdentificacion.Text = "";
            deFechaActual.EditValue = "";
            txtRazonSocial.Text = "";
            txtDirección.Text = "";
            txtMail.Text = "";
            txtWebSite.Text = "";
            cbxEstado.SelectedIndex = 0;
            cbxTipoPersona.EditValue = "";

        }

      
        private void gdcDetalleTelefonico_Click(object sender, EventArgs e)
        {
            MessageBox.Show(men.Guardar_error, men.Titulo, MessageBoxButtons.OK);

          
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        }

    }

