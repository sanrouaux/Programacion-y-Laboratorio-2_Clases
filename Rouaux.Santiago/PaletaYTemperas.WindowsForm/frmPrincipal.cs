using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Paleta_y_Tempera
{
    public partial class frmPrincipal : Form
    {
        //Constructor
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < 5; i++)
            {
                this.toolStripComboBox1.Items.Add(i + 1);
            }                
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {           
                  
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (this.toolStripComboBox1.SelectedItem != null)
            {
                frmPaleta frmPaleta = new frmPaleta((int)this.toolStripComboBox1.SelectedItem);
                frmPaleta.MdiParent = this;
                frmPaleta.Show();
                frmPaleta.StartPosition = FormStartPosition.CenterParent;
                this.toolStripComboBox1.SelectedItem = null;
            }
        }
    }
}
