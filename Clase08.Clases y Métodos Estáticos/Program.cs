using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Métodos_Estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Este es un mensaje de prueba";
            Sello.color = ConsoleColor.Red;
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
