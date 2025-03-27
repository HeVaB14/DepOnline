using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Modelo
{
    // Objetivo:
    /* En Esta Clase Realizaremos la modificación de los Cuartos que estaran en el sistema DepOnline .*/
    // Autor: Autor Equipo DepOnline.
    // Fecha De Creación: 18 Septiembre 2018.
    // Ultima  Fecha de Modificación : 23/Diciembre/2018.
    class Cuarto
    {
        #region Constructores
        private Conexion con = null; // aqui tambien se crea un objeto
        public Cuarto()
        {
            con = Conexion.GetConexion();
           IdCuarto = 0;
            Disponible = "";
            No_de_cuarto = 0;
            Tamanio= "";
            Categoria = "";
            Direccion = "";
            Precio = 0;
            //Propietario_idpropietario = Propietario.idpPR(0).idPropietario;
            
        }
        // En este Constructor podemos Añadimos los datos que se recibiran.
        public  Cuarto(int idcuarto,  string disponible, int numcuarto, string tamaño  , string categoria,string direccion,
            int precio/*int dueño*/
            )
        {
            IdCuarto = idcuarto;
            Disponible = disponible;
            No_de_cuarto = numcuarto;
            Tamanio = tamaño;
            Categoria = categoria;
            Direccion = direccion;
            Precio = precio;
            //Propietario_idpropietario = dueño;
           
        }
        public Cuarto(int idcuarto)
        {
            IdCuarto = idcuarto;


        }
       


        #endregion
        #region Propiedades
        public int IdCuarto { set; get; }
        public string  Disponible { set; get; }
        public int No_de_cuarto { set; get; }
        public string Tamanio { set; get; }  
        public string Categoria { set; get; }
        public string Direccion { set; get; }
        public double Precio { set; get; }
        public int Propietario_idpropietario { set; get; }

      

        #endregion
        #region Metodos


        public Boolean AltaCuartos(Cuarto c)
        {
            String Query = "INSERT INTO cuarto values(0,'" + c.Disponible + "'," + c.No_de_cuarto + ",'" + c.Tamanio + "'," +
                "'" + c.Categoria + "'," +"'"+c.Direccion+"',"+c.Precio+"," + Propietario.idpPR(0).idPropietario+")";

            try
            {
                // Generamos la parte para introducir si no hay ningun puerto.
                if (con.ConectarBD().State == ConnectionState.Closed)
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                // Si hay alguna conexion para entrar.
                if (resultado == 1)
                    // Regresa el valor. 
                    return true;
                else
                    return false;

            }
            catch (OdbcException ex)
                                   

            {
                // Si la consulta Falla se envia el siguiente mensaje.
                MessageBox.Show(ex.Message, "Error al añadir el cuarto nuevo,insertar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        // Este metodo es para Modificar los Cuartos y se reciben los siguinetes parametros.
        public Boolean ModificarCuarto(Cuarto cua)
        {
            string Query = "UPDATE cuarto SET  Disponible = '" + cua.Disponible + "',No_de_cuarto=" + cua.No_de_cuarto + 
                ",Tamanio='"+cua.Tamanio+"'," + " Categoria = '" + cua.Categoria + "',Direccion='"+cua.Direccion+"'," +
                "Precio="+cua.Precio+ ", Propietario_idpropietario="+ Propietario.idpPR(0).idPropietario +
                " WHERE IdCuarto=" + cua.IdCuarto;
            // MessageBox.Show(""+Query);// Para que la sintaxis este bien.
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
                MessageBox.Show(ex.Message, "Error al editar el cuarto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        public Boolean EliminarCuarto(Cuarto cuarto)
        {
            //Aqui Generamos la consulta ala base de datos.
            string Query = "Delete from cuarto where IdCuarto=" + cuarto.IdCuarto+"";
            //Realizamos la Conexion ala base de datos.
            OdbcConnection ConexionBD = null;
            try
            {
                // Generamos la parte para introducir si no hay ningun puerto.
                if (con.ConectarBD().State == ConnectionState.Closed)
                    //Abrimos la Conexion ala base de datos.
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                // Si hay alguna conexion para entrar ya no se abrira otra.
                if (resultado == 1)
                    // Regresa el valor si es Cierto. 
                    return true;
                else
                    return false;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "No se ha completado la eliminacion del cuarto,Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        

        public Cuarto Consultaid(int IdCuarto)
        {
            string Query = "select * from cuarto  where IdCuarto=" + IdCuarto + "";// se deja un espacio para poder hacer una condicion
           Cuarto c = null;
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                con.miLectura = con.miComando.ExecuteReader();// solo para lecturas. o consultas de datos


                while (con.miLectura.Read())
                {
                    c = new Cuarto(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetInt32(2), 
                        con.miLectura.GetString(3), con.miLectura.GetString(4),con.miLectura.GetString(5),
                        con.miLectura.GetInt32(6)/*con.miLectura.GetInt32(7)*/);
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
            return c;
        }

        public List<Cuarto> ConsultarCuarto(int idcuarto)
        {
            listacuartos = new List<Cuarto>();
            string Query = "select * from cuarto where Propietario_idpropietario="+Propietario.idpPR(0).idPropietario+" " +
                ""; //Se deja un espacio para poder hacer una condicion.
            
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                con.miLectura = con.miComando.ExecuteReader();// Solo para lecturas o consultas de datos.

                Cuarto c;
                while (con.miLectura.Read())
                {
                    c = new Cuarto(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetInt32(2),
                        con.miLectura.GetString(3),con.miLectura.GetString(4), con.miLectura.GetString(5), con.miLectura.GetInt32(6)/*, con.miLectura.GetInt32(7)*/);
                    listacuartos.Add(c);

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
            return listacuartos;
        }


        public Cuarto GetCuartos(int indice)
        {
            return listacuartos[indice];
        }


        #endregion
        public List<Cuarto> listacuartos = null;

    }
}
