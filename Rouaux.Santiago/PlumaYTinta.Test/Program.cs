using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;

namespace Clase_05.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo y muestro 3 tipos de tinta");
            Tinta t1 = new Tinta();
            Tinta t2 = new Tinta(ConsoleColor.Blue);
            Tinta t3 = new Tinta(ConsoleColor.DarkGreen, ETipoTinta.China);                        
            Console.WriteLine("Tinta 1 = " + Tinta.Mostrar(t1));
            Console.WriteLine("Tinta 2 = " + Tinta.Mostrar(t2));
            Console.WriteLine("Tinta 3 = " + Tinta.Mostrar(t3));
            Console.WriteLine();


            Console.WriteLine("Creo y muestro 3 tipos de pluma. Utilizo la conversión implícita a tipo String");
            Pluma p1 = new Pluma("Bic", t1, 40);
            Pluma p2 = new Pluma("Parker", t2, 80);
            Pluma p3 = new Pluma("Fibra", t3, 25);            
            Console.Write("Pluma 1 = ");
            Console.WriteLine(p1);
            Console.Write("Pluma 2 = ");
            Console.WriteLine(p2);
            Console.Write("Pluma 3 = ");
            Console.WriteLine(p3);
            Console.WriteLine();


            Console.WriteLine("Comparo las tintas...");
            Console.WriteLine("Comparo tinta 1 con tinta 1. Es igual?");
            Console.WriteLine(t1 == t1);
            Console.WriteLine("Comparo tinta 1 con tinta 2. Es igual?");
            Console.WriteLine(t1 == t2);
            Console.WriteLine();


            Console.WriteLine("Averiguo si una pluma contiene una determinada tinta...");
            Console.WriteLine("La pluma 1 contiene la tinta 2?");
            Console.WriteLine(p1 == t2); 
            Console.WriteLine("La pluma 3 contiene la tinta 3?");
            Console.WriteLine(p3 == t3);
            Console.WriteLine();


            Console.WriteLine("Recargo la pluma 1 con la tinta 1...");
            p1 += t1;
            Console.WriteLine(p1);
            Console.WriteLine("Intento recargar la pluma 1 con la tinta 2...");
            p1 += t2;
            Console.WriteLine(p1);
            Console.WriteLine("Consumo la tinta de la pluma 1...");
            p1 -= t1;
            Console.WriteLine(p1);

            Console.ReadKey();
        }
    }
}
