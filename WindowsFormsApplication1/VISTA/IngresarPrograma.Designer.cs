namespace WindowsFormsApplication1
{
    partial class IngresarPrograma
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
            this.label3 = new System.Windows.Forms.Label();
            this.TexNumeroPrograma = new System.Windows.Forms.TextBox();
            this.TexNombrePrograma = new System.Windows.Forms.TextBox();
            this.ComboxTipoPrograma = new System.Windows.Forms.ComboBox();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboxAreaPrograma = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Programa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Programa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Programa";
            // 
            // TexNumeroPrograma
            // 
            this.TexNumeroPrograma.Location = new System.Drawing.Point(315, 28);
            this.TexNumeroPrograma.Name = "TexNumeroPrograma";
            this.TexNumeroPrograma.Size = new System.Drawing.Size(132, 20);
            this.TexNumeroPrograma.TabIndex = 3;
            this.TexNumeroPrograma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TexNumeroPrograma_KeyPress);
            // 
            // TexNombrePrograma
            // 
            this.TexNombrePrograma.Location = new System.Drawing.Point(315, 62);
            this.TexNombrePrograma.Name = "TexNombrePrograma";
            this.TexNombrePrograma.Size = new System.Drawing.Size(132, 20);
            this.TexNombrePrograma.TabIndex = 4;
            this.TexNombrePrograma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TexNombrePrograma_KeyPress);
            // 
            // ComboxTipoPrograma
            // 
            this.ComboxTipoPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxTipoPrograma.FormattingEnabled = true;
            this.ComboxTipoPrograma.Items.AddRange(new object[] {
            "TECNICO",
            "TECNOLOGO ",
            "AUXILIAR",
            "OPERARIO",
            "ESPECIALIZACION TECNOLOGICA"});
            this.ComboxTipoPrograma.Location = new System.Drawing.Point(315, 103);
            this.ComboxTipoPrograma.Name = "ComboxTipoPrograma";
            this.ComboxTipoPrograma.Size = new System.Drawing.Size(132, 21);
            this.ComboxTipoPrograma.TabIndex = 5;
            // 
            // INGRESAR
            // 
            this.INGRESAR.Location = new System.Drawing.Point(340, 179);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(107, 41);
            this.INGRESAR.TabIndex = 6;
            this.INGRESAR.Text = "&Ingresar";
            this.INGRESAR.UseVisualStyleBackColor = true;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " Area";
            // 
            // ComboxAreaPrograma
            // 
            this.ComboxAreaPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxAreaPrograma.FormattingEnabled = true;
            this.ComboxAreaPrograma.Items.AddRange(new object[] {
            "INDUSTRIA",
            "SERVICIOS"});
            this.ComboxAreaPrograma.Location = new System.Drawing.Point(315, 137);
            this.ComboxAreaPrograma.Name = "ComboxAreaPrograma";
            this.ComboxAreaPrograma.Size = new System.Drawing.Size(132, 21);
            this.ComboxAreaPrograma.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 407);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // IngresarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(588, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboxAreaPrograma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.ComboxTipoPrograma);
            this.Controls.Add(this.TexNombrePrograma);
            this.Controls.Add(this.TexNumeroPrograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresarPrograma";
            this.Text = "Ingresar Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresarPrograma_FormClosed);
            this.Load += new System.EventHandler(this.IngresarPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexNumeroPrograma;
        private System.Windows.Forms.TextBox TexNombrePrograma;
        private System.Windows.Forms.ComboBox ComboxTipoPrograma;
        private System.Windows.Forms.Button INGRESAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboxAreaPrograma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}