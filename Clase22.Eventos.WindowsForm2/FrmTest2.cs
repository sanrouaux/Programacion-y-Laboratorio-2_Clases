using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase22.Eventos.WindowsForm2
{
  public partial class FrmTest2 : Form
  {
    public FrmTest2()
    {
      InitializeComponent();
      this.Load += new EventHandler(this.Inicializar);
    }

    private void Inicializar(object sender, EventArgs e)
    {
      this.btnBoton1.Click += new EventHandler(this.MiManejador);
    }
        
    private void MiManejador(object sender, EventArgs e)
    {
      Control senderAux = (Control)sender;
      if(senderAux == this.btnBoton1)
      {
        this.btnBoton1.Click -= new EventHandler(this.MiManejador);
          this.btnBoton2.Click += new EventHandler(this.MiManejador);   
      }
      else if(senderAux == this.btnBoton2)
      {
        this.btnBoton2.Click -= new EventHandler(this.MiManejador);
        this.btnBoton3.Click += new EventHandler(this.MiManejador);
      }
      else if(senderAux == btnBoton3)
      {
        this.btnBoton3.Click -= new EventHandler(this.MiManejador);
        this.btnBoton1.Click += new EventHandler(this.MiManejador);
      }                
      MessageBox.Show(senderAux.Name);
    }


    public static void Sumar(int a, int b)
    {
      MessageBox.Show((a + b).ToString());
    }

    public void Restar(int a, int b)
    {
      MessageBox.Show((a - b).ToString());
    }

    public void Multiplicar(int a, int b)
    {
      MessageBox.Show((a * b).ToString());
    }

    public void OtraSuma(MiDelegado d, int a, int b)
    {
      d.Invoke(a, b);
    }

    private void btnBoton4_Click(object sender, EventArgs e)
    {
      MiDelegado del = new MiDelegado(Sumar);
      MessageBox.Show(del.Method.ToString());    // Me devuelve metodo de la lista de invocacion
      Delegate[] lista = del.GetInvocationList(); // Me devuelve lista completa de invocacion
      foreach (Delegate d in lista)
      {
        MessageBox.Show(d.Method.ToString());
      }
      del.Invoke(3, 2); // o del(3,2)

      MiDelegado del2 = new MiDelegado(this.Restar);
      MessageBox.Show((del2.Target).ToString()); //Devuelve la instancia de clase que contiene al metodo que esta en la lista
      del2.Invoke(3, 2);

      MiDelegado del3 = (MiDelegado)MiDelegado.Combine(del, del2);
      del3.Invoke(5, 2);

      MiDelegado del4 = (MiDelegado)MiDelegado.Combine(del, new MiDelegado(this.Multiplicar));
      del4.Invoke(12, 4);

      this.OtraSuma(del, 3, 2);
    }

  }
}
