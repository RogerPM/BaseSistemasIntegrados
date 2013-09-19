namespace forms.Compras
{
    partial class rptSolicitud
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer5 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer6 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer7 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer8 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 22.91667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 90.625F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1,
            this.GroupHeader2});
            this.DetailReport.DataMember = "cabeceraDetalle";
            this.DetailReport.DataSource = this.bindingSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel7});
            this.Detail1.HeightF = 32.29167F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.Departamento")});
            this.xrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(307.7083F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.Estado")});
            this.xrLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(425.4166F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.Fecha")});
            this.xrLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(539.9999F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader1});
            this.DetailReport1.DataMember = "cabeceraDetalle.detalle";
            this.DetailReport1.DataSource = this.bindingSource1;
            this.DetailReport1.Level = 0;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4});
            this.Detail2.HeightF = 68.75006F;
            this.Detail2.Name = "Detail2";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(clases.Compras.clsRptSolicitud1);
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.detalle.Articulo")});
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 18.04174F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.detalle.Cantidad")});
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(407.2917F, 18.04174F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.detalle.linea")});
            this.xrLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(66.00002F, 18.04173F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.Empresa")});
            this.xrLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(40.00003F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cabeceraDetalle.Usuario")});
            this.xrLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(181.6667F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(66.00002F, 10.00001F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(26F, 14F);
            this.winControlContainer1.WinControl = this.labelControl1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Linea";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer7,
            this.winControlContainer1,
            this.winControlContainer8});
            this.GroupHeader1.HeightF = 43.75F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Empresa";
            // 
            // winControlContainer2
            // 
            this.winControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(40.00003F, 28.75001F);
            this.winControlContainer2.Name = "winControlContainer2";
            this.winControlContainer2.SizeF = new System.Drawing.SizeF(43F, 14F);
            this.winControlContainer2.WinControl = this.labelControl2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(0, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Usuario";
            // 
            // winControlContainer3
            // 
            this.winControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(181.6667F, 28.75001F);
            this.winControlContainer3.Name = "winControlContainer3";
            this.winControlContainer3.SizeF = new System.Drawing.SizeF(38F, 14F);
            this.winControlContainer3.WinControl = this.labelControl3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Departamento";
            // 
            // winControlContainer4
            // 
            this.winControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(307.7083F, 28.75001F);
            this.winControlContainer4.Name = "winControlContainer4";
            this.winControlContainer4.SizeF = new System.Drawing.SizeF(72F, 14F);
            this.winControlContainer4.WinControl = this.labelControl4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Location = new System.Drawing.Point(0, 0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Estado";
            // 
            // winControlContainer5
            // 
            this.winControlContainer5.LocationFloat = new DevExpress.Utils.PointFloat(425.4166F, 28.75001F);
            this.winControlContainer5.Name = "winControlContainer5";
            this.winControlContainer5.SizeF = new System.Drawing.SizeF(34F, 14F);
            this.winControlContainer5.WinControl = this.labelControl5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Location = new System.Drawing.Point(0, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Fecha";
            // 
            // winControlContainer6
            // 
            this.winControlContainer6.LocationFloat = new DevExpress.Utils.PointFloat(539.9999F, 28.75001F);
            this.winControlContainer6.Name = "winControlContainer6";
            this.winControlContainer6.SizeF = new System.Drawing.SizeF(30F, 14F);
            this.winControlContainer6.WinControl = this.labelControl6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Location = new System.Drawing.Point(0, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Articulo";
            // 
            // winControlContainer7
            // 
            this.winControlContainer7.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 10.75001F);
            this.winControlContainer7.Name = "winControlContainer7";
            this.winControlContainer7.SizeF = new System.Drawing.SizeF(38F, 14F);
            this.winControlContainer7.WinControl = this.labelControl7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl8.Location = new System.Drawing.Point(0, 0);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Cantidad";
            // 
            // winControlContainer8
            // 
            this.winControlContainer8.LocationFloat = new DevExpress.Utils.PointFloat(425.4166F, 10.75001F);
            this.winControlContainer8.Name = "winControlContainer8";
            this.winControlContainer8.SizeF = new System.Drawing.SizeF(45F, 14F);
            this.winControlContainer8.WinControl = this.labelControl8;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer6,
            this.winControlContainer3,
            this.winControlContainer4,
            this.winControlContainer5,
            this.winControlContainer2});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 61.45833F;
            this.GroupHeader2.KeepTogether = true;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel9});
            this.PageHeader.HeightF = 66.66666F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(119.7917F, 29.25F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "TECA S.A.";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 37.5F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(270.8333F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "Reporte Solicitudes Realizadas";
            // 
            // rptSolicitud
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.PageHeader});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 91, 100);
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
    }
}
