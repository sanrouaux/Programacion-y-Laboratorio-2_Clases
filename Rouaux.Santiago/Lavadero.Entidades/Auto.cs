using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Auto : Vehiculo
  {    
    protected int _cantidadAsientos;


    //Sobreescritura de Propiedad. Propiedad de lectura/escritura no ligada a un atributo
    public override double Precio
    {
      get; set;
    }


    //Constructor
    public Auto(string patente, byte cantRuedas, EMarca marca, int cantAsientos) : base(patente, cantRuedas, marca)
    {
      this._cantidadAsientos = cantAsientos;
    }


    //Sobreescritura de ToString
    public override string ToString()
    {
      return base.ToString() + " - " + this._cantidadAsientos.ToString() + "\n";
    }


    //Sobreescritura de método abstracto
    public override double CalcularPrecioConIva()
    {
      return this.Precio * 1.21; 
    }


    //public string MostrarAuto()
    //{
    //  return base.Mostrar() + " - " + this._cantidadAsientos.ToString() + "\n";
    //}
  }
}

