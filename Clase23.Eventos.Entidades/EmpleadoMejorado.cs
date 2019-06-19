using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase23.Eventos.Entidades
{
  public class EmpleadoMejorado
  {
    //ATRIBUTOS
    private string _nombre;
    private int _legajo;
    private float _sueldo;

    //EVENTOS
    public event DelSueldo limiteSueldo; //Creo el evento. El evento está asociado a un tipo de delegado

    //PROPIEDADES
    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }

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

    public float Sueldo
    {
      get
      {
        return this._sueldo;
      }
      set
      {
        if (value <= 12000)
        {
          this._sueldo = value;
        }
        else
        {
          EmpleadoSueldoArgs args = new EmpleadoSueldoArgs();
          args.Sueldo = value;
          this.limiteSueldo(this, args); //Lanzo el evento asociado a la clase
        }
      }
    }

    public override string ToString()
    {
      return "NOMBRE: " + this.Nombre + " - LEGAJO: " + this.Legajo.ToString() + " - SUELDO: " + this.Sueldo.ToString();
    }
  }
}
