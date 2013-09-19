
namespace forms.ActivoFijo
{
    partial class mntTipoBaja
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
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoBajaActivo = new DevExpress.XtraEditors.TextEdit();
            this.clsMotivoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txtnum = new DevExpress.XtraEditors.TextEdit();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBajaActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 282;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(29, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 281;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(508, 25);
            this.toolStrip1.TabIndex = 321;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(127, 22);
            this.tslEnBlanco.Text = "                                        ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_2);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 17);
            this.btnBuscar.TabIndex = 304;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoBajaActivo
            // 
            this.txtCodigoBajaActivo.Enabled = false;
            this.txtCodigoBajaActivo.Location = new System.Drawing.Point(102, 48);
            this.txtCodigoBajaActivo.Name = "txtCodigoBajaActivo";
            this.txtCodigoBajaActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoBajaActivo.TabIndex = 303;
            // 
            // clsMotivoBajaBindingSource
            // 
            this.clsMotivoBajaBindingSource.DataSource = typeof(clases.ActivoFijo.clsMotivoBaja);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 322;
            this.labelControl1.Text = "Motivos";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(250, 51);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 324;
            this.lblEstado.Text = "Estado:";
            // 
            // txtnum
            // 
            this.txtnum.Enabled = false;
            this.txtnum.Location = new System.Drawing.Point(454, 105);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(42, 20);
            this.txtnum.TabIndex = 323;
            this.txtnum.Visible = false;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Location = new System.Drawing.Point(317, 48);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridLookUpEdit1View;
            this.cbxEstado.Size = new System.Drawing.Size(100, 20);
            this.cbxEstado.TabIndex = 325;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // mntTipoBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 127);
            this.ControlBox = false;
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoBajaActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "mntTipoBaja";
            this.Text = "mntTipoBaja";
            this.Load += new System.EventHandler(this.mntTipoBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBajaActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtCodigoBajaActivo;
        private System.Windows.Forms.BindingSource clsMotivoBajaBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.TextEdit txtnum;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;

    }
}