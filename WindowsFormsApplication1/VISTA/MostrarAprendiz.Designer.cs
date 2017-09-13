namespace WindowsFormsApplication1
{
    partial class MostrarAprendiz
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
            this.documento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ficha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.MostrarDataGrid = new System.Windows.Forms.DataGridView();
            this.BtnNombre = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(134, 11);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 20);
            this.documento.TabIndex = 2;
            this.documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ficha";
            // 
            // ficha
            // 
            this.ficha.Location = new System.Drawing.Point(134, 45);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(100, 20);
            this.ficha.TabIndex = 8;
            this.ficha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ficha_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(134, 77);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 10;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // MostrarDataGrid
            // 
            this.MostrarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarDataGrid.Location = new System.Drawing.Point(12, 112);
            this.MostrarDataGrid.Name = "MostrarDataGrid";
            this.MostrarDataGrid.Size = new System.Drawing.Size(497, 289);
            this.MostrarDataGrid.TabIndex = 11;
            // 
            // BtnNombre
            // 
            this.BtnNombre.Location = new System.Drawing.Point(240, 77);
            this.BtnNombre.Name = "BtnNombre";
            this.BtnNombre.Size = new System.Drawing.Size(59, 29);
            this.BtnNombre.TabIndex = 12;
            this.BtnNombre.Text = "Bu&scar";
            this.BtnNombre.UseVisualStyleBackColor = true;
            this.BtnNombre.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(240, 40);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(58, 29);
            this.BtnFiltrar.TabIndex = 13;
            this.BtnFiltrar.Text = "B&uscar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDocumento
            // 
            this.btnDocumento.Location = new System.Drawing.Point(240, 6);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(59, 29);
            this.btnDocumento.TabIndex = 14;
            this.btnDocumento.Text = "&Buscar";
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(515, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 407);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(677, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnNombre);
            this.Controls.Add(this.MostrarDataGrid);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ficha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarAprendiz";
            this.Text = "Mostrar Aprendiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MostrarAprendiz_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ficha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.DataGridView MostrarDataGrid;
        private System.Windows.Forms.Button BtnNombre;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}