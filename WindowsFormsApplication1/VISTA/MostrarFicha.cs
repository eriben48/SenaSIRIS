using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MODELO;

namespace WindowsFormsApplication1
{
    public partial class MostrarFicha : Form
    {


        public MostrarFicha()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
          Ficha.Text = "";
          instructor1.Text = "";
          estado.Text = "";
        }

        private void MostrarFicha_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.MostrarFicha = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoMostrarFicha.IdFicha = Ficha.Text;
            MetodoMostrarFicha.MetodoMostrarFichas(MetodoMostrarFicha.IdFicha);
            MetodoMostrarFicha.da.Fill(MetodoMostrarFicha.ds);
            DataGrievFicha.DataSource = MetodoMostrarFicha.ds.Tables[0];
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoMostrarFicha.MostrarTodoFichas();
            MetodoMostrarFicha.da.Fill(MetodoMostrarFicha.ds);
            DataGrievFicha.DataSource = MetodoMostrarFicha.ds.Tables[0];
            Limpiar();
        }

        private void Ficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            MetodoMostrarFicha.DocumentoInstructor = instructor1.Text;
            MetodoMostrarFicha.MostrarInstructorFicha(MetodoMostrarFicha.DocumentoInstructor);
            MetodoMostrarFicha.da.Fill(MetodoMostrarFicha.ds);
            DataGrievFicha.DataSource = MetodoMostrarFicha.ds.Tables[0];
            Limpiar();
        }

        private void instructor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
    }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodoMostrarFicha.Estado = estado.Text;
            MetodoMostrarFicha.MostrarEstadoFicha(MetodoMostrarFicha.Estado);
            MetodoMostrarFicha.da.Fill(MetodoMostrarFicha.ds);
            DataGrievFicha.DataSource = MetodoMostrarFicha.ds.Tables[0];
            Limpiar();
        }

        private void estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
