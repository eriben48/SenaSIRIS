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

namespace WindowsFormsApplication1.VISTA
{
    public partial class ActualizarFicha : Form
    {
        private object ex;

        public ActualizarFicha()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            ficha.Text = "";
            documento.Text = "";
            programa.Text = "";
            combJornada.SelectedItem = "";
            dateTimeInicio.Text = "";
            dateTimeFin.Text = "";
            combEstado.SelectedItem = "";
        }
        public int Revisar1()
        {
            int ok = 0;
            if (ficha.Text == "") { ok = 1; }
            if (documento.Text == "") { ok = 1; }
            if (programa.Text == "") { ok = 1; }
            if (combJornada.Text == "") { ok = 1; }
            if (dateTimeInicio.Text== "") { ok = 1; }
            if (dateTimeFin.Text == "") { ok = 1; }
            if (combEstado.Text == "") { ok = 1; }
            return ok;
        }
 

        public static string IdFicha { get; private set; }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (ActualizarF.existe == 0)
            {
                ActualizarF x = new ActualizarF();
                x.IdFicha = ficha.Text;
                x.MetodoActualizarFicha(x.IdFicha);
                documento.Text = x.DocumentoInstructor;
                programa.Text = x.IdPrograma;
                combJornada.Text = x.Jornada;
                combEstado.Text = x.Estado;

                if (programa.Text.Length > 0)
                {
                    dateTimeInicio.Value = ActualizarF.FechaInicio;
                    dateTimeFin.Value = ActualizarF.FechaFin;
                }

                if (programa.Text.Length > 0)
                {
                    Buscar.Enabled = false;
                    ficha.Enabled = false;
                    documento.Enabled = true;
                    programa.Enabled = true;
                    combJornada.Enabled = true;
                    dateTimeInicio.Enabled = true;
                    dateTimeFin.Enabled = true;
                    combEstado.Enabled = true;
                    ACTUALIZAR.Enabled = true;
                }
            }
        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (Revisar1() == 0)
            {
                ActualizarF x = new ActualizarF();

                x.Actualizar(ficha.Text, documento.Text, programa.Text, combJornada.Text, dateTimeInicio.Value, dateTimeFin.Value, combEstado.Text);
                Limpiar();
                Buscar.Enabled = true;
                ficha.Enabled = true;
                documento.Enabled = false;
                programa.Enabled = false;
                combJornada.Enabled = false;
                dateTimeInicio.Enabled = false;
                dateTimeFin.Enabled = false;
                combEstado.Enabled = false;
               ACTUALIZAR.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese los campos faltantes");
            }
        }

        private void ficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void programa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void ActualizarFicha_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ActualizarFicha_Load(object sender, EventArgs e)
        {

            documento.Enabled = false;
            programa.Enabled = false;
            combJornada.Enabled = false;
            dateTimeInicio.Enabled = false;
            dateTimeFin.Enabled = false;
            combEstado.Enabled = false;
            ACTUALIZAR.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
