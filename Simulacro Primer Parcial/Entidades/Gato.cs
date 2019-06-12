using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        //Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }

        //Sobreescritura del metodo abstracto 
        protected override string Ficha()
        {            
            return this.DatosCompletos();
        }


        //Sobrecarga de operadores
        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }


        //Sobreescritura del metodo Equals
        public override bool Equals(object obj)
        {
            if (obj is Gato && this == (Gato)obj)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Sobreescritura del metodo ToString
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
