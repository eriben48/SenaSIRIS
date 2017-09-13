using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.VISTA;

namespace WindowsFormsApplication1
{
    public partial class padre : Form
    {
        public static int IngresarAprendiz = 0,MostrarAprendiz=0, IngresarInstructor = 0, MostrarInstructor = 0, IngresarPrograma = 0, MostrarPrograma = 0, IngresarProceso = 0, MostrarProceso = 0, IngresarFicha = 0,MostrarFicha=0,ActualizarInstructor=0;

        private void mostrarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarFicha == 0)
            {
                MostrarFicha I = new MostrarFicha();
                I.MdiParent=this;
                I.Show();
                MostrarFicha = 1;
            }
        }

        private void mostrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarPrograma == 0)
            {
                MostrarPrograma I = new MostrarPrograma();
                I.MdiParent = this;
                I.Show();
                MostrarPrograma = 1;
            }
        }

        private void mostrarProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarProceso == 0)
            {
                MostrarProceso MI = new MostrarProceso();
                MI.MdiParent = this;
                MI.Show();
                MostrarProceso = 1;
            }
        }

        private void padre_FormClosing(object sender, FormClosingEventArgs e)
        {
            AntesdeCerrar.Formulario = this;
            AntesdeCerrar.Antesdecerrar(e);
        }

        private void padre_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void intructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActualizarInstructor == 0)
            {
                ActualizarInstructor  AI= new ActualizarInstructor();
                AI.MdiParent = this;
                AI.Show();
                ActualizarInstructor = 1;
            }
        }

        private void ingresarProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresarProceso == 0)
            {
                
                IngresoProceso I = new IngresoProceso();
                I.MdiParent = this;
                I.Show();
                IngresarProceso = 1;
            }
        }

        private void mostrarAprendizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarAprendiz == 0)
            {
                MostrarAprendiz I = new MostrarAprendiz();
                I.MdiParent = this;
                I.Show();
                MostrarAprendiz = 1;
            }
        }

        private void ingresarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresarFicha == 0)
            {
                IngresarFicha I = new IngresarFicha();
                I.MdiParent = this;
                I.Show();
                IngresarFicha = 1;
            }
        }

        private void ingresarAprendizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresarAprendiz == 0)
            { 
            IngresarAprendiz I = new IngresarAprendiz();
            I.MdiParent = this;
            I.Show();
            IngresarAprendiz= 1;
            }
        }

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
