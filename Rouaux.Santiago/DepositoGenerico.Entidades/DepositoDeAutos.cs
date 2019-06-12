using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
  public class DepositoDeAutos
  {
    private int _capacidadMaxima;
    private List<Auto> _lista;

    public DepositoDeAutos(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<Auto>();
    }

    public static bool operator +(DepositoDeAutos d, Auto a)
    {
      if(d._capacidadMaxima > d._lista.Count)
      {
        d._lista.Add(a);
        return true;
      }
      else
      {
        return false;
      }
    }

    private int GetIndice(Auto a)
    {
      for(int i = 0; i < this._lista.Count; i++)
      {
        if(this._lista[i] == a)
        {
          return i;
        }
      }
      return -1;
    }

    public static bool operator -(DepositoDeAutos d, Auto a)
    {
      if(d.GetIndice(a) != -1)
      {
        d._lista.RemoveAt(d.GetIndice(a));
        return true;
      }
      else
      {
        return false;
      }      
    }

    public bool Agregar(Auto a)
    {
      return this + a;
    }

    public bool Remover(Auto a)
    {
      return this - a;
    }

    public override string ToString()
    {
      string cadena;
      cadena = "Capacidad maxima: " + this._capacidadMaxima + "\n";
      cadena += "Listado de Autos: \n";
      foreach (Auto a in this._lista)
      {
        cadena += a.ToString();
      }
      return cadena;
    }

  }
}
