﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ConnectionBD
    {
        SqlConnection Connexion;
        int EstadoConnexion = 0;
        public ConnectionBD()

        {
            try
            {

                Connexion = new SqlConnection("Data Source=ADMINISTRADOR-S\\SQLEXPRESS;Initial Catalog=SIRIS;Integrated Security=True;User ID=sa; Password=adsi2017");
                Connexion.Open();
                EstadoConnexion = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexión Erronea");
            }

        }
        public int RetornarEstado()
        {
            return EstadoConnexion;

        }

        public void CerrarConnexion()
        {
            Connexion.Close();
        }

        public SqlConnection RetornarConnexion()
        {
            return Connexion;
        }

    }
}

