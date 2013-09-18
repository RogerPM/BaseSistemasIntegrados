namespace forms.Inventario
{
    partial class frmMPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIngresoBodega = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransferencia = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTomaFisica = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBodega = new DevExpress.XtraBars.BarButtonItem();
            this.bbiArticulo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUnidadMedida = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiColor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMarca = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModelo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPercha = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGrupo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTipoChasis = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTipoMotor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTipoMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTipoCombustible = new DevExpress.XtraBars.BarButtonItem();
            this.rpIncio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbProcesos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbMantenimientos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiUsuario,
            this.bbiSalir,
            this.bbiIngresoBodega,
            this.bbiTransferencia,
            this.bbiTomaFisica,
            this.bbiBodega,
            this.bbiArticulo,
            this.bbiUnidadMedida,
            this.barButtonItem4,
            this.bbiColor,
            this.bbiMarca,
            this.bbiModelo,
            this.bbiPercha,
            this.bbiGrupo,
            this.bbiTipoChasis,
            this.bbiTipoMotor,
            this.bbiTipoMaterial,
            this.bbiTipoCombustible});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpIncio,
            this.rbProcesos,
            this.rbMantenimientos,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(599, 142);
            // 
            // bbiUsuario
            // 
            this.bbiUsuario.Caption = "Usuario";
            this.bbiUsuario.Glyph = global::forms.Properties.Resources._24_usuarios;
            this.bbiUsuario.Id = 1;
            this.bbiUsuario.Name = "bbiUsuario";
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "SalirMenu";
            this.bbiSalir.Glyph = global::forms.Properties.Resources._24_cancelar;
            this.bbiSalir.Id = 2;
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick_1);
            // 
            // bbiIngresoBodega
            // 
            this.bbiIngresoBodega.Caption = "Ingreso a Bodega";
            this.bbiIngresoBodega.Id = 3;
            this.bbiIngresoBodega.Name = "bbiIngresoBodega";
            this.bbiIngresoBodega.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiIngresoBodega_ItemClick);
            // 
            // bbiTransferencia
            // 
            this.bbiTransferencia.Caption = "Transferencia entre Bodegas";
            this.bbiTransferencia.Id = 4;
            this.bbiTransferencia.Name = "bbiTransferencia";
            // 
            // bbiTomaFisica
            // 
            this.bbiTomaFisica.Caption = "Toma Fisica";
            this.bbiTomaFisica.Id = 5;
            this.bbiTomaFisica.Name = "bbiTomaFisica";
            // 
            // bbiBodega
            // 
            this.bbiBodega.Caption = "Bodega";
            this.bbiBodega.Id = 6;
            this.bbiBodega.Name = "bbiBodega";
            this.bbiBodega.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBodega_ItemClick_1);
            // 
            // bbiArticulo
            // 
            this.bbiArticulo.Caption = "Articulo";
            this.bbiArticulo.Id = 7;
            this.bbiArticulo.Name = "bbiArticulo";
            this.bbiArticulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiArticulo_ItemClick_1);
            // 
            // bbiUnidadMedida
            // 
            this.bbiUnidadMedida.Caption = "Unidad de Medida";
            this.bbiUnidadMedida.Id = 8;
            this.bbiUnidadMedida.Name = "bbiUnidadMedida";
            this.bbiUnidadMedida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUnidadMedida_ItemClick_1);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bbiColor
            // 
            this.bbiColor.Caption = "Color";
            this.bbiColor.Id = 12;
            this.bbiColor.Name = "bbiColor";
            this.bbiColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiColor_ItemClick_1);
            // 
            // bbiMarca
            // 
            this.bbiMarca.Caption = "Marca";
            this.bbiMarca.Id = 13;
            this.bbiMarca.Name = "bbiMarca";
            this.bbiMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMarca_ItemClick_1);
            // 
            // bbiModelo
            // 
            this.bbiModelo.Caption = "Modelo";
            this.bbiModelo.Id = 14;
            this.bbiModelo.Name = "bbiModelo";
            this.bbiModelo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModelo_ItemClick_1);
            // 
            // bbiPercha
            // 
            this.bbiPercha.Caption = "Percha";
            this.bbiPercha.Id = 15;
            this.bbiPercha.Name = "bbiPercha";
            this.bbiPercha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPercha_ItemClick_1);
            // 
            // bbiGrupo
            // 
            this.bbiGrupo.Caption = "Grupo";
            this.bbiGrupo.Id = 16;
            this.bbiGrupo.Name = "bbiGrupo";
            this.bbiGrupo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGrupo_ItemClick_1);
            // 
            // bbiTipoChasis
            // 
            this.bbiTipoChasis.Caption = "Tipo de Chasis";
            this.bbiTipoChasis.Id = 17;
            this.bbiTipoChasis.Name = "bbiTipoChasis";
            this.bbiTipoChasis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTipoChasis_ItemClick_1);
            // 
            // bbiTipoMotor
            // 
            this.bbiTipoMotor.Caption = "Tipo de Motor";
            this.bbiTipoMotor.Id = 18;
            this.bbiTipoMotor.Name = "bbiTipoMotor";
            this.bbiTipoMotor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTipoMotor_ItemClick_1);
            // 
            // bbiTipoMaterial
            // 
            this.bbiTipoMaterial.Caption = "Tipo de Material";
            this.bbiTipoMaterial.Id = 19;
            this.bbiTipoMaterial.Name = "bbiTipoMaterial";
            this.bbiTipoMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTipoMaterial_ItemClick_1);
            // 
            // bbiTipoCombustible
            // 
            this.bbiTipoCombustible.Caption = "Tipo de Combustible";
            this.bbiTipoCombustible.Id = 20;
            this.bbiTipoCombustible.Name = "bbiTipoCombustible";
            this.bbiTipoCombustible.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTipoCombustible_ItemClick_1);
            // 
            // rpIncio
            // 
            this.rpIncio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpIncio.ImageAlign = DevExpress.Utils.HorzAlignment.Center;
            this.rpIncio.Name = "rpIncio";
            this.rpIncio.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Incio";
            // 
            // rbProcesos
            // 
            this.rbProcesos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbProcesos.Name = "rbProcesos";
            this.rbProcesos.Text = "Procesos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiIngresoBodega);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiTransferencia);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiTomaFisica);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Grupo de Procesos ";
            // 
            // rbMantenimientos
            // 
            this.rbMantenimientos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbMantenimientos.Name = "rbMantenimientos";
            this.rbMantenimientos.Text = "Mantenimientos";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiBodega);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiArticulo);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiUnidadMedida);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiColor);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiMarca);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiModelo);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiPercha);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiGrupo);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiTipoChasis);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiTipoMotor);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiTipoMaterial);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiTipoCombustible);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Grupo de Mantenimientos";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Consultas y reportes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Grupo de Consultas y Reportes";
            // 
            // frmMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 354);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMPrincipal";
            this.Text = "frmMPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.BarButtonItem bbiIngresoBodega;
        private DevExpress.XtraBars.BarButtonItem bbiTransferencia;
        private DevExpress.XtraBars.BarButtonItem bbiTomaFisica;
        private DevExpress.XtraBars.BarButtonItem bbiBodega;
        private DevExpress.XtraBars.BarButtonItem bbiArticulo;
        private DevExpress.XtraBars.BarButtonItem bbiUnidadMedida;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bbiColor;
        private DevExpress.XtraBars.BarButtonItem bbiMarca;
        private DevExpress.XtraBars.BarButtonItem bbiModelo;
        private DevExpress.XtraBars.BarButtonItem bbiPercha;
        private DevExpress.XtraBars.BarButtonItem bbiGrupo;
        private DevExpress.XtraBars.BarButtonItem bbiTipoChasis;
        private DevExpress.XtraBars.BarButtonItem bbiTipoMotor;
        private DevExpress.XtraBars.BarButtonItem bbiTipoMaterial;
        private DevExpress.XtraBars.BarButtonItem bbiTipoCombustible;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpIncio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbProcesos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbMantenimientos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}