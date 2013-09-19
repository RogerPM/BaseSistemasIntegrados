using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Taller;
using clases.Seguridad;
using datos.Taller;
using datos.Inventario;
using clases.Inventario;

namespace forms.Taller
{
    public partial class frmArticulosTaller : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsMensajesTaller msjtaller = new clsMensajesTaller();
        clsArticuloTaller oArticulo = new clsArticuloTaller();
        datArticuloTaller oDatArticulo = new datArticuloTaller();
        datTipoMaterial oDatTipoMaterial = new datTipoMaterial();
        datColor oDatColor = new datColor();
        datModelo oDatModelo = new datModelo();
        datTipoMotor oDatTipoMotor = new datTipoMotor();
        datMarca oDatMarca = new datMarca();
        datTipoCombustible oDatTipoCombustible = new datTipoCombustible();
        datTipoChasis oDatTipoChasis = new datTipoChasis();
        datUnidadMedida oDatUnidadMedida = new datUnidadMedida();
        clsCliente oCliente = new clsCliente();

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
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frmArticulosTaller()
        {
            InitializeComponent();
        }
                   
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Vehiculos.PageEnabled == true)
            {
                if (txtDescripcionV.Text == "" || txtPlaca.Text == ""
                    || txtObservacion.Text == "")
                {
                    MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    getValores();
                    if (oDatArticulo.Guardar(oArticulo))
                    {
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                        txtCodigo.Text = Convert.ToString(oArticulo.IdArticulo);
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
                    }
                }
            }
            else if (Repuestos.PageEnabled == true)
            {
                if (txtDescripcionA.Text == "" || txtCantActualA.Text == "" || txtCantMaximaA.Text == ""
                    || txtCantMinimaA.Text == "" || txtPrecioUnitario.Text == "" || txtObservacion.Text == "")
                {
                    MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(txtCantActualA.Text) > Convert.ToInt32(txtCantMaximaA.Text))
                    {
                        MessageBox.Show(msjtaller.cant_articulotaller, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        getValores();
                        if (oDatArticulo.Guardar(oArticulo))
                        {
                            MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                            txtCodigo.Text = Convert.ToString(oArticulo.IdArticulo);
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGuardar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        public void getValores()
        {
            if (txtCodigo.Text == "")
            {
                oArticulo.IdArticulo = 0;//PK
            }
            else
            {
                oArticulo.IdArticulo= Convert.ToInt32(txtCodigo.Text);
            }

            oArticulo.FechaProduccion = Convert.ToDateTime(cbxFecha.Text);

            if (cbxGrupoArticulo.SelectedItem.ToString() == "Vehiculo")
            {
                oArticulo.IdGrupo = 6;
            }
            else if (cbxGrupoArticulo.SelectedItem.ToString() == "Repuesto")
            {
                oArticulo.IdGrupo = 7;
            }
            
            oArticulo.Observacion = txtObservacion.Text;

            if (Vehiculos.PageEnabled == true)
            {
                //PARA EL VEHICULO
                {
                    oArticulo.IdPersona = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionPersona(txtPropietario.Text));
                    oArticulo.IdMarca = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMarca(cbxMarcaV.Text));
                    oArticulo.IdModelo = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionModelo(cbxModelo.Text));
                    oArticulo.IdColor = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionColor(cbxColor.Text));
                    oArticulo.Descripcion = txtDescripcionV.Text;
                    oArticulo.IdTipoMotor = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMotor(cbxTipoMotor.Text));
                    oArticulo.IdTipoCombustible = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionCombustible(cbxTipoCombustible.Text));
                    oArticulo.IdChasis = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionChasis(cbxChasis.Text));
                    oArticulo.NroPlaca = txtPlaca.Text;
                    oArticulo.IdUnidadMedida = null;
                    oArticulo.IdTipoMaterial = null;
                    oArticulo.CantidadMinima = null;
                    oArticulo.CantidadMaxima = null;
                    oArticulo.CantidadActual = null;
                    oArticulo.PrecioUnitario = null;
                }
                
            }
    
            else if (Repuestos.PageEnabled == true)
            {
                //PARA EL ACCESORIO
                oArticulo.CantidadMinima = Convert.ToInt32(txtCantMinimaA.Text);
                oArticulo.CantidadMaxima = Convert.ToInt32(txtCantMaximaA.Text);
                oArticulo.CantidadActual = Convert.ToInt32(txtCantActualA.Text);
                oArticulo.IdMarca = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMarca(cbxMarcaA.Text));
                oArticulo.IdUnidadMedida = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionUnidadMedida(cbxUnidadMedida.Text));
                oArticulo.Descripcion = txtDescripcionA.Text;
                oArticulo.IdTipoMaterial = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionTipoMaterial(cbxTipoMaterial.Text));
                oArticulo.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                oArticulo.IdModelo = null;
                oArticulo.IdColor = null;
                oArticulo.IdTipoMotor = null;
                oArticulo.IdTipoCombustible = null;
                oArticulo.IdChasis = null;
                oArticulo.NroPlaca = null;
                oArticulo.IdPersona = null;
            }

            if (cbxEstado.SelectedItem.ToString() == "Activo")
            {
                oArticulo.IdEstado = 1;
            }
            else if(cbxEstado.SelectedItem.ToString() == "Inactivo")
            {
                oArticulo.IdEstado = 2;
            }

            oArticulo.IdEmpresa = 1;
            oArticulo.IdUsuario = 1;

        }

        private void cbxGrupoArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGrupoArticulo.SelectedItem.ToString() == "Vehiculo")
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                TbcArticulo.Enabled = true;
                Vehiculos.PageEnabled = true;
                Repuestos.PageEnabled = false;

                txtPropietario.Text = "";
                txtDescripcionV.Text = "";
                cbxChasis.Text = "";
                cbxTipoMotor.Text = "";
                txtPlaca.Text = "";
                cbxTipoCombustible.Text = "";
                cbxColor.Text = "";
                cbxMarcaV.Text = "";
                cbxMarcaV.Properties.DataSource = oDatArticulo.ConsultaMarcasVehiculo();
                cbxModelo.Text = "";
                txtPropietario.Text = "";


            }
            else if (cbxGrupoArticulo.SelectedItem.ToString() == "Repuesto")
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                TbcArticulo.Enabled = true;
                Vehiculos.PageEnabled = false;
                Repuestos.PageEnabled = true;
                txtDescripcionA.Text = "";
                txtCantMinimaA.Text = "";
                txtCantMaximaA.Text = "";
                txtCantActualA.Text = "";
                cbxUnidadMedida.Text = "";
                cbxMarcaA.Text = "";
                cbxMarcaA.Properties.DataSource = oDatArticulo.ConsultaMarcasRepuesto();
                cbxTipoMaterial.Text = "";
                txtPrecioUnitario.Text = "0";

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarArticulo f = new frmConsultarArticulo();
            f.ShowDialog();
            oArticulo = f.e;

            if (oArticulo.IdArticulo == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oArticulo.IdArticulo);
                cbxFecha.Text = Convert.ToString(oArticulo.FechaProduccion.ToShortDateString());
                txtObservacion.Text = Convert.ToString(oArticulo.Observacion);

                if (oArticulo.IdGrupo == 6)
                {
                    cbxGrupoArticulo.SelectedItem = "Vehiculo";
                }
                else if (oArticulo.IdGrupo == 7)
                {
                    cbxGrupoArticulo.SelectedItem = "Repuesto";
                }

                if (Vehiculos.PageEnabled == true)
                {
                    txtDescripcionV.Text = oArticulo.Descripcion;
                    cbxChasis.EditValue = oDatArticulo.getDescripcionSegunIdChasis(oArticulo.IdChasis);
                    cbxTipoMotor.EditValue = oDatArticulo.getDescripcionSegunIdMotor(oArticulo.IdTipoMotor);
                    txtPlaca.Text = oArticulo.NroPlaca;
                    cbxTipoCombustible.EditValue = oDatArticulo.getDescripcionSegunIdCombustible(oArticulo.IdTipoCombustible);
                    cbxColor.EditValue = oDatArticulo.getDescripcionSegunIdColor(oArticulo.IdColor);
                    cbxMarcaV.EditValue = oDatArticulo.getDescripcionSegunIdMarca(oArticulo.IdMarca);
                    cbxModelo.EditValue = oDatArticulo.getDescripcionSegunIdModelo(oArticulo.IdModelo);
                    txtPropietario.Text = oDatArticulo.getDescripcionSegunIdPersona(oArticulo.IdPersona);
                }

                if (Repuestos.PageEnabled == true)
                {
                    txtDescripcionA.Text = oArticulo.Descripcion;
                    txtCantMinimaA.Text = Convert.ToString(oArticulo.CantidadMinima);
                    txtCantMaximaA.Text = Convert.ToString(oArticulo.CantidadMaxima);
                    txtCantActualA.Text = Convert.ToString(oArticulo.CantidadActual);
                    cbxUnidadMedida.EditValue = oDatArticulo.getDescripcionSegunIdUnidadMedida(oArticulo.IdUnidadMedida);
                    cbxMarcaA.EditValue = oDatArticulo.getDescripcionSegunIdMarca(oArticulo.IdMarca);
                    cbxTipoMaterial.EditValue = oDatArticulo.getDescripcionSegunIdTipoMaterial(oArticulo.IdTipoMaterial);
                    txtPrecioUnitario.Text = Convert.ToString(oArticulo.PrecioUnitario);
                }

                if (oArticulo.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oArticulo.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Vehiculos.PageEnabled == true)
            {
                if (txtDescripcionV.Text == "" || txtPlaca.Text == ""
                    || txtObservacion.Text == "")
                {
                    MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Repuestos.PageEnabled == true && Convert.ToInt32(txtCantActualA.Text) > Convert.ToInt32(txtCantMaximaA.Text))
                    {
                        MessageBox.Show(msjtaller.cant_articulotaller, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        getValores();
                        if (oDatArticulo.Modificar(oArticulo))
                        {
                            MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (Repuestos.PageEnabled == true)
            {
                if (txtDescripcionA.Text == "" || txtCantActualA.Text == "" || txtCantMaximaA.Text == ""
                    || txtCantMinimaA.Text == "" || txtPrecioUnitario.Text == "" || txtObservacion.Text == "")
                {
                    MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(txtCantActualA.Text) > Convert.ToInt32(txtCantMaximaA.Text))
                    {
                        MessageBox.Show(msjtaller.cant_articulotaller, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        getValores();
                        if (oDatArticulo.Modificar(oArticulo))
                        {
                            MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatArticulo.Eliminar(oArticulo))
                {

                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            borrar();
        }


        public void borrar()
        {
            txtCodigo.Text = "";
            txtPropietario.Text = "";
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            txtObservacion.Text = "";
            cbxGrupoArticulo.Text = "";

            if (Vehiculos.PageEnabled == true)
            {
                txtDescripcionV.Text = "";
                cbxChasis.Text = "";
                cbxTipoMotor.Text = "";
                txtPlaca.Text = "";
                cbxTipoCombustible.Text = "";
                cbxColor.Text = "";
                cbxMarcaV.Text = "";
                cbxModelo.Text = "";
            }

            if (Repuestos.PageEnabled == true)
            {
                txtDescripcionA.Text = "";
                txtCantMinimaA.Text = "";
                txtCantMaximaA.Text = "";
                txtCantActualA.Text = "";
                cbxUnidadMedida.Text = "";
                cbxMarcaA.Text = "";
                cbxTipoMaterial.Text = "";
                txtPrecioUnitario.Text = "0";
            }

            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void frmArticulosTaller_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cbxFecha.Text = DateTime.Today.ToShortDateString();
            this.cbxTipoMaterial.Properties.DataSource = oDatTipoMaterial.consulta();
            this.cbxColor.Properties.DataSource = oDatColor.consulta();
            this.cbxModelo.Properties.DataSource = oDatModelo.consulta();
            this.cbxTipoMotor.Properties.DataSource = oDatTipoMotor.consulta();
            this.cbxMarcaV.Properties.DataSource = oDatMarca.consulta();
            this.cbxMarcaA.Properties.DataSource = oDatMarca.consulta();
            this.cbxTipoCombustible.Properties.DataSource = oDatTipoCombustible.consulta();
            this.cbxChasis.Properties.DataSource = oDatTipoChasis.consulta();
            this.cbxUnidadMedida.Properties.DataSource = oDatUnidadMedida.consulta();
            Seguridad();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente f = new frmConsultarCliente();
            f.ShowDialog();
            oCliente = f.e;
            txtPropietario.Text = oCliente.Nombre+" "+oCliente.Apellido;
        }
    }
}
