using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Controlador
{
    //Objetivo  Insertar todos los cuartos con los servicios necesarios.
    //Autor Autor Equipo DepOnline
    //Fecha de Creacion 25 noviembre del 2018.
    //Fecha de Modificación 30 enero del 2019.
    class Cuartosincluidoscontroller
    {
        private Cuartosincluidos objtotal = null;

        public Cuartosincluidoscontroller()
        {
            objtotal = new Cuartosincluidos();

        }
        // Recibimos todos los paremetros de todos los campos Cuartos, Sevicios e imagenes.
        public bool Insertarcuarto( string disponible, int numcuarto, string tamaño, string categoria, string direccion, 
            int precio,string baño, string internet, string cable, string amueblado, string aguacaliente, string imagen)
        {
            bool res = false;
            Cuartosincluidos c = new Cuartosincluidos( disponible, numcuarto, tamaño, categoria, direccion, 
                precio,baño,internet,cable,amueblado,aguacaliente,imagen);

            // Describir la variable global.
            res = objtotal.Insertarcuarto(c);
            if (res)
            {
                MessageBox.Show("El registro se realizó de forma correcta", "Registrando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro", "registrando la información", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);

            return res;
        }
        public Cuartosincluidos GetCuartosincluidos(int indice)
        {
            return objtotal.GetCuartosincluidos(indice);
        }


      


    }
}
