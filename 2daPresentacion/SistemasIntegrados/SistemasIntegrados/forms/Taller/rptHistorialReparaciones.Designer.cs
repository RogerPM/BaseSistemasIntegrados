namespace forms.Taller
{
    partial class rptHistorialReparaciones
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
            this.crptMostrarHistorial = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptMostrarHistorial
            // 
            this.crptMostrarHistorial.ActiveViewIndex = -1;
            this.crptMostrarHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptMostrarHistorial.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptMostrarHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptMostrarHistorial.Location = new System.Drawing.Point(0, 0);
            this.crptMostrarHistorial.Name = "crptMostrarHistorial";
            this.crptMostrarHistorial.ShowGroupTreeButton = false;
            this.crptMostrarHistorial.ShowParameterPanelButton = false;
            this.crptMostrarHistorial.Size = new System.Drawing.Size(1052, 509);
            this.crptMostrarHistorial.TabIndex = 1;
            this.crptMostrarHistorial.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptHistorialReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 509);
            this.Controls.Add(this.crptMostrarHistorial);
            this.Name = "rptHistorialReparaciones";
            this.Text = "rptHistorialReparaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptMostrarHistorial;
    }
}