using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Clase_04.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Cosa objeto1 = new Cosa();
      Console.WriteLine(objeto1.Mostrar());

      Cosa objeto2 = new Cosa(125);
      Console.WriteLine(objeto2.Mostrar());

      Cosa objeto3 = new Cosa(15, new DateTime());
      Console.WriteLine(objeto3.Mostrar());

      Cosa objeto4 = new Cosa(35, DateTime.MaxValue, "Mensaje");
      Console.WriteLine(objeto4.Mostrar());


      //objeto.EstablecerValor(9);
      //objeto.EstablecerValor("Esta es la cadena");
      //objeto.EstablecerValor(DateTime.Now);

      ///Console.WriteLine(objeto.Mostrar());
      //Console.WriteLine(Cosa.Mostrar(objeto));

      Console.ReadKey();
    }
  }
}
