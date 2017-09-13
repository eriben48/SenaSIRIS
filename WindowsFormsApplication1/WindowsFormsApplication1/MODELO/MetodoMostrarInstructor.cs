using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MetodoMostrarInstructor
    {
        public object DataSource { get; private set; }
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static void MostrarDataGrid()
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Instructor", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();


            }
            catch (Exception)
            {

            }
        }

    }
}
