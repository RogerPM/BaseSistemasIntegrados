using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using datos.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class prcsRevalorizacion : Form
    {
        public prcsRevalorizacion()
        {
            InitializeComponent();
        }

        public char accion { get; set; }
        clsActivoFijo oActivoFijo = new clsActivoFijo();
        //public clsActivoFijo clase = new clsActivoFijo();
        public clsRevalorizacion revalo = new clsRevalorizacion();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();

        clsClaseDatosSubgrupoActivoFijo datoActivoFijo = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosRevalorizacion datoRevalor = new clsClaseDatosRevalorizacion();


        private void prcsRevalorizacion_Load(object sender, EventArgs e)
        {

        }

        #region"Operaciones de Controles"
        public void set(clsRevalorizacion oRevalorizacion)
        {
            txtUsuario.Text = oActivoFijo._Usuario;
            dtFecha.EditValue = oRevalorizacion.Fecha;
            TxtEmpresa.Text = oActivoFijo._Empresa;
            txtValorAdquisicion.Text = Convert.ToString(oRevalorizacion.valorActual);
            txtValorRevalorizado.Text = Convert.ToString(oRevalorizacion.valorRevalorizado);
            txtValorResidual.Text = Convert.ToString(oRevalorizacion.valorResidual);

        }

        public void setActivofijo(clsActivoFijo ActivoFij)
        {
            txtCodigoActivo.Text = Convert.ToString(ActivoFij.Codigo);
            txtUsuario.Text = ActivoFij._Usuario;
            TxtEmpresa.Text = ActivoFij._Empresa;
            txtValorAdquisicion.Text = Convert.ToString(ActivoFij.valor_actualserie);

        }

        public bool getValor()
        {
            revalo.Codigo = 0;//PK
            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;
            }
            else
            {


                if ((txtCodigoActivo.Text == "" || txtUsuario.Text == "") || (dtFecha.EditValue == null) ||
                    (TxtEmpresa.Text == "") || (txtValorAdquisicion.Text == "") || (txtValorResidual.Text == "") || (txtValorResidual.Text == ""))
                {
                    return false;
                }
                revalo._idActivoFijo = Convert.ToInt32(txtCodigoActivo.Text);
                revalo.Fecha = Convert.ToDateTime(dtFecha.EditValue);
                revalo.valorRevalorizado = Convert.ToDouble(txtValorRevalorizado.Text);
                oActivoFijo.valor_actualserie = Convert.ToDouble(txtValorAdquisicion.Text);//Se llena el campo del acivo fijo 
                revalo.valorActual = oActivoFijo.valor_actualserie;
                oActivoFijo.valor_residual = Convert.ToDouble(txtValorResidual.Text);//Se llena el campo del activo fijo
                revalo.valorResidual = oActivoFijo.valor_residual;

                return true;
            }
        }

        private void HabilitarControles()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = true;
            btnConsultar.Enabled = true;
            btnbuscar.Enabled = true;
            btnProcesar.Enabled = true;
            txtCodigoActivo.Enabled = false;
            dtFecha.Enabled = true;
            //txtValorAdquisicion.Enabled= true;
            //txtValorRevalorizado.Enabled=true;
        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnConsultar.Enabled = false;
            btnbuscar.Enabled = false;
            txtCodigoActivo.Enabled = false;
            dtFecha.Enabled = false;
            txtValorAdquisicion.Enabled = false;
            txtValorRevalorizado.Enabled = false;
        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            dtFecha.EditValue = "";
            txtValorAdquisicion.Text = "";
            //   txtValorResidual.Text  = "";
            //   txtValorRevalorizado.Text  = " ";
        }

        #endregion


        #region"Operaciones Basicas"

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            limpiarControles();
            btnAnular.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (getValor())
            {
                if (revalo.Codigo == 0)
                {
                    if (datoRevalor.guardar(revalo))
                    {
                        MessageBox.Show(msj.Guardar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGuardar.Enabled = true;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(msj.Anulado_error);

            accion = 'E';
            try
            {
                if (accion == 'E')
                {
                    if (datoRevalor.eliminar(revalo))
                    {
                        MessageBox.Show(msj.Anulado_ok);
                        limpiarControles();
                        BloquearControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Anulado_error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(msj.Cancelar, msj.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            accion = 'B';

            VtnConsultaActivoFijo frm = new VtnConsultaActivoFijo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                //btnGuardar.Enabled = false;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                // btnAnular.Enabled = true;
                btnbuscar.Enabled = true;
                oActivoFijo = frm.cls;
                setActivofijo(oActivoFijo);
            }
            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnAnular.Enabled = false;//
                btnConsultar.Enabled = false;//
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            accion = 'C';

            VtnConsultaRevalor frm = new VtnConsultaRevalor();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = false;
                btnbuscar.Enabled = true;
                btnAnular.Enabled = true;
                revalo = frm.cls;
                set(revalo);
            }
            else
            {
                //Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnAnular.Enabled = false;//
                btnConsultar.Enabled = true;//
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        #endregion






    }
}
