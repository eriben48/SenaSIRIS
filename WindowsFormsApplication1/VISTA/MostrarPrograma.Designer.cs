namespace WindowsFormsApplication1
{
    partial class MostrarPrograma
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
            this.TxtIdprogramas = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DtProgramas = new System.Windows.Forms.DataGridView();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtProgramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Programa";
            // 
            // TxtIdprogramas
            // 
            this.TxtIdprogramas.Location = new System.Drawing.Point(302, 24);
            this.TxtIdprogramas.Name = "TxtIdprogramas";
            this.TxtIdprogramas.Size = new System.Drawing.Size(132, 20);
            this.TxtIdprogramas.TabIndex = 1;
            this.TxtIdprogramas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdprogramas_KeyPress);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(520, 24);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(92, 25);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar Todos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtProgramas
            // 
            this.DtProgramas.AllowUserToAddRows = false;
            this.DtProgramas.AllowUserToDeleteRows = false;
            this.DtProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtProgramas.Location = new System.Drawing.Point(158, 55);
            this.DtProgramas.Name = "DtProgramas";
            this.DtProgramas.ReadOnly = true;
            this.DtProgramas.Size = new System.Drawing.Size(469, 310);
            this.DtProgramas.TabIndex = 5;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(440, 24);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(74, 23);
            this.BtnFiltrar.TabIndex = 6;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.Programas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-34, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 283);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(647, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.DtProgramas);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtIdprogramas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarPrograma";
            this.Text = "Mostrar Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MostrarPrograma_FormClosed);
            this.Load += new System.EventHandler(this.MostrarPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtProgramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdprogramas;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DataGridView DtProgramas;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}