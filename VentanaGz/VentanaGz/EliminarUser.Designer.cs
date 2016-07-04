namespace VentanaGz
{
    partial class EliminarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUser));
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarUsertextBox = new System.Windows.Forms.TextBox();
            this.EliminarUserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::VentanaGz.Properties.Resources.images__8_;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña:";
            // 
            // EliminarUsertextBox
            // 
            this.EliminarUsertextBox.Location = new System.Drawing.Point(119, 11);
            this.EliminarUsertextBox.Name = "EliminarUsertextBox";
            this.EliminarUsertextBox.Size = new System.Drawing.Size(100, 20);
            this.EliminarUsertextBox.TabIndex = 1;
            // 
            // EliminarUserbutton
            // 
            this.EliminarUserbutton.BackgroundImage = global::VentanaGz.Properties.Resources.images__8_;
            this.EliminarUserbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarUserbutton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.EliminarUserbutton.Image = global::VentanaGz.Properties.Resources.Misc_Delete_Database_icon;
            this.EliminarUserbutton.Location = new System.Drawing.Point(78, 55);
            this.EliminarUserbutton.Name = "EliminarUserbutton";
            this.EliminarUserbutton.Size = new System.Drawing.Size(69, 83);
            this.EliminarUserbutton.TabIndex = 2;
            this.EliminarUserbutton.Text = "Eliminar";
            this.EliminarUserbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarUserbutton.UseVisualStyleBackColor = true;
            this.EliminarUserbutton.Click += new System.EventHandler(this.EliminarUserbutton_Click);
            // 
            // EliminarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.images__8_;
            this.ClientSize = new System.Drawing.Size(242, 153);
            this.Controls.Add(this.EliminarUserbutton);
            this.Controls.Add(this.EliminarUsertextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarUser";
            this.Text = "EliminarUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EliminarUsertextBox;
        private System.Windows.Forms.Button EliminarUserbutton;
    }
}