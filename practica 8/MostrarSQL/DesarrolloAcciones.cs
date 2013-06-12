using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class DesarrolloAcciones : MySQL
    {
        public ArrayList ObtenerDatos()
        {
            this.IniciarConeccion();
            MySqlCommand Comando = new MySqlCommand(this.Query(),this.Conectado);

            MySqlDataReader LeerSQL = Comando.ExecuteReader();

            ArrayList DatosTabla = new ArrayList();

            Datos datos;

            while (LeerSQL.Read())
            {
                datos = new Datos();
                datos.id = int.Parse(LeerSQL["Id"].ToString());
                datos.nombre = LeerSQL["Nombre"].ToString();
                datos.apellido = LeerSQL["Apellido"].ToString();
                datos.domicilio = LeerSQL["Domicilio"].ToString();
                datos.fecha = LeerSQL["Fecha"].ToString();

                DatosTabla.Add(datos);
            }

            Comando.Dispose();
            Comando = null;

            LeerSQL.Close();
            LeerSQL = null;

            this.CerrarConeccion();
            
            return DatosTabla;
        }

        private string Query()
        {
            string ComandodeEnlace = "SELECT * FROM Empleados";

            return ComandodeEnlace;
        }
    }
}
