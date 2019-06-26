using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18.BaseDeDatos;
using System.Data;

namespace Clase18.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos baseDatos = new AccesoDatos();

            //List<Persona> lista = new List<Persona>();
            //lista = baseDatos.TraerTodos();
            //foreach(Persona p in lista)
            //{
            //    Console.WriteLine(p.ToString());
            //}


            //Persona p = new Persona(10, "Santiago", "Gonzalez", 40);
            //if(baseDatos.AgregarPersona(p) == true)
            //{
            //    Console.WriteLine("Se agregó una persona");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo agregar la persona");
            //}


            //Persona p = new Persona(11, "Juan", "Dominguez", 43);
            //if(baseDatos.ModificarPersona(p))
            //{
            //  Console.WriteLine("Se modificaron datos");
            //}
            //else
            //{
            //  Console.WriteLine("No se modificó la base de datos");
            //}


            //if (baseDatos.EliminarPersona(10))
            //{
            //  Console.WriteLine("Se eliminaron datos");
            //}
            //else
            //{
            //  Console.WriteLine("No se eliminaron datos");
            //}

            DataTable tabla = new DataTable();
            tabla = baseDatos.TraerTablaPersona();

            foreach (DataRow row in tabla.Rows)
            {
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    Console.Write(row[i]);
                }
                Console.WriteLine();
            }

            //tabla.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_Esquemas.xml");
            //tabla.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"/Personas_Datos.xml");

            //tabla.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_Esquemas.xml");
            //tabla.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_Datos.xml");

            //foreach (DataRow row in tabla.Rows)
            //{
            //    for (int i = 0; i < tabla.Columns.Count; i++)
            //    {
            //        Console.Write(row[i]);
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
