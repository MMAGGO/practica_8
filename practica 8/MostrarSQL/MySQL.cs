using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class MySQL
    {
        protected MySqlConnection Conectado;

        protected void IniciarConeccion()
        {
            String Cadena = "Server = localhost;" +
                                  "User ID = Eliseo;" +
                                  "Database = Empleo;" +
                                  "Password = 12345;" +
                                  "Pooling = false";
            this.Conectado = new MySqlConnection(Cadena);
            this.Conectado.Open();
        }

        protected void CerrarConeccion()
        {
            Conectado.Close();
            Conectado = null;
        }
    }
}
