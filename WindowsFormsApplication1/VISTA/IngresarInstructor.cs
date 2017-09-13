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
    public partial class IngresarInstructor : Form
    {
        public IngresarInstructor()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            TxtDocumento.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDirección.Text = "";
            TxtDirección.Text = "";
            TxtTelefono.Text = "";
            TxtCelular.Text = "";
            TxtProfesión.Text="";
            
        }

        public int Revisar()
        {
            int ok = 0;
            if (TxtDocumento.Text == "") { ok = 1; }
            if (TxtNombre.Text == "") { ok = 1; }
            if (TxtApellido.Text == "") { ok = 1; }
            if (TxtDirección.Text == "") { ok = 1; }
            if (TxtTelefono.Text == "") { ok = 1; }
            if (TxtCelular.Text == "") { ok = 1; }
            if (TxtProfesión.Text == "") { ok = 1; }
            if (ComboEstado.Text == "...") { ok = 1; }
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Revisar() == 0)
                {
                    MetodoIngresarInstructor.Documento = TxtDocumento.Text;
                    MetodoIngresarInstructor.Nombre = TxtNombre.Text.ToUpper();
                    MetodoIngresarInstructor.Apellido = TxtApellido.Text.ToUpper();
                    MetodoIngresarInstructor.Direccion = TxtDirección.Text;
                    MetodoIngresarInstructor.Telefono = TxtTelefono.Text;
                    MetodoIngresarInstructor.Celular = TxtCelular.Text;
                    MetodoIngresarInstructor.Profesion = TxtProfesión.Text;
                    MetodoIngresarInstructor.Estado = ComboEstado.Text;
                    MetodoIngresarInstructor.IngresarInstructor(MetodoIngresarInstructor.Documento, MetodoIngresarInstructor.Nombre, MetodoIngresarInstructor.Apellido, MetodoIngresarInstructor.Direccion, MetodoIngresarInstructor.Telefono, MetodoIngresarInstructor.Celular, MetodoIngresarInstructor.Profesion, MetodoIngresarInstructor.Estado);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese Correctamente los campos");
                    Limpiar();
                }
            }


            catch (Exception ex)
            { MessageBox.Show("Error" + ex.ToString()); }
        }
    
        

        private void IngresarInstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.IngresarInstructor = 0;
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtProfesión_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void IngresarInstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
