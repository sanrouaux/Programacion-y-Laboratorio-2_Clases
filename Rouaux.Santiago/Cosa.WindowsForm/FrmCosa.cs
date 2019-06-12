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

namespace Clase_04.WindowsForm
{
    public partial class FrmCosa : Form
    {
        //Constructor
        public FrmCosa()
        {
            InitializeComponent();
        }

        //Además de Atributos y Métodos, la clase tiene Eventos
        //
        //Metodo ligado a Evento Load
        private void FrmCosa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDOS!");
            this.button1.Text = "Crear un objeto bonito";
            this.Text = "Mi formulario";
        }

        //Metodo ligado a Evento Click sobre el boton
        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            DateTime fecha;
            string cadena;

            numero = int.Parse(this.textBox1.Text);
            fecha = this.monthCalendar1.SelectionRange.Start;
            cadena = this.textBox3.Text;

            Cosa objeto = new Cosa(numero, fecha, cadena);
            MessageBox.Show("Has creado un lindo objeto\n" + objeto.Mostrar());

        }
    }
}
