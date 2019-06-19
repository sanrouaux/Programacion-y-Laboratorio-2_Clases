using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Clase23.Eventos.Entidades;

namespace Clase23.Eventos.Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Program program = new Program();
      Empleado emp = new Empleado();
      emp.limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado); //El delegado asocia una funcion a un evento. Inicializa la "escucha"       
      emp.limiteSueldo += new DelegadoSueldo(program.GuardarLog); //Idem
      
      emp.Nombre = "Suarez, Juan";
      emp.Legajo = 4352;
      emp.Sueldo = 13000;
      Console.WriteLine(emp.ToString());

      Console.Read();
    }

    //MANEJADORES 
    public static void LimiteSueldoEmpleado(Empleado e, float sueldo)
    {
      Console.WriteLine("Al empleado " + e.Nombre + ", con legajo nº " + e.Legajo + ", se intentó asignar un sueldo de " + sueldo.ToString());
    }

    public void GuardarLog(Empleado e, float sueldo)
    {
      try
      {
        StreamWriter objEscritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Incidentes.log", true);
        objEscritor.WriteLine(DateTime.Now.ToString());
        objEscritor.WriteLine("Al empleado " + e.Nombre + ", con legajo nº " + e.Legajo + ", se intentó asignar un sueldo de " + sueldo.ToString());
        objEscritor.Close();
      }
      catch (Exception)
      {
        Console.WriteLine("No se pudo escribir");
      }
    }

  }
}
