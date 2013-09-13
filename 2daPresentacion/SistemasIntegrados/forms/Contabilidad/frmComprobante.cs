using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Contabilidad;
using clases.Contabilidad;

namespace forms.Contabilidad
{
    public partial class frmComprobante : Form
    {
        public frmComprobante()
        {
            InitializeComponent();
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            cargar();
            List<clsDetalleComprobante> det = new List<clsDetalleComprobante>();
        }
        private void cargar() {
            try
            {
                clsDatoCuenta cuenta = new clsDatoCuenta();
                var lista=cuenta.ConsultaCuentaComprobante();
                lista.ForEach(q => q.nombre = "[" + q.IdCuenta + "] " + q.nombre);
                comboCuenta.DataSource = lista;
            }
            catch (Exception)
            {
            }
        }
        public decimal NumeroComprobante { get; set; }
        private void gridViewComprobante_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            txtD.Text = get().Select(q => q.debe).Sum().ToString();
            txtH.Text = get().Select(q => q.haber).Sum().ToString();
        }
        public void calcularTotal() {
            try
            {

                //gridViewComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                var s = from q in (List<clsDetalleComprobante>)gridViewComprobante.DataSource select q;
                var x = from q in (List<clsDetalleComprobante>)gridControlComprobante.DataSource select q;


            }
            catch (Exception)
            {
            }
        }
        clsCabeceraComprobante cabecera = new clsCabeceraComprobante();
        public List<clsDetalleComprobante> get() {
            try
            {
                cabecera.fecha = dtFecha.Value;
                cabecera.glosa = txtGlosa.Text;
                cabecera.IdEmpresa = 1;
                //////////
                gridViewComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                List<clsDetalleComprobante> lista = new List<clsDetalleComprobante>();
                for (int i = 0; i < gridViewComprobante.RowCount; i++)
                {
                    clsDetalleComprobante clas = new clsDetalleComprobante();
                    clas.cuenta = Convert.ToString(gridViewComprobante.GetRowCellValue(i, colcuenta));
                    clas.debe = Convert.ToDecimal(gridViewComprobante.GetRowCellValue(i, coldebe));
                    clas.haber = Convert.ToDecimal(gridViewComprobante.GetRowCellValue(i, colhaber));
                    clas.IdEmpresa = Convert.ToInt32(gridViewComprobante.GetRowCellValue(i, colIdEmpresa));
                    clas.linea_comprobante = Convert.ToInt32(gridViewComprobante.GetRowCellValue(i, collinea_comprobante));
                    if (clas.debe>0 && clas.haber>0)
                    {
                        if (clas.debe > clas.haber)
                        {
                            gridViewComprobante.SetRowCellValue(i, colhaber, 0);
                        }
                        else
                        {
                            gridViewComprobante.SetRowCellValue(i, coldebe, 0);
                        }
                    }

                    lista.Add(clas);

                }
                gridViewComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void set(clsCabeceraComprobante Comp)
        {
            try
            {
                txtGlosa.Text = Comp.glosa;
                dtFecha.Value= Comp.fecha;
                gridControlComprobante.DataSource = Comp.Detalle;
                NumeroComprobante = Comp.numero_comprobante;
            }
            catch (Exception)
            {
                txtGlosa.Text = "";
                gridControlComprobante.DataSource = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewComprobante_RowUpdated(new object(), new DevExpress.XtraGrid.Views.Base.RowObjectEventArgs(1, new object()));
                if(txtD.Text!=txtH.Text){
                    MessageBox.Show("No se puede guardar el total del Debe es diferente al total del Haber", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cabecera.Detalle = get();
                clsDatoComprobante dato = new clsDatoComprobante();
                if (dato.GuardarCabecera(ref cabecera)) {
                    MessageBox.Show("Comprobante # "+cabecera.numero_comprobante.ToString()+" Guardado con exito", "TECA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnGuardar.Enabled = false;
                txtNumCom.Enabled = btnBuscar.Enabled = true;
                }
                txtNumCom.Text = Convert.ToString(cabecera.numero_comprobante);
            }
            catch (Exception)
            {
            }
        }
        private bool flag = true;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    frmBusquedaComprobante frm = new frmBusquedaComprobante();
                    frm.ShowDialog();
                    txtNumCom.Text = frm.NumCom;
                }
                clsDatoComprobante dato = new clsDatoComprobante();
                set(dato.consultaComprobante(Convert.ToDecimal(txtNumCom.Text), 1));
                gridViewComprobante_RowUpdated(new object(), new DevExpress.XtraGrid.Views.Base.RowObjectEventArgs(1, new object()));
                flag = true;
            }
            catch (Exception)
            {
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                txtGlosa.Text = "";
                btnGuardar.Enabled = true;
                txtNumCom.Enabled = btnBuscar.Enabled = false;
                clsDetalleComprobanteBindingSource.Clear();
                gridControlComprobante.DataSource = clsDetalleComprobanteBindingSource;
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal NumComReve = 0;
                clsDatoComprobante dato = new clsDatoComprobante();
                if (dato.RevertirC(Convert.ToDecimal(NumeroComprobante), 1,ref NumComReve))
                {
                    MessageBox.Show("Comprobante Revertido con el Numero "+NumComReve.ToString(), "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumCom.Text = NumComReve.ToString();
                    set(dato.consultaComprobante(NumComReve, 1));
                    gridViewComprobante_RowUpdated(new object(), new DevExpress.XtraGrid.Views.Base.RowObjectEventArgs(1, new object()));
                }
                else {
                    MessageBox.Show("Comprobante no existe", "Contabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtNumCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    flag = false;
                    btnBuscar_Click(new object(), new EventArgs());
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
