using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MostrarProgramas
    {
        public object DataSource { get; private set; }
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static string IdProgramas;
        public static void MetodoMostrarProgramas(string IdProgramas)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Programas where IdPrograma='" + IdProgramas + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
            public static void MostrarTodoProgramas()
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Programas", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        }
    }

