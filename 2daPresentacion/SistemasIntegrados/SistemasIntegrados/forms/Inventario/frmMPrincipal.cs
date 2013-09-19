using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;

namespace forms.Inventario
{
    public partial class frmMPrincipal : Form
    {
        public frmMPrincipal()
        {
            InitializeComponent();
        }

        private void bbiBodega_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiGrupo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGrupo grupo = new frmGrupo();
            grupo.Show();
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiArticulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulo articulo = new frmArticulo();
            articulo.Show();
        }

        private void bbiUnidadMedida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUnidadMedida unidadmedida = new frmUnidadMedida();
            unidadmedida.Show();

        }

        private void bbiMotivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMotivo motivo = new frmMotivo();
            motivo.Show();
        }

        private void bbiTipoArticulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoArticulo tipoArticulo = new frmTipoArticulo();
            tipoArticulo.Show();
        }

        private void bbiColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmColor color = new frmColor();
            color.Show();
        }

        private void bbiMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void bbiModelo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModelo modelo = new frmModelo();
            modelo.Show();
        }

        private void bbiPercha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPercha percha = new frmPercha();
            percha.Show();
        }

        

        private void bbiTipoMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoMotor tipomotor = new frmTipoMotor();
            tipomotor.Show();
        }

        private void bbiTipoMaterial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoMaterial tipomaterial = new frmTipoMaterial();
            tipomaterial.Show();
        }

        private void bbiTipoCombustible_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoCombustible tipocombustible = new frmTipoCombustible();
            tipocombustible.Show();
        }

        private void bbiBodega_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBodega bodega = new frmBodega();
            bodega.Show();
        }

        private void bbiTipoChasis_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChasis chasis = new frmChasis();
            chasis.Show();
        }

        private void bbiColor_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmColor color = new frmColor();
            color.Show();
        }

        private void bbiSalir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiArticulo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulo MantArticulo = new frmArticulo();
            MantArticulo.Show();
        }

        private void bbiUnidadMedida_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUnidadMedida unidadmedida = new frmUnidadMedida();
            unidadmedida.Show();
        }

        private void bbiMotivo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMotivo motivo = new frmMotivo();
            motivo.Show();
        }

        private void bbiTipoArticulo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoArticulo tipoarticulo = new frmTipoArticulo();
            tipoarticulo.Show();
        }

        private void bbiMarca_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void bbiModelo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModelo modelo = new frmModelo();
            modelo.Show();
        }

        private void bbiPercha_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPercha percha = new frmPercha();
            percha.Show();
        }

        private void bbiGrupo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGrupo grupo = new frmGrupo();
            grupo.Show();
        }

        private void bbiTipoMotor_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoMotor tipomotor = new frmTipoMotor();
            tipomotor.Show();
        }

        private void bbiTipoMaterial_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoMaterial tipomaterial = new frmTipoMaterial();
            tipomaterial.Show();
        }

        private void bbiTipoCombustible_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoCombustible tipocombustible = new frmTipoCombustible();
            tipocombustible.Show();
        }

        private void bbiIngresoBodega_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIngresoEgresoBodega IngresoEgresoBodega = new frmIngresoEgresoBodega();
            IngresoEgresoBodega.Show();
        }
    }
    
}
