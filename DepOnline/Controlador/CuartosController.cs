using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DepOnline.Controlador {
    //Objetivo  Editar los cuartos. y mostar los datos
    //Autor Autor Equipo DepOnline
    //Fecha de Creacion 15 noviembre del 2018.
    //Fecha de Modificación 30 Noviembre del 2018.
    class CuartosController {
        // Creamos la variable para usar los parametros de la clase Cuarto.
        private Cuarto objCuarto = null;

        public CuartosController() {
            objCuarto = new Cuarto( );
        }

        // Alta De los Cuartos.
        public bool AltaCuartos(string disponible, int numcuarto, string tamaño, string categoria, string direccion,
            
            int precio /*int dueñ*/) {
            bool res = false;
            Cuarto c = new Cuarto(0, disponible, numcuarto, tamaño, categoria, direccion, precio/*dueño*/);
            res = objCuarto.AltaCuartos(c); // describir la variable global

            if (res)
                MessageBox.Show("El registro se realizó de forma correcta", "Registrando información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro", "registrando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }


        // Modificacion de los cuartos  y reciben los parametros.
        public bool ModificarCuarto(int idcuarto, string disponible, int numcuarto, string tamaño, string categoria,
            string direccion, int precio /*int dueñ*/) {
            bool res = false;
            Cuarto c = new Cuarto(idcuarto, disponible, numcuarto, tamaño, categoria, direccion, precio/*dueño*/);

            res = objCuarto.ModificarCuarto(c); // describir la variable global
            if (res)
                MessageBox.Show("La Modificacion  se realizó de forma correcta", "Modificando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("La Modificacion  se realizó de forma correcta", "Modificando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            return res;
        }
        public bool EliminarCuarto(int idcuarto) {
            bool res = false;
            Cuarto c = new Cuarto(idcuarto);

            res = objCuarto.EliminarCuarto(c); // describir la variable global
            if (res) {
                MessageBox.Show("la Eliminacion  se realizó de forma correcta", "Eliminando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else

                MessageBox.Show("se detetecto un error durante el proceso de Eliminacion", "Eliminando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }



        public Cuarto Consultaid(int IdCuarto) {
            return objCuarto.Consultaid(IdCuarto);
        }
        // La Que Consulta los Datos. para mostrar en datagrewviem.

        public void ConsultarCuarto(int idcuarto, DataGridView DatosG) {
            DatosG.Rows.Clear( );
            List<Cuarto> listCuarto = objCuarto.ConsultarCuarto(idcuarto);
            foreach (Cuarto c in listCuarto)
                DatosG.Rows.Add(c.Disponible, c.No_de_cuarto, c.Tamanio, c.Categoria, c.Direccion, c.Precio);
        }


        public Cuarto GetCuartos(int indice) {
            return objCuarto.GetCuartos(indice);
        }
    }
}

