namespace forms.Inventario
{
    partial class frmColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColor));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConsultaColor = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoColor = new System.Windows.Forms.TextBox();
            this.txt_DescripcionColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_EstadoColor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevoColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarColor = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_SalirColor = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_ConsultaColor);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_CodigoColor);
            this.GroupBox1.Controls.Add(this.txt_DescripcionColor);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_EstadoColor);
            this.GroupBox1.Location = new System.Drawing.Point(12, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 138);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            // 
            // btn_ConsultaColor
            // 
            this.btn_ConsultaColor.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaColor.Name = "btn_ConsultaColor";
            this.btn_ConsultaColor.Size = new System.Drawing.Size(35, 23);
            this.btn_ConsultaColor.TabIndex = 45;
            this.btn_ConsultaColor.Text = "...";
            this.btn_ConsultaColor.Click += new System.EventHandler(this.btn_ConsultaColor_Click_2);
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
            // txt_CodigoColor
            // 
            this.txt_CodigoColor.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoColor.Name = "txt_CodigoColor";
            this.txt_CodigoColor.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoColor.TabIndex = 29;
            // 
            // txt_DescripcionColor
            // 
            this.txt_DescripcionColor.Location = new System.Drawing.Point(96, 63);
            this.txt_DescripcionColor.Multiline = true;
            this.txt_DescripcionColor.Name = "txt_DescripcionColor";
            this.txt_DescripcionColor.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionColor.TabIndex = 30;
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
            // cbx_EstadoColor
            // 
            this.cbx_EstadoColor.Location = new System.Drawing.Point(96, 97);
            this.cbx_EstadoColor.Name = "cbx_EstadoColor";
            this.cbx_EstadoColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoColor.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoColor.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoColor.Properties.NullText = "";
            this.cbx_EstadoColor.Properties.PopupSizeable = false;
            this.cbx_EstadoColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_EstadoColor.Properties.ValueMember = "idEstado";
            this.cbx_EstadoColor.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoColor.Size = new System.Drawing.Size(215, 20);
            this.cbx_EstadoColor.TabIndex = 46;
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
            this.tsb_NuevoColor,
            this.tsb_GuardarColor,
            this.tsb_ModificarColor,
            this.tsbEliminar,
            this.tsb_SalirColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 25);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevoColor
            // 
            this.tsb_NuevoColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevoColor.Image")));
            this.tsb_NuevoColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevoColor.Name = "tsb_NuevoColor";
            this.tsb_NuevoColor.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevoColor.Text = "Nuevo";
            this.tsb_NuevoColor.Click += new System.EventHandler(this.tsb_NuevoColor_Click);
            // 
            // tsb_GuardarColor
            // 
            this.tsb_GuardarColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarColor.Image")));
            this.tsb_GuardarColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarColor.Name = "tsb_GuardarColor";
            this.tsb_GuardarColor.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarColor.Text = "Guardar";
            this.tsb_GuardarColor.Click += new System.EventHandler(this.tsb_GuardarColor_Click_1);
            // 
            // tsb_ModificarColor
            // 
            this.tsb_ModificarColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarColor.Image")));
            this.tsb_ModificarColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarColor.Name = "tsb_ModificarColor";
            this.tsb_ModificarColor.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarColor.Text = "Modificar";
            this.tsb_ModificarColor.Click += new System.EventHandler(this.tsb_ModificarColor_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsb_SalirColor
            // 
            this.tsb_SalirColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SalirColor.Image")));
            this.tsb_SalirColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SalirColor.Name = "tsb_SalirColor";
            this.tsb_SalirColor.Size = new System.Drawing.Size(42, 22);
            this.tsb_SalirColor.Text = "Salir";
            this.tsb_SalirColor.Click += new System.EventHandler(this.tsb_SalirColor_Click_1);
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 195);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.Load += new System.EventHandler(this.frmColor_Load_1);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoColor;
        private System.Windows.Forms.TextBox txt_DescripcionColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevoColor;
        private System.Windows.Forms.ToolStripButton tsb_GuardarColor;
        private System.Windows.Forms.ToolStripButton tsb_ModificarColor;
        private System.Windows.Forms.ToolStripButton tsb_SalirColor;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoColor;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}