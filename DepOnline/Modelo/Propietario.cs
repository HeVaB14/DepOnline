using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using DepOnline.Vista;

namespace DepOnline.Modelo
{
    //Objetivo:Esta Clase tiene como objetivo que el propietario pueda acceder ala aplicación para ver sus cuartos disponibles.
    // Autor: Autor Equipo DepOnline.
    // Fecha De inicio: 2 Ocubre del 2018.
    // Fecha de modificacion: 13 diciembre del 2018.


    class Propietario
    {
        // Para llamar en todas las clases las clases. 
        private static Propietario objidp = null;
       // Aqui tambien se crea un objeto de Conexion.
        private Conexion con = null;
        #region Constructores
        // Generamos los contructores.
        public Propietario()
        {
            con = Conexion.GetConexion();
            idPropietario = 0;
            Nombre = "";
            Ap_paterno = "";
            Ap_materno = "";
            Edad = 0;
            Sexo = "";
            Numero_de_telefono = "";
            No_calle = "";
            Calle = "";
            Localidad = "";
           
            //Aqui utilizaremos el usuario y contraseña para hacer el login.
            Usuario = "";
            Password_2 = "";
            //2 Sera el propietario la cual el solo podra acceder al escritorio.
            Tipo_usuario = "";
            




        }
        public static Propietario  idpPR(int Idprop)
        {
            if(objidp==null)
            {
                objidp = new Propietario();
                objidp.idPropietario = Idprop;
            }
            return objidp;
        }
        public static Propietario name(string name)
        {
            if(objidp==null)
            {
                objidp = new Propietario();
                objidp.Nombre = name;
            }
            return objidp;
        }
    
        public Propietario(int idpropietario, string nombre, string apaterno, string amaterno,int edad, string sexo, string numcalle, string Telefono, string localidad, string calle,

            // Generamos los contructores.
            string usuario, string contraseña, string tipous)
           
        {

            idPropietario = idpropietario;
            Nombre = nombre;
            Ap_paterno = apaterno;
            Ap_materno = amaterno;
            Edad = edad;
            Sexo = sexo;
            No_calle = numcalle;
            Numero_de_telefono = Telefono;
            Localidad = localidad;
            Calle = calle;
            Usuario = usuario;
            Password_2 = contraseña;
            Tipo_usuario = tipous;
           



        }
        public Propietario(int idpropietario)
        {

            idPropietario = idPropietario;
        }
        public Propietario(string usuario,string contraseña)
        {
           Usuario = usuario;
           Password_2 = contraseña;
           
        }
        public Propietario(string nombre)
        {
            Nombre = nombre;
        }

        #endregion
        #region Propiedades
        public int idPropietario { get; set; }
        public string Nombre { get; set; }
        public string Ap_paterno { get; set; }
        public string Ap_materno { get; set; }
        public int Edad { set; get; }
        public string Sexo { get; set; }
        public string Numero_de_telefono { get; set; }
        public string No_calle { get; set; }
       public string Calle { get; set; }
        public string Localidad { get; set; }
        
        //aqui utilizaremos el usuario y contraseña para hacer el login
        public string Usuario { get; set; }
        public string Password_2 { get; set; }
        public string Tipo_usuario { get; set; }
     


        #endregion
        #region Metodos
        public Boolean RegistarPropietario(Propietario p)
        {
            string Query = "insert into propietario values(0,'" + p.Nombre + "','" + p.Ap_materno + "','" + p.Ap_paterno + "'," + p.Edad + ",'" + p.Sexo + "'," +
                "'" + p.Numero_de_telefono + "', '" + p.No_calle + "', '" + p.Calle + "','" + p.Localidad + "','" + p.Usuario + "' ,'" + p.Password_2 + "','" + p.Tipo_usuario + "')";
            try
            {

                if (con.ConectarBD().State == System.Data.ConnectionState.Closed)
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }

        }
        // En este metodo se modificara los datos del propietario, se reciben los parametros existentes en la basede datos.
        public Boolean ModificarPropietario(Propietario pr)
        {
            string Query = "UPDATE propietario set Nombre='"+pr.Nombre+ "',Ap_materno='"+pr.Ap_paterno+ "',Ap_materno='"+pr.Ap_materno+ "'," +
                "Edad="+pr.Edad+"," +"Sexo='"+pr.Sexo + "',Numero_de_telefono='"+pr.Numero_de_telefono+ "',No_de_calle='"+pr.No_calle+"'," +
                "Calle='"+pr.Calle+ "',Localidad='"+pr.Localidad+ "',Usuario='"+pr.Usuario+"'," + "Password_2='"+pr.Password_2 + "'," +
                "Tipo_usuario='"+pr.Tipo_usuario+ "' Where idpropietario ="+ Propietario.idpPR(0).idPropietario  ;
            try
            {

                if (con.ConectarBD().State == System.Data.ConnectionState.Closed)
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }

        }
        public Boolean EliminarPropietario(Propietario propietario)
        {
            // No se Eliminara ningun propietario ne la aplicacion de escritorio.
            return false;
        }
        // Estas Son Variables la Cual se utiliza para mostar los datos del propietario.
        public static string Nombrep = null;
        public static string ap = null;
        public static string am = null;
        public static int edad = 0;
        public static string sexo = null;
        public static string tlf = null;
        public static string numcalle = null;
        public static string ncalle = null;
        public static string local = null;
        public static string user = null;
        public static string password=null;
        public static string tipous = null;
        public static int idpro = 0;

         // Aqui Se Logea el usuario de la app.
        public Boolean ValidarLogin(Propietario login)
        {
            // La Consulta  se genera de la siguiente manera  la cual Seleccionamos todos los datos pero solo usaremos 
            // el usuario y La contraseña. 
            bool resultado = false;
            string Query="select * from propietario  where Usuario='"+login.Usuario+"' and Password_2='"+login.Password_2+ "'";

            try
            {
                // Generamos la parte para introducir si no hay ningun puerto.
                if (con.ConectarBD().State == ConnectionState.Closed)
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
               
                con.miLectura = con.miComando.ExecuteReader();
                
                while (con.miLectura.Read())
                {
                    resultado = true;
                    // Las Variables Globales Toma Valoren desde este -metodo.
                    Propietario.idpPR(con.miLectura.GetInt32(0));
                    Nombrep = con.miLectura.GetString(1);
                    ap = con.miLectura.GetString(2);
                    am = con.miLectura.GetString(3);
                    edad = con.miLectura.GetInt32(4);
                    sexo = con.miLectura.GetString(5);
                    tlf=con.miLectura.GetString(6);
                    numcalle=con.miLectura.GetString(7);
                    local= con.miLectura.GetString(8);
                    ncalle =con.miLectura.GetString(9);
                    user= con.miLectura.GetString(10);
                    password= con.miLectura.GetString(11);
                    tipous= con.miLectura.GetString(12);
                    idpro = con.miLectura.GetInt32(0);





                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "El usuario y la contraseña no es correcta,iniciando", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                con.ConectarBD().Close();
            }
            return resultado;
        }

     

       



        public Propietario ConsultarID(int idPropietario)
        {
            string Query = "select * from propietario";
            Propietario p = null;
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                con.miLectura = con.miComando.ExecuteReader();


                while (con.miLectura.Read())
                {
                    p = new Propietario(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetString(2), con.miLectura.GetString(3),
                        con.miLectura.GetInt32(4), con.miLectura.GetString(5), con.miLectura.GetString(6), con.miLectura.GetString(7), con.miLectura.GetString(8), con.miLectura.GetString(9)
                        , con.miLectura.GetString(10), con.miLectura.GetString(11), con.miLectura.GetString(12));
                    listaPropietario.Add(p);

                }

            }
            catch (OdbcException ex)

            {
                MessageBox.Show(ex.Message, "Error en la consulta,:-(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.ConectarBD().Close();
                con.miLectura.Close();
            }
            return p;
        }
        



        public List<Propietario> ConsultarPropietario(int dpropietario)
        {
            listaPropietario = new List<Propietario>();
            string Query = "select * from propietario " ; // se deja un espacio para poder hacer una condicion

            Propietario p = null;
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                con.miLectura = con.miComando.ExecuteReader();// solo para lecturas. o consultas de datos


                while (con.miLectura.Read())
                {
                    p = new Propietario(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetString(2), con.miLectura.GetString(3),
                        con.miLectura.GetInt32(4), con.miLectura.GetString(5), con.miLectura.GetString(6), con.miLectura.GetString(7), con.miLectura.GetString(8), con.miLectura.GetString(9)
                        , con.miLectura.GetString(10), con.miLectura.GetString(11), con.miLectura.GetString(12));


                }

            }

            catch (OdbcException ex)

            {
                MessageBox.Show(ex.Message, "Error en la consulta,:-(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.ConectarBD().Close();
                con.miLectura.Close();  
            }
            return listaPropietario;
        }
        public Propietario GetPropietario(int indice)
        {
            return listaPropietario[indice];
        }


        #endregion
        public List<Propietario> listaPropietario = null;
    }
    
}
       
