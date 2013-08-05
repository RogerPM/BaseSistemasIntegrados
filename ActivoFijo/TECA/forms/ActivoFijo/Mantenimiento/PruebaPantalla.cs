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


namespace forms.ActivoFijo.Mantenimiento
{
    public partial class PruebaPantalla : Form
    {
        clsClasePrueba clase = new clsClasePrueba();
        clsClaseDatosPrueba  dato = new clsClaseDatosPrueba();
        private char  accion { get; set; }
        
        public PruebaPantalla()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            get();
            accion='G';
            if(accion=='G')
            {
               // dato.guardar(clase);
                if (dato.guardar(clase))
                {
                    MessageBox.Show("guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            } 
        }

        public void get()
        {
            clase.codigo =Convert.ToInt32 (txtCodigo.Text);
            clase.nombre = txtNombre.Text;
            clase.decripcion = txtDescripcion.Text;
           
        }




    }
}
