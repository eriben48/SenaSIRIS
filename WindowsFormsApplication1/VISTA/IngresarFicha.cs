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
    public partial class IngresarFicha : Form
    {
        public IngresarFicha()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            ficha.Text = "";
            instructor.Text = "";
            programa.Text = "";
            comboBoxJornada.Text = "";
            dateTimeInicio.Text = "";
            dateTimeFin.Text = "";
            comboBoxEstado.Text = "";
         

        }

        public int Revisar()
        {
            int ok = 0;
            if (ficha.Text == "") { ok = 1; }
            if (instructor.Text == "") { ok = 1; }
            if (programa.Text == "") { ok = 1; }
            if (comboBoxJornada.Text == "") { ok = 1; }
            if (dateTimeInicio.Text == "") { ok = 1; }
            if  (dateTimeFin.Text == "") { ok = 1; }
            if (comboBoxEstado.Text == "") { ok = 1; }
            return ok;
        }

        private void IngresarFicha_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.IngresarFicha = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Revisar() == 0)
                {
                    MetodoIngresarFicha.IdFicha = ficha.Text;
                    MetodoIngresarFicha.DocumentoInstructor = instructor.Text.ToUpper();
                    MetodoIngresarFicha.IdPrograma = programa.Text.ToUpper();
                    MetodoIngresarFicha.Jornada = comboBoxJornada.Text;
                    MetodoIngresarFicha.FechaInicio1 = dateTimeInicio.Value;
                    MetodoIngresarFicha.FechaFin1 = dateTimeFin.Value;
                    MetodoIngresarFicha.Estado = comboBoxEstado.Text;
                    MetodoIngresarFicha.IngresarFicha(MetodoIngresarFicha.IdFicha, MetodoIngresarFicha.DocumentoInstructor, MetodoIngresarFicha.IdPrograma, MetodoIngresarFicha.Jornada, MetodoIngresarFicha.FechaInicio1, MetodoIngresarFicha.FechaFin1, MetodoIngresarFicha.Estado);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese correctamente los campos");
                    Limpiar();
                }
            }


            catch (Exception ex)
            { MessageBox.Show("Error" + ex.ToString()); }
        }

        private void ficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void instructor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void programa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void programa_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresarFicha_Load(object sender, EventArgs e)
        {

        }
    }
}
