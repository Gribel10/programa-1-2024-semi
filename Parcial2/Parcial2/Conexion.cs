using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand();//ejecutar SQL en la BD.
        SqlDataAdapter miAdaptador = new SqlDataAdapter();//Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();//es la representacion grafica de la BD en memoria RAM.

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;

            miAdaptador.SelectCommand = misComandos;
            misComandos.CommandText = "SELECT * Usuario";
            miAdaptador.Fill(ds, "Usuario");

            return ds;
        }
        public String administrarUsuario(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO Usuario(usuario, clave, nombre, dirección, telefono, ) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE Usuario SET usuario='" + datos[2] + "', clave='" + datos[3] + "', nombre='" + datos[4] + "', dirección='" +
                    datos[5] + "', telefono='" + datos[6] + "' WHERE idUsuario=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM Usuario WHERE idUsuario=" + datos[1];
            }
            return EjecutarSQL(sql);
        }

        private String EjecutarSQL(String sql)
        {
            try
            {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                return misComandos.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        internal string administrausuario(object usuario)
        {
            throw new NotImplementedException();
        }

        internal string administrarFrm_usuario(string[] frm_usuario)
        {
            throw new NotImplementedException();
        }
    }
}


