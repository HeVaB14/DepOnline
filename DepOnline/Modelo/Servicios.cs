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

    // Objetivo Editar los servicios que el Propietario dara de alta.
    // Autor Autor Equipo DepOnline.
    //Fecha de inicio. 25 de octubre 2018.
    // FEcha de la ultima Modificacion. 13 Diciembre del 2018.
    class servicio

    {
        private Conexion con = null; // aqui tambien se crea un objeto
        #region Contructores
        public servicio()
        {
            con = Conexion.GetConexion();
            IdServicios = 0;
           
            Banio ="" ;
            Internet = "";
            Cablevision = "";
            Amueblado = "";
            Agua_caliente = "";
            Cuarto_idcuarto = 0;
        }
        public servicio(int idservicio, string baño, string internet,string cable,string amueblado,string aguacaliente,int idcuarto)
        {
            IdServicios = idservicio;
            Banio = baño;
            Internet = internet;
            Cablevision = cable;
            Amueblado = amueblado;
            Agua_caliente = aguacaliente;
            Cuarto_idcuarto = idcuarto;
        }
        
        public servicio(int idservicio)
        {
            IdServicios = idservicio;
            
        }

        #endregion
        #region Propiedades
        public int IdServicios { set; get; }
        public string Wifi { set; get; }
        public string Banio { set; get; }
        public string Internet { set; get; }
        public string Cablevision { set; get; }
        public string Amueblado { set; get; }
        public string Agua_caliente { set; get; }
        public int Cuarto_idcuarto { set; get; }

        #endregion
        #region Metodos
        public Boolean InsertarServicio(servicio s)
        {
          // Aqui usamos un procedure la cual solo usamos los parametros que los servicios necesitan.
            String Query = "call Agregarservicios("+s.IdServicios+",'" +s.Banio+"','"+s.Internet+"' ,'"+s.Cablevision+"' ,  '"+s.Amueblado+"', '"+s.Agua_caliente+"',"+s.Cuarto_idcuarto + ")";
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)// generamos la parte para introducir si no hay ningun puerto
                    con.ConectarBD().Open();//abrimos
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)// si hay alguna conexion para entrar
                    return true;// regresa el valor 
                else
                    return false;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "Error al añadir el cuarto nuevo,insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        public Boolean ModificarServicio (servicio ser)
        {
                // Aqui Ediamos los datos de cada Servicio.
                string Query = "UPDATE servicios SET  Banio = '" + ser.Banio + "',Internet='" + ser.Internet + "',Cablevision='" + ser.Cablevision+ "'," +
                " Amueblado= '" +ser.Amueblado + "',Agua_caliente='"+ser.Agua_caliente+ "',Cuarto_idcuarto="+ser.Cuarto_idcuarto+" WHERE IdServicios=" + ser.IdServicios;
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
                    MessageBox.Show(ex.Message, "Error al editar los servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    con.ConectarBD().Close();
                }
            
        }
        public Boolean EliminarServicio(servicio servicio)
        {

            string Query = "Delete from servicios where IdServicios=" + servicio.IdServicios + "";
            // Aqui realizamos la conexion ala base de datos.
            OdbcConnection ConexionBD = null;
            try
            {
                // Generamos la parte para introducir si no hay ningun puerto.
                if (con.ConectarBD().State == ConnectionState.Closed)
                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)
                    return true; 
                else
                    return false;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "No se ha completado la eliminacion de los servicios,Eliminando",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }

        public servicio GetServicios(int indice)
        {
            return listaservicios[indice];
        }
        public servicio consultaid(int Servicios)
        {
            // Se deja un espacio para poder hacer una condicion.
            string Query = "select * from servicios where IdServicios=" + IdServicios+ "";
            servicio s = null;
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                // Solo para lecturas. o consultas de datos.
                con.miLectura = con.miComando.ExecuteReader();


                while (con.miLectura.Read())
                {
                    s = new servicio(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetString(2),con.miLectura.GetString(3) ,con.miLectura.GetString(4),
                        con.miLectura.GetString(5),con.miLectura.GetInt32(6));


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
            return s;
        }
        public List<servicio> ConsultaServicio(int idservicio)
        {
            listaservicios = new List<servicio>();
            string Query = "select * from servicios inner join cuarto on cuarto.idCuarto=servicios.Cuarto_idcuarto where Propietario_idpropietario=" + Propietario.idpPR(0).idPropietario + " ";// se deja un espacio para poder hacer una condicion
           
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                // Solo para lecturas. o consultas de datos.
                con.miLectura = con.miComando.ExecuteReader();

                servicio s;
                while (con.miLectura.Read())
                {
                    s = new servicio(con.miLectura.GetInt32(0), con.miLectura.GetString(1), con.miLectura.GetString(2), 
                        con.miLectura.GetString(3), con.miLectura.GetString(4),
                        con.miLectura.GetString(5),con.miLectura.GetInt32(6));
                    listaservicios.Add(s);

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
            return listaservicios;
        }


        #endregion
        public List<servicio>listaservicios = null;
    }
}
