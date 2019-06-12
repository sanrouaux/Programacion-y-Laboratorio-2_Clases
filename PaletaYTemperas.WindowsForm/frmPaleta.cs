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
  public partial class frmPaleta : Form
  {
    //Propiedad
    private Paleta _miPaleta;


    //Constructor
    public frmPaleta(int cantidad)
    {
      InitializeComponent();
      this._miPaleta = cantidad;

      //Harcodeo valores 
      //this._miPaleta.Temperas.Add(new Tempera(ConsoleColor.Blue, "bic", 3));
      //this._miPaleta.Temperas.Add(new Tempera(ConsoleColor.Red, "pencil", 2));
      //this.despliegaItems();
    }

    //Metodo DespliegaItems
    private void despliegaItems()
    {
      this.lstLista.Items.Clear();
      for (int i = 0; i < this._miPaleta.Temperas.Count; i++)
      {
        if (this._miPaleta.Temperas[i] != null)
        {
          this.lstLista.Items.Add(Tempera.Mostrar(this._miPaleta.Temperas[i]));
        }
      }
    }


    //Eventos
    private void btnMas_Click(object sender, EventArgs e)
    {
      frmTempera frmTemp = new frmTempera();
      frmTemp.ShowDialog();

      if (frmTemp.DialogResult == DialogResult.OK && this._miPaleta.Temperas.Count < this._miPaleta.CantidadMaxima)
      {
        this._miPaleta += frmTemp.MiTempera;
        this.despliegaItems();
      }
    }


    private void btnMenos_Click(object sender, EventArgs e)
    {
      int indice = this.lstLista.SelectedIndex;
      if (indice > -1)
      {
        Tempera temp = this._miPaleta.Temperas[indice];

        frmTempera frmTemp = new frmTempera(temp, false);
        frmTemp.ShowDialog();

        if (frmTemp.DialogResult == DialogResult.OK)
        {
          this._miPaleta = this._miPaleta - frmTemp.MiTempera;
          this.despliegaItems();
        }
      }
      else
      {
        MessageBox.Show("Selecccione un ítem");
      }
    }

    private void lstLista_DoubleClick(object sender, EventArgs e)
    {
      int indice = this.lstLista.SelectedIndex;
      Tempera temp = this._miPaleta.Temperas[indice];
      frmTempera frmTemp = new frmTempera(temp, true);
      frmTemp.ShowDialog();

      if (frmTemp.DialogResult == DialogResult.OK)
      {
        this._miPaleta.Temperas[indice] = frmTemp.MiTempera;
        this.despliegaItems();
      }       
    }
  }
}
