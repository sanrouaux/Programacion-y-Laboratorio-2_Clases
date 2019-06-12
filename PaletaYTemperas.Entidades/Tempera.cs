using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Tempera
  {
    //ATRIBUTOS
    private ConsoleColor _color;
    private string _marca;
    private sbyte _cantidad;


    //PROPIEDADES
    public ConsoleColor Color
    {
      get { return _color; }
    }

    public string Marca
    {
      get { return _marca; }
    }  
  

    //CONSTRUCTOR
    public Tempera(ConsoleColor color, string marca, sbyte cantidad)
    {
      this._color = color;
      this._marca = marca;
      this._cantidad = cantidad;
    }

    //METODOS MOSTRAR
    private string Mostrar()
    {
      return this._color.ToString() + " - " + this._marca + " - " + this._cantidad.ToString() + "\n";
    }

    public static string Mostrar(Tempera temp)
    {
      if (!Object.Equals(temp, null))
      {
        return temp.Mostrar();
      }
      else
      {
        return "";
      }
    }

    //SOBRECARGA DE OPERADORES
    public static bool operator ==(Tempera temp1, Tempera temp2)
    {
      bool retorno;

      if (Object.Equals(temp1, null) || Object.Equals(temp2, null))
      {
        retorno = false;

        if (Object.Equals(temp1, null) && Object.Equals(temp2, null))
        {
          retorno = true;
        }
      }
      else
      {
        if (temp1._marca == temp2._marca && temp1._color == temp2._color)
        {
          retorno = true;
        }
        else
        {
          retorno = false;
        }
      }
      return retorno;
    }

    public static bool operator !=(Tempera temp1, Tempera temp2)
    {
      return !(temp1 == temp2);
    }

    public static Tempera operator +(Tempera temp, sbyte cantidad)
    {
      temp._cantidad += cantidad;
      return temp;
    }

    public static Tempera operator +(Tempera temp1, Tempera temp2)
    {
      if (temp1 == temp2)
      {
        temp1._cantidad += temp2._cantidad;
      }
      return temp1;
    }


    //CONVERSION IMPLICITA
    public static implicit operator sbyte(Tempera temp)
    {
      return temp._cantidad;
    }

  }
}
