namespace forms.Inventario
{
    partial class frmTipoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoCombustible));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConsultaTipoCombustible = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoCombustible = new System.Windows.Forms.TextBox();
            this.txt_DescripcionTipoCombustible = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_EstadoTipoCombustible = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevoTipoCombustible = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarTipoCombustible = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarTipoCombustible = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_SalirTipoCombustible = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoTipoCombustible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_ConsultaTipoCombustible);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_CodigoCombustible);
            this.GroupBox1.Controls.Add(this.txt_DescripcionTipoCombustible);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_EstadoTipoCombustible);
            this.GroupBox1.Location = new System.Drawing.Point(12, 38);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 138);
            this.GroupBox1.TabIndex = 58;
            this.GroupBox1.TabStop = false;
            // 
            // btn_ConsultaTipoCombustible
            // 
            this.btn_ConsultaTipoCombustible.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaTipoCombustible.Name = "btn_ConsultaTipoCombustible";
            this.btn_ConsultaTipoCombustible.Size = new System.Drawing.Size(31, 23);
            this.btn_ConsultaTipoCombustible.TabIndex = 45;
            this.btn_ConsultaTipoCombustible.Text = "...";
            this.btn_ConsultaTipoCombustible.Click += new System.EventHandler(this.btn_ConsultaTipoCombustible_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Estado:";
            // 
            // txt_CodigoCombustible
            // 
            this.txt_CodigoCombustible.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoCombustible.Name = "txt_CodigoCombustible";
            this.txt_CodigoCombustible.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoCombustible.TabIndex = 29;
            // 
            // txt_DescripcionTipoCombustible
            // 
            this.txt_DescripcionTipoCombustible.Location = new System.Drawing.Point(96, 63);
            this.txt_DescripcionTipoCombustible.Multiline = true;
            this.txt_DescripcionTipoCombustible.Name = "txt_DescripcionTipoCombustible";
            this.txt_DescripcionTipoCombustible.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionTipoCombustible.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripcion:";
            // 
            // cbx_EstadoTipoCombustible
            // 
            this.cbx_EstadoTipoCombustible.Location = new System.Drawing.Point(96, 99);
            this.cbx_EstadoTipoCombustible.Name = "cbx_EstadoTipoCombustible";
            this.cbx_EstadoTipoCombustible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoTipoCombustible.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoTipoCombustible.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoTipoCombustible.Properties.NullText = "";
            this.cbx_EstadoTipoCombustible.Properties.ValueMember = "idEstado";
            this.cbx_EstadoTipoCombustible.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoTipoCombustible.Size = new System.Drawing.Size(134, 20);
            this.cbx_EstadoTipoCombustible.TabIndex = 50;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_NuevoTipoCombustible,
            this.tsb_GuardarTipoCombustible,
            this.tsb_ModificarTipoCombustible,
            this.tsbEliminar,
            this.tsb_SalirTipoCombustible});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(364, 25);
            this.toolStrip1.TabIndex = 57;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevoTipoCombustible
            // 
            this.tsb_NuevoTipoCombustible.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevoTipoCombustible.Image")));
            this.tsb_NuevoTipoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevoTipoCombustible.Name = "tsb_NuevoTipoCombustible";
            this.tsb_NuevoTipoCombustible.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevoTipoCombustible.Text = "Nuevo";
            this.tsb_NuevoTipoCombustible.Click += new System.EventHandler(this.tsb_NuevoTipoCombustible_Click);
            // 
            // tsb_GuardarTipoCombustible
            // 
            this.tsb_GuardarTipoCombustible.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarTipoCombustible.Image")));
            this.tsb_GuardarTipoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarTipoCombustible.Name = "tsb_GuardarTipoCombustible";
            this.tsb_GuardarTipoCombustible.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarTipoCombustible.Text = "Guardar";
            this.tsb_GuardarTipoCombustible.Click += new System.EventHandler(this.tsb_GuardarTipoCombustible_Click);
            // 
            // tsb_ModificarTipoCombustible
            // 
            this.tsb_ModificarTipoCombustible.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarTipoCombustible.Image")));
            this.tsb_ModificarTipoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarTipoCombustible.Name = "tsb_ModificarTipoCombustible";
            this.tsb_ModificarTipoCombustible.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarTipoCombustible.Text = "Modificar";
            this.tsb_ModificarTipoCombustible.Click += new System.EventHandler(this.tsb_ModificarTipoCombustible_Click_2);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsb_SalirTipoCombustible
            // 
            this.tsb_SalirTipoCombustible.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SalirTipoCombustible.Image")));
            this.tsb_SalirTipoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SalirTipoCombustible.Name = "tsb_SalirTipoCombustible";
            this.tsb_SalirTipoCombustible.Size = new System.Drawing.Size(42, 22);
            this.tsb_SalirTipoCombustible.Text = "Salir";
            this.tsb_SalirTipoCombustible.Click += new System.EventHandler(this.tsb_SalirTipoCombustible_Click_1);
            // 
            // frmTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 191);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTipoCombustible";
            this.Text = "frmTipoCombustible";
            this.Load += new System.EventHandler(this.frmTipoCombustible_Load_1);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoTipoCombustible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaTipoCombustible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoCombustible;
        private System.Windows.Forms.TextBox txt_DescripcionTipoCombustible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevoTipoCombustible;
        private System.Windows.Forms.ToolStripButton tsb_GuardarTipoCombustible;
        private System.Windows.Forms.ToolStripButton tsb_ModificarTipoCombustible;
        private System.Windows.Forms.ToolStripButton tsb_SalirTipoCombustible;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoTipoCombustible;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}