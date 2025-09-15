using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPWinForm_equipo_17A
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as Marca, A.IdCategoria, C.Descripcion as Categoria, A.Precio " +
                                  "FROM ARTICULOS A " +
                                  "JOIN MARCAS M ON A.IdMarca = M.Id " +
                                  "JOIN CATEGORIAS C ON A.IdCategoria = C.Id";

                datos.setearConsulta(consulta);
                SqlDataReader lector = datos.ejecutarLectura();

                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)lector["Id"];
                    articulo.Codigo = lector[lector.GetOrdinal("Codigo")].ToString();
                    articulo.Nombre = lector["Nombre"].ToString();
                    articulo.Descripcion = lector["Descripcion"].ToString();
                    articulo.Precio = (decimal)lector["Precio"];
                    articulo.idMarca = (int)lector["IdMarca"];
                    articulo.Marca = new Marca((int)lector["IdMarca"], lector["Marca"].ToString());
                    articulo.idCategoria = (int)lector["IdCategoria"];
                    articulo.Categoria = new Categoria((int)lector["IdCategoria"], lector["Categoria"].ToString());
                    lista.Add(articulo);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.Marca.id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar (int Id)
        {
            try 
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}
