using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
///
/// Nuevo cambio
///
using datos;
using clases.Contabilidad;
using datos.Contabilidad;
using clases.Seguridad;

namespace forms.Contabilidad
{
    public partial class frmMayorizacion : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            //btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            //btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            //btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion

        public frmMayorizacion()
        {
            InitializeComponent();
        }
        //Mayorizar addMayorizar = new Mayorizar();

        //private void Listar()
        //{
        //    try
        //    {
        //        this.dtlista.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
        //        this.dtlista.DataSource = this.addMayorizar.ListarM(this.txtBuscar.Text);
                
        //        this.dtlista.Columns[0].Visible = false;
        //        this.dtlista.Columns[1].HeaderText = "MARCAR";
        //        //this.dtlista.CellFill
        //        this.dtlista.Columns[2].HeaderText = "VALOR";
        //        this.dtlista.Columns[3].HeaderText = "NUMERO DE COMPROBANTE";
        //        this.dtlista.Columns[3].Visible = false;
        //        this.dtlista.Columns[4].HeaderText = "DEBITO";
        //        this.dtlista.Columns[4].Width = 188;
        //        this.dtlista.Columns[5].HeaderText = "CREDITO";
        //        this.dtlista.Columns[6].Visible = false;
                


        //    }
        //    catch (Exception)
        //    {


        //    }
        //}


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMayorizacion_Load(object sender, EventArgs e)
        {
            dateInicio.EditValue = DateTime.Now;
            dateFin.EditValue = DateTime.Now.AddDays(30);
            cargar();
            labelControl6.Text = clsVwUsuarioInformacion.nombreUsuario;
            Seguridad();
        }
        public void cargar(){
            
            clsDatoSaldo saldo = new clsDatoSaldo();
            gcMayorizacion.DataSource = saldo.select(Convert.ToDateTime(Convert.ToDateTime(dateInicio.EditValue).ToShortDateString()), Convert.ToDateTime(Convert.ToDateTime(dateFin.EditValue).ToShortDateString()));

        }

        private void dateFin_EditValueChanged(object sender, EventArgs e)
        {
            cargar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Focus();
                List<clsvwComprobanteMayorizar> lista = new List<clsvwComprobanteMayorizar>();
                List<clsvwComprobanteMayorizar> aux = new List<clsvwComprobanteMayorizar>();
                lista = (List<clsvwComprobanteMayorizar>)gcMayorizacion.DataSource;
                foreach (var item in lista)
                {
                    if (item.check==true){aux.Add(item);}
                }
                clsDatoSaldo saldo = new clsDatoSaldo();
                if (saldo.insert(aux)) { MessageBox.Show("Mayorizado con exito","TECA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
                cargar();
            }
            catch (Exception)
            {
            }
            

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}
