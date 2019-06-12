using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase17.Entidades;
using System.Xml.Serialization;
using System.IO;

namespace Clase17.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Humano humano = new Humano();
      humano.Dni = 3154678;
      Persona persona1 = new Persona();
      Persona persona2 = new Persona("Juan", "Rodriguez");
      persona2.Dni = 34567898;
      Alumno alumno = new Alumno();
      alumno.nombre = "Martin";
      alumno.Legajo = 3435;
      Profesor profesor = new Profesor();
      profesor.Dni = 456789;
      profesor.nombre = "Pablo";
      profesor.apellido = "Ruiz";
      profesor.Titulo = "L";

      List<Humano> lista = new List<Humano>();
      lista.Add(alumno);
      lista.Add(profesor);

      

      //Console.WriteLine(humano.ToString());
      //Console.WriteLine(persona1.ToString());
      //Console.WriteLine(persona2.ToString());
      //Console.WriteLine(alumno.ToString());
      //Console.WriteLine(profesor.ToString());

      if (Program.SerializarAlumno(alumno) == true)
      {
        Console.WriteLine("Se logró serializar");
      }
      else
      {
        Console.WriteLine("No se logró serializar");
      }

      Alumno auxAlumno = Program.DeserealizarAlumno();
      if(auxAlumno != null)
      {
        Console.WriteLine("Se logró deserializar");
        Console.WriteLine(auxAlumno.ToString());
      }
      else
      {
        Console.WriteLine("No se pudo deserializar");
      }

      //if(Program.SerializarHumano(humano) == true)
      //{
      //  Console.WriteLine("Se logró serializar\n");
      //}
      //else
      //{
      //  Console.WriteLine("No se logró serializar\n");
      //}

      //if (Program.SerializarHumano(profesor) == true)
      //{
      //  Console.WriteLine("Se logró serializar\n");
      //}
      //else
      //{
      //  Console.WriteLine("No se logró serializar\n");
      //}

      
      Program.SerializarLista(lista);

      Console.ReadKey();
    }


    public static bool SerializarAlumno(Alumno a)
    {
      try
      {
        XmlSerializer objSerializador = new XmlSerializer(typeof(Alumno));
        StreamWriter objEscritor = new StreamWriter(@"C:\Users\alumno\Desktop\alumno.xml");
        objSerializador.Serialize(objEscritor, a);
        objEscritor.Close();
        return true;
      }
      catch (Exception)
      {        
        return false;
      }
    }

    public static Alumno DeserealizarAlumno()
    {
      try
      {
        XmlSerializer objSerializador = new XmlSerializer(typeof(Alumno));
        StreamReader objLector = new StreamReader("C:\\Users\\alumno\\Desktop\\alumno.xml");
        Alumno a = new Alumno();
        a = (Alumno)objSerializador.Deserialize(objLector);
        objLector.Close();
        return a;
      }
      catch (Exception)
      {
        return null;
      }
    }


    public static bool SerializarHumano(Humano h)
    {
      try
      {
        XmlSerializer objSerializador = new XmlSerializer(typeof(Humano));
        StreamWriter objEscritor = new StreamWriter(@"C:\Users\alumno\Desktop\humano.xml");
        objSerializador.Serialize(objEscritor, h);
        objEscritor.Close();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public static Humano DeserealizarHumano()
    {
      try
      {
        XmlSerializer objSerializador = new XmlSerializer(typeof(Humano));
        StreamReader objLector = new StreamReader("C:\\Users\\alumno\\Desktop\\humano.xml");
        Humano h = new Humano();
        h = (Humano)objSerializador.Deserialize(objLector);
        objLector.Close();
        return h;
      }
      catch (Exception)
      {
        return null;
      }
    }


    public static bool SerializarLista(List<Humano> lista)
    {
      try
      {
        XmlSerializer objSerializar = new XmlSerializer(typeof(List<Humano>));
        StreamWriter objEscritor = new StreamWriter("C:\\Users\\alumno\\Desktop\\lista.xml");
        objSerializar.Serialize(objEscritor, lista);
        objEscritor.Close();
        return true;

      }
      catch (Exception)
      {
        return false;
      }
    }

    //public static bool SerializarXML(IXmlSerializable o)
    //{
    //  return o.SerializarXml();
    //}

  }
}
