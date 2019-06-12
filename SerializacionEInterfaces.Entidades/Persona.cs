using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Clase17.Entidades
{
  public class Persona : Humano, ISerializableXML
  {
    public string apellido;
    public string nombre;

    public Persona()
    {
    }

    public Persona(string nombre, string apellido)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }

    public string Path
    { get; set; }


    bool ISerializableXML.SerializarXML()
    {
      try
      {
        XmlSerializer objSerializador = new XmlSerializer(typeof(Persona));
        StreamWriter objEscritor = new StreamWriter(@"C:\Users\alumno\Desktop\persona.xml");
        objSerializador.Serialize(objEscritor, this);
        objEscritor.Close();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool DeserealizarXML()
    {
      return true;
    }


    public override string ToString()
    {
      return base.ToString() + "APELLIDO: " + this.apellido + "\nNOMBRE: " + this.nombre + "\n";
    }

    public bool SerializarXML()
    {
      throw new NotImplementedException();
    }
  }
}
