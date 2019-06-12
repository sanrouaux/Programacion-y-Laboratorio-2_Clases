using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Camion : Vehiculo
  {
    //Atributo
    protected float _tara;


    //Sobreescritura de Propiedad. Propiedad de lectura/escritura no ligada a un atributo
    public override double Precio
    {
      get; set;
    }


    //Constructor
    public Camion(string patente, byte cantRuedas, EMarca marca, float tara) : base(patente, cantRuedas, marca)
    {
      this._tara = tara;
    }


    ////Sobreescritura de método ToString
    public override string ToString()
    {
      return base.ToString() + " - " + this._tara.ToString() + "\n";
    }


    //Sobreescritura de método abstracto
    public override double CalcularPrecioConIva()
    {
      return this.Precio * 1.21;
    }


    //public string MostrarCamion()
    //{
    //  return base.Mostrar() + " - " + this._tara.ToString() + "\n";
    //}
  }
}
