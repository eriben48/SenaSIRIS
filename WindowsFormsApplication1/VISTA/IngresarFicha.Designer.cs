namespace WindowsFormsApplication1
{
    partial class IngresarFicha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.instructor = new System.Windows.Forms.TextBox();
            this.ficha = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxJornada = new System.Windows.Forms.ComboBox();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Ficha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento  Instructor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jornada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // instructor
            // 
            this.instructor.Location = new System.Drawing.Point(323, 61);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(159, 20);
            this.instructor.TabIndex = 10;
            this.instructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.instructor_KeyPress);
            // 
            // ficha
            // 
            this.ficha.Location = new System.Drawing.Point(323, 23);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(159, 20);
            this.ficha.TabIndex = 11;
            this.ficha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ficha_KeyPress);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "...",
            "ACTIVO",
            "INACTIVO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(323, 251);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(159, 21);
            this.comboBoxEstado.TabIndex = 13;
            // 
            // comboBoxJornada
            // 
            this.comboBoxJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJornada.FormattingEnabled = true;
            this.comboBoxJornada.Items.AddRange(new object[] {
            "...",
            "MAÑANA",
            "TARDE"});
            this.comboBoxJornada.Location = new System.Drawing.Point(323, 146);
            this.comboBoxJornada.Name = "comboBoxJornada";
            this.comboBoxJornada.Size = new System.Drawing.Size(149, 21);
            this.comboBoxJornada.TabIndex = 14;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(323, 189);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(149, 20);
            this.dateTimeInicio.TabIndex = 15;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(323, 216);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(149, 20);
            this.dateTimeFin.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Programa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // programa
            // 
            this.programa.Location = new System.Drawing.Point(323, 105);
            this.programa.Name = "programa";
            this.programa.Size = new System.Drawing.Size(159, 20);
            this.programa.TabIndex = 22;
            this.programa.TextChanged += new System.EventHandler(this.programa_TextChanged);
            this.programa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programa_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 247);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Captura3;
            this.pictureBox2.Location = new System.Drawing.Point(499, -29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 301);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // IngresarFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(699, 365);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.programa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.comboBoxJornada);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.ficha);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresarFicha";
            this.Text = "Ingresar Ficha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresarFicha_FormClosed);
            this.Load += new System.EventHandler(this.IngresarFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox instructor;
        private System.Windows.Forms.TextBox ficha;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxJornada;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox programa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}