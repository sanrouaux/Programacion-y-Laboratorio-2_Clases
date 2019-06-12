using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase14.Entidades;

namespace Clase14.Test
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Ingrese un numero: ");
      string cadena;
      cadena = Console.ReadLine();

      try
      {
        Console.WriteLine(ParseadoraDeEnteros.Parse(cadena));
      }
      catch (ErrorParserException e)
      {
        Console.WriteLine(e.Message);
      }

      Console.WriteLine("Ingrese otro numero: ");
      string cadena2;
      cadena2 = Console.ReadLine();
      int salida;
      if(ParseadoraDeEnteros.TryParse(cadena2, out salida) == false)
      {
        Console.WriteLine("No se puede convertir");
      }
      else
      {
        Console.WriteLine(salida);
      }

      Console.ReadKey();
    }
  }
}
