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
using datos.Inventario;

namespace forms.ActivoFijo.Mantenimiento
{
    public partial class mntActivoFIjo : Form
    {
        public mntActivoFIjo()
        {
            InitializeComponent();
        }
     

        //Declare una instancia de la clase de Subgrupos para poder llenar los datos
        public clsSubgrupoActivoFijo clase = new clsSubgrupoActivoFijo();
        clsClaseDatosSubgrupoActivoFijo  dato = new clsClaseDatosSubgrupoActivoFijo();
        public char accion { get; set; }
        

        private void mntActivoFIjo_Load(object sender, EventArgs e)
        {
                //Llenamos el combo grupo de inventario en la pantalla 
                clsClaseDatosGrupo dat = new clsClaseDatosGrupo();
                ComboGrupo.Properties.DataSource = dat.consultaGrupo();
        }



        public void set()
        {

            txtCodigoActivo.Text =Convert.ToString(clase.Codigo);
            ComboGrupo.EditValue = clase.Grupo; 
            txtSubgrupo.Text = clase.descripcion;
            dtFecha.EditValue  = clase.Fecha;
            cbxEstado.SelectedIndex = (clase.IdEstado)-1;
            txtEmpresa.Text =Convert.ToString(clase.Empresa);
        }


        public void get()
        {
            clase.Codigo  =Convert.ToInt32 (txtCodigoActivo.Text);
            //clase.Grupo = 1 ;
            //clase.Grupo   =(int)(ComboGrupo.EditValue);
            clase.Grupo = 1;
            clase.descripcion=txtSubgrupo.Text ;
            clase.Fecha   =Convert.ToDateTime(dtFecha.EditValue);
            clase.IdEstado =1;
            clase.Empresa  =Convert.ToInt32(txtEmpresa.Text);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            accion='C';
            VtnConsultaSubgrupo  frm = new VtnConsultaSubgrupo ();
            frm.ShowDialog();
            clase = frm.cls;
            set();
        }


        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnbuscar.Enabled = true;
            txtCodigoActivo.Enabled = true;
            ComboGrupo.Enabled = true;
            txtSubgrupo.Enabled = true;
            dtFecha.Enabled = true;
            txtEmpresa.Enabled = true;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = " ";
            ComboGrupo.EditValue = 0;
            txtSubgrupo.Text = " ";
            dtFecha.EditValue = " ";
            cbxEstado.Text  = "ACTIVO";
            txtEmpresa.Text = " ";

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            limpiarControles();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            get();
            accion = 'G';
            if (accion == 'G')
            {
                if (dato.guardar(clase))
                {
                    MessageBox.Show("guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = 'E';
            if (accion == 'E')
            {
                if (dato.eliminar(clase))
                {
                    MessageBox.Show("Eliminado Exitoso");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = 'M';
            if (accion == 'M')
            {
                if (dato.modificar(clase))
                {
                    MessageBox.Show("Registro Modificado");
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al Modificar");
                }

            }
          
        }


        private void btnPrueba_Click(object sender, EventArgs e)
        {
            PruebaPantalla frm = new PruebaPantalla();
            frm.ShowDialog();
        }

       


    }
}
