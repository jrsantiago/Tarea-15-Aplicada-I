namespace VentanaGz.Consultas
{
    partial class ReportarViewer
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
            this.RpViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpViewer
            // 
            this.RpViewer.Location = new System.Drawing.Point(3, 4);
            this.RpViewer.Name = "RpViewer";
            this.RpViewer.Size = new System.Drawing.Size(684, 458);
            this.RpViewer.TabIndex = 0;
            // 
            // ReportarViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 474);
            this.Controls.Add(this.RpViewer);
            this.Name = "ReportarViewer";
            this.Text = "ReporteViewer";
            this.Load += new System.EventHandler(this.ReporteViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RpViewer;
    }
}