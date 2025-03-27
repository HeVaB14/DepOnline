using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Controlador
{
    // Objetivo tomar los parametros y validar todo los campos.
    // Autor Autor Equipo DepOnline.
    // Fecha de inicio 07 De noviembre del 2018.
    // Ultima fecha de modificación;  22 Diciembre del 2018
    class ImagenesController
    {
        private Imagenes objImagen = null;

        public ImagenesController()
        {
            objImagen = new Imagenes();
        }
       // En este Metodo Recolectamos los parametros para agregar las imagenes.
        public bool AñadirImagenes(int idimagen, string imagen, int idcuarto)

        {
            bool res = false;
            //Imagenes img = new Imagenes(idimagen, imagen, idcuarto);

            res = objImagen.AñadirImagenes(idimagen, imagen, idcuarto); // describir la variable global
            if (res)
                MessageBox.Show("El registro se realizó de forma correcta", "Registrando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro", "registrando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }
       // Aqui Se Reciben los paremtros para Que se puedan modificar las imagenes.
        public bool ModificarImagenes(int idimagen, string imagen, int idcuarto)
        {
            bool res = false;
            Imagenes img = new Imagenes(idimagen, imagen, idcuarto);

            res = objImagen.ModificarImagenes(img); 
           

           

            return res;
        }
        // Para eliminar Las imagenes.
        public bool EliminarImagen(int idimagen)
        {
            bool res = false;
            Imagenes img = new Imagenes(idimagen);

            // Describir la variable global.
            res = objImagen.EliminarImagen(img); 
            if (res)
                MessageBox.Show("El registro se realizó de forma correcta", "Eliminando información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de Eliminacion", "Eliminando la información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }
        public void ConsultarImagenes(int NumImagen, DataGridView DatosG)
        {

            DatosG.Rows.Clear();
            List<Imagenes> listaimagen = objImagen.ConsultarImagenes(NumImagen);
            foreach (Imagenes img in listaimagen)
                DatosG.Rows.Add(img.NumImagenes,img.Nombre_imagenes, img.Cuarto_idcuarto);
        }
        public Imagenes Getimagenes(int indice)
        {
            return objImagen.Getimagenes(indice);
        }

    }
}
