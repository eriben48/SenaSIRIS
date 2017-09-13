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
    public partial class IngresarPrograma : Form
    {



        public IngresarPrograma()
        {
            InitializeComponent();
        }

        private void IngresarPrograma_Load(object sender, EventArgs e)
        {
          /*
        
            try
            {
                ConnectionBD Puente;
                SqlDataReader Lector;
                Puente = new ConnectionBD();
                SqlCommand Commando;
                Commando = new SqlCommand("SELECT DISTINCT Tipo FROM Programas", Puente.RetornarConnexion());
                Lector = Commando.ExecuteReader();
                while(Lector.Read())
                {
                    ComboxTipoPrograma.Items.Add(Lector.GetString(0));
                    
                }
            }
            catch (Exception)
            {

            }
            try
            {
                ConnectionBD Puente;
                SqlDataReader Lector;
                Puente = new ConnectionBD();
                SqlCommand Commando;
                Commando = new SqlCommand("SELECT DISTINCT Area FROM Programas", Puente.RetornarConnexion());
                Lector = Commando.ExecuteReader();
                while (Lector.Read())
                {
                    
                    ComboxAreaPrograma.Items.Add(Lector.GetString(0));
                }
            }
            catch (Exception)
            {

            }*/

        }
        private void INGRESAR_Click(object sender, EventArgs e)
        {
            Metodos.NumeroPrograma = TexNumeroPrograma.Text.ToUpper();
            Metodos.NombrePrograma = TexNombrePrograma.Text.ToUpper();
            Metodos.TipoPrograma = ComboxTipoPrograma.Text.ToUpper();
            Metodos.AreaPrograma = ComboxAreaPrograma.Text.ToUpper();
            Metodos.IngresarPrograma(Metodos.NumeroPrograma,Metodos.NombrePrograma,Metodos.TipoPrograma,Metodos.AreaPrograma);
        }

        private void IngresarPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.IngresarPrograma = 0;
        }

        private void TexNumeroPrograma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TexNombrePrograma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
