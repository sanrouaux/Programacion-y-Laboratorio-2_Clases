using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Entidades
{
  public class ErrorParserException : Exception
  {
    public ErrorParserException(string mensaje, Exception e) : base("El string no podra ser convertido " + mensaje, e)
    {

    }
  }
}
