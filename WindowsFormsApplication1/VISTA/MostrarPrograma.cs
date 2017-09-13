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
    public partial class MostrarPrograma : Form
    {
        public MostrarPrograma()
        {
            InitializeComponent();
        }

        private void MostrarPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.MostrarPrograma = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MostrarProgramas.MostrarTodoProgramas();
            MostrarProgramas.da.Fill(MostrarProgramas.ds);
            DtProgramas.DataSource = MostrarProgramas.ds.Tables[0];
        }

        private void Programas_Click(object sender, EventArgs e)
        {
            MostrarProgramas.IdProgramas = TxtIdprogramas.Text;
            MostrarProgramas.MetodoMostrarProgramas(MostrarProgramas.IdProgramas);
            MostrarProgramas.da.Fill(MostrarProgramas.ds);
            DtProgramas.DataSource = MostrarProgramas.ds.Tables[0];
        }

        private void TxtIdprogramas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void MostrarPrograma_Load(object sender, EventArgs e)
        {

        }
    }
}
