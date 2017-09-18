using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MetodoIngresarProceso
    {
        public static String IdProceso,TipoProceso,TipoNovedad,Fecha,FechaRadicacion,ConceptoNovedad,DocumentoAprendiz;
        public static DateTime DateFecha;
        public static DateTime DateFechaRadicacion;
        //public static void IngresarProceso(String TxtNumeroProceso, DateTime DateFecha,DateTime FechaRadicacion, String ComboBoxTipoProceso, String ComboBoxTipoNovedad, String TxtConceptoNovedad, String TxtDocAprendiz)
            public static void IngresarProceso(string idProceso, string tipoProceso, DateTime dateFecha, string fechaRadicacion, string tipoNovedad, string conceptoNovedad, string documentoAprendiz)
        {


            try
            {
                SqlCommand Commando;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                Commando = new SqlCommand("insert into Proceso(TipoProceso,Fecha,FechaRadicacion,TipoNovedad,ConceptoNovedad,DocumentoAprendiz) values('"
                    + TipoProceso.ToUpper() + "','" + DateFecha +  "','" + DateFechaRadicacion + "','" + TipoNovedad.ToUpper() +
                "','" + ConceptoNovedad.ToUpper() + "','" + DocumentoAprendiz.ToUpper() + "')",
                Puente.RetornarConnexion()); 
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
