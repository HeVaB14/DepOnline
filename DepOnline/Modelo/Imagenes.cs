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
    // Objetivo Subir imagenes de los Cuartos que estaran en el sistema.
    // Autor Autor Equipo DepOnline.
    //Fecha de inicio 28 de Octubre del 2018.
    // Ultima fecha de modificación 27 de Diciembre del 2018.
    class Imagenes
    {
        private Conexion con = null;
        #region Constructores
        public Imagenes()
        {
            con = Conexion.GetConexion();
            NumImagenes = 0;
            Nombre_imagenes = "";
            Cuarto_idcuarto =0;
        }
        public Imagenes(int idimagen,string imagen,int idcuarto)
        {
            NumImagenes = idimagen;
            Nombre_imagenes = imagen;
            Cuarto_idcuarto =idcuarto;
        }
        public Imagenes(int idimagen)
        {
            NumImagenes = idimagen;
            
        }

        #endregion
        #region Propiedades
        public int NumImagenes {  set; get; }
        public string Nombre_imagenes { set; get; }
        public int Cuarto_idcuarto { set; get; }

        #endregion
        #region Metodos
        public bool AñadirImagenes( int NumImagenes, string Nombre_imagenes, int Cuarto_idcuarto)
        {
            // Usamos un procedure para poder subir las imagenes.
            String Query = "insert into imagenes values ( 0,'"+Nombre_imagenes+"',"+Cuarto_idcuarto+")";
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)// generamos la parte para introducir si no hay ningun puerto
                    con.ConectarBD().Open();//abrimos
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                var resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)// si hay alguna conexion para entrar
                {
                    return true;// regresa el valor 
                }
                else
                    return false;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message, "Error al añadir la imagen,insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        public bool ModificarImagenes(Imagenes im)
        {
            // Para Actualizar las imagenes.
            string Query = "UPDATE imagenes SET Nombre_imagenes = '" + im.Nombre_imagenes + "',Cuarto_idcuarto=" +im.Cuarto_idcuarto+ " WHERE NumImagenes=" + im.NumImagenes;
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
                MessageBox.Show( "Error al editar la imagen","Editando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        public bool EliminarImagen(Imagenes imagen)
        {
            string Query = "Delete from imagenes where NumImagenes=" +imagen.NumImagenes+ "";
            OdbcConnection ConexionBD = null;// aqui realizamos la conexion ala base de datos
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
                MessageBox.Show(ex.Message, "No se ha completado la eliminacion de la imagen,Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        public List<Imagenes> ConsultarImagenes(int NumImagen)
        {
            listaImagenes = new List<Imagenes>();
            string Query = "select * from imagenes inner join cuarto on cuarto.idCuarto=imagenes.Cuarto_idcuarto where Propietario_idpropietario=" + Propietario.idpPR(0).idPropietario + " ";// se deja un espacio para poder hacer una condicion
            
            try
            {
                if (con.ConectarBD().State == ConnectionState.Closed)

                    con.ConectarBD().Open();
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                con.miLectura = con.miComando.ExecuteReader();// solo para lecturas. o consultas de datos

                Imagenes img;
                while (con.miLectura.Read())
                {
                   img = new Imagenes(con.miLectura.GetInt32(0),  con.miLectura.GetString(1),
                        con.miLectura.GetInt32(2));
                    listaImagenes.Add(img);

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
            return listaImagenes;
        }
        public Imagenes Getimagenes(int indice)
        {
            return listaImagenes[indice];
        }
        #endregion
        public List<Imagenes> listaImagenes = null;
    }
}
