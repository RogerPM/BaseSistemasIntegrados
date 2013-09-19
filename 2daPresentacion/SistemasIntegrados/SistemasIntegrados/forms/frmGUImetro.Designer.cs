namespace forms
{
    partial class frmGUImetro
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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileItem10 = new DevExpress.XtraEditors.TileItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btnCambiar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tileItem10
            // 
            this.tileItem10.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tileItem10.AppearanceItem.Hovered.Image = global::forms.Properties.Resources.fondoLISTO;
            this.tileItem10.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.tileItem10.AppearanceItem.Hovered.Options.UseImage = true;
            this.tileItem10.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tileItem10.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tileItem10.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem10.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem10.AppearanceItem.Selected.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileItem10.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem10.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem10.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemElement5.Text = "Actualizar";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem10.Elements.Add(tileItemElement5);
            this.tileItem10.FrameAnimationInterval = 1000000;
            this.tileItem10.Id = 13;
            this.tileItem10.Name = "tileItem10";
            this.tileItem10.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem10_ItemClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(1250, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(19, 25);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "-";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Location = new System.Drawing.Point(1275, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(19, 25);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "x";
            this.simpleButton2.ToolTip = "Cerrar TECA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tileControl1
            // 
            this.tileControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.tileControl1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileControl1.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.White;
            this.tileControl1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.tileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Cyan;
            this.tileControl1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tileControl1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControl1.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tileControl1.BackgroundImage = global::forms.Properties.Resources.fondoListo1600x1200;
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.ItemSize = 150;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.LookAndFeel.SkinName = "Metropolis Dark";
            this.tileControl1.MaxId = 19;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.SelectionColor = System.Drawing.Color.WhiteSmoke;
            this.tileControl1.Size = new System.Drawing.Size(1296, 604);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // btnCambiar
            // 
            this.btnCambiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCambiar.Location = new System.Drawing.Point(0, 0);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(117, 23);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar contraseña";
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmGUImetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 604);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "Metropolis";
            this.Name = "frmGUImetro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGUImetro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileGroup tileGroup3;
        public DevExpress.XtraEditors.TileItem tileItem10;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnCambiar;

    }
}