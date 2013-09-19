using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;
using clases.Seguridad;
using clases.Cuentasxpagar;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;


namespace forms.CuentasxCobrar
{
    public partial class frm_conciliacionBancaria : Form
    {
        
        public frm_conciliacionBancaria()
        {
            InitializeComponent();
            event_click += new delegate_Click(frm_conciliacionBancaria_event_click);
            
        }
        void frm_conciliacionBancaria_event_click(object sender, EventArgs e)
        {

        }
        //delegate y event
        public delegate void delegate_Click(object sender, EventArgs e);
        public event delegate_Click event_click;

        public clsConciliacionBancaria conci = new clsConciliacionBancaria();
        public datos.CuentasxCobrar.clsDatosConciliacionBancaria datocon = new datos.CuentasxCobrar.clsDatosConciliacionBancaria();


        public clsBanco clas = new clsBanco();
        clsDatosBanco dato = new clsDatosBanco();
        private string accion { set; get; }
        int solo = 1;
        public void set()
        {
            //txtCodigo.Text = Convert.ToString(clas.idBanco);
            txtNombre.Text = clas.Nombre;            
            //esto de arriba  de banco
            solo = conci.idEmpresa;//loq me dan de seguridad aki lo integro
            
            //cmabios mios.....*******
            txtCodigo.Text = Convert.ToString(conci.idBanco);
            txtnumero.Text = Convert.ToString(conci.NumeroCuenta);
            txtnConciliacion.Text = Convert.ToString(conci.idConciliacionBancaria);
            dtpconciliacion.Text = Convert.ToString(conci.FechaConciliacion);
            dtpModificacion.Text = Convert.ToString(conci.FechaModificacion);
            dtpFechaDesde.Text = Convert.ToString(conci.FechaDesde);
            dtpFechaHasta.Text = Convert.ToString(conci.FechaHasta);
            txt_saldo.Text = Convert.ToString(conci.Saldo);
            txt_totalE.Text = Convert.ToString(conci.TotalEgresos);
            txt_totalI.Text = Convert.ToString(conci.TotalIngresos);
            txt_conciliado.Text = Convert.ToString(conci.TotalConciliacion);
            gleEstado.EditValue = conci.idEstado;
            solo = conci.idUsuario;


        }

        public void get()
        {
            //clas.idBanco = Convert.ToInt32(txtCodigo.Text);
           // clas.Nombre = txtNombre.Text;            
            //clas.IdEmpresa = solo;
            //******lo mio de conciliacion
            conci.idBanco = Convert.ToInt32(txtCodigo.Text);
            conci.NumeroCuenta = Convert.ToInt32(txtnumero.Text);
            conci.idConciliacionBancaria = Convert.ToInt32(txtnConciliacion.Text);
            conci.FechaConciliacion = Convert.ToDateTime(dtpconciliacion.EditValue);
            conci.FechaModificacion = Convert.ToDateTime(dtpModificacion.EditValue);
            conci.FechaDesde = Convert.ToDateTime(dtpFechaDesde.EditValue);
            conci.FechaHasta = Convert.ToDateTime(dtpFechaHasta.EditValue);
            conci.Saldo = Convert.ToInt32(txt_saldo.Text);
            conci.TotalEgresos =  Convert.ToInt32(txt_totalE.Text);
            conci.TotalIngresos =  Convert.ToInt32(txt_totalI.Text);
            conci.TotalConciliacion =  Convert.ToInt32(txt_conciliado.Text);

            conci.idEstado = Convert.ToInt32(gleEstado.EditValue);
            conci.idEmpresa = solo;
            conci.idUsuario = solo;
            
        }

        

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //
            Frm_ConsultaBanco con  = new Frm_ConsultaBanco();
            //frmPrueba con = new frmPrueba();
            con.ShowDialog();
            clas = con.banc;
            txtCodigo.Text = Convert.ToString(clas.idBanco);
            txtNombre.Text = clas.Nombre;
            clsDatosCuentaBancaria cuenta = new clsDatosCuentaBancaria();
            List<clsCuentaBancaria> lista = new List<clsCuentaBancaria>();
            lista = cuenta.consulta(Convert.ToInt32(txtCodigo.Text));

            clsCuentaBancaria cuenta2 = new clsCuentaBancaria();
            
            
            try
            {
                cuenta2 = lista.ElementAt(0);
                txtnumero.Text = Convert.ToString(cuenta2.NumeroCuenta);
                string temp = cuenta2.TipoCuenta.ToString();
                if (temp.Equals("ahorro"))
                {
                    rd_a.Checked = true;
                    rd_c.Checked = false;
                }
                else
                {
                    rd_c.Checked = true;
                    rd_a.Checked = false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }      



        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {                        
        
            ClsDatosCobroLis conciliacion = new ClsDatosCobroLis();
            String[] NombresColumnas = new String[4];
            NombresColumnas[0] = "ID ";
            NombresColumnas[1] = "Tipo";
            NombresColumnas[2] = "Fecha";
            NombresColumnas[3] = "Valor Pagado";


            List<clsCobro> temp = new List<clsCobro>();
            List<clsconciliacion> concilia = new List<clsconciliacion>();
            temp= conciliacion.consultacobro();

            List<clsPago> temp2 = new List<clsPago>();
            temp2 = conciliacion.consultaPago();

            try
            {

                foreach (var item3 in temp)
                {
                    
                    //pregunto banco
                    

                    if ((item3.Fecha) >= dtpFechaDesde.DateTime)
                    {
                        if ((item3.Fecha) <= dtpFechaHasta.DateTime )
                        {
                            clsconciliacion cobro = new clsconciliacion();
                            cobro.Idconciliacion = item3.idCobro;
                            cobro.Tipo = "I";
                            cobro.fecha = item3.Fecha;
                            cobro.Valor = Convert.ToInt32(item3.ValorPagado);

                            concilia.Add(cobro);
                        }
                    }
                    

                }

                foreach (var item2 in temp2)
                {
                    //item2 pago cabecera
                    //pregunto banco
                    clsPagodet pagdet = new clsPagodet();
                    pagdet= datocon.consultitaBanco(item2.NumPago);
                    if (pagdet.NumeroCuenta.Equals (Convert.ToInt32(txtnumero.Text)))
                    {
                        if ((item2.FechaIngreso) >= dtpFechaDesde.DateTime)
                        {
                            if ((item2.FechaIngreso) <= dtpFechaHasta.DateTime)
                            {

                                clsconciliacion pago = new clsconciliacion();
                                pago.Idconciliacion = item2.NumPago;
                                pago.Tipo = "E";
                                pago.fecha = item2.FechaIngreso;
                                pago.Valor = Convert.ToInt32(item2.TotalPagar);

                                concilia.Add(pago);
                            }
                        }
                    }
                    
                    

                    

                }


                dgvBusqueda.DataSource = concilia ;

                int a = 0;
                this.Text = "Conciliacion Bancaria";
                while (a < NombresColumnas.Length)
                {
                    dgvBusqueda.Columns[a].HeaderText = NombresColumnas[a];
                    a = a + 1 ; // a = a+1;
                }

                dgvBusqueda.Columns[0].Visible = true;// false
                
                
                
                int x=0;//suma ingresos
                int y = 0;//suma egresos 
                for (int i = 0; i < dgvBusqueda.RowCount; i++)
                 {
                     


                    // txt_totalI.Text =Convert.ToString( dgvBusqueda.Rows[i].Cells[3].Value );
                     
                    if (Convert.ToString(dgvBusqueda.Rows[i].Cells[1].Value)=="I")
                     {
                         txt_totalI.Text =Convert.ToString( x=x+Convert.ToInt32(dgvBusqueda.Rows[i].Cells[3].Value));
                    }
                    else
                    {
                        txt_totalE.Text  = Convert.ToString( y=y+Convert.ToInt32(dgvBusqueda.Rows[i].Cells[3].Value));
                    }

                    txt_saldo.Text = Convert.ToString(x-y);
                    txt_conciliado.Text = Convert.ToString(x + y);


                }
            
                

            }
            catch (Exception)
            {
                throw;
            }
        
        }

        private void frm_conciliacionBancaria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tECADataSet.Cobro' Puede moverla o quitarla según sea necesario.
            this.cobroTableAdapter.Fill(this.dataSetCuentasPorCobrar.Cobro);

            clsDatosConciliacionBancaria datoscon = new clsDatosConciliacionBancaria();
            gleEstado.Properties.DataSource = datoscon.consultaEstado();
            gleEstado.EditValue = 1;

            dtpconciliacion.EditValue = DateTime.Today;
            dtpFechaDesde.EditValue = DateTime.Today;
            dtpFechaHasta.EditValue = DateTime.Today;
            dtpModificacion.EditValue = DateTime.Today;

            txtnConciliacion.Text = Convert.ToString(datocon.getSiguiente());
            txtnConciliacion.Properties.ReadOnly = true;

            if (accion == "a")
            {
                set();
            }

        }

        private void gdcConciliar_Click(object sender, EventArgs e)
        {
            //textEdit8.Text=  Convert.ToString( gridView1.GetRowCellValue(1, "ValorPagado")) ;      
           // gridView1.GetRow(1);

            
              //  for (int i = 0; i < gridView1.RowCount; i++)
              //  {
               //     textEdit10.Text = Convert.ToString(gridView1.GetRowCellValue(i, "idCobro"));
                    
                //    x = x + Convert.ToInt32 (gridView1.GetRowCellValue(i, "ValorPagado"));
                //    txt_totali.Text = Convert.ToString(x);
                    

                //}
            
            
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
           // gdcConciliar.ShowPrintPreview();
        }
        //el imprimir----// gdcConciliar.ShowPrintPreview();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row =  datagridview.Rows[e.RowIndex];

            //DataGridViewCheckBoxCell chk = row.Cells["column1"] as DataGridViewCheckBoxCell;
            //string y =Convert.ToString( chk.ToString  );
                    
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtnConciliacion.Text = Convert.ToString(datocon.getSiguiente());

        }

        public void limpiar()
        {
            txt_conciliado.Text = "";
            txt_saldo.Text = "";
            txt_totalE.Text = "";
            //txtnConciliacion.Text = "";
            txtNombre.Text = "";
            txtnumero.Text = "";
            txt_totalI.Text = "";
            txtCodigo.Text = "";

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            get();
            accion = "G";//variable de control 
            if (accion == "G")
            {
                if (datocon.guardar(conci))
                {
                    MessageBox.Show("Guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
                event_click(sender, e);
                frm_conciliacionBancaria_event_click(sender, e);
            }
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
             get();
            if (datocon.anular(conci))
            {
                MessageBox.Show("Conciliacion Anulada ");
                limpiar();
            }
            else
            {
                MessageBox.Show("Anulación sin Exito");
            }


            event_click(sender, e);
            frm_conciliacionBancaria_event_click(sender, e);
          }

        private void gleEstado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cobroBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }       

       

    }
}
