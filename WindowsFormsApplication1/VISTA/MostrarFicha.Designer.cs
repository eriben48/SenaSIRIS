namespace WindowsFormsApplication1
{
    partial class MostrarFicha
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
            this.Ficha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGrievFicha = new System.Windows.Forms.DataGridView();
            this.instructor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.instructor1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrievFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Ficha";
            // 
            // Ficha
            // 
            this.Ficha.Location = new System.Drawing.Point(150, 17);
            this.Ficha.Name = "Ficha";
            this.Ficha.Size = new System.Drawing.Size(123, 20);
            this.Ficha.TabIndex = 1;
            this.Ficha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ficha_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGrievFicha
            // 
            this.DataGrievFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrievFicha.Location = new System.Drawing.Point(35, 119);
            this.DataGrievFicha.Name = "DataGrievFicha";
            this.DataGrievFicha.Size = new System.Drawing.Size(509, 197);
            this.DataGrievFicha.TabIndex = 7;
            // 
            // instructor
            // 
            this.instructor.Location = new System.Drawing.Point(292, 45);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(75, 23);
            this.instructor.TabIndex = 8;
            this.instructor.Text = "Instructor";
            this.instructor.UseVisualStyleBackColor = true;
            this.instructor.Click += new System.EventHandler(this.instructor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instructor";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(150, 80);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(123, 20);
            this.estado.TabIndex = 11;
            this.estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estado_KeyPress);
            // 
            // instructor1
            // 
            this.instructor1.Location = new System.Drawing.Point(150, 43);
            this.instructor1.Name = "instructor1";
            this.instructor1.Size = new System.Drawing.Size(123, 20);
            this.instructor1.TabIndex = 12;
            this.instructor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.instructor1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Estado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(561, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 407);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MostrarFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(731, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructor1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.DataGrievFicha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ficha);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarFicha";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ficha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MostrarFicha_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrievFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ficha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataGrievFicha;
        private System.Windows.Forms.Button instructor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox instructor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}