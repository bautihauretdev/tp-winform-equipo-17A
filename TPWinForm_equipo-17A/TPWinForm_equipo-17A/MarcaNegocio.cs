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
        public void Agregar(Marca nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta($"INSERT INTO MARCAS (Descripcion) VALUES ('{nueva.descripcion}')");
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
        public void Modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = $"UPDATE MARCAS SET Descripcion = '{marca.descripcion}' WHERE Id = {marca.id}";
                datos.ejecutarLectura(consulta);
                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = $"DELETE FROM MARCAS WHERE Id = {id}";
                datos.ejecutarLectura(consulta);
                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}