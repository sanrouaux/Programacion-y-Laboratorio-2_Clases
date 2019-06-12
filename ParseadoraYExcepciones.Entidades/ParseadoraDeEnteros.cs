using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Entidades
{
  public static class ParseadoraDeEnteros
  {
    public static int Parse(string s)
    {      
      try
      {
        return Int32.Parse(s);
      }
      catch (FormatException e)
      {        
        throw new ErrorParserException("por error de formato", e);
      }
      catch(OverflowException e)
      {
        throw new ErrorParserException("por tamaño del dato", e);
      }      
    }


    public static bool TryParse(string s, out int salida)
    {
      try
      {
        salida = Int32.Parse(s);
        return true;
      }
      catch (Exception e)
      {
        salida = 0;
        return false;              
      }       
    }

  }
}
