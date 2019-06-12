using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Rouaux.Santiago._2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perroUno = new Perro("Moro", "Pitbull");
            Perro perroDos = new Perro("Julio", "Cruza", 13, false);
            Perro perroTres = new Perro("Ramón", "Salchicha", 2, true);
            Perro perroCuatro = new Perro("Moro", "Pitbull");
            Gato gatoUno = new Gato("José", "Angora");
            Gato gatoDos = new Gato("Hernán", "Cruza");
            Gato gatoTres = new Gato("Fer", "Siamés");

            Grupo grupoUno = new Grupo("Río", EtipoManada.Mixta);
            grupoUno += perroUno;
            grupoUno += perroDos;
            grupoUno += perroUno;
            grupoUno += perroTres;
            grupoUno += perroCuatro;
            grupoUno += gatoUno;
            grupoUno += gatoDos;
            grupoUno += gatoTres;
            Console.WriteLine(grupoUno);

            grupoUno -= perroTres;
            grupoUno -= gatoTres;
            grupoUno -= gatoTres;
            Console.WriteLine(grupoUno);

            if (perroUno.Equals("perroUno"))
                Console.WriteLine("Son la misma mascota");
            else
                Console.WriteLine("No son la misma mascota");

            Console.WriteLine("");
            Perro nuevoPerro = new Perro("Moro", "Pitbull", 1, false);
            Console.WriteLine(grupoUno == nuevoPerro);
            grupoUno += nuevoPerro;
            Console.WriteLine(grupoUno == nuevoPerro);

            Console.ReadLine();
        }
    }
}
