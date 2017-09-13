namespace WindowsFormsApplication1
{
    partial class padre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aprendizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarAprendizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAprendizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.barra;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprendizToolStripMenuItem,
            this.fichaToolStripMenuItem,
            this.intructorToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.programasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aprendizToolStripMenuItem
            // 
            this.aprendizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarAprendizToolStripMenuItem,
            this.mostrarAprendizToolStripMenuItem});
            this.aprendizToolStripMenuItem.Name = "aprendizToolStripMenuItem";
            this.aprendizToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.aprendizToolStripMenuItem.Text = "Aprendiz";
            // 
            // ingresarAprendizToolStripMenuItem
            // 
            this.ingresarAprendizToolStripMenuItem.Name = "ingresarAprendizToolStripMenuItem";
            this.ingresarAprendizToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ingresarAprendizToolStripMenuItem.Text = "Ingresar Aprendiz";
            this.ingresarAprendizToolStripMenuItem.Click += new System.EventHandler(this.ingresarAprendizToolStripMenuItem_Click);
            // 
            // mostrarAprendizToolStripMenuItem
            // 
            this.mostrarAprendizToolStripMenuItem.Name = "mostrarAprendizToolStripMenuItem";
            this.mostrarAprendizToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mostrarAprendizToolStripMenuItem.Text = "Mostrar Aprendiz";
            this.mostrarAprendizToolStripMenuItem.Click += new System.EventHandler(this.mostrarAprendizToolStripMenuItem_Click);
            // 
            // fichaToolStripMenuItem
            // 
            this.fichaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarFichaToolStripMenuItem,
            this.mostrarFichaToolStripMenuItem});
            this.fichaToolStripMenuItem.Name = "fichaToolStripMenuItem";
            this.fichaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fichaToolStripMenuItem.Text = "Ficha";
            // 
            // ingresarFichaToolStripMenuItem
            // 
            this.ingresarFichaToolStripMenuItem.Name = "ingresarFichaToolStripMenuItem";
            this.ingresarFichaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ingresarFichaToolStripMenuItem.Text = "Ingresar Ficha";
            this.ingresarFichaToolStripMenuItem.Click += new System.EventHandler(this.ingresarFichaToolStripMenuItem_Click);
            // 
            // mostrarFichaToolStripMenuItem
            // 
            this.mostrarFichaToolStripMenuItem.Name = "mostrarFichaToolStripMenuItem";
            this.mostrarFichaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.mostrarFichaToolStripMenuItem.Text = "Mostrar Ficha";
            this.mostrarFichaToolStripMenuItem.Click += new System.EventHandler(this.mostrarFichaToolStripMenuItem_Click);
            // 
            // intructorToolStripMenuItem
            // 
            this.intructorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarInstructorToolStripMenuItem,
            this.mostrarInstructorToolStripMenuItem,
            this.actualizarInstructorToolStripMenuItem});
            this.intructorToolStripMenuItem.Name = "intructorToolStripMenuItem";
            this.intructorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.intructorToolStripMenuItem.Text = "Instructor";
            this.intructorToolStripMenuItem.Click += new System.EventHandler(this.intructorToolStripMenuItem_Click);
            // 
            // ingresarInstructorToolStripMenuItem
            // 
            this.ingresarInstructorToolStripMenuItem.Name = "ingresarInstructorToolStripMenuItem";
            this.ingresarInstructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarInstructorToolStripMenuItem.Text = "Ingresar Instructor";
            this.ingresarInstructorToolStripMenuItem.Click += new System.EventHandler(this.ingresarInstructorToolStripMenuItem_Click);
            // 
            // mostrarInstructorToolStripMenuItem
            // 
            this.mostrarInstructorToolStripMenuItem.Name = "mostrarInstructorToolStripMenuItem";
            this.mostrarInstructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarInstructorToolStripMenuItem.Text = "Mostrar Instructor";
            this.mostrarInstructorToolStripMenuItem.Click += new System.EventHandler(this.mostrarInstructorToolStripMenuItem_Click);
            // 
            // actualizarInstructorToolStripMenuItem
            // 
            this.actualizarInstructorToolStripMenuItem.Name = "actualizarInstructorToolStripMenuItem";
            this.actualizarInstructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarInstructorToolStripMenuItem.Text = "Actualizar Instructor";
            this.actualizarInstructorToolStripMenuItem.Click += new System.EventHandler(this.actualizarInstructorToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProcesoToolStripMenuItem,
            this.mostrarProcesoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.procesosToolStripMenuItem.Text = "Proceso";
            // 
            // ingresarProcesoToolStripMenuItem
            // 
            this.ingresarProcesoToolStripMenuItem.Name = "ingresarProcesoToolStripMenuItem";
            this.ingresarProcesoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ingresarProcesoToolStripMenuItem.Text = "Ingresar Proceso";
            this.ingresarProcesoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProcesoToolStripMenuItem_Click);
            // 
            // mostrarProcesoToolStripMenuItem
            // 
            this.mostrarProcesoToolStripMenuItem.Name = "mostrarProcesoToolStripMenuItem";
            this.mostrarProcesoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mostrarProcesoToolStripMenuItem.Text = "Mostrar Proceso";
            this.mostrarProcesoToolStripMenuItem.Click += new System.EventHandler(this.mostrarProcesoToolStripMenuItem_Click);
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProgramaToolStripMenuItem,
            this.mostrarProgramaToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // ingresarProgramaToolStripMenuItem
            // 
            this.ingresarProgramaToolStripMenuItem.Name = "ingresarProgramaToolStripMenuItem";
            this.ingresarProgramaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ingresarProgramaToolStripMenuItem.Text = "Ingresar Programa";
            this.ingresarProgramaToolStripMenuItem.Click += new System.EventHandler(this.ingresarProgramaToolStripMenuItem_Click);
            // 
            // mostrarProgramaToolStripMenuItem
            // 
            this.mostrarProgramaToolStripMenuItem.Name = "mostrarProgramaToolStripMenuItem";
            this.mostrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mostrarProgramaToolStripMenuItem.Text = "Mostrar Programa";
            this.mostrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.mostrarProgramaToolStripMenuItem_Click);
            // 
            // padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.uima;
            this.ClientSize = new System.Drawing.Size(1112, 448);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "padre";
            this.Text = "Sistema Inteligente de Retiros Institucionales Sena";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.padre_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.padre_FormClosed);
            this.Load += new System.EventHandler(this.padre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aprendizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarAprendizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAprendizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInstructorToolStripMenuItem;
    }
}

