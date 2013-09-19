using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using clases.Inventario;
using clases.Seguridad;
using datos.ActivoFijo;
using datos.Inventario;
using datos.Seguridad;


namespace forms.ActivoFijo
{
    public partial class mntTipoBaja : Form
    {
        public char accionk { get; set; }
        public clsMotivoBaja clase = new clsMotivoBaja();
        clsActivoFijo oActivoFijo = new clsActivoFijo();
        clsMotivoBaja omotivobaja = new clsMotivoBaja();
        datEmpresa datoEmpresa = new datEmpresa();

        datosmotivobaja datosmotivo = new datosmotivobaja();
        //datEstado datoEstado = new datEstado();
        datEstado datoEstado = new datEstado();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();
         
        public mntTipoBaja()
        {
            InitializeComponent();
        }



        //Declare una instancia de la clase de Subgrupos para poder llenar los datos
        public char accion { get; set; }
        // public clsSubgrupoActivoFijo clase = new clsSubgrupoActivoFijo();
        // clsSubgrupoActivoFijo oSubGrupo = new clsSubgrupoActivoFijo();
        //clsEmpresa oEmpresa = new clsEmpresa();
        //clsEstado  oEstado  = new clsEstado();
        //clsGrupo   oGrupo   = new clsGrupo();
        //clsMensajesActivoFijos msj = new clsMensajesActivoFijos();
        //clsBajaActivo oBajaActivo = new clsBajaActivo();

        //clsClaseDatosSubgrupoActivoFijo datoSubgrupo = new clsClaseDatosSubgrupoActivoFijo();
        //datGrupo datGrupo = new datGrupo();
        //clsClaseDatosBajaActivo datoProvePersoBajaActivo = new clsClaseDatosBajaActivo();
        
        //datEmpresa datoEmpresa = new datEmpresa();

        //clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();




        //public clsClaseDatosBajaActivo clas = new clsClaseDatosBajaActivo();


        #region"Evento Load"
        private void mntTipoBaja_Load(object sender, EventArgs e)
        {
            //Llenamos el combo grupo de inventario en la pantalla 
            cbxEstado.Properties.DataSource = datoEstado.consEstado();
            BloquearControles();
            ;
            //cbxEstado.Properties.DataSource = new datoEstado.ConsultaTodos();
            
            
        }

        #endregion

        #region"Operaciones de Controles"
       public void set(clsMotivoBaja  oBajaActivo)
        {
        //   // txtCodigoActivo.Text = Convert.ToString(oBajaActivo.Codigo);
        //    cbxGrupo.EditValue = datoActivo.getDescripcionSegunIdInventarioGrupo(oBajaActivo.Grupo);
        //    cbxSubGrupo.Text = datoSubgrupo.getDescripcionSegunIdActivoFIjoSubGrupo (oBajaActivo.Subgrupo);
        //    dtFecha.EditValue = oBajaActivo.Fecha;
        //    txtDescripcion.Text  = oBajaActivo.Descripcion;
        //    cbxEstado.EditValue = datoEstado.getDescripcionSegunId(oBajaActivo.IdEstado);
        //    cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId(oBajaActivo.IdEmpresa);
            txtCodigoBajaActivo.Text = Convert.ToString(oBajaActivo.idMotivoBaja);
            txtDescripcion.Text = oBajaActivo.descripcion;
            cbxEstado.EditValue = datoEstado.getDescripcionSegunId(oActivoFijo.estado);
       

       }

         public bool getValor()
        {

            if (txtCodigoBajaActivo.Text =="" || txtCodigoBajaActivo.Text == "0")
            {
          
            omotivobaja.idMotivoBaja = 0;//PK //lo que se hace aqui es colocar los pk en 0 para que se las pueda utilizar 
            }
            else
            {
                omotivobaja.idMotivoBaja = Convert.ToInt32(txtCodigoBajaActivo.Text);
            }



            if ((cbxEstado.EditValue == null || (txtDescripcion.Text == ""))) 
                   
                {
                    return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                    //bote un error 
                }

                omotivobaja.descripcion = Convert.ToString(txtDescripcion.Text);
                //omotivobaja.idMotivoBaja = Convert.ToInt32(txtCodigoBajaActivo.Text);//Se llena el campo del acivo fijo 
                omotivobaja.idEstado = oActivoFijo.estado;
                return true;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote que todos los datos estan llenos 
            

        }

         private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCodigoBajaActivo.Enabled = false;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            
            
            

            //btnProcesar.Enabled = true;
            //txtCodigoActivo.Enabled = false;
            //cbxGrupo.Enabled = true;
            //cbxSubGrupo.Enabled = true;
            //cbxEstado.Enabled = true;
            //dtFecha.Enabled = true;
            //txtDescripcion.Enabled = true;
            //GridDepreciacion.Enabled = true;
        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;
            txtDescripcion.Enabled = false;
            btnBuscar.Enabled = true;
            txtCodigoBajaActivo.Enabled = true;

        }

        private void limpiarControles()
        {
            txtCodigoBajaActivo.Text = "";
            txtDescripcion.Text = "";


        }



        #endregion


    #region"Operaciones Basicas"
         private void btnBuscar_Click(object sender, EventArgs e)
        {
            VtnConsultaTipoBajaActivo frm = new VtnConsultaTipoBajaActivo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = false;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                txtDescripcion.Enabled = true;
                    //btnAnular.Enabled = true;//
                
                //btnConsultar.Enabled = true;//

                omotivobaja = frm.cls;
                set(omotivobaja);
            }
            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                //btnAnular.Enabled = false;//
                //btnConsultar.Enabled = false;//
                //btnProcesar.Enabled = false;
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }




#endregion

         private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
            HabilitarControles();
            txtnum.Text = "1";

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(msj.Eliminar_ok);
                limpiarControles();
                BloquearControles();
                {
                    MessageBox.Show(msj.Eliminar_error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }
        }
        
        private void cbxProveedor_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            accionk = 'E';
            try
            {
                if (accionk == 'E')
                {
                    if (datosmotivo.eliminar(omotivobaja))
                    {
                        MessageBox.Show(msj.Eliminar_ok);
                        limpiarControles();
                        BloquearControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Eliminar_error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(msj.Cancelar, msj.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (getValor())
            {

                if (omotivobaja.idMotivoBaja == 0)
                {

                    if (datosmotivo.guardar(omotivobaja))
                    {
                        MessageBox.Show(msj.Guardar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else 
                {
                    if (datosmotivo.modificar(clase))
                    {
                        MessageBox.Show(msj.Modificar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Modificar_error);
                    }

                    }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

                //limpiarControles();
                //btnGuardar.Enabled = false;
                //btnNuevo.Enabled = true;
            

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            accion = 'M';
            try
            {
                getValor();
                if (accion == 'M')
                {
                    if (datosmotivo.modificar(omotivobaja))//Esto va hacer que compare si el resultado de esta opdracion es true o false tal como se declara la funsion en datos de tipo boolean
                    {
                        MessageBox.Show(msj.Modificar_ok);
                        limpiarControles();
                        BloquearControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Modificar_error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(msj.Modificar_error); ;
            }





        }
    }
}
