using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MODELO;

namespace WindowsFormsApplication1
{
    public partial class MostrarInstructor : Form
    {
      

        public MostrarInstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoMostrarInstructor.MostrarDataGrid();
            MetodoMostrarInstructor.da.Fill(MetodoMostrarInstructor.ds);
            dataGridView1.DataSource = MetodoMostrarInstructor.ds.Tables[0];
        }

        private void MostrarInstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.MostrarInstructor = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoMostrarInstructor.DocumentoInstructor = documento.Text;
            MetodoMostrarInstructor.FiltrarDatos(MetodoMostrarInstructor.DocumentoInstructor);
            MetodoMostrarInstructor.da.Fill(MetodoMostrarInstructor.ds);
            dataGridView1.DataSource = MetodoMostrarInstructor.ds.Tables[0];
        }

        private void documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }
    }

    }

