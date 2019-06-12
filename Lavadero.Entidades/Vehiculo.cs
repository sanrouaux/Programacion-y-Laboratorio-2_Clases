using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        //Atributos
        protected string _patente;
        protected byte _cantidadRuedas;
        protected EMarca _marca;


        //Propiedades
        public string Patente
        {
            get { return _patente; }
        }

        public EMarca Marca
        {
            get { return _marca; }
        }

        //Propiedad no ligada a un atributo 
        public abstract double Precio
        { get; set; }


        //Constructor
        public Vehiculo(string patente, byte cantRuedas, EMarca marca)
        {
            this._patente = patente;
            this._cantidadRuedas = cantRuedas;
            this._marca = marca;
        }


        //Sobreescritura Metodo ToString
        public override string ToString()
        {
            return this._patente + " - " + this._marca.ToString() + " - " + this._cantidadRuedas.ToString();
        }


        //Metodo Mostrar
        //protected string Mostrar()
        //{
        //  return this._patente + " - " + this._marca.ToString() + " - " + this._cantidadRuedas.ToString();
        //}


        //Sobrecarga de operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1._patente == v2._patente && v1._marca == v2._marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        //Metodo abstracto
        public abstract double CalcularPrecioConIva();

    }
}
