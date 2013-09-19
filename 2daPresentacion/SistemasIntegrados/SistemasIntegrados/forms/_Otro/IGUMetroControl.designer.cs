namespace forms._Otro
{
    partial class IGUMetroControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGUMetroControl));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemActualizar = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
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
            this.tileControl1.Size = new System.Drawing.Size(1063, 600);
            this.tileControl1.TabIndex = 2;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItemActualizar);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // tileItemActualizar
            // 
            this.tileItemActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemActualizar.BackgroundImage")));
            this.tileItemActualizar.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "Actualizar";
            this.tileItemActualizar.Elements.Add(tileItemElement1);
            this.tileItemActualizar.Id = 18;
            this.tileItemActualizar.Name = "tileItemActualizar";
            this.tileItemActualizar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItemActualizar_ItemClick);
            // 
            // IGUMetroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Name = "IGUMetroControl";
            this.Size = new System.Drawing.Size(1063, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileItem tileItemActualizar;
    }
}
