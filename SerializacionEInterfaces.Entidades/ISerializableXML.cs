using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.Entidades
{
  interface ISerializableXML
  {
    bool SerializarXML();

    bool DeserealizarXML();

    string Path { get; set; }
  }
}
