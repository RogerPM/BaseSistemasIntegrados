namespace forms.Inventario
{
    partial class frmTomaFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTomaFisica));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdcTomaFisica = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Existencia_Sistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Existencia_Fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad_Ajustada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Ajuste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxBodega = new System.Windows.Forms.GroupBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarNroTF = new DevExpress.XtraEditors.SimpleButton();
            this.txtNTomaFisica = new System.Windows.Forms.TextBox();
            this.lblNTomaFisica = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.cbxMotivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsMotivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTipoArticulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsTipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtResponsable = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTomaFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.cbxBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdcTomaFisica);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 176);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            // 
            // gdcTomaFisica
            // 
            this.gdcTomaFisica.Location = new System.Drawing.Point(16, 19);
            this.gdcTomaFisica.MainView = this.gridView1;
            this.gdcTomaFisica.Name = "gdcTomaFisica";
            this.gdcTomaFisica.Size = new System.Drawing.Size(460, 151);
            this.gdcTomaFisica.TabIndex = 0;
            this.gdcTomaFisica.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Articulo,
            this.Existencia_Sistema,
            this.Existencia_Fisica,
            this.Cantidad_Ajustada,
            this.Fecha_Ajuste});
            this.gridView1.GridControl = this.gdcTomaFisica;
            this.gridView1.Name = "gridView1";
            // 
            // Articulo
            // 
            this.Articulo.Caption = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Visible = true;
            this.Articulo.VisibleIndex = 0;
            // 
            // Existencia_Sistema
            // 
            this.Existencia_Sistema.Caption = "Existencia_Sistema";
            this.Existencia_Sistema.Name = "Existencia_Sistema";
            this.Existencia_Sistema.Visible = true;
            this.Existencia_Sistema.VisibleIndex = 1;
            // 
            // Existencia_Fisica
            // 
            this.Existencia_Fisica.Caption = "Existencia_Fisica";
            this.Existencia_Fisica.Name = "Existencia_Fisica";
            this.Existencia_Fisica.Visible = true;
            this.Existencia_Fisica.VisibleIndex = 2;
            // 
            // Cantidad_Ajustada
            // 
            this.Cantidad_Ajustada.Caption = "Cantidad Ajustada";
            this.Cantidad_Ajustada.Name = "Cantidad_Ajustada";
            this.Cantidad_Ajustada.Visible = true;
            this.Cantidad_Ajustada.VisibleIndex = 3;
            // 
            // Fecha_Ajuste
            // 
            this.Fecha_Ajuste.Caption = "Fecha de Ajuste";
            this.Fecha_Ajuste.Name = "Fecha_Ajuste";
            this.Fecha_Ajuste.Visible = true;
            this.Fecha_Ajuste.VisibleIndex = 4;
            // 
            // cbxBodega
            // 
            this.cbxBodega.Controls.Add(this.dateEdit1);
            this.cbxBodega.Controls.Add(this.labelControl2);
            this.cbxBodega.Controls.Add(this.labelControl1);
            this.cbxBodega.Controls.Add(this.label4);
            this.cbxBodega.Controls.Add(this.label2);
            this.cbxBodega.Controls.Add(this.label1);
            this.cbxBodega.Controls.Add(this.btnBuscarNroTF);
            this.cbxBodega.Controls.Add(this.txtNTomaFisica);
            this.cbxBodega.Controls.Add(this.lblNTomaFisica);
            this.cbxBodega.Controls.Add(this.cbxMotivo);
            this.cbxBodega.Controls.Add(this.cbxTipoArticulo);
            this.cbxBodega.Controls.Add(this.comboBoxEdit2);
            this.cbxBodega.Controls.Add(this.txtResponsable);
            this.cbxBodega.Location = new System.Drawing.Point(12, 28);
            this.cbxBodega.Name = "cbxBodega";
            this.cbxBodega.Size = new System.Drawing.Size(476, 152);
            this.cbxBodega.TabIndex = 107;
            this.cbxBodega.TabStop = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(296, 28);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(150, 20);
            this.dateEdit1.TabIndex = 112;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(252, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 111;
            this.labelControl2.Text = "Fecha:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 109;
            this.labelControl1.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tipo de Articulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Bodega: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Motivo: ";
            // 
            // btnBuscarNroTF
            // 
            this.btnBuscarNroTF.Location = new System.Drawing.Point(184, 28);
            this.btnBuscarNroTF.Name = "btnBuscarNroTF";
            this.btnBuscarNroTF.Size = new System.Drawing.Size(33, 20);
            this.btnBuscarNroTF.TabIndex = 100;
            this.btnBuscarNroTF.Text = "....";
            // 
            // txtNTomaFisica
            // 
            this.txtNTomaFisica.Location = new System.Drawing.Point(109, 28);
            this.txtNTomaFisica.Name = "txtNTomaFisica";
            this.txtNTomaFisica.Size = new System.Drawing.Size(69, 20);
            this.txtNTomaFisica.TabIndex = 99;
            // 
            // lblNTomaFisica
            // 
            this.lblNTomaFisica.AutoSize = true;
            this.lblNTomaFisica.Location = new System.Drawing.Point(13, 31);
            this.lblNTomaFisica.Name = "lblNTomaFisica";
            this.lblNTomaFisica.Size = new System.Drawing.Size(90, 13);
            this.lblNTomaFisica.TabIndex = 98;
            this.lblNTomaFisica.Text = " No. Toma Fisica ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 106;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Nuevo";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton5.Text = "Guardar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton3.Text = "Modificar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton4.Text = "Salir";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.Location = new System.Drawing.Point(109, 54);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMotivo.Properties.DataSource = this.clsMotivoBindingSource;
            this.cbxMotivo.Properties.DisplayMember = "descripcion";
            this.cbxMotivo.Properties.NullText = "";
            this.cbxMotivo.Properties.PopupSizeable = false;
            this.cbxMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxMotivo.Properties.ValueMember = "codigo";
            this.cbxMotivo.Properties.View = this.gridLookUpEdit1View;
            this.cbxMotivo.Size = new System.Drawing.Size(337, 20);
            this.cbxMotivo.TabIndex = 108;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clsMotivoBindingSource
            // 
            this.clsMotivoBindingSource.DataSource = typeof(clases.Inventario.clsMotivo);
            // 
            // cbxTipoArticulo
            // 
            this.cbxTipoArticulo.Location = new System.Drawing.Point(109, 85);
            this.cbxTipoArticulo.Name = "cbxTipoArticulo";
            this.cbxTipoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTipoArticulo.Properties.DataSource = this.clsTipoArticuloBindingSource;
            this.cbxTipoArticulo.Properties.DisplayMember = "descripcion";
            this.cbxTipoArticulo.Properties.NullText = "";
            this.cbxTipoArticulo.Properties.PopupSizeable = false;
            this.cbxTipoArticulo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxTipoArticulo.Properties.ValueMember = "codigo";
            this.cbxTipoArticulo.Properties.View = this.gridView2;
            this.cbxTipoArticulo.Size = new System.Drawing.Size(108, 20);
            this.cbxTipoArticulo.TabIndex = 106;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // clsTipoArticuloBindingSource
            // 
            this.clsTipoArticuloBindingSource.DataSource = typeof(clases.Inventario.clsTipoArticulo);
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(296, 85);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.DataSource = this.clsBodegaBindingSource;
            this.comboBoxEdit2.Properties.DisplayMember = "descripcion";
            this.comboBoxEdit2.Properties.NullText = "";
            this.comboBoxEdit2.Properties.PopupSizeable = false;
            this.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.comboBoxEdit2.Properties.ValueMember = "codigo";
            this.comboBoxEdit2.Properties.View = this.gridView3;
            this.comboBoxEdit2.Size = new System.Drawing.Size(150, 20);
            this.comboBoxEdit2.TabIndex = 107;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // clsBodegaBindingSource
            // 
            this.clsBodegaBindingSource.DataSource = typeof(clases.Inventario.clsBodega);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(109, 123);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(337, 20);
            this.txtResponsable.TabIndex = 110;
            // 
            // frmTomaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxBodega);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTomaFisica";
            this.Text = "frmTomaFisica";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcTomaFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.cbxBodega.ResumeLayout(false);
            this.cbxBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gdcTomaFisica;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn Existencia_Sistema;
        private DevExpress.XtraGrid.Columns.GridColumn Existencia_Fisica;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad_Ajustada;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Ajuste;
        internal System.Windows.Forms.GroupBox cbxBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBuscarNroTF;
        private System.Windows.Forms.TextBox txtNTomaFisica;
        private System.Windows.Forms.Label lblNTomaFisica;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMotivo;
        private System.Windows.Forms.BindingSource clsMotivoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cbxTipoArticulo;
        private System.Windows.Forms.BindingSource clsTipoArticuloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit comboBoxEdit2;
        private System.Windows.Forms.BindingSource clsBodegaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit txtResponsable;
    }
}