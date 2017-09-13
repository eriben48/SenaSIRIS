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
            this.TexTipoPrograma = new System.Windows.Forms.ComboBox();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TexAreaPrograma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Programa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Programa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Programa";
            // 
            // TexNumeroPrograma
            // 
            this.TexNumeroPrograma.Location = new System.Drawing.Point(142, 64);
            this.TexNumeroPrograma.Name = "TexNumeroPrograma";
            this.TexNumeroPrograma.Size = new System.Drawing.Size(132, 20);
            this.TexNumeroPrograma.TabIndex = 3;
            // 
            // TexNombrePrograma
            // 
            this.TexNombrePrograma.Location = new System.Drawing.Point(142, 98);
            this.TexNombrePrograma.Name = "TexNombrePrograma";
            this.TexNombrePrograma.Size = new System.Drawing.Size(132, 20);
            this.TexNombrePrograma.TabIndex = 4;
            // 
            // TexTipoPrograma
            // 
            this.TexTipoPrograma.FormattingEnabled = true;
            this.TexTipoPrograma.Location = new System.Drawing.Point(414, 63);
            this.TexTipoPrograma.Name = "TexTipoPrograma";
            this.TexTipoPrograma.Size = new System.Drawing.Size(132, 21);
            this.TexTipoPrograma.TabIndex = 5;
            // 
            // INGRESAR
            // 
            this.INGRESAR.Location = new System.Drawing.Point(238, 135);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(107, 41);
            this.INGRESAR.TabIndex = 6;
            this.INGRESAR.Text = "INGRESAR";
            this.INGRESAR.UseVisualStyleBackColor = true;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "INGRESAR PROGRAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " Area";
            // 
            // TexAreaPrograma
            // 
            this.TexAreaPrograma.FormattingEnabled = true;
            this.TexAreaPrograma.Location = new System.Drawing.Point(414, 97);
            this.TexAreaPrograma.Name = "TexAreaPrograma";
            this.TexAreaPrograma.Size = new System.Drawing.Size(132, 21);
            this.TexAreaPrograma.TabIndex = 9;
            // 
            // IngresarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 192);
            this.Controls.Add(this.TexAreaPrograma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.TexTipoPrograma);
            this.Controls.Add(this.TexNombrePrograma);
            this.Controls.Add(this.TexNumeroPrograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresarPrograma";
            this.Text = "Ingresar Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresarPrograma_FormClosed);
            this.Load += new System.EventHandler(this.IngresarPrograma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexNumeroPrograma;
        private System.Windows.Forms.TextBox TexNombrePrograma;
        private System.Windows.Forms.ComboBox TexTipoPrograma;
        private System.Windows.Forms.Button INGRESAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TexAreaPrograma;
    }
}