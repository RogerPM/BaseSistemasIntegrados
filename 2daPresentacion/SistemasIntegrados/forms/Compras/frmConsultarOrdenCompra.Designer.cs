namespace forms.Compras
{
    partial class frmConsultarOrdenCompra
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
            this.dtgOrdenDet = new DevExpress.XtraGrid.GridControl();
            this.DatosOrdenDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtgOrdenCab = new DevExpress.XtraGrid.GridControl();
            this.DatosOrdenCab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenCab)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOrdenDet
            // 
            this.dtgOrdenDet.Location = new System.Drawing.Point(12, 216);
            this.dtgOrdenDet.MainView = this.DatosOrdenDet;
            this.dtgOrdenDet.Name = "dtgOrdenDet";
            this.dtgOrdenDet.Size = new System.Drawing.Size(619, 173);
            this.dtgOrdenDet.TabIndex = 38;
            this.dtgOrdenDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosOrdenDet});
            // 
            // DatosOrdenDet
            // 
            this.DatosOrdenDet.GridControl = this.dtgOrdenDet;
            this.DatosOrdenDet.Name = "DatosOrdenDet";
            // 
            // dtgOrdenCab
            // 
            this.dtgOrdenCab.Location = new System.Drawing.Point(17, 42);
            this.dtgOrdenCab.MainView = this.DatosOrdenCab;
            this.dtgOrdenCab.Name = "dtgOrdenCab";
            this.dtgOrdenCab.Size = new System.Drawing.Size(614, 150);
            this.dtgOrdenCab.TabIndex = 37;
            this.dtgOrdenCab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosOrdenCab});
            // 
            // DatosOrdenCab
            // 
            this.DatosOrdenCab.GridControl = this.dtgOrdenCab;
            this.DatosOrdenCab.Name = "DatosOrdenCab";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 22);
            this.btnCargar.Text = "Cargar";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            // 
            // frmConsultarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 401);
            this.Controls.Add(this.dtgOrdenDet);
            this.Controls.Add(this.dtgOrdenCab);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarOrdenCompra";
            this.Text = "frmConsultarOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenCab)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgOrdenDet;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosOrdenDet;
        private DevExpress.XtraGrid.GridControl dtgOrdenCab;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosOrdenCab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}