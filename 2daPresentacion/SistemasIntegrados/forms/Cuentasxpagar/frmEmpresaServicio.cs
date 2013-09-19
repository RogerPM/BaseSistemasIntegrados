using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using clases.Cuentasxpagar;
using datos.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmEmpresaServicio : Form
    {
        //============================================================================================================================================================
        //=============================================================DECLARACION DE ATRIBUTOS=======================================================================
        //============================================================================================================================================================
        int error = 0; // parametro para buscar mensaje
        string msj = "", elemento = "Éxito"; //variables de datos a presentar en mensajes
        clsEmpresaServicioDAT1 EmpresaServicio = new clsEmpresaServicioDAT1();
        clsEmpresaServicio EmpresaServicioCls = new clsEmpresaServicio();

        public frmEmpresaServicio()
        {
            InitializeComponent();
        }

        
        private void frmEmpresaServicio_Load(object sender, EventArgs e)
        {
            dtpFechaRegistro.EditValue = DateTime.Today;
            cbxTipoPersona.Properties.DataSource = EmpresaServicio.ConsultaTipoPersona();
            cbxTipoTelefono.DataSource = EmpresaServicio.ConsultaTipoTelefono();
            cbxBanco.DataSource = EmpresaServicio.ConsultaBanco();
            cbxEstado.SelectedIndex = 1;
        }

        //====================================================================================================================================================
        //=========================================================DECLARACION DE MÉTODOS Y FUNCIONES=========================================================
        //====================================================================================================================================================

        public void limpiarGrid()
        {
            try
            {
                int x = gdvDetalleTelefonico.RowCount;
                for (int i = 0; i <= x; i++)
                {
                    gdvDetalleTelefonico.DeleteRow(0);
                }

                int y = gdvDetalleCtasBancarias.RowCount;
                for (int i = 0; i <= y; i++)
                {
                    gdvDetalleTelefonico.DeleteRow(0);
                }
            }
            catch (Exception)
            {
            }
        }



        private void Limpiar()
        {
            dtpFechaRegistro.EditValue = DateTime.Today;
            cbxTipoPersona = null;
            txtRuc = null;
            txtRazonSocial = null;
            cbxEstado = null;
            txtDireccion = null;
            txtEmail = null;
            txtWebSite = null;
            limpiarGrid();
        }


        
        int validaciones(DateTime fechaRegistro, int tipoPersona, long ruc, string razonSocial, int estado, string direccion, string email, string webSite)
        {
            if (fechaRegistro == null)
            {
                error = 2;
                elemento = "Fecha de registro";
            }
            else if (tipoPersona < 0 || tipoPersona >= 2)
            {
                error = 2;
                elemento = "Tipo de persona";
            }
            else if (ruc <= 0 || ruc > 9999999999999)
            {
                error = 2;
                elemento = "RUC";
            }
            else if (razonSocial == null)
            {
                error = 2;
                elemento = "Razón social";
            }
            else if (estado < 0 || estado >= 2)
            {
                error = 2;
                elemento = "Estado";
            }
            else if (direccion == null)
            {
                error = 2;
                elemento = "Dirección";
            }

            return error;
        }



        public void get()
        {
            if (error == 0)
            {
                EmpresaServicioCls._IdEmpresa = 1;
                EmpresaServicioCls._IdUsuario = 11;
                EmpresaServicioCls._FechaRegistro = dtpFechaRegistro.DateTime;
                EmpresaServicioCls._TipoPersona = Convert.ToInt32(cbxTipoPersona.EditValue);//gdvTipoPersona.GetFocusedDataSourceRowIndex();
                EmpresaServicioCls._IdEmpresaServicio = txtRuc.Text;
                EmpresaServicioCls._RazonSocial = txtRazonSocial.Text;
                EmpresaServicioCls._Estado = cbxEstado.SelectedIndex;
                EmpresaServicioCls._Direccion = txtDireccion.Text;
                EmpresaServicioCls._Email = txtEmail.Text;
                EmpresaServicioCls._Website = txtWebSite.Text;
                List<clsDetalleTelefonoCXP> listdet = new List<clsDetalleTelefonoCXP>();
                for (int i = 0; i < gdvDetalleTelefonico.RowCount; i++)
                {
                    clsDetalleTelefonoCXP det = new clsDetalleTelefonoCXP();
                    det._IdTelefono = 1;
                    det._TipoTelefono=Convert.ToInt32(gdvDetalleTelefonico.GetRowCellValue(i, colIdTipoTelefono));
                    det._numTelefono = Convert.ToInt32(gdvDetalleTelefonico.GetRowCellValue(i, col_numTelefono));
                    listdet.Add(det);
                    EmpresaServicioCls._DetalleTelefono = listdet;
                }

                List<clsCtaBancaria2> listdettel = new List<clsCtaBancaria2>();
                for (int i = 0; i < gdvDetalleCtasBancarias.RowCount; i++)
                {
                    clsCtaBancaria2 detcta = new clsCtaBancaria2();
                    detcta._IdBanco = Convert.ToInt32(gdvDetalleCtasBancarias.GetRowCellValue(i, col_IdBanco));
                    detcta._TipoCuenta = Convert.ToString(gdvDetalleCtasBancarias.GetRowCellValue(i, col_tipoCuenta));
                    detcta._NroCuenta = Convert.ToString(gdvDetalleCtasBancarias.GetRowCellValue(i, col_numeroCuenta));
                    listdettel.Add(detcta);
                    EmpresaServicioCls._CuentaBancaria = listdettel;
                }
            }
            else
            {
                error = 1;
                msj = "Error";
                Mensaje(error, msj, elemento);
            }
        }


        void Mensaje(int error, string msj, string elemento)
        {
            clsMsgCuentasPorPagar Mensaje = new clsMsgCuentasPorPagar();
            MessageBox.Show(Mensaje.mensajes(ref error, msj), elemento, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //====================================================================================================================================================
        //==============================================================PROGRAMACION DE CONTROLES=============================================================
        //====================================================================================================================================================

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            error = validaciones(dtpFechaRegistro.DateTime, gdvTipoPersona.GetFocusedDataSourceRowIndex(), Convert.ToInt64(txtRuc.Text), txtRazonSocial.Text, cbxEstado.SelectedIndex, txtDireccion.Text, txtEmail.Text, txtWebSite.Text);
            get();
            if (EmpresaServicio.Guardar(EmpresaServicioCls))
            {
                Mensaje(error, msj, elemento);
                Limpiar();
            }
            else
            {
                error = 1;
                msj = "Error";
                Mensaje(error, msj, elemento);
            }
        }


        
        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }



        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }



        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            clsEmpresaServicio empserv = new clsEmpresaServicio();
            frmConsultas Consulta = new frmConsultas();
            Consulta.ShowDialog();
        }


    }


}
