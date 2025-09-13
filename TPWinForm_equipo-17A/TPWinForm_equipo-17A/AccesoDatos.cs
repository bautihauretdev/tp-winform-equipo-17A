using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace TPWinForm_equipo_17A
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            // Cambia el nombre del servidor y la base según tu configuración
            conexion = new SqlConnection("server=LAPTOP-3F4KD52E; database=CATALOGO_P3_DB; integrated security= true");
            comando = new SqlCommand();
        }

        public SqlDataReader ejecutarLectura(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                return lector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}