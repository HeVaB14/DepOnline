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
    // Objetivo Aqui Agregamos todo los cuartos, los servicios e imagenes.
    // Autor Autor Equipo DepOnline.
    // Fecha de creacion 15 de noviembre del 2018.
    // Fecha de modificacion 27 noviembre  del 2018.
    class Cuartosincluidos
    {

        private Conexion con = null;
        #region Constructores
        public Cuartosincluidos()
        {
            con = Conexion.GetConexion();
         //   IdCuarto = 0;
            Disponible = "";
            No_de_cuarto = 0;
            Tamanio = "";
            Categoria = "";
            Direccion = "";
            Precio = 0;
          //IdServicios = 0;
            Banio = "";
            Internet = "";
            Cablevision = "";
            Amueblado = "";
            Agua_caliente = "";
           //NumImagenes = 0;
            Nombre_imagenes = "";

        }
        public  Cuartosincluidos(/*int idcuarto*/  string disponible, int numcuarto, string tamaño  , string categoria,string direccion,int precio, string baño, string internet, string cable, 
            string amueblado, string aguacaliente,string imagen)
        {
           
            Disponible = disponible;
            No_de_cuarto = numcuarto;
            Tamanio = tamaño;
            Categoria = categoria;
            Direccion = direccion;
            Precio = precio;         
            Banio = baño;
            Internet = internet;
            Cablevision = cable;
            Amueblado = amueblado;
            Agua_caliente = aguacaliente;            
            Nombre_imagenes = imagen;
        }
        public Cuartosincluidos(int idcuarto)
        {
            IdCuarto = idcuarto;


        }

        #endregion

        #region Propiedades

        public int IdCuarto { set; get; }
        public string Disponible { set; get; }
        public int No_de_cuarto { set; get; }
        public string Tamanio { set; get; }
        public string Categoria { set; get; }
        public string Direccion { set; get; }
        public double Precio { set; get; }
        public int Propietario_idpropietario { set; get; }
        public int IdServicios { set; get; }
        public string Wifi { set; get; }
        public string Banio { set; get; }
        public string Internet { set; get; }
        public string Cablevision { set; get; }
        public string Amueblado { set; get; }
        public string Agua_caliente { set; get; }
        public int NumImagenes { set; get; }
        public string Nombre_imagenes { set; get; }


        #endregion
        #region Metodos
        public Boolean Insertarcuarto(Cuartosincluidos c)
        {
            // Usamos los parametros para utilizar y asi poder insertar todo los datos ala BD.
            string Query = " call agregarcuartos(0, '" + c.Disponible + "', " + c.No_de_cuarto + ", '" + c.Tamanio + "', '" + c.Categoria + "', " +
               "'" + c.Direccion + "'," + c.Precio + "," + Propietario.idpPR(0).idPropietario + ",0,'" + c.Banio + "','" + c.Internet + "' ,'" + c.Cablevision + "' , " +
               " '" + c.Amueblado + "', '" + c.Agua_caliente + "',0,'" + c.Nombre_imagenes + "')";
            try
            {
                // Generamos la parte para introducir si no hay ningun puerto.
                if (con.ConectarBD().State == ConnectionState.Closed)
                    con.ConectarBD().Open();//abrimos
                con.miComando = new OdbcCommand(Query, con.ConectarBD());
                int resultado = con.miComando.ExecuteNonQuery();
                if (resultado == 1)
                    return true;
                else
                    return false;

            }
            catch (OdbcException ex)


            {
                MessageBox.Show(ex.Message, "Error al añadir el cuarto nuevo,insertando datos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.ConectarBD().Close();
            }
        }
        // Utilizamos la las otras clases.
        public Boolean Modificarcuarto(Cuartosincluidos cua)
        {
            return false;
        }
        public Cuartosincluidos GetCuartosincluidos(int indice)
        {
            return listcuartosincluidos[indice];
            
        }
      

        #endregion
        public List<Cuartosincluidos> listcuartosincluidos = null;
    }
}

