using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class padre : Form
    {
        public static int IngresarPrograma=0, IngresarInstructor=0, MostrarInstructor=0;
        IngresarPrograma I;
        IngresarInstructor II;
        MostrarInstructor MI;
        public padre()
        {
            InitializeComponent();
        }

        private void ingresarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresarPrograma == 0)
            {
                IngresarPrograma I = new IngresarPrograma();
                I.MdiParent = this;
                I.Show();
                IngresarPrograma = 1;
            }
        }

        private void padre_Load(object sender, EventArgs e)
        {

        }

        private void mostrarInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( MostrarInstructor == 0)
            {
                MostrarInstructor MI = new MostrarInstructor();
                MI.MdiParent = this;
                MI.Show();
                MostrarInstructor = 1;
            }
        }

        private void ingresarInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresarInstructor == 0)
            {
                IngresarInstructor II = new IngresarInstructor();
                II.MdiParent = this;
                II.Show();
                IngresarInstructor = 1;
            }
        }
    }
}
