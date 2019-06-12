using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace WindowsForms_Paleta_y_Tempera
{
  public partial class frmTempera : Form
  {
    //Atributo
    private Tempera _miTempera;


    //Propiedad de lectura
    public Tempera MiTempera
    {
      get
      {
        return _miTempera;
      }
    }

    //Constructor
    public frmTempera()
    {
      InitializeComponent();

      //Carga el comboBox
      foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
      {
        cbColor.Items.Add(color);
      }
    }

    public frmTempera(Tempera temp, bool modificar) : this()
    {            
      this.txtMarca.Text = temp.Marca;    
      this.cbColor.SelectedItem = temp.Color;
      sbyte cant = temp;
      this.txtCantidad.Text = cant.ToString();

      if(modificar == true)
      {
        this.txtMarca.Enabled = true;
        this.cbColor.Enabled = true;
        this.txtCantidad.Enabled = true;
      }
      else
      {
        this.txtMarca.Enabled = false;
        this.cbColor.Enabled = false;
        this.txtCantidad.Enabled = false;
      }      
    }


    //Evento Click Aceptar
    private void btnAceptar_Click(object sender, EventArgs e)
    {
      sbyte salida;
      if (this.cbColor.SelectedItem != null && this.txtMarca.Text != "" && sbyte.TryParse(this.txtCantidad.Text, out salida))
      {
        Tempera tmp = new Tempera((ConsoleColor)this.cbColor.SelectedItem, this.txtMarca.Text, sbyte.Parse(this.txtCantidad.Text));
        this._miTempera = tmp;
        this.DialogResult = DialogResult.OK;        
      }
      else
      {
        MessageBox.Show("Algún campo está incompleto o presenta un valor incompatible");
      }
    }

    //Evento Click Cancelar
    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

  }
}
