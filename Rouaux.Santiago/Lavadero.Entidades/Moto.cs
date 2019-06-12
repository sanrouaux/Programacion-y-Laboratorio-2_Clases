using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Moto : Vehiculo
  {
    //Atributo
    protected float _cilindrada;

    //Sobreescritura de Propiedad. Propiedad de lectura/escritura no ligada a un atributo
    public override double Precio
    {
      get; set;
    }

    //Constructor
    public Moto(string patente, byte cantRuedas, EMarca marca, float cilindrada) : base(patente, cantRuedas, marca)
    {
      this._cilindrada = cilindrada;
    }

    ////Sobreescritura de método abstracto
    public override string ToString()
    {
      return base.ToString() + " - " + this._cilindrada.ToString() + "\n";
    }


    //Sobreescritura de método abstracto
    public override double CalcularPrecioConIva()
    {
      return this.Precio * 1.21;
    }


    //public string MostrarMoto()
    //{
    //  return base.Mostrar() + " - " + this._cilindrada.ToString() + "\n";
    //}
  }
}
