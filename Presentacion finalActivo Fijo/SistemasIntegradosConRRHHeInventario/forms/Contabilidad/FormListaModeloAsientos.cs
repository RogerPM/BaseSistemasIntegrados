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

namespace forms.Contabilidad
{
    public partial class FormListaModeloAsientos : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            
        }
        #endregion
        public FormListaModeloAsientos()
        {
            InitializeComponent();
        }
        NModeloAsiento addModeloAsiento = new NModeloAsiento();
        NModeloAsiento addModeloAsientoG = new NModeloAsiento();
                
        private void Listar()
        {
            try
            {
                this.dtlista.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                this.dtlista.DataSource = this.addModeloAsiento.ListarModeloAsiento();
                //this.dtlista.DataSource = this.clslistaTT.Query1List addclslistaTT;                
                //this.dtlista.DataSource = addclslistaTT;
                //this.dtlista.DataSource = Listar();
                //TECAEntitiesCont ob = new TECAEntitiesCont();
                //var Obj = from q in ob.Modulo  select q;
                //var datasource = this.addModeloAsiento.Listar(this.textBuscar.Text);
                //datasource.ForEach(v => { v.descripcion = Obj.First(s => s.IdModulo == v.modulo).Nombre; });
                //dtlista.DataSource = datasource;
                //this.dtlista.Columns[0].HeaderText = "Transaccion";
                //this.dtlista.Columns[1].HeaderText = "Modulo";
                //this.dtlista.Columns[2].HeaderText = "Tipo de Documentos";
                //this.dtlista.Columns[2].Width = 100;
                //this.dtlista.Columns[3].HeaderText = "Descripcion";
                //this.dtlista.Columns[3].Width = 188;               
                //this.dtlista.Columns[4].HeaderText = "Modulo Luis" ;
                
                //this.dtlista.Columns[0].Visible = false;
                //this.dtlista.Columns[7].Visible = false;
                //this.dtlista.Columns[8].Visible = false;
                //this.dtlista.Columns[9].Visible = false;
                //this.dtlista.Columns[1].HeaderText = "Transaccion" ;
                //this.dtlista.Columns[1].Width = 80;
                //this.dtlista.Columns[2].HeaderText = "Modulo";
                //this.dtlista.Columns[2].Width = 50;
                //this.dtlista.Columns[3].HeaderText = "Secuencia";
                //this.dtlista.Columns[3].Width = 70;
                //this.dtlista.Columns[4].HeaderText = "Descripcion";
                //this.dtlista.Columns[4].Width = 140;
                //this.dtlista.Columns[5].HeaderText = "Debe";
                //this.dtlista.Columns[5].Width = 72;
                //this.dtlista.Columns[6].HeaderText = "Haber";
                //this.dtlista.Columns[6].Width = 72;

            }
            catch (Exception)
            {


            }
        }

        private void FormListaModeloAsientos_Load(object sender, EventArgs e)
        {
            
            this.Listar();
            Seguridad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModeloAsiento frm = new FrmModeloAsiento();
            frm.nuevo = true; // indica que es nuevo registro
            frm.ShowDialog();
            this.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormGridModeloAsientos frm = new FormGridModeloAsientos();
                ///var t = this.addModeloAsiento.getDatos(1, 1, 1,3 );
                ///var t = this.addModeloAsiento.getDatosD(1, int.Parse(this.dtlista.CurrentRow.Cells[1].Value.ToString()), int.Parse(this.dtlista.CurrentRow.Cells[0].Value.ToString()));
                var t = this.addModeloAsiento.getDatosT(int.Parse(this.dtlista.CurrentRow.Cells[0].Value.ToString()), int.Parse(this.dtlista.CurrentRow.Cells[1].Value.ToString()));
                ///this.dtlista.Columns[0];
                ///var t = this.addModeloAsientoG.getDatosD(1, Convert.ToInt32(frm.txtmodulod.Text), Convert.ToInt32(frm.txtTransacciond), 3);
                ///ToInt32(String)

                //var t = this.addModeloAsiento.getDatos(int.Parse(this.dtlista.CurrentRow.Cells[3].Value.ToString()));
                frm.txtmodulod.Text = t.modulo.ToString();
                frm.txtTransacciond.Text = t.IdTransaccion.ToString();
                frm.txtDescripciond.Text = t.descripcion;
                frm.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FormGridModeloAsientos frm = new FormGridModeloAsientos();
                ///var t = this.addModeloAsiento.getDatos(1, 1, 1,3 );
                var t = this.addModeloAsiento.getDatosT(int.Parse(this.dtlista.CurrentRow.Cells[0].Value.ToString()), int.Parse(this.dtlista.CurrentRow.Cells[1].Value.ToString()));
                frm.txtmodulod.Text = t.modulo.ToString();
                //frm.txtnombremodulo = Convert.ToString(this.dtlista.CurrentRow.Cells[4].Value.ToString()) ;
                frm.txtTransacciond.Text = t.IdTransaccion.ToString();
                frm.txtDescripciond.Text = t.descripcion;
                frm.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ///private void button1_Click(object sender, EventArgs e)
        ///{
        ///    this.gridControl1.DataSource = this.addModeloAsiento.Listar(this.textBuscar.Text);
        ///
        ///}

        ///Cambios para agregar detalle con un grid
        /// private void btnEditar_Click(object sender, EventArgs e)
        ///{
        ///    try
        ///    {
        ///        FrmModeloAsiento frm = new FrmModeloAsiento();
        ///        var t = this.addModeloAsiento.getDatos(1, 1, 1, 1);
        ///        frm.txtModulo.Text = t.modulo.ToString();
        ///        frm.txtTransaccion.Text = t.IdTransaccion.ToString();
        ///        frm.txtSecuencia.Text = t.secuencia.ToString();
        ///        frm.txtDescripcion.Text = t.descripcion;
        ///        frm.txtDebe.Text = t.debe;
        ///        frm.txthaber.Text = t.haber;
        ///        frm.ShowDialog();
        ///        this.Listar();
        ///    }
        ///    catch (Exception ex)
        ///    {
        ///
        ///        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ///    }
         
    }
}
