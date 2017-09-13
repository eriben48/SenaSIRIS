namespace WindowsFormsApplication1.VISTA
{
    partial class ActualizarInstructor
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
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.TxtProfesión = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(269, 43);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(168, 20);
            this.TxtDocumento.TabIndex = 2;
            this.TxtDocumento.TextChanged += new System.EventHandler(this.TxtDocumento_TextChanged_1);
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(355, 347);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(109, 38);
            this.BtnActualizar.TabIndex = 34;
            this.BtnActualizar.Text = "&Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // ComboEstado
            // 
            this.ComboEstado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.ComboEstado.Location = new System.Drawing.Point(269, 164);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(168, 21);
            this.ComboEstado.TabIndex = 33;
            // 
            // TxtProfesión
            // 
            this.TxtProfesión.Location = new System.Drawing.Point(270, 270);
            this.TxtProfesión.Name = "TxtProfesión";
            this.TxtProfesión.Size = new System.Drawing.Size(194, 20);
            this.TxtProfesión.TabIndex = 32;
            this.TxtProfesión.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProfesión_KeyPress);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(270, 234);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(194, 20);
            this.TxtCelular.TabIndex = 31;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(270, 200);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(194, 20);
            this.TxtTelefono.TabIndex = 30;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(269, 133);
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(168, 20);
            this.TxtDirección.TabIndex = 29;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(269, 107);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(168, 20);
            this.TxtApellido.TabIndex = 28;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(269, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(168, 20);
            this.TxtNombre.TabIndex = 27;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dirección ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Profesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Estado";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(454, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(51, 28);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "&Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Enabled = false;
            this.TxtEstado.Location = new System.Drawing.Point(270, 310);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(194, 20);
            this.TxtEstado.TabIndex = 36;
            this.TxtEstado.TextChanged += new System.EventHandler(this.TxtEstado_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Estado";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(261, 347);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(88, 38);
            this.BtnCancelar.TabIndex = 38;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Captura31;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 247);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // ActualizarInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(615, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.ComboEstado);
            this.Controls.Add(this.TxtProfesión);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDirección);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarInstructor";
            this.Text = "Actualizar  Instructor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarInstructor_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.TextBox TxtProfesión;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}