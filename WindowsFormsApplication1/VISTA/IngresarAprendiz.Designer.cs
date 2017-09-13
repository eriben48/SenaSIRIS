namespace WindowsFormsApplication1
{
    partial class IngresarAprendiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDocumentoAprendiz = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombreAprendiz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textApellidoAprendiz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textCelularContacto = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.ComboBox();
            this.textGenero = new System.Windows.Forms.ComboBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.FechaNacimiento1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textFicha = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Documento";
            // 
            // textDocumentoAprendiz
            // 
            this.textDocumentoAprendiz.Location = new System.Drawing.Point(318, 51);
            this.textDocumentoAprendiz.Name = "textDocumentoAprendiz";
            this.textDocumentoAprendiz.Size = new System.Drawing.Size(150, 20);
            this.textDocumentoAprendiz.TabIndex = 2;
            this.textDocumentoAprendiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDocumentoAprendiz_KeyPress);
            // 
            // Tipo
            // 
            this.Tipo.AllowDrop = true;
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            "CEDULA DE CIUDADANIA",
            "TARJETA DE IDENTIDAD",
            "CEDULA EXTRANJERA",
            "PASAPORTE"});
            this.Tipo.Location = new System.Drawing.Point(318, 12);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(150, 21);
            this.Tipo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " Nombre ";
            // 
            // textNombreAprendiz
            // 
            this.textNombreAprendiz.Location = new System.Drawing.Point(318, 114);
            this.textNombreAprendiz.Name = "textNombreAprendiz";
            this.textNombreAprendiz.Size = new System.Drawing.Size(150, 20);
            this.textNombreAprendiz.TabIndex = 4;
            this.textNombreAprendiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreAprendiz_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = " Apellidos ";
            // 
            // textApellidoAprendiz
            // 
            this.textApellidoAprendiz.Location = new System.Drawing.Point(318, 151);
            this.textApellidoAprendiz.Name = "textApellidoAprendiz";
            this.textApellidoAprendiz.Size = new System.Drawing.Size(150, 20);
            this.textApellidoAprendiz.TabIndex = 5;
            this.textApellidoAprendiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidoAprendiz_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Direccion ";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(549, 15);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(105, 20);
            this.textDireccion.TabIndex = 8;
            this.textDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = " Telefono ";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(549, 51);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(105, 20);
            this.textTelefono.TabIndex = 9;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = " Celular ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = " Correo  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha de Nacimiento ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = " Celular del Contacto";
            // 
            // textCelularContacto
            // 
            this.textCelularContacto.Location = new System.Drawing.Point(318, 253);
            this.textCelularContacto.Name = "textCelularContacto";
            this.textCelularContacto.Size = new System.Drawing.Size(121, 20);
            this.textCelularContacto.TabIndex = 12;
            this.textCelularContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCelularContacto_KeyPress);
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(549, 123);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(121, 20);
            this.textCorreo.TabIndex = 11;
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(549, 86);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(105, 20);
            this.textCelular.TabIndex = 10;
            this.textCelular.TextChanged += new System.EventHandler(this.textCelular_TextChanged);
            this.textCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCelular_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(487, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Genero";
            // 
            // textEstado
            // 
            this.textEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "ACTIVO"});
            this.textEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textEstado.FormattingEnabled = true;
            this.textEstado.Items.AddRange(new object[] {
            "ACTIVO"});
            this.textEstado.Location = new System.Drawing.Point(318, 226);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(150, 21);
            this.textEstado.TabIndex = 7;
            // 
            // textGenero
            // 
            this.textGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textGenero.FormattingEnabled = true;
            this.textGenero.Items.AddRange(new object[] {
            "H",
            "M"});
            this.textGenero.Location = new System.Drawing.Point(549, 151);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(121, 21);
            this.textGenero.TabIndex = 13;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(506, 221);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(121, 51);
            this.Ingresar.TabIndex = 14;
            this.Ingresar.Text = "&Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaNacimiento1
            // 
            this.FechaNacimiento1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimiento1.Location = new System.Drawing.Point(318, 185);
            this.FechaNacimiento1.Name = "FechaNacimiento1";
            this.FechaNacimiento1.Size = new System.Drawing.Size(149, 20);
            this.FechaNacimiento1.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ficha  ";
            // 
            // textFicha
            // 
            this.textFicha.Location = new System.Drawing.Point(318, 86);
            this.textFicha.Name = "textFicha";
            this.textFicha.Size = new System.Drawing.Size(150, 20);
            this.textFicha.TabIndex = 3;
            this.textFicha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFicha_KeyPress);
            this.textFicha.Leave += new System.EventHandler(this.textFicha_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 247);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // IngresarAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textFicha);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.FechaNacimiento1);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textCelularContacto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textApellidoAprendiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombreAprendiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.textDocumentoAprendiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresarAprendiz";
            this.Text = "Ingresar Aprendiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresarAprendiz_FormClosed);
            this.Load += new System.EventHandler(this.IngresarAprendiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDocumentoAprendiz;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombreAprendiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textApellidoAprendiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCelularContacto;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox textEstado;
        private System.Windows.Forms.ComboBox textGenero;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.DateTimePicker FechaNacimiento1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textFicha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}