using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MetodoIngresarAprendiz
    {
        public static string NombreDocumento, DocumentoAprendiz, Ficha, NombreAprendiz, ApellidoAprendiz, Direccion, Telefono, Celular, Correo, CelularContacto, Genero, Estado;
        public static DateTime FechaNacimiento1;
        public static void IngresarAprendiz(string NombreDocumento, string DocumentoAprendiz, string Ficha, string NombreAprendiz, string ApellidoAprendiz, DateTime FechaNacimiento1, string Direccion, string Telefono, string Celular, string Correo, string CelularContacto, string Estado, string Genero)
        {
            try
                {
                    SqlCommand Commando;
                    ConnectionBD Puente;
                    Puente = new ConnectionBD();
                    Commando = new SqlCommand("insert into Aprendiz(DocumentoAprendiz,IdFicha,NombreDocumento,NombreAprendiz,ApellidoAprendiz,Direccion,Telefono,Celular,Correo,FechaNacimiento,CelularContacto,Estado,Genero) values('"+DocumentoAprendiz+"','"+Ficha+"','"+NombreDocumento+"','"+NombreAprendiz+"','"+ApellidoAprendiz+"','"+Direccion+"','"+Telefono+"','"+Celular+"','"+Correo+"','"+FechaNacimiento1+"','"+CelularContacto+"','"+Estado+"','"+Genero+"');",Puente.RetornarConnexion());
                    Commando.ExecuteNonQuery();
                    //MessageBox.Show(""+Commando.ExecuteNonQuery());
                    Commando.Dispose();
                }
                catch (Exception ex)
                    {
                        MessageBox.Show("INGRESO ERRONEO"+ex);
                    }
        }

    }

}
