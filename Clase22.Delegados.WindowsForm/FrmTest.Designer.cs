namespace Clase22.Eventos.WindowsForm
{
  partial class FrmTest
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnBoton = new System.Windows.Forms.Button();
      this.lblEtiqueta = new System.Windows.Forms.Label();
      this.txtCuadroTexto = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnBoton
      // 
      this.btnBoton.Location = new System.Drawing.Point(364, 66);
      this.btnBoton.Name = "btnBoton";
      this.btnBoton.Size = new System.Drawing.Size(75, 23);
      this.btnBoton.TabIndex = 0;
      this.btnBoton.Text = "Boton";
      this.btnBoton.UseVisualStyleBackColor = true;
      //this.btnBoton.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblEtiqueta
      // 
      this.lblEtiqueta.AutoSize = true;
      this.lblEtiqueta.Location = new System.Drawing.Point(387, 152);
      this.lblEtiqueta.Name = "lblEtiqueta";
      this.lblEtiqueta.Size = new System.Drawing.Size(35, 13);
      this.lblEtiqueta.TabIndex = 1;
      this.lblEtiqueta.Text = "label1";
      //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
      // 
      // txtCuadroTexto
      // 
      this.txtCuadroTexto.Location = new System.Drawing.Point(355, 216);
      this.txtCuadroTexto.Name = "txtCuadroTexto";
      this.txtCuadroTexto.Size = new System.Drawing.Size(100, 20);
      this.txtCuadroTexto.TabIndex = 2;
      //this.txtCuadroTexto.Click += new System.EventHandler(this.textBox1_Click);
      //
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtCuadroTexto);
      this.Controls.Add(this.lblEtiqueta);
      this.Controls.Add(this.btnBoton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBoton;
    private System.Windows.Forms.Label lblEtiqueta;
    private System.Windows.Forms.TextBox txtCuadroTexto;
  }
}

