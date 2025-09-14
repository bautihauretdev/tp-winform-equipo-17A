using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPWinForm_equipo_17A
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                SqlDataReader lector = datos.ejecutarLectura();

                while (lector.Read())
                {
                    Categoria cat = new Categoria();
                    cat.id = (int)lector["Id"];
                    cat.descripcion = lector["Descripcion"].ToString();
                    lista.Add(cat);
                }

                return lista;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
   
