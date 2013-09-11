namespace forms.Contabilidad
{
    partial class FormListaModeloAsientos
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
            this.dtlista = new System.Windows.Forms.DataGridView();
            this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.idTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwTipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTransaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtlista
            // 
            this.dtlista.AllowUserToAddRows = false;
            this.dtlista.AllowUserToDeleteRows = false;
            this.dtlista.AutoGenerateColumns = false;
            this.dtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaccionDataGridViewTextBoxColumn,
            this.modulo,
            this.nombreModuloDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dtlista.DataSource = this.vwTipoTransaccionBindingSource;
            this.dtlista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtlista.Location = new System.Drawing.Point(0, 38);
            this.dtlista.Name = "dtlista";
            this.dtlista.ReadOnly = true;
            this.dtlista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtlista.Size = new System.Drawing.Size(584, 369);
            this.dtlista.TabIndex = 1;
            this.dtlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlista_CellContentClick);
            // 
            // modulo
            // 
            this.modulo.DataPropertyName = "modulo";
            this.modulo.HeaderText = "Id Modulo";
            this.modulo.Name = "modulo";
            this.modulo.ReadOnly = true;
            this.modulo.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 22);
            this.toolStripLabel1.Text = "                                                  ";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::forms.Properties.Resources._24_cancelar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // idTransaccionDataGridViewTextBoxColumn
            // 
            this.idTransaccionDataGridViewTextBoxColumn.DataPropertyName = "IdTransaccion";
            this.idTransaccionDataGridViewTextBoxColumn.FillWeight = 80F;
            this.idTransaccionDataGridViewTextBoxColumn.HeaderText = "Id Transacc";
            this.idTransaccionDataGridViewTextBoxColumn.Name = "idTransaccionDataGridViewTextBoxColumn";
            this.idTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreModuloDataGridViewTextBoxColumn
            // 
            this.nombreModuloDataGridViewTextBoxColumn.DataPropertyName = "NombreModulo";
            this.nombreModuloDataGridViewTextBoxColumn.HeaderText = "Modulo";
            this.nombreModuloDataGridViewTextBoxColumn.Name = "nombreModuloDataGridViewTextBoxColumn";
            this.nombreModuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreModuloDataGridViewTextBoxColumn.Width = 130;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Id Tipo Doc";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 130;
            // 
            // vwTipoTransaccionBindingSource
            // 
            this.vwTipoTransaccionBindingSource.DataSource = typeof(datos.Contabilidad.vwTipoTransaccion);
            // 
            // tipoTransaccionBindingSource1
            // 
            this.tipoTransaccionBindingSource1.DataSource = typeof(datos.Contabilidad.TipoTransaccion);
            // 
            // FormListaModeloAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 407);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtlista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormListaModeloAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de Asientos";
            this.Load += new System.EventHandler(this.FormListaModeloAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtlista;
        private System.Windows.Forms.BindingSource tipoTransaccionBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource tipoTransaccionBindingSource1;
        private System.Windows.Forms.BindingSource vwTipoTransaccionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}