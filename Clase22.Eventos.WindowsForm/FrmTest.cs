using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase22.Eventos.WindowsForm
{
  public partial class FrmTest : Form
  {
    public FrmTest()
    {
      InitializeComponent();
      Manejadora m = new Manejadora();
      this.lblEtiqueta.Click += new EventHandler(m.ManejadorInst);

      this.lblEtiqueta.Click += new EventHandler(Manejadora.Manejador);
      this.btnBoton.Click += new EventHandler(Manejadora.Manejador);
      this.txtCuadroTexto.Click += new EventHandler(Manejadora.Manejador);
    }

    private void lblEtiqueta_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Evento Click sobre etiqueta");
      //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
      //this.txtCuadroTexto.Click -= new System.EventHandler(this.textBox1_Click);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Evento Click sobre botón");
      //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
      //this.txtCuadroTexto.Click += new System.EventHandler(this.textBox1_Click);
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Evento Click sobre TextBox");
    }
    
  }
}
