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

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {

        private string rutaEscritura;


        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog1.Title = "Seleccione un archivo";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.DefaultExt = ".txt";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.Filter = "Archivos (*.TXT) | *.txt";
        }


        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            string valor;
            valor = this.txtValor.Text;

            try
            {
                if (this.rutaEscritura != null)
                {
                    StreamWriter escrituraArchivo = new StreamWriter(rutaEscritura, true);
                    escrituraArchivo.WriteLine(valor);
                    escrituraArchivo.Close();
                }
                else
                {
                    MessageBox.Show("La ruta no puede ser nula");
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("No se pudo escribir el archivo\n" + i.Message);
            }

            this.txtValor.Text = "";
        }


        private void btnTraer_Click(object sender, EventArgs e)
        {
            this.lstVisor.Items.Clear();
            string valor;

            DialogResult resultado = this.openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                try
                {
                    string rutaLectura = this.openFileDialog1.FileName;
                    StreamReader lecturaArchivo = new StreamReader(rutaLectura);
                    while ((valor = lecturaArchivo.ReadLine()) != null)
                    {
                        this.lstVisor.Items.Add(valor);
                    }
                    lecturaArchivo.Close();
                }
                catch (Exception i)
                {
                    MessageBox.Show("No se pudo abrir el archivo\n" + i.Message);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = this.openFileDialog1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show(this.openFileDialog1.FileName);
                rutaEscritura = this.openFileDialog1.FileName;
            }
        }

    }
}
