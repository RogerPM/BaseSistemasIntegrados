using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Contabilidad;
using datos.Contabilidad;

namespace forms.Contabilidad
{
    public partial class frmMantenimientoTipoTransaccion : Form
    {
        public frmMantenimientoTipoTransaccion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public clsTipoTransaccion clas = new clsTipoTransaccion();
        clsDatoTipoTransaccion dato = new clsDatoTipoTransaccion();
        //aqui seteamos que accion estamos haciendo guardar modificar etc
        public string accion { get; set; }
        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            //
            clsDatoTipoTransaccion dat = new clsDatoTipoTransaccion();
            combo.Properties.DataSource = dat.ConsultaModulo();
            set();
            if (accion == "M")//M de modificar
            {
                set();
            }
            if (accion == "E")//cargar antes de eliminar
            {
                set();
            }
        }

        public void set()
        {
            textEdit1.Text = clas.IdTransaccion.ToString();
            textEdit3.Text = clas.TipoDocumento;
            textEdit4.Text = clas.descripcion;
            combo.EditValue = clas.modulo;

        }
        public void get()
        {
            clas.IdTransaccion = Convert.ToInt32(textEdit1.Text);
            clas.TipoDocumento = textEdit3.Text;
            clas.descripcion = textEdit4.Text;
            clas.modulo = Convert.ToInt32(combo.EditValue);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            get();
            if (accion == "G")
            {

                dato.guardar(clas);
            }
            if (accion == "M")
            {
                dato.modificar(clas);

            }
            if (accion == "E")
            {
                dato.eliminar(clas);

            }
        }

        private void frmMantenimientoTipoTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void combo_EditValueChanged(object sender, EventArgs e)
        {

        }



    }
}
