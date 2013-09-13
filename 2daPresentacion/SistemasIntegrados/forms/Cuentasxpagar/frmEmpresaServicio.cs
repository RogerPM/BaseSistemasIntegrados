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
            clsMensajeCxP ms = new clsMensajeCxP();
 
        }
        int solo = 1;
        int solo2 = 2;
        void frmEmpresaServicio_event_cllick(object sender, EventArgs e)
        {

        }

        public clsMensajeCxP men = new clsMensajeCxP();
        public clsCuentaBancaria2 bancaria = new clsCuentaBancaria2();
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
       
        private void frmEmpresaServicio_Load(object sender, EventArgs e)
        {
             deFechaActual.EditValue = DateTime.Today;
           
            datosEmpresaServicio Ser = new datosEmpresaServicio();
            
            gleTipoPersona.Properties.DataSource = Ser.consultaTipoPersona();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            getSeleccion();
           

            if (txtRazonSocial.Text == " ")
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
                frmEmpresaServicio_event_cllick(sender, e);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaEmpresaServicio Ser = new frmConsultaEmpresaServicio();
            Ser.ShowDialog();
            clas = Ser.Es;
            clsCuentaBancaria2 cli = new clsCuentaBancaria2();
           
            Set();
            


        }
        datosCuentaBancaria datosbancaria = new datosCuentaBancaria();
        public void Set()
        {
            txtNroIdentificacion.Text =Convert.ToString (clas._IdEmpresaServicio);
            deFechaActual.EditValue = clas._FechaRegistro;
            txtRazonSocial.Text = clas._RazonSocial;
            txtDirección.Text = clas._Direccion;
            txtMail.Text = clas._Email;
            txtWebSite.Text = clas._Website;
            if (clas._Estado == 1)
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            gleTipoPersona.EditValue = clas._TipoPersona;
            solo2 = clas._IdEmpresa;
            solo = clas._IdUsuario;
            
            gdcDetalleBancario.DataSource = datosbancaria.consultaPorEmpresa(txtNroIdentificacion.Text);
            


        }

        public void getSeleccion()
        {
           
            int bandera = 2;
            while (bandera != 1)
            {
                if (bandera!=0)
                {
                    bancaria.Serie = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colSerie));
                    bancaria.TipoCuenta = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colTipoCuenta));
                    bancaria.NroCta = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colNroCta));
                    bancaria.IdBanco = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdBanco));
                    bancaria.IdEmpresa = solo2;
                    bancaria.IdEmpresaServicio = Convert.ToString(txtNroIdentificacion.Text);
                    datosbancaria.Guardar(bancaria);
                    bandera = 0;
                   
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
            clas._IdEmpresaServicio = Convert.ToString(txtNroIdentificacion.Text);
            clas._FechaRegistro=Convert.ToDateTime(deFechaActual.EditValue);
            clas._RazonSocial=txtRazonSocial.Text ;
             clas._Direccion=txtDirección.Text;
             clas._Email=txtMail.Text;
            clas._Website=txtWebSite.Text;

            if (cbxEstado.Text == "Activo")
                clas._Estado = 1;
            else
            {
                clas._Estado = 0;
            }
            clas._TipoPersona = solo;// Convert.ToInt32(cbxTipoPersona.EditValue);
            clas._IdEmpresa = solo2;//solo;
            clas._IdUsuario=solo;

           
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
            gleTipoPersona.EditValue = "";

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

        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }

       

        }

    }

