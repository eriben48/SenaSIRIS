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

namespace WindowsFormsApplication1
{
    public partial class MostrarInstructor : Form
    {
      

        public MostrarInstructor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void documento_Leave(object sender, EventArgs e)
        {
            MetodoMostrarInstructor.MostrarDataGrid();
            MetodoMostrarInstructor.da.Fill(MetodoMostrarInstructor.ds);
            dataGridView1.DataSource = MetodoMostrarInstructor.ds.Tables[0];
        }
    }

    }

