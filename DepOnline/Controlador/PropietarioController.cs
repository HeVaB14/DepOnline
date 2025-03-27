using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Controlador
{
    // Objetivo: Seguir Cargando los datos del propietario la cual controla los datos de cada uno de ello(parametros).
    // Autor: Autor Equipo DepOnline.
    // Fecha de inicio:  5 de octubre del 2018.
    // Fecha de la ultima  Edicion:  10 de enero del 2019.

    class PropietarioController
    {

        Propietario objp = new Propietario();
        private Propietario objPropietario = null;
        public PropietarioController()
        {
            objPropietario = new Propietario();
        }
        public Boolean ValidarLogin(string user, string pass)
        {
            bool res = false;
            Propietario pro = new Propietario(user, pass);

            res = objPropietario.ValidarLogin(pro);
            
            if (res)
            {

            }
          

            else
            {
                MessageBox.Show("El usuario Y/O contraseña son incorrectas ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            ;

      
            return res;





        }
        public bool Recuperaid(int prop)
        {
            Propietario obj = new Propietario();
            obj.idPropietario = prop;
            return objp.ValidarLogin(obj);
        }

        // Aqui se reciben los parametros de cada uno de losa datos que se editaran.
        public bool ModificarPropietario(int idpropietario, string nombre, string paterno, string materno, int edad, string sexo, 
            string telefono, string numcalle, string calle, string localidad,
            string usuario, string contraseña, string tipous)
        {
            bool res = false;
            Propietario p = new Propietario(idpropietario, nombre, paterno, materno, edad, sexo, telefono, numcalle, 
                calle, localidad, usuario, contraseña, tipous);

            res = objPropietario.ModificarPropietario(p); // describir la variable global
            if (res)
                MessageBox.Show("La Modificacion  se realizó de forma correcta", "Modificando información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro", "Modificando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }
        public bool RegistarPropietario(int idpropietario, string nombre, string paterno, string materno, int edad, string sexo, 
            string telefono, string numcalle, string calle, string localidad,
            string usuario, string contraseña, string tipous)
        {
            bool res = false;
            Propietario pr = new Propietario(idpropietario, nombre, paterno, materno, edad, sexo, telefono, numcalle, 
                calle, localidad, usuario, contraseña, tipous);

            res = objPropietario.RegistarPropietario(pr); // describir la variable global
            if (res)
                MessageBox.Show("Bienvenido al sistema Deponline,  ahora inicie sessión", "Modificando información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("se detetecto un error durante el proceso de registro", "Modificando la información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res;
        }



        public Propietario ConsultarID(int idPropietario)
        {
            return objPropietario.ConsultarID(idPropietario);
        }

        public void ConsultarPropietario(int dpropietario,DataGridView DatosG)
        {
            DatosG.Rows.Clear();
            List<Propietario> listPropietario = objPropietario.ConsultarPropietario(dpropietario);
            foreach (Propietario p in listPropietario)
            {
                DatosG.Rows.Add(p.idPropietario,p.Nombre,p.Ap_paterno,p.Ap_materno,p.Edad,p.Sexo,p.Numero_de_telefono,
                    p.No_calle,p.Calle,p.Localidad,p.Usuario,p.Password_2,p.Tipo_usuario);
            }
            
        }
        public Propietario GetPropietario(int indice)
        {
            return objPropietario.GetPropietario(indice);
        }




    }
}