using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase22.Eventos.WindowsForm
{
  public class Manejadora
  {
    public static void Manejador(object sender, EventArgs e)
    {
      string cadena = "";
      if(sender is Button)
      {
        cadena = " y soy un botón";
      }
      else if(sender is Label)
      {
        cadena = " y soy una etiqueta";
      }
      else if (sender is TextBox)
      {
        cadena = " y soy una caja de texto";
      }

      MessageBox.Show("Estoy en la clase manejadora" + cadena);
    }

    public void ManejadorInst(object sender, EventArgs e)
    {
      MessageBox.Show("Estoy en el método de instancia de la Clase Manejadora");
    }
  }
}
