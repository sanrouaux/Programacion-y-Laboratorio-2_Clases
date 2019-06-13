using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta
    {
        //ATRIBUTOS
        private List<Tempera> _temperas;
        private int _cantidadMaxima;


        //CONSTRUCTORES PRIVADOS
        private Paleta() : this(5)
        {

        }

        private Paleta(int cantidad)
        {
            this._cantidadMaxima = cantidad;
            this._temperas = new List<Tempera>();
        }


        //PROPIEDAD
        public List<Tempera> Temperas
        {
            get { return _temperas; }
        }


        public int CantidadMaxima
        {
            get { return _cantidadMaxima; }            
        }
        

        //METODO MOSTRAR
        private string Mostrar()
        {
            string retorno = "La paleta tiene " + this._cantidadMaxima + " pinturas.\n";

            foreach (Tempera temp in this._temperas)
            {
                retorno += Tempera.Mostrar(temp);
            }
            return retorno;
        }


        //CONVERSION IMPLICITA. LLama al constructor de Paleta con un parámetro y devuelve un objeto Paleta  
        public static implicit operator Paleta(int tamano)
        {
            return new Paleta(tamano);
        }


        //CONVERSION EXPLICITA. Llama al método Mostrar de Paleta, que llama al método Mostrar de Tempera
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        //SOBRECARGA DE OPERADORES
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;
            foreach (Tempera temp in paleta._temperas)
            {
                if (temp == tempera)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }


        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            if (paleta != tempera)
            {
                paleta._temperas.Add(tempera);
            }
            return paleta;
        }


        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            for (int i = 0; i < paleta.Temperas.Count; i++)
            {
                if (paleta.Temperas[i] == tempera)
                {
                    paleta.Temperas.Remove(paleta.Temperas[i]);
                    break;
                }
            }
            return paleta;
        }


        //private int ObtenerIndice()
        //{
        //    int retorno = -1;
        //    for (int i = 0; i < this._cantidadMaxima; i++)
        //    {
        //        if (this._temperas[i] == null)
        //        {
        //            retorno = i;
        //        }
        //    }
        //    return retorno;
        //}

    }
}
