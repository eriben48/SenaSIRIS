using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MetodoMostrarAprendiz
    {
        public object DataSource { get; private set; }
        public static string Idficha { get; internal set; }
        public static string NombreAprendiz { get; internal set; }
        public static string DocumentoAprendiz { get; internal set; }

        public static DataSet ds;
        public static SqlDataAdapter da;
        public static string documento;
        public static string ficha;
        public static string nombre;
        public static void MostrarDataGrid()
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Aprendiz ", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();


            }
            catch (Exception)
            {

            }
        }
        public static void MostrarDocumento(string documento)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Aprendiz where DocumentoAprendiz='" + documento + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();

            }
            catch (Exception)
            {

            }
        }

    

        public static void MostrarFicha(string ficha)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Aprendiz  where IdFicha='" + ficha + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();


            }
            catch (Exception)
            {

            }
        }
        public static void MostrarNombre(string nombre)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Aprendiz where NombreAprendiz='" + nombre + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();


            }
            catch (Exception)
            {

            }

        }

       
    }
}
