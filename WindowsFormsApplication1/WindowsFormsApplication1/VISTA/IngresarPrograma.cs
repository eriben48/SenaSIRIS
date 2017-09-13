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
           
        }

        private void INGRESAR_Click(object sender, EventArgs e)
        {
            Metodos.NumeroPrograma = TexNumeroPrograma.Text.ToUpper();
            Metodos.NombrePrograma = TexNombrePrograma.Text.ToUpper();
            Metodos.TipoPrograma = TexTipoPrograma.Text.ToUpper();
            Metodos.AreaPrograma = TexAreaPrograma.Text.ToUpper();
            Metodos.IngresarPrograma(Metodos.NumeroPrograma,Metodos.NombrePrograma,Metodos.TipoPrograma,Metodos.AreaPrograma);
        }

        private void IngresarPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
