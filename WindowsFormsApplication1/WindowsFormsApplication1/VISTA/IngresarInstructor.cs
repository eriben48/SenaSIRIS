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
    public partial class IngresarInstructor : Form
    {
        public IngresarInstructor()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            TxtDocumento.Text = ("");
            TxtNombre.Text = ("");
            TxtApellido.Text = ("");
            TxtDireccion.Text = ("");
            TxtTelefono.Text = ("");
            TxtCelular.Text = ("");
            TxtProfesion.Text = ("");
            ComboBoxEstado.Text = ("");
        }
        public int Revisar()
        {
            int ok = 1;
            if (TxtDocumento.Text.Equals("")) { ok = 0; }
            if (TxtNombre.Text.Equals("")) { ok = 0; }
            if (TxtApellido.Text.Equals("")) { ok = 0; }
            if (TxtDireccion.Text.Equals("")) { ok = 0; }
            if (TxtTelefono.Text.Equals("")) { ok = 0; }
            if (TxtCelular.Text.Equals("")) { ok = 0; }
            if (TxtProfesion.Text.Equals("")) { ok = 0; }
            if (ComboBoxEstado.Text.Equals("")) { ok = 0; }

            return ok;
        }
        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras();
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros();
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Revisar() == 1)
            {

                MetodoIngresarInstructor.Documento = TxtDocumento.Text;
                MetodoIngresarInstructor.Nombre = TxtNombre.Text.ToUpper();
                MetodoIngresarInstructor.Apellido = TxtNombre.Text.ToUpper();
                MetodoIngresarInstructor.Direccion = TxtDireccion.Text.ToUpper();
                MetodoIngresarInstructor.Telefono = TxtTelefono.Text;
                MetodoIngresarInstructor.Celular = TxtCelular.Text;
                MetodoIngresarInstructor.Profesion = TxtProfesion.Text.ToUpper();
                MetodoIngresarInstructor.Estado = ComboBoxEstado.Text.ToUpper();
                MetodoIngresarInstructor.IngresarInstructor(MetodoIngresarInstructor.Documento, MetodoIngresarInstructor.Nombre, MetodoIngresarInstructor.Apellido, MetodoIngresarInstructor.Direccion, MetodoIngresarInstructor.Telefono, MetodoIngresarInstructor.Celular, MetodoIngresarInstructor.Profesion, MetodoIngresarInstructor.Estado);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ingrese correctamente los campos","SIRIS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
