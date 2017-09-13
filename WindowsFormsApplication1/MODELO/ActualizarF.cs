using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ActualizarF
    {
        public string IdFicha, DocumentoInstructor, IdPrograma, Jornada, Estado;
        public static DateTime FechaInicio;
        public static DateTime FechaFin;
        public static int existe = 0;
        public static string a;

        public void MetodoActualizarFicha(string IdFicha)
        {

            try
            {

                ConnectionBD Puente;
                SqlCommand Comando;
                SqlDataReader Lector;
                Puente = new ConnectionBD();
                Comando = new SqlCommand("select * from Ficha where IdFicha='" + IdFicha + "'", Puente.RetornarConnexion());
                Lector = Comando.ExecuteReader();


                while (Lector.Read())
                {
                    DocumentoInstructor = Lector.GetString(1);
                    IdPrograma = Lector.GetString(2);
                    Jornada = Lector.GetString(3);
                    FechaInicio = Lector.GetDateTime(4);
                    FechaFin = Lector.GetDateTime(5);
                    Estado = Lector.GetString(6);

                }
                a = IdPrograma.ToString();
                if (a == "")
                {
                    existe = 1;
                }
                Lector.Close();
                Comando.Dispose();
                Puente.CerrarConnexion();
            }
     
            catch (Exception ex)
            {
                MessageBox.Show("la ficha no existe");
            }
        }

        public void Actualizar(string IdFicha, String DocumentoInstructor1, String IdPrograma1, String Jornada1, DateTime FechaInicio, DateTime FechaFin, String Estado1)
        {
            try
            {
              
                    SqlCommand Comando1;
                    ConnectionBD Puente;
                    Puente = new ConnectionBD();

                    Comando1 = new SqlCommand("Update Ficha set DocumentoInstructor='" + DocumentoInstructor1.ToUpper() + "',IdPrograma='" + IdPrograma1.ToUpper() + "',Jornada='" + Jornada1 + "',FechaInicio='" + FechaInicio + "',FechaFin='" + FechaFin + "',Estado='" + Estado1.ToUpper() + "' where IdFicha='" + IdFicha + "'", Puente.RetornarConnexion());
                    Comando1.ExecuteNonQuery();

                    MessageBox.Show("ACTUALIZACIÓN EXITOSA");
                    Comando1.Dispose();
                    Puente.CerrarConnexion();
                }
            catch (Exception ex)
            {
                MessageBox.Show("El dato ingresado no existe");
            }
        }
    
    }
}
