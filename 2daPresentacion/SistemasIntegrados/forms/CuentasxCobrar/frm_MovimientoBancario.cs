using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.CuentasxCobrar;
using clases.Seguridad;
using datos.CuentasxCobrar;



namespace forms.CuentasxCobrar
{
    public partial class frm_MovimientoBancario : Form
    {
        
        public frm_MovimientoBancario()
        {
            InitializeComponent();
            event_click += new delegate_Click(frm_MovimientoBancario_event_click);
        }
        void frm_MovimientoBancario_event_click(object sender, EventArgs e)
        {

        }
        //delegate y event
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;

        public clsMovimientobancario clas = new clsMovimientobancario();
        clsDatosMovimientoBancario dato = new clsDatosMovimientoBancario();
        

        
        public clsBanco clas2 = new clsBanco();
        clsDatosBanco dbanco = new clsDatosBanco();

        private string accion { set; get; }
        int solo = 1;
        public void set()
        {
            txtmovimiento.Text = Convert.ToString(clas.idMovimientoBancario);
            txtdocumento.Text = Convert.ToString(clas.NumeroDocumento);
            txtCodigo.Text = Convert.ToString(clas.idBanco);
            txtObservacion.Text = clas.Observacion;
            dtpFecha.Text = Convert.ToString(clas.Fecha);
            dtpFechaModificacion.Text = Convert.ToString(clas.FechaModificacion);
            txtValor.Text = Convert.ToString(clas.Valor);

            gleEstado.EditValue = clas.idEstado;
            solo = clas.idEmpresa;
            solo = clas.idUsuario;
            solo = clas.idTransaccion;


        }

        public void get()
        {
            clas.idMovimientoBancario = Convert.ToInt32(txtmovimiento.Text);
            clas.NumeroDocumento = Convert.ToInt32(txtdocumento.Text);
            clas.idBanco = Convert.ToInt32(txtCodigo.Text);
            clas.Observacion = txtObservacion.Text;
            clas.Fecha = Convert.ToDateTime(dtpFecha.Text);
            clas.FechaModificacion = Convert.ToDateTime(dtpFechaModificacion.Text);
            clas.Valor = Convert.ToInt32(txtValor.Text);

            clas.idEstado = Convert.ToInt32(gleEstado.EditValue);
            clas.idEmpresa = solo;
            clas.idUsuario = solo;
            clas.idTransaccion = solo;

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //
            Frm_ConsultaBanco con = new Frm_ConsultaBanco();
            //frmPrueba con = new frmPrueba();
            con.ShowDialog();
            clas2 = con.banc;
            
            txtCodigo.Text = Convert.ToString(clas2.idBanco);
            txtNombre.Text = Convert.ToString(clas2.Nombre);
        }

        public void limpiar()
        {
            txtmovimiento.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtObservacion.Text = "";
            txtdocumento.Text = "";
            txtValor.Text = "";
            gleEstado.EditValue = '1';

        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            get();
            accion = "G";//variable de control 
            if (accion == "G")
            {
                if (dato.guardar(clas))
                {
                    MessageBox.Show("guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
                event_click(sender, e);
                frm_MovimientoBancario_event_click(sender, e);
            }

            /*private void tsbGuardar_Click(object sender, EventArgs e)
            {
                get();
                accion = "G";//variable de control 
                if (accion == "G")
                {
                    if (dato.guardar(clas))
                    {
                        MessageBox.Show("guardado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al Guardar");
                    }
                    event_click(sender, e);
                    frm_MovimientoBancario_event_click(sender, e);

                }
            }*/




        }

        private void frm_MovimientoBancario_Load(object sender, EventArgs e)
        {
            clsDatosMovimientoBancario dato2 = new clsDatosMovimientoBancario();
            gleEstado.Properties.DataSource = dato2.consultaEstado();

            if (accion == "a")
            {
                set();
            }
            
        }

        private void gleEstado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {

        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            get();
            if (dato.anular(clas))
            {
                MessageBox.Show("Movimiento Anulado ");
                limpiar();
            }
            else
            {
                MessageBox.Show("anulado sin exito");
            }


            event_click(sender, e);
            frm_MovimientoBancario_event_click(sender, e);
        }
    }
}