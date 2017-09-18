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
        DateTime fecha;
        SqlDataReader lector;
        SqlDataReader lector1;
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
            textDireccion.Text = "";
            textTelefono.Text = "";
            textCelular.Text = "";
            textCorreo.Text = "";
            textCelularContacto.Text = "";
            textGenero.SelectedItem = "";
            label15.Text = "";


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
                    MetodoIngresarAprendiz.Estado = Estado.Text.ToString();
                    MetodoIngresarAprendiz.Direccion = textDireccion.Text.ToUpper();
                    MetodoIngresarAprendiz.Telefono = textTelefono.Text.ToUpper();
                    MetodoIngresarAprendiz.Celular = textCelular.Text.ToUpper();
                    MetodoIngresarAprendiz.Correo = textCorreo.Text.ToUpper();
                    MetodoIngresarAprendiz.CelularContacto = textCelularContacto.Text.ToUpper();
                    MetodoIngresarAprendiz.Genero = textGenero.SelectedItem.ToString();
                    MetodoIngresarAprendiz.IngresarAprendiz(MetodoIngresarAprendiz.NombreDocumento, MetodoIngresarAprendiz.DocumentoAprendiz, MetodoIngresarAprendiz.Ficha, MetodoIngresarAprendiz.NombreAprendiz, MetodoIngresarAprendiz.ApellidoAprendiz, MetodoIngresarAprendiz.FechaNacimiento1, MetodoIngresarAprendiz.Direccion, MetodoIngresarAprendiz.Telefono, MetodoIngresarAprendiz.Celular, MetodoIngresarAprendiz.Correo, MetodoIngresarAprendiz.CelularContacto, MetodoIngresarAprendiz.Estado, MetodoIngresarAprendiz.Genero);
                    FechaNacimiento1.Value = fecha;
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
            if (textFicha.Text.Length >= 1)
            {
                int existe = 0;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select IdFicha from Ficha where IdFicha= '" + textFicha.Text + "'", Puente.RetornarConnexion());
                lector = Commando.ExecuteReader();
                while (lector.Read())
                {
                    textFicha.Text = lector.GetString(0);
                    lector.NextResult();
                    existe = 1;

                }
                lector.Close();
                Commando.Dispose();

                if (existe == 0)
                {

                    MessageBox.Show("La ficha no  esta registrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpiar();

                }



                ConnectionBD Puente1;
                Puente1 = new ConnectionBD();
                SqlCommand Commando1 = new SqlCommand("select Estado from Ficha where IdFicha= '" + textFicha.Text + "'", Puente1.RetornarConnexion());
                lector1 = Commando1.ExecuteReader();
                while (lector1.Read())
                {
                    label15.Text = lector1.GetString(0);
                    lector1.NextResult();

                }

                lector1.Close();
                if (label15.Text.Equals("INACTIVO"))
                {

                    MessageBox.Show("EL ESTADO DE LA FICHA REGISTRADA ES INACTIVA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpiar();

                }
            }
           
        }

        private void IngresarAprendiz_Load(object sender, EventArgs e)
        {
            fecha = FechaNacimiento1.Value;
        }
    }
}
