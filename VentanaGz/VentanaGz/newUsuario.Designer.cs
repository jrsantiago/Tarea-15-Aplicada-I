namespace VentanaGz
{
    partial class newUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newUsuario));
            this.nombreNewUsuariotextBox = new System.Windows.Forms.TextBox();
            this.apellidoNuevoUsuatextBox = new System.Windows.Forms.TextBox();
            this.UserNameNuevoUsuariotextBox = new System.Windows.Forms.TextBox();
            this.contrasenaNuevaUsuariotextBox = new System.Windows.Forms.TextBox();
            this.RepetirContrasetextBox = new System.Windows.Forms.TextBox();
            this.mascucheckBox = new System.Windows.Forms.CheckBox();
            this.femeninocheckBox = new System.Windows.Forms.CheckBox();
            this.NewUsuariobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreNewUsuariotextBox
            // 
            this.nombreNewUsuariotextBox.Location = new System.Drawing.Point(95, 106);
            this.nombreNewUsuariotextBox.Name = "nombreNewUsuariotextBox";
            this.nombreNewUsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreNewUsuariotextBox.TabIndex = 0;
            this.nombreNewUsuariotextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apellidoNuevoUsuatextBox
            // 
            this.apellidoNuevoUsuatextBox.Location = new System.Drawing.Point(95, 132);
            this.apellidoNuevoUsuatextBox.Name = "apellidoNuevoUsuatextBox";
            this.apellidoNuevoUsuatextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoNuevoUsuatextBox.TabIndex = 1;
            // 
            // UserNameNuevoUsuariotextBox
            // 
            this.UserNameNuevoUsuariotextBox.Location = new System.Drawing.Point(186, 180);
            this.UserNameNuevoUsuariotextBox.Name = "UserNameNuevoUsuariotextBox";
            this.UserNameNuevoUsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameNuevoUsuariotextBox.TabIndex = 2;
            // 
            // contrasenaNuevaUsuariotextBox
            // 
            this.contrasenaNuevaUsuariotextBox.Location = new System.Drawing.Point(120, 206);
            this.contrasenaNuevaUsuariotextBox.Name = "contrasenaNuevaUsuariotextBox";
            this.contrasenaNuevaUsuariotextBox.PasswordChar = '*';
            this.contrasenaNuevaUsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.contrasenaNuevaUsuariotextBox.TabIndex = 3;
            // 
            // RepetirContrasetextBox
            // 
            this.RepetirContrasetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepetirContrasetextBox.Location = new System.Drawing.Point(204, 232);
            this.RepetirContrasetextBox.Name = "RepetirContrasetextBox";
            this.RepetirContrasetextBox.PasswordChar = '*';
            this.RepetirContrasetextBox.Size = new System.Drawing.Size(100, 21);
            this.RepetirContrasetextBox.TabIndex = 4;
            // 
            // mascucheckBox
            // 
            this.mascucheckBox.AutoSize = true;
            this.mascucheckBox.Location = new System.Drawing.Point(64, 158);
            this.mascucheckBox.Name = "mascucheckBox";
            this.mascucheckBox.Size = new System.Drawing.Size(64, 17);
            this.mascucheckBox.TabIndex = 5;
            this.mascucheckBox.Text = "Mascu..";
            this.mascucheckBox.UseVisualStyleBackColor = true;
            // 
            // femeninocheckBox
            // 
            this.femeninocheckBox.AutoSize = true;
            this.femeninocheckBox.Location = new System.Drawing.Point(134, 158);
            this.femeninocheckBox.Name = "femeninocheckBox";
            this.femeninocheckBox.Size = new System.Drawing.Size(64, 17);
            this.femeninocheckBox.TabIndex = 6;
            this.femeninocheckBox.Text = "Femen..";
            this.femeninocheckBox.UseVisualStyleBackColor = true;
            // 
            // NewUsuariobutton
            // 
            this.NewUsuariobutton.BackgroundImage = global::VentanaGz.Properties.Resources.images__8_;
            this.NewUsuariobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUsuariobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsuariobutton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NewUsuariobutton.Image = global::VentanaGz.Properties.Resources.system_database_add_icon__1_;
            this.NewUsuariobutton.Location = new System.Drawing.Point(236, 308);
            this.NewUsuariobutton.Name = "NewUsuariobutton";
            this.NewUsuariobutton.Size = new System.Drawing.Size(68, 93);
            this.NewUsuariobutton.TabIndex = 7;
            this.NewUsuariobutton.Text = "Crear";
            this.NewUsuariobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewUsuariobutton.UseVisualStyleBackColor = true;
            this.NewUsuariobutton.Click += new System.EventHandler(this.NewUsuariobutton_Click);
            // 
            // newUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.newUsuario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 413);
            this.Controls.Add(this.NewUsuariobutton);
            this.Controls.Add(this.femeninocheckBox);
            this.Controls.Add(this.mascucheckBox);
            this.Controls.Add(this.RepetirContrasetextBox);
            this.Controls.Add(this.contrasenaNuevaUsuariotextBox);
            this.Controls.Add(this.UserNameNuevoUsuariotextBox);
            this.Controls.Add(this.apellidoNuevoUsuatextBox);
            this.Controls.Add(this.nombreNewUsuariotextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.newUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreNewUsuariotextBox;
        private System.Windows.Forms.TextBox apellidoNuevoUsuatextBox;
        private System.Windows.Forms.TextBox UserNameNuevoUsuariotextBox;
        private System.Windows.Forms.TextBox contrasenaNuevaUsuariotextBox;
        private System.Windows.Forms.TextBox RepetirContrasetextBox;
        private System.Windows.Forms.CheckBox mascucheckBox;
        private System.Windows.Forms.CheckBox femeninocheckBox;
        private System.Windows.Forms.Button NewUsuariobutton;
    }
}