using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Inventario;
using clases.Inventario;

namespace forms.Inventario
{
    public partial class frmTomaFisica : Form
    {
        public frmTomaFisica()
        {
            InitializeComponent();
        }
        clsInventario dat = new clsInventario();
        clsTomaFisicaCAB cab = new clsTomaFisicaCAB();
        private void frmTomaFisica_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            gdcTomaFisica.DataSource = dat.consultaTomaFisicaDetalle();
            cmbArticulo.DataSource = dat.consultainventario();
            cbxTipoArticulo.Properties.DataSource = dat.consultaTipoArticulo();
            cbxMotivo.Properties.DataSource = dat.consultaMotivo();

            cbxBodega.Properties.DataSource = dat.consultaBodega();
        }
        private void get()
        {
            try
            {
                cab.IdMotivo = Convert.ToInt32(cbxMotivo.EditValue);
                cab.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.EditValue);
                cab.IdBodega = Convert.ToInt32(cbxBodega.EditValue);
                cab.Auditor = txtResponsable.Text;
                cab.IdEstado = 1;
                cab.FechaModificacion = cab.FechaTomaFisica = DateTime.Now;
                List<clsTomaFisicaDET> lista = new List<clsTomaFisicaDET>();
                //lista = (List<clsTomaFisicaDET>)gdcTomaFisica.DataSource;
                foreach (var item in (List<clsTomaFisicaDET>)gdcTomaFisica.DataSource)
                {
                    if (Convert.ToBoolean(item.check))
                    {
                        lista.Add(item);
                    }
                }
                cab.detalle = lista;
            }
            catch (Exception)
            {
            }
        }
        private void btnBuscarNroTF_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTomaFisica.Text==""){MessageBox.Show("Introduzca el Numero de Toma Fisica","TECA",MessageBoxButtons.OK,MessageBoxIcon.Warning);return;}
                toolStripButton5.Enabled = false; toolStripButton3.Enabled = true;
                txtTomaFisica.Enabled = false;
                cab = dat.consultaTomaFisica(Convert.ToInt32(txtTomaFisica.Text));
                set();
            }
            catch (Exception)
            {
            }
           
        }
        public void set() {
            try
            {
                cbxMotivo.EditValue = cab.IdMotivo;
                cbxTipoArticulo.EditValue = cab.IdTipoArticulo;
                cbxBodega.EditValue = cab.IdBodega;
                txtResponsable.Text = cab.Auditor;
                dtFecha.Value = (cab.FechaTomaFisica == Convert.ToDateTime("01/01/0001")) ? DateTime.Now : cab.FechaTomaFisica;
                List<clsTomaFisicaDET> lista = new List<clsTomaFisicaDET>();
                lista = (List<clsTomaFisicaDET>)gdcTomaFisica.DataSource;
                foreach (var item in lista)
                {
                    item.check = false;
                    item.CantidadAjustada = null;
                    item.ExistenciaFisica = null;
                    //item.ExistenciaSistema = null;
                    try
                    {
                        foreach (var item2 in cab.detalle)
                        {
                            if (item.IdArticulo == item2.IdArticulo)
                            {
                                item.check = true;
                                item.CantidadAjustada = item2.CantidadAjustada;
                                item.ExistenciaFisica = item2.ExistenciaFisica;
                                //item.ExistenciaSistema = item2.ExistenciaSistema;
                            }
                        }
                    }
                    catch(Exception) { }
                }
                gdcTomaFisica.DataSource = lista;
                for (int i = gridView1.RowCount; i >= 0; i--)
                {
                    gridView1.FocusedRowHandle = i;
                }
            }
            catch (Exception)
            {
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                List<clsTomaFisicaDET> lista = new List<clsTomaFisicaDET>();
                lista = (List<clsTomaFisicaDET>)gdcTomaFisica.DataSource;
                foreach (var item in lista)
                {
                    item.CantidadAjustada = item.ExistenciaSistema - item.ExistenciaFisica;
                    
                }
                gdcTomaFisica.DataSource = lista;

            }
            catch (Exception)
            {
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtResponsable.Focus();
            get();
            if (dat.guardarTomaFisica(ref cab))
            {
                MessageBox.Show("Guardado con Exito la Toma Fisica # " + cab.NroTomaFisica.ToString(), "TECA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                MessageBox.Show("Un error ha ocurrido Consulte Con el Administrador del Sistema TECA", "TECA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton5.Enabled= txtTomaFisica.Enabled = true;
            toolStripButton3.Enabled = false;
            cab = new clsTomaFisicaCAB();
            set();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtResponsable.Focus();
            get();
            if (dat.ModificarTomaFisica(cab))
            {
                MessageBox.Show("Guardado con Exito la Toma Fisica # " + cab.NroTomaFisica.ToString(), "TECA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripButton3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Un error ha ocurrido Consulte Con el Administrador del Sistema TECA", "TECA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txtTomaFisica_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                btnBuscarNroTF_Click(new object(),new EventArgs());}
            }
            catch (Exception)
            {
            }
        }
    }
}
