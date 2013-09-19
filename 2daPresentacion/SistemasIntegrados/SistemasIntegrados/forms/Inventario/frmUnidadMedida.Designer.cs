namespace forms.Inventario
{
    partial class frmUnidadMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidadMedida));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConsultaUnidadMedida = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoUnidadMedida = new System.Windows.Forms.TextBox();
            this.txt_DescripcionUnidadMedida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_EstadoUnidadMedida = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevaUnidadMedida = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarUnidadMedida = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarUnidadMedida = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_SalirUnidadMedida = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoUnidadMedida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_ConsultaUnidadMedida);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_CodigoUnidadMedida);
            this.GroupBox1.Controls.Add(this.txt_DescripcionUnidadMedida);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cbx_EstadoUnidadMedida);
            this.GroupBox1.Location = new System.Drawing.Point(12, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 138);
            this.GroupBox1.TabIndex = 56;
            this.GroupBox1.TabStop = false;
            // 
            // btn_ConsultaUnidadMedida
            // 
            this.btn_ConsultaUnidadMedida.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaUnidadMedida.Name = "btn_ConsultaUnidadMedida";
            this.btn_ConsultaUnidadMedida.Size = new System.Drawing.Size(42, 23);
            this.btn_ConsultaUnidadMedida.TabIndex = 45;
            this.btn_ConsultaUnidadMedida.Text = "...";
            this.btn_ConsultaUnidadMedida.Click += new System.EventHandler(this.btn_ConsultaUnidadMedida_Click_1);
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
            // txt_CodigoUnidadMedida
            // 
            this.txt_CodigoUnidadMedida.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoUnidadMedida.Name = "txt_CodigoUnidadMedida";
            this.txt_CodigoUnidadMedida.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoUnidadMedida.TabIndex = 29;
            // 
            // txt_DescripcionUnidadMedida
            // 
            this.txt_DescripcionUnidadMedida.Location = new System.Drawing.Point(96, 63);
            this.txt_DescripcionUnidadMedida.Multiline = true;
            this.txt_DescripcionUnidadMedida.Name = "txt_DescripcionUnidadMedida";
            this.txt_DescripcionUnidadMedida.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionUnidadMedida.TabIndex = 30;
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
            // cbx_EstadoUnidadMedida
            // 
            this.cbx_EstadoUnidadMedida.Location = new System.Drawing.Point(96, 99);
            this.cbx_EstadoUnidadMedida.Name = "cbx_EstadoUnidadMedida";
            this.cbx_EstadoUnidadMedida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoUnidadMedida.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoUnidadMedida.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoUnidadMedida.Properties.NullText = "";
            this.cbx_EstadoUnidadMedida.Properties.ValueMember = "idEstado";
            this.cbx_EstadoUnidadMedida.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoUnidadMedida.Size = new System.Drawing.Size(134, 20);
            this.cbx_EstadoUnidadMedida.TabIndex = 49;
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
            this.tsb_NuevaUnidadMedida,
            this.tsb_GuardarUnidadMedida,
            this.tsb_ModificarUnidadMedida,
            this.tsbEliminar,
            this.tsb_SalirUnidadMedida});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(354, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevaUnidadMedida
            // 
            this.tsb_NuevaUnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevaUnidadMedida.Image")));
            this.tsb_NuevaUnidadMedida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevaUnidadMedida.Name = "tsb_NuevaUnidadMedida";
            this.tsb_NuevaUnidadMedida.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevaUnidadMedida.Text = "Nuevo";
            this.tsb_NuevaUnidadMedida.Click += new System.EventHandler(this.tsb_NuevaUnidadMedida_Click);
            // 
            // tsb_GuardarUnidadMedida
            // 
            this.tsb_GuardarUnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarUnidadMedida.Image")));
            this.tsb_GuardarUnidadMedida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarUnidadMedida.Name = "tsb_GuardarUnidadMedida";
            this.tsb_GuardarUnidadMedida.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarUnidadMedida.Text = "Guardar";
            this.tsb_GuardarUnidadMedida.Click += new System.EventHandler(this.tsb_GuardarUnidadMedida_Click_1);
            // 
            // tsb_ModificarUnidadMedida
            // 
            this.tsb_ModificarUnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarUnidadMedida.Image")));
            this.tsb_ModificarUnidadMedida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarUnidadMedida.Name = "tsb_ModificarUnidadMedida";
            this.tsb_ModificarUnidadMedida.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarUnidadMedida.Text = "Modificar";
            this.tsb_ModificarUnidadMedida.Click += new System.EventHandler(this.tsb_ModificarUnidadMedida_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsb_SalirUnidadMedida
            // 
            this.tsb_SalirUnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("tsb_SalirUnidadMedida.Image")));
            this.tsb_SalirUnidadMedida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SalirUnidadMedida.Name = "tsb_SalirUnidadMedida";
            this.tsb_SalirUnidadMedida.Size = new System.Drawing.Size(42, 22);
            this.tsb_SalirUnidadMedida.Text = "Salir";
            this.tsb_SalirUnidadMedida.Click += new System.EventHandler(this.tsb_SalirUnidadMedida_Click_1);
            // 
            // frmUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 186);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUnidadMedida";
            this.Text = "frmUnidadMedida";
            this.Load += new System.EventHandler(this.frmUnidadMedida_Load_1);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoUnidadMedida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaUnidadMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoUnidadMedida;
        private System.Windows.Forms.TextBox txt_DescripcionUnidadMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevaUnidadMedida;
        private System.Windows.Forms.ToolStripButton tsb_GuardarUnidadMedida;
        private System.Windows.Forms.ToolStripButton tsb_ModificarUnidadMedida;
        private System.Windows.Forms.ToolStripButton tsb_SalirUnidadMedida;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoUnidadMedida;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}