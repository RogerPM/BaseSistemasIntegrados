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
        public char accion { get; set; }
        

        private void mntActivoFIjo_Load(object sender, EventArgs e)
        {
                //Llenamos el combo grupo de inventario en la pantalla 
                clsClaseDatosGrupo dat = new clsClaseDatosGrupo();
                ComboGrupo.Properties.DataSource = dat.consultaGrupo();
        }


        //Esta es una funcion que se hizo para poder seter todos los campos 
        public void set(clsSubgrupoActivoFijo clas)
        {

            txtCodigoActivo.Text =Convert.ToString(clas.Codigo);
            ComboGrupo.EditValue = clas.Grupo; 
            txtSubgrupo.Text = clas.descripcion;
            dtFecha.EditValue  = clas.Fecha;
            cbxEstado.SelectedIndex = (clas.IdEstado)-1;
            cbxEmpresa.SelectedIndex = (clas.Empresa)-1;
        }

        public void get(clsSubgrupoActivoFijo clas)
        {
            clas.Codigo  =Convert.ToInt32(txtCodigoActivo.Text);
            clas.Grupo = 0 ;
            //clas.Grupo   =Convert.ToInt32(ComboGrupo.EditValue);
            clas.descripcion=txtSubgrupo.Text ;
            clas.Fecha   =Convert.ToDateTime(dtFecha.EditValue);
            clas.IdEstado =cbxEstado.SelectedIndex;
            clas.Empresa  =cbxEmpresa.SelectedIndex;
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
            set(clase);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = 'E';
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //accion = 'M';
            //set(clase);
            //VtnConsultaSubgrupo frm = new VtnConsultaSubgrupo();
            //frm.ShowDialog();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            limpiarControles();
        }

        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCodigoActivo.Enabled = true;
            cbxGrupo.Enabled = true;
            txtSubgrupo.Enabled = true;
            dtFecha.Enabled = true;
            cbxEmpresa.Enabled = true;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = " ";
            cbxGrupo.SelectedIndex = 0;
            txtSubgrupo.Text = " ";
            dtFecha.EditValue = " ";
            cbxEstado.SelectedIndex = 0;
            cbxEmpresa.SelectedIndex = 0;

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            accion = 'G';
            clsSubgrupoActivoFijo cls= new clsSubgrupoActivoFijo ();
            clsClaseDatosSubgrupoActivoFijo datosub = new clsClaseDatosSubgrupoActivoFijo();
            //clsClaseDatosGrupo datogrup = new clsClaseDatosGrupo();
            get(cls);
            datosub.guardar(cls);
            
            //cls.Codigo      =Convert.ToInt32(txtCodigoActivo.Text);
            //cls.descripcion = txtSubgrupo.Text;
            //cls.Fecha    = Convert.ToDateTime(dtFecha);
            //cls.IdEstado = cbxEstado.SelectedIndex;
            //cls.Empresa  = cbxEmpresa.SelectedIndex;
            //clsClaseDatosSubgrupoActivoFijo clas = new clsClaseDatosSubgrupoActivoFijo();
            //clas.guardar(cls);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            PruebaPantalla frm = new PruebaPantalla();
            frm.ShowDialog();
        }

       


    }
}
