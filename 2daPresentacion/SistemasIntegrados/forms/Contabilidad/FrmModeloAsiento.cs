using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using clases.Contabilidad;

namespace forms.Contabilidad
{
    public partial class FrmModeloAsiento : Form
    {
        public FrmModeloAsiento()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Añadimos una variable para indicar al formulario si lo 
        /// que se quiere es editar o eliminar
        /// </summary>

        public bool nuevo;

        EModeloAsiento ma = new EModeloAsiento();
        NModeloAsiento addModeloAsiento = new NModeloAsiento();

        /// <summary>
        /// instanciamos nuestra clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmModeloAsiento_Load(object sender, EventArgs e)
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ma.IdEmpresa = 1;
                this.ma.IdTransaccion = int.Parse(this.txtTransaccion.Text);
                this.ma.Modulo = int.Parse(this.txtModulo.Text);
                this.ma.Secuencia = int.Parse(this.txtSecuencia.Text);
                this.ma.Descripcion = this.txtDescripcion.Text;
                this.ma.Debe = this.txtDebe.Text;
                this.ma.Haber = this.txthaber.Text;
                this.ma.IdUsuario1 = 1;
                this.ma.FechaModificacion1 = DateTime.Now;// Convert.ToDateTime("2013-07-29");  ///DateTime;
                //DateTime.Now
                if (this.nuevo)
                {
                    NModeloAsiento dat = new NModeloAsiento();
                    //dat.Insertar(ma);                    
                    dat.Insertar(this.ma.IdEmpresa, this.ma.IdTransaccion, this.ma.Modulo, this.ma.Descripcion, this.ma.Debe, this.ma.Haber, this.ma.IdUsuario1, this.ma.FechaModificacion1);
                    ///this.txtSecuencia.Text = this.addModeloAsiento.Insertar(this.e).ToString();
                    ///this.addModeloAsiento.Insertar(this.e).ToString();
                    MessageBox.Show("Registro insertado correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /// pongo en falso que al precionar grabar otra vez no se 
                    this.nuevo = false;
                }
                else
                {
                    ///Editar
                    //this.addModeloAsiento.Editar(this.e);
                    this.addModeloAsiento.Editar(this.ma.IdEmpresa,  this.ma.Modulo, this.ma.IdTransaccion, this.ma.Secuencia, this.ma.Descripcion, this.ma.Debe, this.ma.Haber, this.ma.IdUsuario1, this.ma.FechaModificacion1);
                                                 
                    
                    MessageBox.Show("Registro Actualizado correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                ///
                ///Vamos a mostrar todos los errores
                MessageBox.Show("Error en el formulario Modelo de Asiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

}
}