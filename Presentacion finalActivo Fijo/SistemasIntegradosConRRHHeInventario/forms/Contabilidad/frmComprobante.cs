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
using clases.Seguridad;

namespace forms.Contabilidad
{
    public partial class frmComprobante : Form
    {
        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            //btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion

        public frmComprobante()
        {
            InitializeComponent();
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = clsVwUsuarioInformacion.nombreUsuario;
            cargar();
            List<clsDetalleComprobante> det = new List<clsDetalleComprobante>();
            Seguridad();
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
                    MessageBox.Show("Comprobante Ingresado con Exito","TECA System",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    btnGuardar.Enabled = false;
                txtNumCom.Enabled = btnBuscar.Enabled = true;
                }
                txtNumCom.Text = Convert.ToString(cabecera.numero_comprobante);
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatoComprobante dato = new clsDatoComprobante();
                set(dato.consultaComprobante(Convert.ToDecimal(txtNumCom.Text), 1));
                gridViewComprobante_RowUpdated(new object(), new DevExpress.XtraGrid.Views.Base.RowObjectEventArgs(1, new object()));
        
            }
            catch (Exception)
            {
            }
            }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void txtGlosa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
