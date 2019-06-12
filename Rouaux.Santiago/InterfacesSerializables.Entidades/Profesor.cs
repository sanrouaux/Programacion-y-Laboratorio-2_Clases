using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.Entidades
{
  public class Profesor : Persona
  {
    private string _titulo;

    public string Titulo
    {
      get
      {
        return this._titulo;
      }

      set
      {
        this._titulo = value;
      }
    }

    public override string ToString()
    {
      return base.ToString() + "TITULO: " + this._titulo + "\n";
    }
  }
}
