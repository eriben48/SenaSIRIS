using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MetodoMostrarProceso
    {
        public object DataSource { get; private set; }
        public static string FechaRadicacion { get; internal set; }
        public static string TipoProceso { get; internal set; }
        public static string DocumentoAprendiz { get; internal set; }

        public static DataSet ds;
        public static SqlDataAdapter da;
        public static string IdProceso;
        public static void MetodoMostrarProcesos(string IdProceso)
        {
            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from Proceso where IdProceso='" + IdProceso + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarTodoProceso()
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Proceso", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarIdProceso(string IdProceso)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Proceso where IdProceso='" + IdProceso + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarFechaRadicacion(string FechaRadicacion)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Proceso where FechaRadicacion='" + FechaRadicacion + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarTipoProceso(string TipoProceso)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Proceso where TipoProceso='" + TipoProceso + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
        public static void MostrarDocumentoAprendiz(string DocumentoAprendiz)
        {

            try
            {
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                SqlCommand Commando = new SqlCommand("select * from  Proceso where DocumentoAprendiz='" + DocumentoAprendiz + "'", Puente.RetornarConnexion());
                da = new SqlDataAdapter(Commando);
                ds = new DataSet();
            }
            catch (Exception)
            {

            }
        }
    }
}

