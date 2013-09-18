namespace forms.Inventario
{
    partial class frmTipoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMaterial));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConsultaMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoMaterial = new System.Windows.Forms.TextBox();
            this.txt_DescripcionMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_EstadoMaterial = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevoTipoMaterial = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarTipoMaterial = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarTipoMaterial = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Salir = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_ConsultaMaterial);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_CodigoMaterial);
            this.GroupBox1.Controls.Add(this.txt_DescripcionMaterial);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_EstadoMaterial);
            this.GroupBox1.Location = new System.Drawing.Point(12, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 138);
            this.GroupBox1.TabIndex = 54;
            this.GroupBox1.TabStop = false;
            // 
            // btn_ConsultaMaterial
            // 
            this.btn_ConsultaMaterial.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaMaterial.Name = "btn_ConsultaMaterial";
            this.btn_ConsultaMaterial.Size = new System.Drawing.Size(42, 23);
            this.btn_ConsultaMaterial.TabIndex = 45;
            this.btn_ConsultaMaterial.Text = "...";
            this.btn_ConsultaMaterial.Click += new System.EventHandler(this.btn_ConsultaMaterial_Click_2);
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
            // txt_CodigoMaterial
            // 
            this.txt_CodigoMaterial.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoMaterial.Name = "txt_CodigoMaterial";
            this.txt_CodigoMaterial.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoMaterial.TabIndex = 29;
            // 
            // txt_DescripcionMaterial
            // 
            this.txt_DescripcionMaterial.Location = new System.Drawing.Point(96, 63);
            this.txt_DescripcionMaterial.Multiline = true;
            this.txt_DescripcionMaterial.Name = "txt_DescripcionMaterial";
            this.txt_DescripcionMaterial.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionMaterial.TabIndex = 30;
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
            // cbx_EstadoMaterial
            // 
            this.cbx_EstadoMaterial.Location = new System.Drawing.Point(96, 99);
            this.cbx_EstadoMaterial.Name = "cbx_EstadoMaterial";
            this.cbx_EstadoMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoMaterial.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoMaterial.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoMaterial.Properties.NullText = "";
            this.cbx_EstadoMaterial.Properties.ValueMember = "idEstado";
            this.cbx_EstadoMaterial.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoMaterial.Size = new System.Drawing.Size(134, 20);
            this.cbx_EstadoMaterial.TabIndex = 50;
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
            this.tsb_NuevoTipoMaterial,
            this.tsb_GuardarTipoMaterial,
            this.tsb_ModificarTipoMaterial,
            this.tsbEliminar,
            this.tsb_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 25);
            this.toolStrip1.TabIndex = 53;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevoTipoMaterial
            // 
            this.tsb_NuevoTipoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevoTipoMaterial.Image")));
            this.tsb_NuevoTipoMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevoTipoMaterial.Name = "tsb_NuevoTipoMaterial";
            this.tsb_NuevoTipoMaterial.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevoTipoMaterial.Text = "Nuevo";
            // 
            // tsb_GuardarTipoMaterial
            // 
            this.tsb_GuardarTipoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarTipoMaterial.Image")));
            this.tsb_GuardarTipoMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarTipoMaterial.Name = "tsb_GuardarTipoMaterial";
            this.tsb_GuardarTipoMaterial.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarTipoMaterial.Text = "Guardar";
            this.tsb_GuardarTipoMaterial.Click += new System.EventHandler(this.tsb_GuardarTipoMaterial_Click_2);
            // 
            // tsb_ModificarTipoMaterial
            // 
            this.tsb_ModificarTipoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarTipoMaterial.Image")));
            this.tsb_ModificarTipoMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarTipoMaterial.Name = "tsb_ModificarTipoMaterial";
            this.tsb_ModificarTipoMaterial.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarTipoMaterial.Text = "Modificar";
            this.tsb_ModificarTipoMaterial.Click += new System.EventHandler(this.tsb_ModificarTipoMaterial_Click_2);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsb_Salir
            // 
            this.tsb_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Salir.Image")));
            this.tsb_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Salir.Name = "tsb_Salir";
            this.tsb_Salir.Size = new System.Drawing.Size(42, 22);
            this.tsb_Salir.Text = "Salir";
            this.tsb_Salir.Click += new System.EventHandler(this.tsb_Salir_Click_2);
            // 
            // frmTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 195);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTipoMaterial";
            this.Text = "frmTipoMaterial";
            this.Load += new System.EventHandler(this.frmTipoMaterial_Load_1);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoMaterial;
        private System.Windows.Forms.TextBox txt_DescripcionMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevoTipoMaterial;
        private System.Windows.Forms.ToolStripButton tsb_GuardarTipoMaterial;
        private System.Windows.Forms.ToolStripButton tsb_ModificarTipoMaterial;
        private System.Windows.Forms.ToolStripButton tsb_Salir;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoMaterial;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}