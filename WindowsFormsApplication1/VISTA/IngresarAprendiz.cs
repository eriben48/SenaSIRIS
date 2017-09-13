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
    public partial class IngresarAprendiz : Form
    {
        public IngresarAprendiz()
        {
            InitializeComponent();
        }
     
        private void IngresarAprendiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.IngresarAprendiz = 0;
        }
        public void Limpiar()
        {
            Tipo.SelectedItem = "";
            textDocumentoAprendiz.Text = "";
            textFicha.Text = "";
            textNombreAprendiz.Text = "";
            textApellidoAprendiz.Text = "";
            FechaNacimiento1.Text = "";
            textEstado.SelectedItem = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textCelular.Text = "";
            textCorreo.Text = "";
            textCelularContacto.Text = "";
            textGenero.SelectedItem = "";


        }
        public int Revisar()
        {
            int ok = 0;
            if (Tipo.Text == "") { ok = 1; }
            if (textDocumentoAprendiz.Text == "") { ok = 1; }
            if (textFicha.Text == "") { ok = 1; }
            if (textNombreAprendiz.Text == "") { ok = 1; }
            if (textApellidoAprendiz.Text == "") { ok = 1; }
            if (FechaNacimiento1.Text == "") { ok = 1; }
            if (textEstado.Text == "") { ok = 1; }
            if (textDireccion.Text == "...") { ok = 1; }
            if (textTelefono.Text == "...") { ok = 1; }
            if (textCelular.Text == "...") { ok = 1; }
            if (textCorreo.Text == "...") { ok = 1; }
            if (textCelularContacto.Text == "...") { ok = 1; }
            if (textGenero.Text == "...") { ok = 1; }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Revisar() == 0)
                {
                    MetodoIngresarAprendiz.NombreDocumento = Tipo.SelectedItem.ToString();
                    MetodoIngresarAprendiz.DocumentoAprendiz = textDocumentoAprendiz.Text.ToUpper();
                    MetodoIngresarAprendiz.Ficha = textFicha.Text.ToUpper();
                    MetodoIngresarAprendiz.NombreAprendiz = textNombreAprendiz.Text.ToUpper();
                    MetodoIngresarAprendiz.ApellidoAprendiz = textApellidoAprendiz.Text.ToUpper();
                    MetodoIngresarAprendiz.FechaNacimiento1 = FechaNacimiento1.Value;
                    MetodoIngresarAprendiz.Estado = textEstado.SelectedItem.ToString();
                    MetodoIngresarAprendiz.Direccion = textDireccion.Text.ToUpper();
                    MetodoIngresarAprendiz.Telefono = textTelefono.Text.ToUpper();
                    MetodoIngresarAprendiz.Celular = textCelular.Text.ToUpper();
                    MetodoIngresarAprendiz.Correo = textCorreo.Text.ToUpper();
                    MetodoIngresarAprendiz.CelularContacto = textCelularContacto.Text.ToUpper();
                    MetodoIngresarAprendiz.Genero = textGenero.SelectedItem.ToString();
                    MetodoIngresarAprendiz.IngresarAprendiz(MetodoIngresarAprendiz.NombreDocumento, MetodoIngresarAprendiz.DocumentoAprendiz, MetodoIngresarAprendiz.Ficha, MetodoIngresarAprendiz.NombreAprendiz, MetodoIngresarAprendiz.ApellidoAprendiz, MetodoIngresarAprendiz.FechaNacimiento1, MetodoIngresarAprendiz.Direccion, MetodoIngresarAprendiz.Telefono, MetodoIngresarAprendiz.Celular, MetodoIngresarAprendiz.Correo, MetodoIngresarAprendiz.CelularContacto, MetodoIngresarAprendiz.Estado, MetodoIngresarAprendiz.Genero);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese Correctamente los campos");
                    Limpiar();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            
        }
            
        private void textDocumentoAprendiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void textFicha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void textNombreAprendiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void textApellidoAprendiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void textCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void textCelularContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void textCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFicha_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("sdfsdf");
        }

        private void IngresarAprendiz_Load(object sender, EventArgs e)
        {

        }
    }
}
