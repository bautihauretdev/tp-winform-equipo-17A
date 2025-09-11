using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_17A
{
    internal class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Id, Descripcion FROM MARCAS";
                SqlDataReader lector = datos.ejecutarLectura(consulta);

                while (lector.Read())
                {
                    int id = (int)lector["Id"];
                    string descripcion = lector["Descripcion"].ToString();
                    lista.Add(new Marca(id, descripcion));
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}