using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        //Atributos
        private string _nombre;
        private string _raza;


        //Propiedades
        public string Nombre
        {
            get { return _nombre; }         
        }
       

        public string Raza
        {
            get { return _raza; }       
        }


        //Constructores
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }


        //Metodo Abstracto
        protected abstract string Ficha();


        //Metodo virtual
        protected virtual string DatosCompletos()
        {
            return this._nombre + " " + this._raza;
        }

    }
}
