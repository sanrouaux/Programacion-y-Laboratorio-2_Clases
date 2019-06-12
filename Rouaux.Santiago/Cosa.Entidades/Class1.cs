using System;

namespace Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        //Sobrecarga de Constructores
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(int numero) : this()
        {
            this.entero = numero;
        }

        public Cosa(int numero, DateTime fecha) : this(numero)
        {
            this.fecha = fecha;
        }

        public Cosa(int numero, DateTime fecha, string cadena) : this(numero, fecha)
        {
            this.cadena = cadena;
        }


        //METODOS
        public string Mostrar()
        {
            return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToShortDateString();
        }

        public static string Mostrar(Cosa objeto)
        {
            return objeto.Mostrar();
        }

        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
    }
}
