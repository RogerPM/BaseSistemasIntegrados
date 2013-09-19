namespace forms.Taller
{
    partial class rptOrdenesTrabajos
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
            this.crptMostrarOrdenes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptMostrarOrdenes
            // 
            this.crptMostrarOrdenes.ActiveViewIndex = -1;
            this.crptMostrarOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptMostrarOrdenes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptMostrarOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptMostrarOrdenes.Location = new System.Drawing.Point(0, 0);
            this.crptMostrarOrdenes.Name = "crptMostrarOrdenes";
            this.crptMostrarOrdenes.ShowGroupTreeButton = false;
            this.crptMostrarOrdenes.ShowParameterPanelButton = false;
            this.crptMostrarOrdenes.Size = new System.Drawing.Size(1138, 542);
            this.crptMostrarOrdenes.TabIndex = 0;
            this.crptMostrarOrdenes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptOrdenesTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 542);
            this.Controls.Add(this.crptMostrarOrdenes);
            this.Name = "rptOrdenesTrabajos";
            this.Text = "Reporte Ordenes de Trabajo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptMostrarOrdenes;
    }
}