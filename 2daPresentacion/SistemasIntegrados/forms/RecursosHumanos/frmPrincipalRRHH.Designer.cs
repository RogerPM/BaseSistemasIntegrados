namespace forms
{
    partial class frmPrincipalRRHH
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.BarButtonItem biMaternidad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalRRHH));
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.biDepartamento = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.biCargo = new DevExpress.XtraBars.BarButtonItem();
            this.biTitulo = new DevExpress.XtraBars.BarButtonItem();
            this.biMulta = new DevExpress.XtraBars.BarButtonItem();
            this.biRubro = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem22 = new DevExpress.XtraBars.BarButtonItem();
            this.biPrestamo = new DevExpress.XtraBars.BarButtonItem();
            this.biPermiso = new DevExpress.XtraBars.BarButtonItem();
            this.biContrato = new DevExpress.XtraBars.BarButtonItem();
            this.biUniversidad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            biMaternidad = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // biMaternidad
            // 
            biMaternidad.Caption = "Maternidad";
            biMaternidad.Glyph = ((System.Drawing.Image)(resources.GetObject("biMaternidad.Glyph")));
            biMaternidad.Id = 33;
            biMaternidad.Name = "biMaternidad";
            biMaternidad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biEmpleado,
            this.biDepartamento,
            this.barButtonItem3,
            this.biCargo,
            this.biTitulo,
            this.biMulta,
            this.biRubro,
            this.barButtonItem4,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barButtonItem18,
            this.barButtonItem19,
            this.barButtonItem20,
            this.barButtonItem21,
            this.barButtonItem22,
            this.biPrestamo,
            biMaternidad,
            this.biPermiso,
            this.biContrato,
            this.biUniversidad});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 40;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(734, 142);
            // 
            // biEmpleado
            // 
            this.biEmpleado.Caption = "Empleado";
            this.biEmpleado.Glyph = global::forms.Properties.Resources._24_usuarios;
            this.biEmpleado.Id = 1;
            this.biEmpleado.Name = "biEmpleado";
            this.biEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // biDepartamento
            // 
            this.biDepartamento.Caption = "Departamento";
            this.biDepartamento.Glyph = ((System.Drawing.Image)(resources.GetObject("biDepartamento.Glyph")));
            this.biDepartamento.Id = 2;
            this.biDepartamento.Name = "biDepartamento";
            this.biDepartamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nomina Empleado";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // biCargo
            // 
            this.biCargo.Caption = "cargos";
            this.biCargo.Glyph = ((System.Drawing.Image)(resources.GetObject("biCargo.Glyph")));
            this.biCargo.Id = 9;
            this.biCargo.Name = "biCargo";
            this.biCargo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // biTitulo
            // 
            this.biTitulo.Caption = "Título Profesional";
            this.biTitulo.Glyph = ((System.Drawing.Image)(resources.GetObject("biTitulo.Glyph")));
            this.biTitulo.Id = 10;
            this.biTitulo.Name = "biTitulo";
            this.biTitulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // biMulta
            // 
            this.biMulta.Caption = "Multa";
            this.biMulta.Glyph = ((System.Drawing.Image)(resources.GetObject("biMulta.Glyph")));
            this.biMulta.Id = 12;
            this.biMulta.Name = "biMulta";
            this.biMulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // biRubro
            // 
            this.biRubro.Caption = "Rubros";
            this.biRubro.Glyph = ((System.Drawing.Image)(resources.GetObject("biRubro.Glyph")));
            this.biRubro.Id = 13;
            this.biRubro.Name = "biRubro";
            this.biRubro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Contrato";
            this.barButtonItem4.Glyph = global::forms.Properties.Resources.recursoshumanos;
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Permisos";
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 18;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "barButtonItem15";
            this.barButtonItem15.Id = 21;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "barButtonItem16";
            this.barButtonItem16.Id = 23;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "barButtonItem17";
            this.barButtonItem17.Id = 24;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Anticipo de sueldo";
            this.barButtonItem18.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.Glyph")));
            this.barButtonItem18.Id = 25;
            this.barButtonItem18.Name = "barButtonItem18";
            this.barButtonItem18.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem18_ItemClick);
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Liquidacion";
            this.barButtonItem19.Glyph = global::forms.Properties.Resources.cuentasporcobrar;
            this.barButtonItem19.Id = 27;
            this.barButtonItem19.Name = "barButtonItem19";
            this.barButtonItem19.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem19_ItemClick);
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Prestamos";
            this.barButtonItem20.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem20.Glyph")));
            this.barButtonItem20.Id = 28;
            this.barButtonItem20.Name = "barButtonItem20";
            this.barButtonItem20.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem20_ItemClick);
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Trabajo Diario";
            this.barButtonItem21.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.Glyph")));
            this.barButtonItem21.Id = 29;
            this.barButtonItem21.Name = "barButtonItem21";
            this.barButtonItem21.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem21_ItemClick);
            // 
            // barButtonItem22
            // 
            this.barButtonItem22.Caption = "Vacaciones";
            this.barButtonItem22.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.Glyph")));
            this.barButtonItem22.Id = 30;
            this.barButtonItem22.Name = "barButtonItem22";
            this.barButtonItem22.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem22_ItemClick);
            // 
            // biPrestamo
            // 
            this.biPrestamo.Caption = "Tipo Prestamo";
            this.biPrestamo.Glyph = ((System.Drawing.Image)(resources.GetObject("biPrestamo.Glyph")));
            this.biPrestamo.Id = 32;
            this.biPrestamo.Name = "biPrestamo";
            this.biPrestamo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // biPermiso
            // 
            this.biPermiso.Caption = "Tipo Permiso";
            this.biPermiso.Glyph = ((System.Drawing.Image)(resources.GetObject("biPermiso.Glyph")));
            this.biPermiso.Id = 34;
            this.biPermiso.Name = "biPermiso";
            this.biPermiso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // biContrato
            // 
            this.biContrato.Caption = "Tipo Contrato";
            this.biContrato.Glyph = ((System.Drawing.Image)(resources.GetObject("biContrato.Glyph")));
            this.biContrato.Id = 37;
            this.biContrato.Name = "biContrato";
            this.biContrato.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biContrato_ItemClick);
            // 
            // biUniversidad
            // 
            this.biUniversidad.Caption = "Universidad";
            this.biUniversidad.Glyph = global::forms.Properties.Resources._16_tag_pencil;
            this.biUniversidad.Id = 38;
            this.biUniversidad.Name = "biUniversidad";
            this.biUniversidad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biUniversidad_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Mantenimiento";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.biEmpleado);
            this.ribbonPageGroup1.ItemLinks.Add(this.biDepartamento);
            this.ribbonPageGroup1.ItemLinks.Add(this.biCargo);
            this.ribbonPageGroup1.ItemLinks.Add(this.biTitulo);
            this.ribbonPageGroup1.ItemLinks.Add(this.biMulta);
            this.ribbonPageGroup1.ItemLinks.Add(this.biRubro);
            this.ribbonPageGroup1.ItemLinks.Add(this.biPrestamo);
            this.ribbonPageGroup1.ItemLinks.Add(biMaternidad);
            this.ribbonPageGroup1.ItemLinks.Add(this.biPermiso);
            this.ribbonPageGroup1.ItemLinks.Add(this.biContrato);
            this.ribbonPageGroup1.ItemLinks.Add(this.biUniversidad);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Opciones de mantenimiento";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Procesos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem18);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem19);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem20);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem21);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem22);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Opciones de Procesos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Consultas/Reportes";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Opciones de Consultas/Reportes";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Tipo Prestamo";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 32;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Tipo Prestamo";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 32;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // frmPrincipalRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 344);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmPrincipalRRHH";
            this.Text = " Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipalRRHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem biEmpleado;
        private DevExpress.XtraBars.BarButtonItem biDepartamento;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem biCargo;
        private DevExpress.XtraBars.BarButtonItem biTitulo;
        private DevExpress.XtraBars.BarButtonItem biMulta;
        private DevExpress.XtraBars.BarButtonItem biRubro;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.BarButtonItem barButtonItem20;
        private DevExpress.XtraBars.BarButtonItem barButtonItem21;
        private DevExpress.XtraBars.BarButtonItem barButtonItem22;
        private DevExpress.XtraBars.BarButtonItem biPrestamo;
        private DevExpress.XtraBars.BarButtonItem biPermiso;
        private DevExpress.XtraBars.BarButtonItem biContrato;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem biUniversidad;
    }
}

