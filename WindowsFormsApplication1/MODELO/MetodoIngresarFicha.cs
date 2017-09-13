using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.MODELO
{
    class MetodoIngresarFicha
    {
        public static String IdFicha, DocumentoInstructor, IdPrograma, Jornada,FechaInicio,FechaFin, Estado;
        public static DateTime FechaInicio1, FechaFin1;
        public static void IngresarFicha(String IdFicha, String DcumentoInstructor, String IdPrograma, String Jornada, DateTime FefchaInicio1, DateTime FechaFin1, String Estado)
        {

            try
            {
                SqlCommand Commando;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                Commando = new SqlCommand("insert into Ficha (IdFicha,DocumentoInstructor,IdPrograma,Jornada,FechaInicio,FechaFin,Estado)  values('" + IdFicha.ToUpper() + "','"
                         + DocumentoInstructor.ToUpper() + "','" + IdPrograma.ToUpper() + "','"
                     + Jornada.ToUpper() + "','" + FechaInicio1 + "','" + FechaFin1
                     + "','" + Estado + "')", Puente.RetornarConnexion());
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
