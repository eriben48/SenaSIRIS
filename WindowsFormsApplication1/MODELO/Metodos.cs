using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Metodos
    {
        
        
        public static String NumeroPrograma, NombrePrograma, TipoPrograma, AreaPrograma;
        public static void IngresarPrograma(String NumeroPrograma, String NombrePrograma, String TipoPrograma, String AreaPrograma)
        {
            

            try
            {
                SqlCommand Commando;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                Commando = new SqlCommand("insert into Programas(IdPrograma,Nombre,Tipo,Area) values('" + NumeroPrograma.ToUpper() + "','" + NombrePrograma.ToUpper() + "','" + TipoPrograma.ToUpper() + "','" + AreaPrograma.ToUpper() + "')", Puente.RetornarConnexion());
                Commando.ExecuteNonQuery();

                MessageBox.Show("INGRESO EXITOSO");
                Commando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INGRESO ERRONEO");
            }

        }
       
    }
}
