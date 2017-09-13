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
    public partial class ActualizarInstructor : Form
    {
        public ActualizarInstructor()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            TxtDocumento.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDirección.Text = "";
            TxtTelefono.Text = "";
            TxtCelular.Text= "";
            TxtProfesión.Text = "";
            TxtEstado.Text = "";
            ComboEstado.Text="";
        }
        public static string DocumentoInstructor { get; private set; }

        private void ActualizarInstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.ActualizarInstructor = 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
                Instructor x = new Instructor();
                x.DocumentoInstructor = TxtDocumento.Text;
                x.MetodoInstructor(x.DocumentoInstructor);
                TxtNombre.Text = x.Nombre;
                TxtApellido.Text = x.Apellido;
                TxtDirección.Text = x.Direccion;
                TxtTelefono.Text = x.Telefono;
                TxtCelular.Text = x.Celular;
                TxtProfesión.Text = x.Profesion;
                TxtEstado.Text = x.Estado;
            if (TxtEstado.TextLength > 0)
            {
                TxtDocumento.Enabled = false;
            }
                
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Instructor x = new Instructor();
      
            x.Actualizar(TxtDocumento.Text,TxtNombre.Text,TxtApellido.Text,TxtDirección.Text,TxtTelefono.Text,TxtCelular.Text,TxtProfesión.Text,ComboEstado.Text);
            //textBox1.Text=x. 
            Limpiar();
            TxtDocumento.Enabled = true;
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
           
            Limpiar();
            TxtDocumento.Enabled = true;
        }

        private void ActualizarInstructor_Load(object sender, EventArgs e)
        {
            BtnBuscar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnActualizar.Enabled = false;
        }

        private void TxtEstado_TextChanged(object sender, EventArgs e)
        {
            if (TxtEstado.Text == "")
            {
                BtnActualizar.Enabled = false;
                BtnCancelar.Enabled = false;
            }
            else
            {
                BtnActualizar.Enabled = true;
                BtnCancelar.Enabled = true;
            }
            
        }

        private void TxtDocumento_TextChanged_1(object sender, EventArgs e)
        {
            int contar = TxtDocumento.Text.Count();
            if (contar == 0)
            {
                BtnBuscar.Enabled = false;
            }
            else
            {
                BtnBuscar.Enabled = true;
            }
        }
    }
    }

