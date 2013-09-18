using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
///
/// Nuevo cambio
///
using datos;
using clases.Contabilidad;

namespace forms.Contabilidad
{
    public partial class frmPeriodo : Form
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
            //btnGuardar.Visible = frmPrincipal.Escritura;
            btnAperturar .Visible = frmPrincipal.Escritura;
            btnCerrar.Visible = frmPrincipal.Escritura;
            //eliminacion
            //btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion

        public frmPeriodo()
        {
            InitializeComponent();
        }
        NPeriodo addPeriodoContable = new NPeriodo();
        //NModeloAsiento addModeloAsiento = new NModeloAsiento();
        //NModeloAsiento addModeloAsientoG = new NModeloAsiento();
        public void llenacombobox()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = @"Data Source=(local);Initial Catalog=TECA;Integrated Security=True";
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT IdPeriodoContable FROM Contabilidad.PeriodoContable", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "Contabilidad.PeriodoContable");
            cmperiodo.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cmperiodo.ValueMember = "IdPeriodoContable";
        }

        private void ListarP()
        {
            try
            {
                this.dtlista.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                //this.dtlista.DataSource = this.addPeriodoContable.ListarP(Convert.ToInt32(this.textBuscar.Text));
                this.dtlista.DataSource = this.addPeriodoContable.ListarP(Convert.ToInt32(cmperiodo.Text));
                //this.dtlista.Columns[0].Visible = false;
                //this.dtlista.Columns[1].HeaderText = "Periodo Contable";
                //this.dtlista.Columns[2].HeaderText = "Mes";
                //this.dtlista.Columns[3].HeaderText = "Fecha Inicio";
                ////this.dtlista.Columns[2].Width = 100;
                //this.dtlista.Columns[4].HeaderText = "Fecha Fin";
                ////this.dtlista.Columns[3].Width = 188;               
                //this.dtlista.Columns[5].HeaderText = "Estado" ;
                //this.dtlista.Columns[6].Visible = false;
                //this.dtlista.Columns[7].Visible = false;
            }
            catch (Exception)
            {


            }
        }
        private void frmPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Modulo' table. You can move, or remove it, as needed.
            //int x =DateTime.Now.Year;
            //this.textBuscar.Text = "2013" ;// DateTime.Now.Year; // Convert.ToInt32(x);
            llenacombobox();
            this.ListarP();
            Seguridad();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.ListarP();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btnAperturar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Realmente desea Aperturar el Mes?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ///
                    this.addPeriodoContable.periodocontable_Editar(1, Convert.ToInt32(this.dtlista.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(this.dtlista.CurrentRow.Cells[2].Value.ToString()), 1, 1, DateTime.Now);

                    //this.addPeriodoContable.periodocontable_Editar(1, 2013, 1, 7, 1, DateTime.Now);
                                            
                    /// listamos 
                    this.ListarP();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult res = MessageBox.Show("Realmente desea Cerrar el Mes?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ///
                    /// Elimino el registro segun lo selecionado
                    this.addPeriodoContable.periodocontable_Editar(1, Convert.ToInt32(this.dtlista.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(this.dtlista.CurrentRow.Cells[2].Value.ToString()), 2, 1, DateTime.Now);

                    /// listamos 
                    this.ListarP();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Realmente desea Generar el año del Periodo?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ///
                    //this.addPeriodoContable.periodocontable_Editar(1, Convert.ToInt32(this.dtlista.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(this.dtlista.CurrentRow.Cells[2].Value.ToString()), 1, 1, DateTime.Now);
                    this.addPeriodoContable.generarP(cmperiodo.Text);

                    //this.addPeriodoContable.periodocontable_Editar(1, 2013, 1, 7, 1, DateTime.Now);

                    /// listamos 
                    this.ListarP();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dtlista.DataSource = this.addPeriodoContable.ListarP(Convert.ToInt32(cmperiodo.Text));
        }

      
    }
}
