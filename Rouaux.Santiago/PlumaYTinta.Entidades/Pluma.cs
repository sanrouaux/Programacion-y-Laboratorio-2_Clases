using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        //Sobrecarga de Constructores
        public Pluma() : this("sin marca", null, 0)
        {
        }

        public Pluma(string marca) : this(marca, null, 0)
        {
        }

        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }


        //Metodos
        private string Mostrar()
        {
            return this._marca + " - " + "(" + Tinta.Mostrar(this._tinta) + ")" + " - " + this._cantidad.ToString();
        }


        //Sobrecarga de Operadores: "==", "!=", "+" y "-"

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma._tinta == tinta;
        }


        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }


        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma._tinta == tinta && pluma._cantidad < 100)
            {
                pluma._cantidad += 10;

                if(pluma._cantidad > 100)
                {
                    pluma._cantidad = 100;
                }
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma._tinta == tinta && pluma._cantidad > 0)
            {
                pluma._cantidad -= 10;

                if (pluma._cantidad < 0)
                {
                    pluma._cantidad = 0;
                }
            }
            return pluma;
        }


        //Conversion de datos
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }


    }
}
