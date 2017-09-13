using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MetodoIngresarInstructor
    {
        public static String Documento, Nombre, Apellido, Direccion,Telefono,Celular,Profesion,Estado;
        public static void IngresarInstructor(String Documento, String Nombre, String Apellido, String Direccion, String Telefono, String Celular, String Profesion, String Estado)
        {


            try
            {
                SqlCommand Commando;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                Commando = new SqlCommand("insert into Instructor(DocumentoInstructor,NombreInstructor,ApellidoInstructor,Direccion,Telefono,Celular,Profesion,Estado)  values('" + Documento.ToUpper() + "','" 
                        + Nombre.ToUpper() + "','" + Apellido.ToUpper() + "','"
                    + Direccion.ToUpper() + "','" + Telefono.ToUpper() + "','" + Celular.ToUpper() 
                    + "','" + Profesion.ToUpper() + "','" +Estado + "')", Puente.RetornarConnexion());
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
