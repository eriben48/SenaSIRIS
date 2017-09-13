using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MetodoMostrarFicha
    {
        public object DataSource { get; private set; }
        public static string DocumentoInstructor { get; internal set; }
        public static string Estado { get; internal set; }

        public static DataSet ds;
        public static SqlDataAdapter da;
        public static string IdFicha;
        public static void MetodoMostrarFichas(string IdFichas)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Ficha where IdFicha='" + IdFicha + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarTodoFichas()
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Ficha", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarInstructorFicha(string DocumentoInstructor)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Ficha where DocumentoInstructor='" + DocumentoInstructor + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
            public static void MostrarEstadoFicha(string ACTIVO)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Ficha where Estado='" +ACTIVO + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
    }
}

    
    

