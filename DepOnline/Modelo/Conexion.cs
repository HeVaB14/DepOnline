using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepOnline.Modelo
{
    //Objetivo  Realizar una conexion ala base de datos para que se puedan trabajr con las consultas sql.
    //Autor Autor Equipo DepOnline.
    //Fecha de Creacion 12 noviembre del 2018.
    //Fecha de Modificación 13 Noviembre del 2018.
    class Conexion

    {
        // Crearemos la conexion a nustra base de datos.

        // Generamos la conexion.
        public OdbcConnection miConexion = null;
        // Los comandos que usaremos.
        public OdbcCommand miComando = null;
        // Las que leera nuestros scrip de la bd.
        public OdbcDataReader miLectura = null;

        private static Conexion miCon = null;
        //Aqui vamos a abriri la conexion.
        public static Conexion GetConexion()
        {
            // Si el valor no es creado.
            if (miCon == null)
                // Creamos la conexion.
                miCon = new Conexion();
            return miCon;
        }
        public OdbcConnection ConectarBD()
        {
            if (miConexion == null)
                // Conexion ala base de datos con el conector odbc.
                miConexion = new OdbcConnection("DSN=servicios");
            return miConexion;
                  
        }


    }
}
