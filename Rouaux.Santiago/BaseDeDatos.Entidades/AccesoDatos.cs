using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase18.BaseDeDatos
{
  public class AccesoDatos
  {
    private SqlConnection _conexion;
    private SqlCommand _comando;

    public AccesoDatos()
    {
      _conexion = new SqlConnection(Properties.Settings.Default.coneccion_bd);
    }

    public List<Persona> TraerTodos()
    {
      List<Persona> lista = new List<Persona>();

      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "SELECT id,nombre, apellido,edad FROM Padron.dbo.Personas";

      try
      {
        this._conexion.Open(); //Establece la conexion
        SqlDataReader lector = this._comando.ExecuteReader(); //Es uno de los métodos que ejecutan el comando

        while (lector.Read())
        {
          Persona p = new Persona((int)lector["id"], (string)lector["nombre"], (string)lector["apellido"], (int)lector["edad"]);
          lista.Add(p);
        }
        this._conexion.Close();
      }
      catch (Exception)
      {
        throw;
      }
      return lista;
    }

    public bool AgregarPersona(Persona p)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre, apellido, edad) VALUES" + "('" + p.nombre +
          "','" + p.apellido + "'," + p.edad.ToString() + ")";

      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }
    }

    public bool ModificarPersona(Persona p)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "UPDATE Padron.dbo.Personas SET nombre = '" + p.nombre + "', apellido = '"
        + p.apellido + "', edad = " + p.edad.ToString() + " WHERE id = " + p.id.ToString();
      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }
    }

    public bool EliminarPersona(int id)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "DELETE FROM Padron.dbo.Personas WHERE id = " + id.ToString();

      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }
    }    


    public DataTable TraerTablaPersona()
    {
      DataTable tabla = new DataTable("Personas");

      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "SELECT id,nombre, apellido,edad FROM Padron.dbo.Personas";

      try
      {
        this._conexion.Open(); 
        SqlDataReader lector = this._comando.ExecuteReader();
        tabla.Load(lector);
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }

      return tabla;
    }
  }
}
