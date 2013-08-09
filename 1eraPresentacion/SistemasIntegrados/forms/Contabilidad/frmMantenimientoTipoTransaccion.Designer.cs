namespace forms.Contabilidad
{
    partial class frmMantenimientoTipoTransaccion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.combo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsModuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsModuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsModuloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(461, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(43, 22);
            this.btnGuardar.Text = "OK";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id Transaccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descripcion";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(186, 49);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "n3";
            this.textEdit1.Size = new System.Drawing.Size(120, 20);
            this.textEdit1.TabIndex = 38;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(186, 132);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(184, 20);
            this.textEdit3.TabIndex = 40;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(186, 176);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(223, 63);
            this.textEdit4.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Modulo";
            // 
            // combo
            // 
            this.combo.Location = new System.Drawing.Point(186, 91);
            this.combo.Name = "combo";
            this.combo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo.Properties.DataSource = this.clsModuloBindingSource1;
            this.combo.Properties.DisplayMember = "IdModulo";
            this.combo.Properties.ValueMember = "Nombre";
            this.combo.Properties.View = this.gridLookUpEdit1View;
            this.combo.Size = new System.Drawing.Size(152, 20);
            this.combo.TabIndex = 43;
            this.combo.EditValueChanged += new System.EventHandler(this.combo_EditValueChanged);
            // 
            // clsModuloBindingSource1
            // 
            this.clsModuloBindingSource1.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clsModuloBindingSource
            // 
            this.clsModuloBindingSource.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // moduloBindingSource
            // 
            this.moduloBindingSource.DataSource = typeof(datos.Seguridad.Modulo);
            // 
            // clsModuloBindingSource2
            // 
            this.clsModuloBindingSource2.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // frmMantenimientoTipoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 358);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textEdit4);
            this.Name = "frmMantenimientoTipoTransaccion";
            this.Text = "frmMantenimientoTipoTransaccion";
            this.Load += new System.EventHandler(this.frmMantenimientoTipoTransaccion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.MemoEdit textEdit4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit combo;
        private System.Windows.Forms.BindingSource moduloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource clsModuloBindingSource;
        private System.Windows.Forms.BindingSource clsModuloBindingSource1;
        private System.Windows.Forms.BindingSource clsModuloBindingSource2;
    }
}