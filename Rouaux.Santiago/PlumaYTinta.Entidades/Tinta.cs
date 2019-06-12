using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        //Constructores - Sobrecarga
        public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color) : this(color, ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
        {
            this._color = color;
            this._tipoTinta = tipoTinta;
        }

        //Metodos - Sobrecarga
        private string Mostrar()
        {
            return this._color.ToString() + ", " + this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        //Sobrecarga de operadores "==" y "!="
        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            if (tinta1._color == tinta2._color && tinta1._tipoTinta == tinta2._tipoTinta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

    }
}
