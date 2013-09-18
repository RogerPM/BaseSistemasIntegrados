namespace forms.Inventario
{
    partial class frmTransferenciaBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferenciaBodega));
            this.btnBuscarTransferencia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad_Transferir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.cbxOrigen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxDestino = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxResponsable = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxMotivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMotivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarTransferencia
            // 
            this.btnBuscarTransferencia.Location = new System.Drawing.Point(170, 48);
            this.btnBuscarTransferencia.Name = "btnBuscarTransferencia";
            this.btnBuscarTransferencia.Size = new System.Drawing.Size(30, 19);
            this.btnBuscarTransferencia.TabIndex = 111;
            this.btnBuscarTransferencia.Text = "...";
            this.btnBuscarTransferencia.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Motivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Responsable";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Transferencia No.- ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Bodega Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Bodega Origen:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(28, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(483, 176);
            this.gridControl1.TabIndex = 115;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Articulo,
            this.Tipo_Articulo,
            this.Cantidad_Transferir,
            this.Detalle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Articulo
            // 
            this.Articulo.Caption = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Visible = true;
            this.Articulo.VisibleIndex = 0;
            // 
            // Tipo_Articulo
            // 
            this.Tipo_Articulo.Caption = "Tipo de Articulo";
            this.Tipo_Articulo.Name = "Tipo_Articulo";
            this.Tipo_Articulo.Visible = true;
            this.Tipo_Articulo.VisibleIndex = 1;
            // 
            // Cantidad_Transferir
            // 
            this.Cantidad_Transferir.Caption = "Cantidad a Transferir";
            this.Cantidad_Transferir.Name = "Cantidad_Transferir";
            this.Cantidad_Transferir.Visible = true;
            this.Cantidad_Transferir.VisibleIndex = 2;
            // 
            // Detalle
            // 
            this.Detalle.Caption = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Visible = true;
            this.Detalle.VisibleIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(542, 25);
            this.toolStrip1.TabIndex = 116;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Nuevo";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton5.Text = "Guardar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton3.Text = "Modificar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton4.Text = "Salir";
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = null;
            this.dtpFecha.Location = new System.Drawing.Point(334, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFecha.Size = new System.Drawing.Size(177, 20);
            this.dtpFecha.TabIndex = 120;
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.Location = new System.Drawing.Point(117, 73);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxOrigen.Properties.DataSource = this.clsBodegaBindingSource;
            this.cbxOrigen.Properties.DisplayMember = "descripcion";
            this.cbxOrigen.Properties.NullText = "";
            this.cbxOrigen.Properties.PopupSizeable = false;
            this.cbxOrigen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxOrigen.Properties.ValueMember = "codigo";
            this.cbxOrigen.Properties.View = this.gridLookUpEdit1View;
            this.cbxOrigen.Size = new System.Drawing.Size(157, 20);
            this.cbxOrigen.TabIndex = 117;
            // 
            // clsBodegaBindingSource
            // 
            this.clsBodegaBindingSource.DataSource = typeof(clases.Inventario.clsBodega);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbxDestino
            // 
            this.cbxDestino.Location = new System.Drawing.Point(117, 103);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDestino.Properties.DataSource = this.clsBodegaBindingSource;
            this.cbxDestino.Properties.DisplayMember = "descripcion";
            this.cbxDestino.Properties.NullText = "";
            this.cbxDestino.Properties.PopupSizeable = false;
            this.cbxDestino.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxDestino.Properties.ValueMember = "codigo";
            this.cbxDestino.Properties.View = this.gridView2;
            this.cbxDestino.Size = new System.Drawing.Size(157, 20);
            this.cbxDestino.TabIndex = 118;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.Location = new System.Drawing.Point(117, 131);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxResponsable.Properties.DataSource = this.clsPersonaBindingSource;
            this.cbxResponsable.Properties.DisplayMember = "NombreRazonSocial";
            this.cbxResponsable.Properties.NullText = "";
            this.cbxResponsable.Properties.PopupSizeable = false;
            this.cbxResponsable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxResponsable.Properties.ValueMember = "IdPersona";
            this.cbxResponsable.Properties.View = this.gridView3;
            this.cbxResponsable.Size = new System.Drawing.Size(157, 20);
            this.cbxResponsable.TabIndex = 119;
            // 
            // clsPersonaBindingSource
            // 
            this.clsPersonaBindingSource.DataSource = typeof(clases.RecursosHumanos.clsPersona);
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Location = new System.Drawing.Point(334, 103);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.NullText = "";
            this.cbxEstado.Properties.PopupSizeable = false;
            this.cbxEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxEstado.Properties.ValueMember = "codigo";
            this.cbxEstado.Properties.View = this.gridView4;
            this.cbxEstado.Size = new System.Drawing.Size(177, 20);
            this.cbxEstado.TabIndex = 121;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.Location = new System.Drawing.Point(333, 131);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMotivo.Properties.DataSource = this.clsMotivoBindingSource;
            this.cbxMotivo.Properties.DisplayMember = "descripcion";
            this.cbxMotivo.Properties.NullText = "";
            this.cbxMotivo.Properties.PopupSizeable = false;
            this.cbxMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxMotivo.Properties.ValueMember = "codigo";
            this.cbxMotivo.Properties.View = this.gridView5;
            this.cbxMotivo.Size = new System.Drawing.Size(178, 20);
            this.cbxMotivo.TabIndex = 122;
            // 
            // clsMotivoBindingSource
            // 
            this.clsMotivoBindingSource.DataSource = typeof(clases.Inventario.clsMotivo);
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // frmTransferenciaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 357);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnBuscarTransferencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxResponsable);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxMotivo);
            this.Name = "frmTransferenciaBodega";
            this.Text = "frmTransferenciaBodega";
            this.Load += new System.EventHandler(this.frmTransferenciaBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarTransferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo_Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad_Transferir;
        private DevExpress.XtraGrid.Columns.GridColumn Detalle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraEditors.GridLookUpEdit cbxOrigen;
        private System.Windows.Forms.BindingSource clsBodegaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cbxDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cbxResponsable;
        private System.Windows.Forms.BindingSource clsPersonaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMotivo;
        private System.Windows.Forms.BindingSource clsMotivoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
    }
}