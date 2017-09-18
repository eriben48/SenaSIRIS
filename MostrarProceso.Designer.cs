namespace WindowsFormsApplication1
{
    partial class MostrarProceso
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
            this.TxtDocAprendiz = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DataGridProceso = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFechaRadicacion = new System.Windows.Forms.TextBox();
            this.TxtTipoProceso = new System.Windows.Forms.TextBox();
            this.TxtNumeroProceso = new System.Windows.Forms.TextBox();
            this.BtnNumeroProceso = new System.Windows.Forms.Button();
            this.BtnFechaRadicacion = new System.Windows.Forms.Button();
            this.BtnTipoProceso = new System.Windows.Forms.Button();
            this.BtnDocAprendiz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Documento Aprendiz";
            // 
            // TxtDocAprendiz
            // 
            this.TxtDocAprendiz.Location = new System.Drawing.Point(252, 97);
            this.TxtDocAprendiz.Name = "TxtDocAprendiz";
            this.TxtDocAprendiz.Size = new System.Drawing.Size(127, 20);
            this.TxtDocAprendiz.TabIndex = 1;
            this.TxtDocAprendiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocAprendiz_KeyPress);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(475, 81);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(111, 39);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "MOSTRAR";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // DataGridProceso
            // 
            this.DataGridProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProceso.Location = new System.Drawing.Point(136, 126);
            this.DataGridProceso.Name = "DataGridProceso";
            this.DataGridProceso.Size = new System.Drawing.Size(500, 229);
            this.DataGridProceso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero Del Proceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha De Radicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo De Proceso";
            // 
            // TxtFechaRadicacion
            // 
            this.TxtFechaRadicacion.Location = new System.Drawing.Point(252, 45);
            this.TxtFechaRadicacion.Name = "TxtFechaRadicacion";
            this.TxtFechaRadicacion.Size = new System.Drawing.Size(127, 20);
            this.TxtFechaRadicacion.TabIndex = 9;
            this.TxtFechaRadicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaRadicacion_KeyPress);
            // 
            // TxtTipoProceso
            // 
            this.TxtTipoProceso.Location = new System.Drawing.Point(252, 73);
            this.TxtTipoProceso.Name = "TxtTipoProceso";
            this.TxtTipoProceso.Size = new System.Drawing.Size(127, 20);
            this.TxtTipoProceso.TabIndex = 10;
            this.TxtTipoProceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoProceso_KeyPress);
            // 
            // TxtNumeroProceso
            // 
            this.TxtNumeroProceso.Location = new System.Drawing.Point(252, 19);
            this.TxtNumeroProceso.Name = "TxtNumeroProceso";
            this.TxtNumeroProceso.Size = new System.Drawing.Size(127, 20);
            this.TxtNumeroProceso.TabIndex = 11;
            this.TxtNumeroProceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroProceso_KeyPress);
            // 
            // BtnNumeroProceso
            // 
            this.BtnNumeroProceso.Location = new System.Drawing.Point(394, 17);
            this.BtnNumeroProceso.Name = "BtnNumeroProceso";
            this.BtnNumeroProceso.Size = new System.Drawing.Size(75, 23);
            this.BtnNumeroProceso.TabIndex = 12;
            this.BtnNumeroProceso.Text = "&Buscar";
            this.BtnNumeroProceso.UseVisualStyleBackColor = true;
            this.BtnNumeroProceso.Click += new System.EventHandler(this.BtnNumeroProceso_Click);
            // 
            // BtnFechaRadicacion
            // 
            this.BtnFechaRadicacion.Location = new System.Drawing.Point(394, 47);
            this.BtnFechaRadicacion.Name = "BtnFechaRadicacion";
            this.BtnFechaRadicacion.Size = new System.Drawing.Size(75, 23);
            this.BtnFechaRadicacion.TabIndex = 13;
            this.BtnFechaRadicacion.Text = "B&uscar";
            this.BtnFechaRadicacion.UseVisualStyleBackColor = true;
            this.BtnFechaRadicacion.Click += new System.EventHandler(this.BtnFechaRadicacion_Click);
            // 
            // BtnTipoProceso
            // 
            this.BtnTipoProceso.Location = new System.Drawing.Point(394, 72);
            this.BtnTipoProceso.Name = "BtnTipoProceso";
            this.BtnTipoProceso.Size = new System.Drawing.Size(75, 23);
            this.BtnTipoProceso.TabIndex = 14;
            this.BtnTipoProceso.Text = "Bu&scar";
            this.BtnTipoProceso.UseVisualStyleBackColor = true;
            this.BtnTipoProceso.Click += new System.EventHandler(this.BtnTipoProceso_Click);
            // 
            // BtnDocAprendiz
            // 
            this.BtnDocAprendiz.Location = new System.Drawing.Point(394, 97);
            this.BtnDocAprendiz.Name = "BtnDocAprendiz";
            this.BtnDocAprendiz.Size = new System.Drawing.Size(75, 23);
            this.BtnDocAprendiz.TabIndex = 15;
            this.BtnDocAprendiz.Text = "Bus&car";
            this.BtnDocAprendiz.UseVisualStyleBackColor = true;
            this.BtnDocAprendiz.Click += new System.EventHandler(this.BtnDocAprendiz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 387);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(664, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDocAprendiz);
            this.Controls.Add(this.BtnTipoProceso);
            this.Controls.Add(this.BtnFechaRadicacion);
            this.Controls.Add(this.BtnNumeroProceso);
            this.Controls.Add(this.TxtNumeroProceso);
            this.Controls.Add(this.TxtTipoProceso);
            this.Controls.Add(this.TxtFechaRadicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridProceso);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtDocAprendiz);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarProceso";
            this.Text = "Mostrar Proceso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MostrarProceso_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDocAprendiz;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DataGridView DataGridProceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFechaRadicacion;
        private System.Windows.Forms.TextBox TxtTipoProceso;
        private System.Windows.Forms.TextBox TxtNumeroProceso;
        private System.Windows.Forms.Button BtnNumeroProceso;
        private System.Windows.Forms.Button BtnFechaRadicacion;
        private System.Windows.Forms.Button BtnTipoProceso;
        private System.Windows.Forms.Button BtnDocAprendiz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}