using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Perro : Mascota
  {
    //Atributos
    private int edad;
    private bool esAlfa;


    //Constructores
    public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
    {
    }

    public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
    {
      this.edad = edad;
      this.esAlfa = esAlfa;
    }


    //Metodo - Sobreescritura de metodo abstracto
    protected override string Ficha()
    {
      if (this.esAlfa == true)
      {
        return this.DatosCompletos() + ", alfa de la manada, edad " + this.edad;
      }
      else
      {
        return this.DatosCompletos() + ", edad " + this.edad;
      }
    }


    //Conversion explicita
    public static explicit operator int(Perro p)
    {
      return p.edad;
    }

    //Sobrecarga de operadores
    public static bool operator ==(Perro p1, Perro p2)
    {
      if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Perro p1, Perro p2)
    {
      return !(p1 == p2);
    }

    //Sobreescritura de metodo Equals - Permite comparar un objeto de este tipo con cualquier objeto
    public override bool Equals(object obj)
    {
      if (obj is Perro && this == (Perro)obj)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    //Sobreescritura del metodo ToString
    public override string ToString()
    {
      return this.Ficha();
    }

  }
}
