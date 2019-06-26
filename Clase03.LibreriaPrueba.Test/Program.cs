using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Libreria;
using System.Xml.Serialization;
using System.Xml;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xml = new XmlSerializer(typeof(string));
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\serie.xml");
            xml.Serialize(writer, "Hola");

            XmlTextWriter 

            /*Console.WriteLine("Hola, mundo!");
            Console.ReadKey();

            Console.Write("Ingrese su nombre: ");
            String nombre;
            nombre = Console.ReadLine();

            Console.WriteLine("Su nombre es: {0}", nombre);
            Console.ReadKey();*/

            //Console.WriteLine(Prueba.Saludar());
            Console.ReadKey();
        }
    }
}

