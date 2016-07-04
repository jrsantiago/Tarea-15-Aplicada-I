namespace VentanaGz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nombreLogingTexBox = new System.Windows.Forms.TextBox();
            this.contrasenaLogingtextBox = new System.Windows.Forms.TextBox();
            this.Logingbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLogingTexBox
            // 
            this.nombreLogingTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLogingTexBox.Location = new System.Drawing.Point(101, 127);
            this.nombreLogingTexBox.Name = "nombreLogingTexBox";
            this.nombreLogingTexBox.Size = new System.Drawing.Size(110, 21);
            this.nombreLogingTexBox.TabIndex = 0;
            // 
            // contrasenaLogingtextBox
            // 
            this.contrasenaLogingtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaLogingtextBox.Location = new System.Drawing.Point(101, 173);
            this.contrasenaLogingtextBox.Name = "contrasenaLogingtextBox";
            this.contrasenaLogingtextBox.PasswordChar = '*';
            this.contrasenaLogingtextBox.Size = new System.Drawing.Size(138, 21);
            this.contrasenaLogingtextBox.TabIndex = 1;
            // 
            // Logingbutton
            // 
            this.Logingbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Logingbutton.BackgroundImage = global::VentanaGz.Properties.Resources.images__8_;
            this.Logingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logingbutton.Image = global::VentanaGz.Properties.Resources.go_back_icon;
            this.Logingbutton.Location = new System.Drawing.Point(242, 114);
            this.Logingbutton.Name = "Logingbutton";
            this.Logingbutton.Size = new System.Drawing.Size(53, 48);
            this.Logingbutton.TabIndex = 2;
            this.Logingbutton.UseVisualStyleBackColor = false;
            this.Logingbutton.Click += new System.EventHandler(this.Logingbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 366);
            this.Controls.Add(this.Logingbutton);
            this.Controls.Add(this.contrasenaLogingtextBox);
            this.Controls.Add(this.nombreLogingTexBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreLogingTexBox;
        private System.Windows.Forms.TextBox contrasenaLogingtextBox;
        private System.Windows.Forms.Button Logingbutton;
    }
}

