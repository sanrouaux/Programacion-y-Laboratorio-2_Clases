using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase18.BaseDeDatos;

namespace BaseDeDatos.WindowsForm
{
  public partial class FrmListado : Form
  {
    List<Persona> lista = new List<Persona>();
    DataTable tabla = new DataTable();

    public FrmListado()
    {
      InitializeComponent();     
    }

    private void FrmListado_Load(object sender, EventArgs e)
    {
      AccesoDatos baseDatos = new AccesoDatos();
      lista = baseDatos.TraerTodos();
      tabla = baseDatos.TraerTablaPersona();
      this.grilla.DataSource = this.tabla;
    }
  }
}
