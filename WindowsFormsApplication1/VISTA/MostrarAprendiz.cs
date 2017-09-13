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
    public partial class MostrarAprendiz : Form
    {
        private static string NombreAprendiz;
        private static string Idficha;
        private static string DocumentoAprendiz;
        private static DataSet ds;

        public MostrarAprendiz()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            nombre.Text = "";
            documento.Text = "";
            ficha.Text = "";
        }

        private void MostrarAprendiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.MostrarAprendiz = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoMostrarAprendiz.MostrarDataGrid();
            MetodoMostrarAprendiz.da.Fill(MetodoMostrarAprendiz.ds);
            MostrarDataGrid.DataSource = MetodoMostrarAprendiz.ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoMostrarAprendiz.NombreAprendiz = nombre.Text.ToUpper();
            MetodoMostrarAprendiz.MostrarNombre(MetodoMostrarAprendiz.NombreAprendiz);
            MetodoMostrarAprendiz.da.Fill(MetodoMostrarAprendiz.ds);
            MostrarDataGrid.DataSource = MetodoMostrarAprendiz.ds.Tables[0];
            Limpiar();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            MetodoMostrarAprendiz.Idficha = ficha.Text;
            MetodoMostrarAprendiz.MostrarFicha(MetodoMostrarAprendiz.Idficha);
            MetodoMostrarAprendiz.da.Fill(MetodoMostrarAprendiz.ds);
            MostrarDataGrid.DataSource = MetodoMostrarAprendiz.ds.Tables[0];
            Limpiar();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            MetodoMostrarAprendiz.DocumentoAprendiz = documento.Text;
            MetodoMostrarAprendiz.MostrarDocumento(MetodoMostrarAprendiz.DocumentoAprendiz);
            MetodoMostrarAprendiz.da.Fill(MetodoMostrarAprendiz.ds);
            MostrarDataGrid.DataSource = MetodoMostrarAprendiz.ds.Tables[0];
            Limpiar();
        
        }

        private void documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void ficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }
    }
}
