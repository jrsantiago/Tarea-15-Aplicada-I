namespace VentanaGz.Consultas
{
    partial class ConsultaUsuario
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
            this.dbVentanaGzDataSet = new VentanaGz.DbVentanaGzDataSet();
            this.dbVentanaGzDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new VentanaGz.DbVentanaGzDataSetTableAdapters.UsuarioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.consultaUsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbVentanaGzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVentanaGzDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbVentanaGzDataSet
            // 
            this.dbVentanaGzDataSet.DataSetName = "DbVentanaGzDataSet";
            this.dbVentanaGzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbVentanaGzDataSetBindingSource
            // 
            this.dbVentanaGzDataSetBindingSource.DataSource = this.dbVentanaGzDataSet;
            this.dbVentanaGzDataSetBindingSource.Position = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dbVentanaGzDataSetBindingSource;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(227, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // consultaUsuariodataGridView
            // 
            this.consultaUsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaUsuariodataGridView.Location = new System.Drawing.Point(12, 71);
            this.consultaUsuariodataGridView.Name = "consultaUsuariodataGridView";
            this.consultaUsuariodataGridView.Size = new System.Drawing.Size(491, 294);
            this.consultaUsuariodataGridView.TabIndex = 3;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 381);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 4;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 428);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.consultaUsuariodataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaUsuario";
            this.Text = "ConsultaUsuario";
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbVentanaGzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVentanaGzDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbVentanaGzDataSetBindingSource;
        private DbVentanaGzDataSet dbVentanaGzDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DbVentanaGzDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView consultaUsuariodataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
    }
}