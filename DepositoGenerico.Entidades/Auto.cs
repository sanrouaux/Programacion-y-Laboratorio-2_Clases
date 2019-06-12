using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
  public class Auto
  {
    private string _color;
    private string _marca;

    public string Color
    {
      get
      {
        return this._color;
      }      
    }

    public string Marca
    {
      get
      {
        return this._marca;
      }
    }

    public Auto(string color, string marca)
    {
      this._color = color;
      this._marca = marca;
    }

    public override string ToString()
    {
      return  "Marca: " + this._marca + " - Color: " + this._color + "\n";
    }

    public static bool operator ==(Auto a1, Auto a2)
    {
      if(a1._color == a2._color && a1._marca == a2._marca)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Auto a1, Auto a2)
    {
      return !(a1 == a2);
    }

    public override bool Equals(object obj)
    {
      if(obj is Auto && (Auto)obj == this)
      {
        return true;
      }
      else
      {
        return false;
      }    
    }

  }
}
