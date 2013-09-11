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
using datos;

namespace forms.CuentasxCobrar
{
    public partial class frm_Inversion : Form
    {
        String AccionBotonAplastado;

        public clsInversion objInversion = new clsInversion();
        public clsPersonaCXC objPersona = new clsPersonaCXC();
        public clsTipoInversion objTipoInversion = new clsTipoInversion();
        public clsUnidadTiempo objUnidadTiempo = new clsUnidadTiempo();
        public clsBanco objBanco = new clsBanco();

        int idEmpresa = 1;
        int idUsuario = 11;

        public frm_Inversion()
        {
            InitializeComponent();
        }

        private void frm_Inversion_Load(object sender, EventArgs e)
        {
            clsDatosTipoInversion tipoInversion = new clsDatosTipoInversion();
            this.gueTipoInversion.Properties.DataSource = tipoInversion.consultaTipoInversionGeneral();
            /*this.Inactivar();*/


        }

        private void btnBuscaPersona_Click(object sender, EventArgs e)
        {
            clsMensaje objMensaje = new clsMensaje();
            clsDatosPersonaCXC objDatosPersona = new clsDatosPersonaCXC();
            String[] NombresColumnas = new String[16];
            NombresColumnas[0] = "ID Persona";
            NombresColumnas[1] = "Identificacion";
            NombresColumnas[2] = "ID Empresa";
            NombresColumnas[3] = "ID Tipo Persona";
            NombresColumnas[4] = "Nombre o Razon Social";
            NombresColumnas[5] = "Apellido";
            NombresColumnas[6] = "Fecha Nacimiento";
            NombresColumnas[7] = "Genero";
            NombresColumnas[8] = "Tipo Identificacion";
            NombresColumnas[9] = "Direccion";
            NombresColumnas[10] = "Telefono General";
            NombresColumnas[11] = "Telefono Movil";
            NombresColumnas[12] = "Telefono Casa";
            NombresColumnas[13] = "Telefono Otros";
            NombresColumnas[14] = "Email";
            NombresColumnas[15] = "Estado";

            List<object> lista = new List<object>(objDatosPersona.ConsultaPersona()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Busca Persona", NombresColumnas);
                FormularioBusqueda.OcultarColumna(2);
                FormularioBusqueda.OcultarColumna(3);
                FormularioBusqueda.OcultarColumna(6);
                FormularioBusqueda.OcultarColumna(7);
                FormularioBusqueda.OcultarColumna(8);
                FormularioBusqueda.OcultarColumna(9);
                FormularioBusqueda.OcultarColumna(10);
                FormularioBusqueda.OcultarColumna(11);
                FormularioBusqueda.OcultarColumna(13);
                FormularioBusqueda.OcultarColumna(14);
                FormularioBusqueda.OcultarColumna(15);

                FormularioBusqueda.ShowDialog();

                if (FormularioBusqueda.Seleccion)
                {
                    DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                    objPersona.IdPersona = Convert.ToInt32(Fila.Cells[0].Value);
                    objDatosPersona.ConsultaPersonaEspecifica(objPersona);
                    this.txtCodigoPersona.Text = Convert.ToString(objPersona.Identificacion);
                    this.txtNombrePersona.Text = objPersona.NombreRazonSocial + " " + objPersona.Apellido;
                }
            }
            else
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }

        }

        public void Set()
        {
            this.txtNumeroInversion.Text = Convert.ToString(objInversion.idInversion);
            //this.txtCodigoPersona.Text = Convert.ToString(objPersona.Identificacion);
            //this.txtNombrePersona.Text = objPersona.NombreRazonSocial + " " + objPersona.Apellido;
            this.gueTipoInversion.EditValue = objTipoInversion.Descripcion;
            MessageBox.Show("hhhhhhhhhhhhhh" + this.gueTipoInversion);
            this.txtTiempo.Text = Convert.ToString(objInversion.Tiempo);
          /*   this.gueUnidadTiempo.SelectedText = objUnidadTiempo.Descripcion;
             this.gueBanco.SelectedText = objBanco.Nombre;*/
            this.txtValor.Text = Convert.ToString(objInversion.Valor);
            this.txtPorcentaje.Text = Convert.ToString(objInversion.Porcentaje);
            this.txtGanancia.Text = Convert.ToString(objInversion.Ganancia);
            this.deFechaActual.EditValue = Convert.ToString(objInversion.Fecha);
            this.deFechaDesde.EditValue = Convert.ToString(objInversion.FechaInicio);
            this.deFechaHasta.EditValue = Convert.ToString(objInversion.FechaFinal);
            if (this.objInversion.idEstado.Equals("A"))
            {
                this.ckbActivo.Checked = true;
            }
            else
            {
                this.ckbActivo.Checked = false;
            }
        }


        public Boolean Get()
        {
            clsMensaje objMensaje = new clsMensaje();
            try
            {
                objInversion.idEmpresa = idEmpresa;
                objInversion.idUsuario = idUsuario;
                objInversion.idInversion = Convert.ToInt32(this.txtNumeroInversion.Text);
                objInversion.idEntidad = objPersona.IdPersona;
                objInversion.idTipoInversion = Convert.ToInt32(gueTipoInversion.EditValue);
                objInversion.Tiempo = Convert.ToInt32(this.txtTiempo.Text);
                objInversion.idUnidadTiempo = Convert.ToInt32(gueUnidadTiempo.EditValue);
                objInversion.idBanco = Convert.ToInt32(gueBanco.EditValue);
                objInversion.Valor = Convert.ToDecimal(txtValor.Text);
                objInversion.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                objInversion.Ganancia = this.Ganancia();
                objInversion.Fecha = Convert.ToDateTime(deFechaActual.EditValue);
                objInversion.FechaModificacion = Convert.ToDateTime(deFechaActual.EditValue);
                objInversion.FechaInicio = Convert.ToDateTime(deFechaDesde.EditValue);
                objInversion.FechaFinal = Convert.ToDateTime(deFechaHasta.EditValue);
                if (ckbActivo.Checked)
                {
                      objInversion.idEstado = "A";
                }
                else
                {
                       objInversion.idEstado = "I";
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }

        }

        public void Inactivar()
        {
            this.txtNumeroInversion.Properties.ReadOnly = true;
            this.txtCodigoPersona.Properties.ReadOnly = true;
            this.txtNombrePersona.Properties.ReadOnly = true;
            this.gueTipoInversion.Enabled = false;
            this.txtTiempo.Properties.ReadOnly = true;
            this.gueUnidadTiempo.Enabled = false;
            this.gueBanco.Enabled = false;
            this.txtValor.Properties.ReadOnly = true;
            this.txtPorcentaje.Properties.ReadOnly = true;
            this.txtGanancia.Properties.ReadOnly = true;
            this.deFechaActual.Enabled = false;
            this.deFechaDesde.Enabled = false;
            this.deFechaHasta.Enabled = false;
            this.ckbActivo.Properties.ReadOnly = true;
            btnBuscaPersona.Enabled = false;
        }
        public void Limpiar()
        {
            this.txtNumeroInversion.Text = "";
            this.txtCodigoPersona.Text = "";
            this.txtNombrePersona.Text = "";
            this.gueTipoInversion.EditValue = 1;
            this.txtTiempo.Text = "";
            this.gueUnidadTiempo.EditValue = 1;
            this.gueBanco.EditValue = 1;
            this.txtValor.Text = "";
            this.txtPorcentaje.Text = "";
            this.txtGanancia.Text = "";
            this.deFechaActual.EditValue = "";
            this.deFechaDesde.EditValue = "";
            this.deFechaHasta.EditValue = "";
            this.ckbActivo.Checked = true;
        }


        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "N";
            this.txtNumeroInversion.Properties.ReadOnly = true;
            this.txtCodigoPersona.Properties.ReadOnly = true;
            this.txtNombrePersona.Properties.ReadOnly = true;
            this.gueTipoInversion.Enabled = true;
            this.txtTiempo.Properties.ReadOnly = false;
            this.gueUnidadTiempo.Enabled = true;
            this.gueBanco.Enabled = true;
            this.txtValor.Properties.ReadOnly = false;
            this.txtPorcentaje.Properties.ReadOnly = false;
            this.txtGanancia.Properties.ReadOnly = true;
            this.deFechaActual.Enabled = true;
            this.deFechaDesde.Enabled = true;
            this.deFechaHasta.Enabled = true;
            this.ckbActivo.Properties.ReadOnly = false;
            btnBuscaPersona.Enabled = true;

            clsDatosBanco banco = new clsDatosBanco();
            this.gueBanco.Properties.DataSource = banco.consultaBancoGeneral();

            clsDatosTipoInversion tipoInversion = new clsDatosTipoInversion();
            this.gueTipoInversion.Properties.DataSource = tipoInversion.consultaTipoInversionGeneral();

            clsDatosUnidadTiempo unidadTiempo = new clsDatosUnidadTiempo();
            this.gueUnidadTiempo.Properties.DataSource = unidadTiempo.consultaUnidadTiempoGeneral();

            this.Limpiar();
            clsDatosInversion objDatosInversion = new clsDatosInversion();
            this.txtNumeroInversion.Text = Convert.ToString(objDatosInversion.getIdSiguiente());
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "S";
            this.Close();
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosInversion objDatosInversion = new clsDatosInversion();
            clsMensaje objMensaje = new clsMensaje();
            
                if (this.Get())
                {
                    if (AccionBotonAplastado == "N")
                    {
                        if (objDatosInversion.guardar(objInversion))
                        {
                            string variable = objMensaje.Titulo;
                            MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                        }
                    }

                    this.Limpiar();
                    this.Inactivar();
                    AccionBotonAplastado = "G";
                }
            


        }
        
        public Decimal Ganancia()
        {
                decimal ganancia;
                ganancia = Convert.ToDecimal(this.txtValor.Text) * (Convert.ToDecimal(txtPorcentaje.Text)/100) * Convert.ToDecimal(txtTiempo.Text);
                this.txtGanancia.Text = Convert.ToString(ganancia);
                return ganancia;
        }

        private void btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnBuscarInversion_Click(object sender, EventArgs e)
        {
            AccionBotonAplastado = "B";
            clsMensaje objMensaje = new clsMensaje();
            clsDatosTipoInversion objDatosTipoInversion = new clsDatosTipoInversion();
            clsDatosUnidadTiempo objUnidadTiempo = new clsDatosUnidadTiempo();
            clsDatosBanco objDatosBanco = new clsDatosBanco();
            clsDatosPersonaCXC objDatosPersona = new clsDatosPersonaCXC();
            clsDatosInversion objDatosInversion = new clsDatosInversion();
            String[] NombresColumnas = new String[16];
            NombresColumnas[0] = "ID Empresa";
            NombresColumnas[1] = "ID Usuario";
            NombresColumnas[2] = "ID Inversion";
            NombresColumnas[3] = "ID Entidad";
            NombresColumnas[4] = "ID Tipo Inversion";
            NombresColumnas[5] = "Tiempo";
            NombresColumnas[6] = "ID Unidad Tiempo";
            NombresColumnas[7] = "ID Banco";
            NombresColumnas[8] = "Valor";
            NombresColumnas[9] = "Porcentaje";
            NombresColumnas[10] = "Ganancia";
            NombresColumnas[11] = "Fecha Inversion";
            NombresColumnas[12] = "Fecha Modificacion";
            NombresColumnas[13] = "Fecha Inicio";
            NombresColumnas[14] = "Fecha Fin";
            NombresColumnas[15] = "Estado";

            List<object> lista = new List<object>(objDatosInversion.consultaInversionGeneral()); ;
            if (lista.Count > 0)
            {
                frm_Busqueda FormularioBusqueda = new frm_Busqueda();
                FormularioBusqueda.CargarBanco(lista);
                FormularioBusqueda.EstablecerPropiedades("Total Inversiones", NombresColumnas);
                FormularioBusqueda.OcultarColumna(12);
                FormularioBusqueda.ShowDialog();

                   if (FormularioBusqueda.Seleccion)
                   {
                       DataGridViewRow Fila = FormularioBusqueda.FilaSeleccionada;
                       objInversion.idInversion = Convert.ToInt32(Fila.Cells[2].Value);
                       objDatosInversion.ConsultaInversionEspecifica(objInversion);
                       MessageBox.Show(Convert.ToString(objInversion.idTipoInversion));
                       objTipoInversion.idTipoInversion = objInversion.idTipoInversion;
                       
                       MessageBox.Show(Convert.ToString(objTipoInversion.idTipoInversion));
                       objDatosTipoInversion.consultaTipoInversionEspecifica(objTipoInversion);
                       MessageBox.Show(Convert.ToString(objTipoInversion.Descripcion));
                       this.Set();

                       /*
                    
                    objPersona.IdPersona = objCuentaBancaria.idTitular;
                    objDatosPersona.ConsultaEspecificaPersona(objPersona);
                    this.Set();*/
                      
                   }
            }
            else
            {
                MessageBox.Show(objMensaje.Vacio, objMensaje.Titulo, MessageBoxButtons.OK);
            }
            this.Inactivar();
        }

        

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}

