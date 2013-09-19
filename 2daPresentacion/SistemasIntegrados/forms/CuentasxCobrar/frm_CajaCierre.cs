using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_CajaCierre : Form
    {
        clsCierreCaja objCierreCaja = new clsCierreCaja();
        clsAperturaCaja objAperturaCaja = new clsAperturaCaja();
        int idEmpresa = 1;
        int idUsuario = 1;
        int idEstado = 1;

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            //btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnGenerarCierre.Enabled = frmPrincipal.Escritura;
        }
        #endregion


        public frm_CajaCierre()
        {
            InitializeComponent();
        }

        private void frm_CajaCierre_Load(object sender, EventArgs e)
        {
           clsDatosCierreCaja objDatosCierreCaja = new clsDatosCierreCaja();
           clsDatosAperturaCaja objDatosAperturaCaja = new clsDatosAperturaCaja();
           if (objDatosCierreCaja.consultaCerrada(DateTime.Today,idUsuario))
               {
                MessageBox.Show("LA CAJA YA HA SIDO APERTURADA POR ESTE USUARIO EL DIA DE HOY");
                this.Close();
            }
            else
            {
           DataGridView dgvCierre = new DataGridView();
           dgvCierre.DataSource = objDatosCierreCaja.CerrarCaja();
            string Campo;
            decimal Total;
            decimal TotalRecaudado;
            for (int i = 0; i < dgvCierre.Rows.Count; i++)
           {
               Campo = Convert.ToString(dgvCierre.Rows[i].Cells[0].Value);
               Total = Convert.ToDecimal(dgvCierre.Rows[i].Cells[1].Value);
               if (Campo == "Efectivo") { objCierreCaja.TotalEfectivo = Total; txtEfectivo.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo == "Cheque") { objCierreCaja.TotalBoucher = Total; txtBoucher.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo == "Tarjeta Credito") { objCierreCaja.TotalCheque = Total; txtCheque.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo.Contains("Transferencia")) { objCierreCaja.TotalTransferencia = Total; txtTransferencia.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
            }
            objDatosAperturaCaja.consultaAperturaCajaEspecificaFecha(objAperturaCaja, DateTime.Today);
            objCierreCaja.MontoApertura = objAperturaCaja.Monto;
            objCierreCaja.idEmpresa = idEmpresa;
            objCierreCaja.idUsuario = idUsuario;
            objCierreCaja.idEstado = idEstado;
            objCierreCaja.idCierreCaja = objDatosCierreCaja.getIdSiguiente();
            txtCodigo.Text = Convert.ToString(objCierreCaja.idCierreCaja);
            objCierreCaja.FechaModificacion = dtpFechaCierre.Value;
            objCierreCaja.FechaCierre = dtpFechaCierre.Value;
            TotalRecaudado = objCierreCaja.TotalBoucher + objCierreCaja.TotalCheque + objCierreCaja.TotalDeposito + objCierreCaja.TotalEfectivo + objCierreCaja.MontoApertura;
            txtMontoApertura.Text = Convert.ToString(objCierreCaja.MontoApertura);
            txtTotalRecaudado.Text = Convert.ToString(TotalRecaudado);
        }
           Seguridad();
        }

        private void dgvCierre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarCierre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsMensaje objMensaje = new clsMensaje();
            clsDatosCierreCaja objDatosCierreCaja = new clsDatosCierreCaja();
            if (objDatosCierreCaja.guardar(objCierreCaja))
            {
                MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                this.Close();
            }
        }

    }
}
