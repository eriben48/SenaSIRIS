namespace WindowsFormsApplication1.VISTA
{
    partial class ActualizarFicha
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
            this.ficha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ACTUALIZAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combJornada = new System.Windows.Forms.ComboBox();
            this.combEstado = new System.Windows.Forms.ComboBox();
            this.documento = new System.Windows.Forms.TextBox();
            this.programa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.Buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ficha
            // 
            this.ficha.Location = new System.Drawing.Point(308, 26);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(121, 20);
            this.ficha.TabIndex = 0;
            this.ficha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ficha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(198, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la Ficha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.Location = new System.Drawing.Point(334, 282);
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Size = new System.Drawing.Size(123, 46);
            this.ACTUALIZAR.TabIndex = 2;
            this.ACTUALIZAR.Text = "&Actualizar";
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            this.ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento Instructor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Programa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jornada";
            // 
            // combJornada
            // 
            this.combJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combJornada.Items.AddRange(new object[] {
            "MAÑANA ",
            "TARDE"});
            this.combJornada.Location = new System.Drawing.Point(308, 137);
            this.combJornada.Name = "combJornada";
            this.combJornada.Size = new System.Drawing.Size(121, 21);
            this.combJornada.TabIndex = 6;
            // 
            // combEstado
            // 
            this.combEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEstado.FormattingEnabled = true;
            this.combEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.combEstado.Location = new System.Drawing.Point(308, 245);
            this.combEstado.Name = "combEstado";
            this.combEstado.Size = new System.Drawing.Size(149, 21);
            this.combEstado.TabIndex = 7;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(308, 62);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(121, 20);
            this.documento.TabIndex = 8;
            this.documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documento_KeyPress);
            // 
            // programa
            // 
            this.programa.Location = new System.Drawing.Point(308, 96);
            this.programa.Name = "programa";
            this.programa.Size = new System.Drawing.Size(121, 20);
            this.programa.TabIndex = 10;
            this.programa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Inicio ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(308, 171);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(149, 20);
            this.dateTimeInicio.TabIndex = 16;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(308, 210);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(149, 20);
            this.dateTimeFin.TabIndex = 17;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(449, 26);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(66, 23);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "Filtrar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 247);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // ActualizarFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(571, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.programa);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.combEstado);
            this.Controls.Add(this.combJornada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACTUALIZAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ficha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarFicha";
            this.Text = "Actualizar Ficha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarFicha_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ficha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ACTUALIZAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combJornada;
        private System.Windows.Forms.ComboBox combEstado;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox programa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}