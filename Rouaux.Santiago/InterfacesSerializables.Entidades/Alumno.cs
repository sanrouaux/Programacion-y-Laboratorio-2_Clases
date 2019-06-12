using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.Entidades
{
  public class Alumno : Persona
  {
    private int _legajo;

    public int Legajo
    {
      get
      {
        return this._legajo;
      }

      set
      {
        this._legajo = value;
      }
     }

    public override string ToString()
    {
      return base.ToString() + "LEGAJO: " + this._legajo.ToString() + "\n";
    }

  }
}
