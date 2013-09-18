namespace forms.Inventario
{
    partial class frmChasis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChasis));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConsultaChasis = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoChasis = new System.Windows.Forms.TextBox();
            this.txt_DescripcionChasis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_EstadoChasis = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevoChasis = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarChasis = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarChasis = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_SalirChasis = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoChasis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_ConsultaChasis);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_CodigoChasis);
            this.GroupBox1.Controls.Add(this.txt_DescripcionChasis);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_EstadoChasis);
            this.GroupBox1.Location = new System.Drawing.Point(12, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 138);
            this.GroupBox1.TabIndex = 56;
            this.GroupBox1.TabStop = false;
            // 
            // btn_ConsultaChasis
            // 
            this.btn_ConsultaChasis.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaChasis.Name = "btn_ConsultaChasis";
            this.btn_ConsultaChasis.Size = new System.Drawing.Size(42, 23);
            this.btn_ConsultaChasis.TabIndex = 45;
            this.btn_ConsultaChasis.Text = "....";
            this.btn_ConsultaChasis.Click += new System.EventHandler(this.btn_ConsultaChasis_Click_2);
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
            // txt_CodigoChasis
            // 
            this.txt_CodigoChasis.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoChasis.Name = "txt_CodigoChasis";
            this.txt_CodigoChasis.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoChasis.TabIndex = 29;
            // 
            // txt_DescripcionChasis
            // 
            this.txt_DescripcionChasis.Location = new System.Drawing.Point(96, 63);
            this.txt_DescripcionChasis.Multiline = true;
            this.txt_DescripcionChasis.Name = "txt_DescripcionChasis";
            this.txt_DescripcionChasis.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionChasis.TabIndex = 30;
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
            // cbx_EstadoChasis
            // 
            this.cbx_EstadoChasis.Location = new System.Drawing.Point(96, 99);
            this.cbx_EstadoChasis.Name = "cbx_EstadoChasis";
            this.cbx_EstadoChasis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoChasis.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoChasis.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoChasis.Properties.NullText = "";
            this.cbx_EstadoChasis.Properties.ValueMember = "idEstado";
            this.cbx_EstadoChasis.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoChasis.Size = new System.Drawing.Size(134, 20);
            this.cbx_EstadoChasis.TabIndex = 49;
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
            this.tsb_NuevoChasis,
            this.tsb_GuardarChasis,
            this.tsb_ModificarChasis,
            this.tsbEliminar,
            this.tsb_SalirChasis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(359, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevoChasis
            // 
            this.tsb_NuevoChasis.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevoChasis.Image")));
            this.tsb_NuevoChasis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevoChasis.Name = "tsb_NuevoChasis";
            this.tsb_NuevoChasis.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevoChasis.Text = "Nuevo";
            this.tsb_NuevoChasis.Click += new System.EventHandler(this.tsb_NuevoChasis_Click);
            // 
            // tsb_GuardarChasis
            // 
            this.tsb_GuardarChasis.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarChasis.Image")));
            this.tsb_GuardarChasis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarChasis.Name = "tsb_GuardarChasis";
            this.tsb_GuardarChasis.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarChasis.Text = "Guardar";
            this.tsb_GuardarChasis.Click += new System.EventHandler(this.tsb_GuardarChasis_Click);
            // 
            // tsb_ModificarChasis
            // 
            this.tsb_ModificarChasis.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarChasis.Image")));
            this.tsb_ModificarChasis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarChasis.Name = "tsb_ModificarChasis";
            this.tsb_ModificarChasis.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarChasis.Text = "Modificar";
            this.tsb_ModificarChasis.Click += new System.EventHandler(this.tsb_ModificarChasis_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsb_SalirChasis
            // 
            this.tsb_SalirChasis.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SalirChasis.Image")));
            this.tsb_SalirChasis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SalirChasis.Name = "tsb_SalirChasis";
            this.tsb_SalirChasis.Size = new System.Drawing.Size(42, 22);
            this.tsb_SalirChasis.Text = "Salir";
            this.tsb_SalirChasis.Click += new System.EventHandler(this.tsb_SalirChasis_Click);
            // 
            // frmChasis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 199);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChasis";
            this.Text = "frmChasis";
            this.Load += new System.EventHandler(this.frmChasis_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoChasis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaChasis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoChasis;
        private System.Windows.Forms.TextBox txt_DescripcionChasis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevoChasis;
        private System.Windows.Forms.ToolStripButton tsb_GuardarChasis;
        private System.Windows.Forms.ToolStripButton tsb_ModificarChasis;
        private System.Windows.Forms.ToolStripButton tsb_SalirChasis;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoChasis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}