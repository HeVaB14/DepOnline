using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepOnline.Modelo;

namespace DepOnline.Controlador {
    // Objetivo Para controlar los datos que se necesitan, y recibir parametros.
    // Autor Autor Equipo DepOnline.
    //Fecha de inicio 27 De octubre del 2018.
    // FEcha de la ultima Modificacion.  17 Diciembre del 2018.
    class ServiciosController {
        private servicio objservicio = null;
        public ServiciosController() {
            objservicio = new servicio( );
        }

        public bool InsertarServicio(int idservicio, string baño,
            string internet, string cable, string amueblado,
            string aguacaliente, int idcuarto) {
            bool res = false;
            servicio s = new servicio(idservicio, baño, internet, cable, amueblado, aguacaliente, idcuarto);

            res = objservicio.InsertarServicio(s); // describir la variable global
            if (res)
                MessageBox.Show("El registro se realizó de forma correcta",
                    "Registrando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro",
                    "registrando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }
        // Aqui recibimos los parametros para modificar los servicios.
        public bool ModificarServicio(int idservicio, string baño, string internet, string cable, string amueblado,
            string aguacaliente, int idcuarto) {
            bool res = false;
            servicio s = new servicio(idservicio, baño, internet, cable, amueblado, aguacaliente, idcuarto);

            res = objservicio.ModificarServicio(s);


            return res;

        }

        public Boolean EliminarServicio(int idservicios) {
            bool res = false;
            servicio s = new servicio(idservicios);

            res = objservicio.EliminarServicio(s);
            if (res)
                MessageBox.Show("La Eliminación se realizó de forma correcta",
                    "Eliminando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de Eliminacion",
                    "Eliminando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }

        public void ConsultaServicio(int idservicio, DataGridView DatosG) {
            DatosG.Rows.Clear( );
            List<servicio> listaservicio = objservicio.ConsultaServicio(idservicio);
            foreach (servicio s in listaservicio)
                DatosG.Rows.Add(s.IdServicios, s.Banio, s.Internet, s.Cablevision, s.Amueblado, s.Agua_caliente,
                    s.Cuarto_idcuarto);
        }
        public servicio consultaid(int idservicio) {
            return objservicio.consultaid(idservicio);
        }
        public servicio Getservicios(int indice) {
            return objservicio.GetServicios(indice);
        }



    }
}
