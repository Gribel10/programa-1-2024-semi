using System;

return ds;
        }
        public String administrarAlumnos(String[] datos)
{
    String sql = "";
    if (datos[0] == "nuevo")
    {
        sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, dui) VALUES('" +
            datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
    }
    else if (datos[0] == "modificar")
    {
        sql = "UPDATE alumnos SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" +
            datos[5] + "', dui='" + datos[6] + "' WHERE idAlumno=" + datos[1];
    }
    else if (datos[0] == "eliminar")
    {
        sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[1];
    }
    return ejecutarSQL(sql);
}
private String ejecutarSQL(String sql)
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
    }
}