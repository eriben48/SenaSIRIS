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
    class Instructor
    {
        //public string Documento1,Nombre1, Apellido1, Direccion1, Telefono1, Celular1, Profesion1, Estado1;
        public string DocumentoInstructor, Nombre, Apellido, Direccion, Telefono, Celular, Profesion, Estado;
       // public string DocumentoInstructor,Nombre1,Apellido1,Direccion1,Telefono1,Celular1,Profesion1,Estado1;
        public void  MetodoInstructor(string DocumentoInstructor)
        {

            try
            {
                ConnectionBD Puente;
                SqlCommand Comando;
                SqlDataReader Lector;
                Puente = new ConnectionBD();
                Comando = new SqlCommand("select * from Instructor where DocumentoInstructor='" + DocumentoInstructor + "'", Puente.RetornarConnexion());
                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                     Nombre = Lector.GetString(1);
                     Apellido = Lector.GetString(2);
                     Direccion = Lector.GetString(3);
                     Telefono = Lector.GetString(4);
                     Celular = Lector.GetString(5);
                     Profesion = Lector.GetString(6);
                     Estado = Lector.GetString(7);
                   

                }
                Nombre.ToString();
                Apellido.ToString();
                Direccion.ToString();
                Telefono.ToString();
                Celular.ToString();
                Profesion.ToString();
                Estado.ToString();
                Lector.Close();
                Comando.Dispose();
                Puente.CerrarConnexion();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("El Instructor no existe");
            }
        }

        public void Actualizar(string DocumentoInstructor, String Nombre1, String Apellido1, String Direccion1, String Telefono1, String Celular1, String Profesion1, String Estado1)
        {
            try
            {
               
                SqlCommand Comando1;
                ConnectionBD Puente;
                Puente = new ConnectionBD();
                Comando1 = new SqlCommand("Update Instructor set NombreInstructor='"+Nombre1.ToUpper()+"',ApellidoInstructor='"+Apellido1.ToUpper()+"',Direccion='"+Direccion1+"',Telefono='"+Telefono1+"',Celular='"+Celular1+"',Profesion='"+Profesion1.ToUpper()+"',Estado='"+Estado1.ToUpper()+"' where DocumentoInstructor='"+DocumentoInstructor+"'", Puente.RetornarConnexion());
                Comando1.ExecuteNonQuery();

                MessageBox.Show("ACTUALIZACIÓN EXITOSA");
                Comando1.Dispose();
                Puente.CerrarConnexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ACTUALIZACIÓN ERRONEA"+ex.ToString());
            }
        }
    }
}
