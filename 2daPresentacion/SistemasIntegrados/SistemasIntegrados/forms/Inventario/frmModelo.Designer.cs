namespace forms.Inventario
{
    partial class frmModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelo));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DescripcionModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoArticulo = new System.Windows.Forms.Label();
            this.btn_ConsultaModelo = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CodigoModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_EstadoModelo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxMarca = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_NuevoModelo = new System.Windows.Forms.ToolStripButton();
            this.tsb_GuardarModelo = new System.Windows.Forms.ToolStripButton();
            this.tsb_ModificarModelo = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Salir = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txt_DescripcionModelo);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.lblTipoArticulo);
            this.GroupBox1.Controls.Add(this.btn_ConsultaModelo);
            this.GroupBox1.Controls.Add(this.txt_CodigoModelo);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.cbx_EstadoModelo);
            this.GroupBox1.Controls.Add(this.cbxMarca);
            this.GroupBox1.Location = new System.Drawing.Point(12, 40);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 170);
            this.GroupBox1.TabIndex = 55;
            this.GroupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Estado:";
            // 
            // txt_DescripcionModelo
            // 
            this.txt_DescripcionModelo.Location = new System.Drawing.Point(97, 97);
            this.txt_DescripcionModelo.Multiline = true;
            this.txt_DescripcionModelo.Name = "txt_DescripcionModelo";
            this.txt_DescripcionModelo.Size = new System.Drawing.Size(215, 30);
            this.txt_DescripcionModelo.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Descripcion:";
            // 
            // lblTipoArticulo
            // 
            this.lblTipoArticulo.AutoSize = true;
            this.lblTipoArticulo.Location = new System.Drawing.Point(17, 69);
            this.lblTipoArticulo.Name = "lblTipoArticulo";
            this.lblTipoArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblTipoArticulo.TabIndex = 50;
            this.lblTipoArticulo.Text = "Marca:";
            // 
            // btn_ConsultaModelo
            // 
            this.btn_ConsultaModelo.Location = new System.Drawing.Point(188, 26);
            this.btn_ConsultaModelo.Name = "btn_ConsultaModelo";
            this.btn_ConsultaModelo.Size = new System.Drawing.Size(39, 23);
            this.btn_ConsultaModelo.TabIndex = 45;
            this.btn_ConsultaModelo.Text = "...";
            this.btn_ConsultaModelo.Click += new System.EventHandler(this.btn_ConsultaModelo_Click_2);
            // 
            // txt_CodigoModelo
            // 
            this.txt_CodigoModelo.Location = new System.Drawing.Point(96, 29);
            this.txt_CodigoModelo.Name = "txt_CodigoModelo";
            this.txt_CodigoModelo.Size = new System.Drawing.Size(83, 20);
            this.txt_CodigoModelo.TabIndex = 29;
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
            // cbx_EstadoModelo
            // 
            this.cbx_EstadoModelo.Location = new System.Drawing.Point(97, 133);
            this.cbx_EstadoModelo.Name = "cbx_EstadoModelo";
            this.cbx_EstadoModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_EstadoModelo.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbx_EstadoModelo.Properties.DisplayMember = "descripcion";
            this.cbx_EstadoModelo.Properties.NullText = "";
            this.cbx_EstadoModelo.Properties.PopupSizeable = false;
            this.cbx_EstadoModelo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_EstadoModelo.Properties.ValueMember = "idEstado";
            this.cbx_EstadoModelo.Properties.View = this.gridLookUpEdit1View;
            this.cbx_EstadoModelo.Size = new System.Drawing.Size(134, 20);
            this.cbx_EstadoModelo.TabIndex = 56;
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
            // cbxMarca
            // 
            this.cbxMarca.Location = new System.Drawing.Point(97, 66);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMarca.Properties.DataSource = this.clsMarcaBindingSource;
            this.cbxMarca.Properties.DisplayMember = "descripcion";
            this.cbxMarca.Properties.NullText = "";
            this.cbxMarca.Properties.PopupSizeable = false;
            this.cbxMarca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxMarca.Properties.ValueMember = "codigo";
            this.cbxMarca.Properties.View = this.gridView1;
            this.cbxMarca.Size = new System.Drawing.Size(215, 20);
            this.cbxMarca.TabIndex = 57;
            // 
            // clsMarcaBindingSource
            // 
            this.clsMarcaBindingSource.DataSource = typeof(clases.Inventario.clsMarca);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_NuevoModelo,
            this.tsb_GuardarModelo,
            this.tsb_ModificarModelo,
            this.tsbEliminar,
            this.tsb_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_NuevoModelo
            // 
            this.tsb_NuevoModelo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NuevoModelo.Image")));
            this.tsb_NuevoModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NuevoModelo.Name = "tsb_NuevoModelo";
            this.tsb_NuevoModelo.Size = new System.Drawing.Size(51, 22);
            this.tsb_NuevoModelo.Text = "Nuevo";
            this.tsb_NuevoModelo.Click += new System.EventHandler(this.tsb_NuevoModelo_Click);
            // 
            // tsb_GuardarModelo
            // 
            this.tsb_GuardarModelo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GuardarModelo.Image")));
            this.tsb_GuardarModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GuardarModelo.Name = "tsb_GuardarModelo";
            this.tsb_GuardarModelo.Size = new System.Drawing.Size(57, 22);
            this.tsb_GuardarModelo.Text = "Guardar";
            this.tsb_GuardarModelo.Click += new System.EventHandler(this.tsb_GuardarModelo_Click_1);
            // 
            // tsb_ModificarModelo
            // 
            this.tsb_ModificarModelo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ModificarModelo.Image")));
            this.tsb_ModificarModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ModificarModelo.Name = "tsb_ModificarModelo";
            this.tsb_ModificarModelo.Size = new System.Drawing.Size(62, 22);
            this.tsb_ModificarModelo.Text = "Modificar";
            this.tsb_ModificarModelo.Click += new System.EventHandler(this.tsb_ModificarModelo_Click_2);
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
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 227);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmModelo";
            this.Text = "frmModelo";
            this.Load += new System.EventHandler(this.frmModelo_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_EstadoModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DescripcionModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btn_ConsultaModelo;
        private System.Windows.Forms.TextBox txt_CodigoModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_NuevoModelo;
        private System.Windows.Forms.ToolStripButton tsb_GuardarModelo;
        private System.Windows.Forms.ToolStripButton tsb_ModificarModelo;
        private System.Windows.Forms.ToolStripButton tsb_Salir;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_EstadoModelo;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMarca;
        private System.Windows.Forms.BindingSource clsMarcaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}