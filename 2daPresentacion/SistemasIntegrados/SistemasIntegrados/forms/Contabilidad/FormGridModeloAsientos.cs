using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos;
using clases.Contabilidad;

namespace forms.Contabilidad
{
    public partial class FormGridModeloAsientos : Form
    {
        public FormGridModeloAsientos()
        {
            InitializeComponent();
        }

        NModeloAsiento addModeloAsientoG = new NModeloAsiento();

        private void ListaD()
        {
            try
            {
                this.dtlistad.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                this.dtlistad.DataSource = this.addModeloAsientoG.ListarG(1, int.Parse(this.txtmodulod.Text), int.Parse(this.txtTransacciond.Text));
                this.dtlistad.Columns[0].Visible = false;
                this.dtlistad.Columns[1].Visible = false;
                this.dtlistad.Columns[2].Visible = false;
                this.dtlistad.Columns[7].Visible = false;
                this.dtlistad.Columns[8].Visible = false;
                this.dtlistad.Columns[9].Visible = false;
                this.dtlistad.Columns[3].HeaderText = "Secuencia";
                this.dtlistad.Columns[4].HeaderText = "Descripcion";
                this.dtlistad.Columns[4].Width = 180;
                this.dtlistad.Columns[5].HeaderText = "Debe";
                this.dtlistad.Columns[6].HeaderText = "Haber";

                ///this.dtlistad.Columns[0].HeadeText = "Transaccion";
                ///this.dtlistad.Columns[1].HeaderText = "Modulo";
                ///this.dtlistad.Columns[2].HeaderText = "Tipo de Documentos";
                ///this.dtlistad.Columns[2].Width = 100;
                ///this.dtlistad.Columns[3].HeaderText = "Descripcion";
                ///this.dtlistad.Columns[3].Width = 188;

            }
            catch (Exception)
            {

            }
        }

        private void FormGridModeloAsientos_Load(object sender, EventArgs e)
        {
            this.ListaD();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmModeloAsiento frm = new FrmModeloAsiento();
            frm.txtTransaccion.Text = this.txtTransacciond.Text;
            ///frm.txtTransaccion.Text = ReadOnlyAttribute.No;
            frm.txtModulo.Text = this.txtmodulod.Text;
            frm.nuevo = true; // indica que es nuevo registro
            frm.ShowDialog();
            this.ListaD();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                FrmModeloAsiento frm = new FrmModeloAsiento();
                //var t = this.addModeloAsientoG.getDatos(1, int.Parse(this.txtmodulod.Text), int.Parse(this.txtTransacciond.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));
                this.addModeloAsientoG.getDatos(1, int.Parse(this.txtmodulod.Text), int.Parse(this.txtTransacciond.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));
                this.ListaD();
                //frm.txtModulo.Text = t.modulo.ToString();
                //frm.txtTransaccion.Text = t.IdTransaccion.ToString();
                //frm.txtSecuencia.Text = t.secuencia.ToString();
                //frm.txtDescripcion.Text = t.descripcion;
                //frm.txtDebe.Text = t.debe;
                //frm.txthaber.Text = t.haber;
                //frm.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Realmente desea eliminar eliminar registro ?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ///
                    /// Elimino el registro segun lo selecionado
                    this.addModeloAsientoG.Eliminar(1, int.Parse(this.txtmodulod.Text), int.Parse(this.txtTransacciond.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));
                    /// listamos 
                    this.ListaD();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModeloAsiento frm = new FrmModeloAsiento();
            frm.txtTransaccion.Text = this.txtTransacciond.Text;
            ///frm.txtTransaccion.Text = ReadOnlyAttribute.No;
            frm.txtModulo.Text = this.txtmodulod.Text;
            frm.nuevo = true; // indica que es nuevo registro
            frm.ShowDialog();
            this.ListaD();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            try
            {
                FrmModeloAsiento frm = new FrmModeloAsiento();
                //var t = this.addModeloAsientoG.getDatos(1, int.Parse(this.txtTransacciond.Text), int.Parse(this.txtmodulod.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));
                this.addModeloAsientoG.getDatos(1, int.Parse(this.txtTransacciond.Text), int.Parse(this.txtmodulod.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));
                frm.txtModulo.Text = this.txtmodulod.Text;
                frm.txtTransaccion.Text = this.txtTransacciond.Text; //t.IdTransaccion.ToString();
                frm.txtSecuencia.Text = this.dtlistad.CurrentRow.Cells[3].Value.ToString();
                frm.txtDescripcion.Text = this.dtlistad.CurrentRow.Cells[4].Value.ToString();
                frm.txtDebe.Text = this.dtlistad.CurrentRow.Cells[5].Value.ToString();
                frm.txthaber.Text = this.dtlistad.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
                this.ListaD();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult res = MessageBox.Show("Realmente desea eliminar eliminar registro ?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ///
                    /// Elimino el registro segun lo selecionado
                    this.addModeloAsientoG.Eliminar(1, int.Parse(this.txtmodulod.Text), int.Parse(this.txtTransacciond.Text), int.Parse(this.dtlistad.CurrentRow.Cells[3].Value.ToString()));

                    /// listamos 
                    this.ListaD();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtlistad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
