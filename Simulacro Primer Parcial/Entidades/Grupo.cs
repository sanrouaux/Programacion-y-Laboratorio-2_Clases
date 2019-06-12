using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        //Atributos
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        //Propiedades
        public EtipoManada Tipo
        {
            set { Grupo._tipo = value; }
        }

        //Constructores
        //Constructor estatico - Es llamado la primera vez que se inicializa un objeto
        static Grupo()
        {
            Grupo._tipo = EtipoManada.Unica;
        }

        //Constructores de instancia
        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }


        //Conversion implicita
        public static implicit operator string(Grupo g)
        {
            string retorno = "Grupo: " + g._nombre + " - tipo: " + Grupo._tipo.ToString() + "\n"
                + "Integrantes (" + g._manada.Count() + "):\n";
            
            foreach(Mascota m in g._manada)
            {
                retorno += m.ToString() + "\n";
            }
            return retorno;
        }


        //Sobrecarga de opeeradores
        public static bool operator ==(Grupo g, Mascota m)
        {
            return g._manada.Contains(m);
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m)
            {
                g._manada.Add(m);                
            }
            else
            {
                Console.WriteLine("Ya está el " + m.ToString() + " en el grupo");
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No está el " + m.ToString() + " en el grupo");
            }
            return g;
        }
    }
}
