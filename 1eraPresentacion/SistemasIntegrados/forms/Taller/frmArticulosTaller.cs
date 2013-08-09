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

namespace forms.Taller
{
    public partial class frmArticulosTaller : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsMensajesTaller msjtaller = new clsMensajesTaller();
        clsArticulo oArticulo = new clsArticulo();
        datArticulo oDatArticulo = new datArticulo();

        public frmArticulosTaller()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantActualV.Text) > Convert.ToInt32(txtCantMaximaV.Text))
            {
                MessageBox.Show(msjtaller.cant_articulotaller, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getValores();
                if (oDatArticulo.Guardar(oArticulo))
                {
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
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
            else if (cbxGrupoArticulo.SelectedItem.ToString() == "Accesorio")
            {
                oArticulo.IdGrupo = 7;
            }
            
            oArticulo.Observacion = txtObservacion.Text;

            if (Vehiculos.PageEnabled == true)
            {
                //PARA EL VEHICULO
                oArticulo.CantidadMinima = Convert.ToInt32(txtCantMinimaV.Text);
                oArticulo.CantidadMaxima = Convert.ToInt32(txtCantMaximaV.Text);
                oArticulo.CantidadActual = Convert.ToInt32(txtCantActualV.Text);
               
                {
                    oArticulo.IdMarca = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMarca(cbxMarcaV.Text));
                    oArticulo.IdModelo = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionModelo(cbxModelo.Text));
                    oArticulo.IdColor = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionColor(cbxColor.Text));
                    oArticulo.Descripcion = txtDescripcionV.Text;
                    oArticulo.IdTipoMotor = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMotor(cbxTipoMotor.Text));
                    oArticulo.IdTipoCombustible = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionCombustible(cbxTipoCombustible.Text));
                    oArticulo.IdChasis = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionChasis(cbxChasis.Text));
                    oArticulo.NroPlaca = Convert.ToInt32(txtPlaca.Text);
                    oArticulo.IdUnidadMedida = null;
                    oArticulo.IdTipoMaterial = null;
                }
                
            }
    
            else if (Accesorios.PageEnabled == true)
            {
                //PARA EL ACCESORIO
                oArticulo.CantidadMinima = Convert.ToInt32(txtCantMinimaA.Text);
                oArticulo.CantidadMaxima = Convert.ToInt32(txtCantMaximaA.Text);
                oArticulo.CantidadActual = Convert.ToInt32(txtCantActualA.Text);
                oArticulo.IdMarca = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionMarca(cbxMarcaA.Text));
                oArticulo.IdUnidadMedida = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionUnidadMedida(cbxUnidadMedida.Text));
                oArticulo.Descripcion = txtDescripcionA.Text;
                oArticulo.IdTipoMaterial = Convert.ToInt32(oDatArticulo.getIdSegunDescripcionTipoMaterial(cbxTipoMaterial.Text));
                oArticulo.IdModelo = null;
                oArticulo.IdColor = null;
                oArticulo.IdTipoMotor = null;
                oArticulo.IdTipoCombustible = null;
                oArticulo.IdChasis = null;
                oArticulo.NroPlaca = null;
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
                TbcArticulo.Enabled = true;
                Vehiculos.PageEnabled = true;
                Accesorios.PageEnabled = false;

                txtDescripcionV.Text = "";
                txtCantMinimaV.Text = "";
                txtCantMaximaV.Text = "";
                txtCantActualV.Text = "";
                cbxChasis.Text = "";
                cbxTipoMotor.Text = "";
                txtPlaca.Text = "";
                cbxTipoCombustible.Text = "";
                cbxColor.Text = "";
                cbxMarcaV.Text = "";
                cbxModelo.Text = "";


            }
            else if (cbxGrupoArticulo.SelectedItem.ToString() == "Accesorio")
            {
                TbcArticulo.Enabled = true;
                Vehiculos.PageEnabled = false;
                Accesorios.PageEnabled = true;

                txtDescripcionA.Text = "";
                txtCantMinimaA.Text = "";
                txtCantMaximaA.Text = "";
                txtCantActualA.Text = "";
                cbxUnidadMedida.Text = "";
                cbxMarcaA.Text = "";
                cbxTipoMaterial.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarArticulo f = new frmConsultarArticulo();
            f.ShowDialog();
            oArticulo = f.e;
            txtCodigo.Text = Convert.ToString(oArticulo.IdArticulo);
            cbxFecha.Text = Convert.ToString(oArticulo.FechaProduccion);
            txtObservacion.Text = Convert.ToString(oArticulo.Observacion);

            if (oArticulo.IdGrupo == 6)
            {
                cbxGrupoArticulo.SelectedItem = "Vehiculo";
            }
            else if (oArticulo.IdGrupo == 7)
            {
                cbxGrupoArticulo.SelectedItem = "Accesorio";
            }

            if (Vehiculos.PageEnabled == true)
            {
                txtDescripcionV.Text = oArticulo.Descripcion;
                txtCantMinimaV.Text = Convert.ToString(oArticulo.CantidadMinima);
                txtCantMaximaV.Text = Convert.ToString(oArticulo.CantidadMaxima);
                txtCantActualV.Text = Convert.ToString(oArticulo.CantidadActual);
                cbxChasis.SelectedItem = oDatArticulo.getDescripcionSegunIdChasis(oArticulo.IdChasis);
                cbxTipoMotor.SelectedItem = oDatArticulo.getDescripcionSegunIdMotor(oArticulo.IdTipoMotor);
                txtPlaca.Text = Convert.ToString(oArticulo.NroPlaca);
                cbxTipoCombustible.SelectedItem = oDatArticulo.getDescripcionSegunIdCombustible(oArticulo.IdTipoCombustible);
                cbxColor.SelectedItem = oDatArticulo.getDescripcionSegunIdColor(oArticulo.IdColor);
                cbxMarcaV.SelectedItem = oDatArticulo.getDescripcionSegunIdMarca(oArticulo.IdMarca);
                cbxModelo.SelectedItem = oDatArticulo.getDescripcionSegunIdModelo(oArticulo.IdModelo);
            }

            if (Accesorios.PageEnabled == true)
            {
                txtDescripcionA.Text = oArticulo.Descripcion;
                txtCantMinimaA.Text = Convert.ToString(oArticulo.CantidadMinima);
                txtCantMaximaA.Text = Convert.ToString(oArticulo.CantidadMaxima);
                txtCantActualA.Text = Convert.ToString(oArticulo.CantidadActual);
                cbxUnidadMedida.Text = oDatArticulo.getDescripcionSegunIdUnidadMedida(oArticulo.IdUnidadMedida);
                cbxMarcaA.SelectedItem = oDatArticulo.getDescripcionSegunIdMarca(oArticulo.IdMarca);
                cbxTipoMaterial.SelectedItem = oDatArticulo.getDescripcionSegunIdTipoMaterial(oArticulo.IdTipoMaterial);
            }

            if (oArticulo.IdEstado == 1)
            {
                cbxEstado.SelectedItem = "Activo";
            }
            else
            {
                cbxEstado.SelectedItem = "Inactivo";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
        }


        public void borrar()
        {
            txtCodigo.Text = "";
            cbxFecha.Text = "";
            txtObservacion.Text = "";
            cbxGrupoArticulo.Text = "";

            if (Vehiculos.PageEnabled == true)
            {
                txtDescripcionV.Text = "";
                txtCantMinimaV.Text = "";
                txtCantMaximaV.Text = "";
                txtCantActualV.Text = "";
                cbxChasis.Text = "";
                cbxTipoMotor.Text = "";
                txtPlaca.Text = "";
                cbxTipoCombustible.Text = "";
                cbxColor.Text = "";
                cbxMarcaV.Text = "";
                cbxModelo.Text = "";
            }

            if (Accesorios.PageEnabled == true)
            {
                txtDescripcionA.Text = "";
                txtCantMinimaA.Text = "";
                txtCantMaximaA.Text = "";
                txtCantActualA.Text = "";
                cbxUnidadMedida.Text = "";
                cbxMarcaA.Text = "";
                cbxTipoMaterial.Text = "";
            }

            cbxEstado.Text = "";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void frmArticulosTaller_Load(object sender, EventArgs e)
        {

        }

        private void cbxUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxMarcaA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
