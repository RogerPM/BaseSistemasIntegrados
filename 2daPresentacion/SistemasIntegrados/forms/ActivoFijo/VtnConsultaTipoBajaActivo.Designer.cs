namespace forms.ActivoFijo
{
    partial class VtnConsultaTipoBajaActivo
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
            this.gridConsultaTipoBajaActivo = new DevExpress.XtraGrid.GridControl();
            this.clsMotivoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidMotivoBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTipoBajaActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsultaTipoBajaActivo
            // 
            this.gridConsultaTipoBajaActivo.DataSource = this.clsMotivoBajaBindingSource;
            this.gridConsultaTipoBajaActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaTipoBajaActivo.Location = new System.Drawing.Point(0, 0);
            this.gridConsultaTipoBajaActivo.MainView = this.gridView1;
            this.gridConsultaTipoBajaActivo.Name = "gridConsultaTipoBajaActivo";
            this.gridConsultaTipoBajaActivo.Size = new System.Drawing.Size(607, 321);
            this.gridConsultaTipoBajaActivo.TabIndex = 0;
            this.gridConsultaTipoBajaActivo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsMotivoBajaBindingSource
            // 
            this.clsMotivoBajaBindingSource.DataSource = typeof(clases.ActivoFijo.clsMotivoBaja);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidMotivoBaja,
            this.coldescripcion,
            this.colidEstado});
            this.gridView1.GridControl = this.gridConsultaTipoBajaActivo;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            // 
            // colidMotivoBaja
            // 
            this.colidMotivoBaja.FieldName = "idMotivoBaja";
            this.colidMotivoBaja.Name = "colidMotivoBaja";
            this.colidMotivoBaja.Visible = true;
            this.colidMotivoBaja.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 301;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(505, 22);
            this.tslEnBlanco.Text = "                                                                                 " +
                "                                                                                " +
                "     ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // VtnConsultaTipoBajaActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridConsultaTipoBajaActivo);
            this.Name = "VtnConsultaTipoBajaActivo";
            this.Text = "VtnConsultaTipoBajaActivo";
            this.Load += new System.EventHandler(this.VtnConsultaTipoBajaActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTipoBajaActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsultaTipoBajaActivo;
        private System.Windows.Forms.BindingSource clsMotivoBajaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidMotivoBaja;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;


    }
}