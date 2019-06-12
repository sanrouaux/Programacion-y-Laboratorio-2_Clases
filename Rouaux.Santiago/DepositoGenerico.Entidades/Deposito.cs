using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
  public class Deposito<T>
  {
    private int _capacidadMaxima;
    private List<T> _lista;

    public Deposito(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<T>();
    }

    public static bool operator +(Deposito<T> deposito, T objeto)
    {
      if (deposito._capacidadMaxima > deposito._lista.Count)
      {
        deposito._lista.Add(objeto);
        return true;
      }
      else
      {
        return false;
      }
    }

    private int GetIndice(T objeto)
    {
      for (int i = 0; i < this._lista.Count; i++)
      {
        if (this._lista[i].Equals(objeto))
        {
          return i;
        }
      }
      return -1;
    }

    public static bool operator -(Deposito<T> deposito, T objeto)
    {
      if (deposito.GetIndice(objeto) != -1)
      {
        deposito._lista.RemoveAt(deposito.GetIndice(objeto));
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool Agregar(T objeto)
    {
      return this + objeto;
    }

    public bool Remover(T objeto)
    {
      return this - objeto;
    }

    public override string ToString()
    {
      string cadena;
      cadena = "Capacidad maxima: " + this._capacidadMaxima + "\n";
      cadena += "Listado de " + typeof(T).Name + ": \n";
      foreach (T objeto in this._lista)
      {
        cadena += objeto.ToString();
      }
      return cadena;
    }
  }
}
