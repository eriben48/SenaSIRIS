namespace WindowsFormsApplication1
{
    partial class IngresoProceso
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDocAprendiz = new System.Windows.Forms.TextBox();
            this.TxtConceptoNovedad = new System.Windows.Forms.TextBox();
            this.ComboBoxTipoNovedad = new System.Windows.Forms.ComboBox();
            this.ComboBoxTipoProceso = new System.Windows.Forms.ComboBox();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.DateFechaRadicacion = new System.Windows.Forms.DateTimePicker();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Proceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha  Proceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Radicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Novedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Concepto de Novedad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Documento  Aprendiz";
            // 
            // TxtDocAprendiz
            // 
            this.TxtDocAprendiz.Location = new System.Drawing.Point(331, 15);
            this.TxtDocAprendiz.Name = "TxtDocAprendiz";
            this.TxtDocAprendiz.Size = new System.Drawing.Size(162, 20);
            this.TxtDocAprendiz.TabIndex = 8;
            this.TxtDocAprendiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocAprendiz_KeyPress);
            this.TxtDocAprendiz.Leave += new System.EventHandler(this.TxtDocAprendiz_Leave);
            // 
            // TxtConceptoNovedad
            // 
            this.TxtConceptoNovedad.Location = new System.Drawing.Point(188, 236);
            this.TxtConceptoNovedad.Multiline = true;
            this.TxtConceptoNovedad.Name = "TxtConceptoNovedad";
            this.TxtConceptoNovedad.Size = new System.Drawing.Size(334, 117);
            this.TxtConceptoNovedad.TabIndex = 9;
            this.TxtConceptoNovedad.TextChanged += new System.EventHandler(this.TxtConceptoNovedad_TextChanged);
            this.TxtConceptoNovedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConceptoNovedad_KeyPress);
            // 
            // ComboBoxTipoNovedad
            // 
            this.ComboBoxTipoNovedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipoNovedad.FormattingEnabled = true;
            this.ComboBoxTipoNovedad.Location = new System.Drawing.Point(331, 169);
            this.ComboBoxTipoNovedad.Name = "ComboBoxTipoNovedad";
            this.ComboBoxTipoNovedad.Size = new System.Drawing.Size(227, 21);
            this.ComboBoxTipoNovedad.TabIndex = 10;
            this.ComboBoxTipoNovedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxTipoNovedad_KeyPress);
            // 
            // ComboBoxTipoProceso
            // 
            this.ComboBoxTipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipoProceso.FormattingEnabled = true;
            this.ComboBoxTipoProceso.Items.AddRange(new object[] {
            "RETIRO VOLUNTARIO",
            "DESERCION"});
            this.ComboBoxTipoProceso.Location = new System.Drawing.Point(331, 50);
            this.ComboBoxTipoProceso.Name = "ComboBoxTipoProceso";
            this.ComboBoxTipoProceso.Size = new System.Drawing.Size(162, 21);
            this.ComboBoxTipoProceso.TabIndex = 11;
            this.ComboBoxTipoProceso.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxTipoProceso_SelectionChangeCommitted);
            // 
            // DateFecha
            // 
            this.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFecha.Location = new System.Drawing.Point(331, 91);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(149, 20);
            this.DateFecha.TabIndex = 15;
            // 
            // DateFechaRadicacion
            // 
            this.DateFechaRadicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFechaRadicacion.Location = new System.Drawing.Point(331, 136);
            this.DateFechaRadicacion.Name = "DateFechaRadicacion";
            this.DateFechaRadicacion.Size = new System.Drawing.Size(149, 20);
            this.DateFechaRadicacion.TabIndex = 16;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(188, 371);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(100, 38);
            this.BtnIngresar.TabIndex = 17;
            this.BtnIngresar.Text = "&Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(424, 53);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(0, 13);
            this.Estado.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 407);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // IngresoProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(595, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboBoxTipoProceso);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.TxtDocAprendiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.DateFechaRadicacion);
            this.Controls.Add(this.DateFecha);
            this.Controls.Add(this.ComboBoxTipoNovedad);
            this.Controls.Add(this.TxtConceptoNovedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresoProceso";
            this.Text = "Ingresar Proceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoProceso_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresoProceso_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDocAprendiz;
        private System.Windows.Forms.TextBox TxtConceptoNovedad;
        private System.Windows.Forms.ComboBox ComboBoxTipoNovedad;
        private System.Windows.Forms.ComboBox ComboBoxTipoProceso;
        private System.Windows.Forms.DateTimePicker DateFecha;
        private System.Windows.Forms.DateTimePicker DateFechaRadicacion;
        private System.Windows.Forms.Button BtnIngresar;
      //  private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}