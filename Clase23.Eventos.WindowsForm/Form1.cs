using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Clase23.Eventos.Entidades;


namespace Clase23.Eventos.WindowsForm
{
  public partial class Form1 : Form
  {
    EmpleadoMejorado emp = new EmpleadoMejorado();

    public Form1()
    {
      InitializeComponent();

      this.button1.Click += new EventHandler(button1_Click);

      foreach(ETipoManejador tm in Enum.GetValues(typeof(ETipoManejador)))
      {
        this.comboBox1.Items.Add(tm);
      }      
    }

    public void button1_Click(object sender, EventArgs e)
    {
      emp.limiteSueldo -= new DelSueldo(EmpleadoMejorado_limiteSueldo);
      emp.limiteSueldo -= new DelSueldo(EmpleadoMejorado_log_limiteSueldo);

      ETipoManejador tm = (ETipoManejador)this.comboBox1.SelectedItem;
      if(tm == ETipoManejador.limiteSueldo || tm == ETipoManejador.ambos)
      {
        emp.limiteSueldo += new DelSueldo(EmpleadoMejorado_limiteSueldo);        
      }
      if(tm == ETipoManejador.log || tm == ETipoManejador.ambos)
      {        
        emp.limiteSueldo += new DelSueldo(EmpleadoMejorado_log_limiteSueldo);
      }
      
      emp.Nombre = this.textBox1.Text;
      emp.Legajo = int.Parse(this.textBox2.Text);
      emp.Sueldo = float.Parse(this.textBox3.Text);
    }


    public void EmpleadoMejorado_limiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs args)
    {
      MessageBox.Show("Al empleado " + e.Nombre + ", con legajo nº " + e.Legajo + ", se intentó asignar un sueldo de " + args.Sueldo.ToString());
    }

    public void EmpleadoMejorado_log_limiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs args)
    {
      try
      {
        StreamWriter objEscritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Incidentes2.log", true);
        objEscritor.WriteLine(DateTime.Now.ToString());
        objEscritor.WriteLine("Al empleado " + e.Nombre + ", con legajo nº " + e.Legajo + ", se intentó asignar un sueldo de " + args.Sueldo.ToString());
        objEscritor.Close();
      }
      catch (Exception)
      {
        MessageBox.Show("No se pudo escribir");
      }
    }
  }
}
