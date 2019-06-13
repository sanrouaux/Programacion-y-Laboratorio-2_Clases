using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Lavadero
{
  public class Lavadero 
  {
    //ATRIBUTOS
    private List<Vehiculo> _vehiculos;
    private float _precioAuto;
    private float _precioCamion;
    private float _precioMoto;


    //PROPIEDADES
    public string MiLavadero 
    {
      get
      {
        string retorno;
        retorno = "El precio del lavado del auto es " + this._precioAuto + "\n";
        retorno += "El precio del lavado del camion es " + this._precioCamion + "\n";
        retorno += "El precio del lavado de la moto es " + this._precioMoto + "\n";
        retorno += "Vehiculos en el Lavadero: \n";
        retorno += "PATENTE - MARCA - CANT DE RUEDAS - INFO EXTRA\n";
        foreach (Vehiculo veh in this._vehiculos)
        {
          retorno += veh.ToString();
        }
        return retorno;
      }
    }


    public List<Vehiculo> Vehiculos
    {
      get
      {
        return _vehiculos;
      }
    }


    //CONSTRUCTORES
    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
    {
      this._precioAuto = precioAuto;
      this._precioCamion = precioCamion;
      this._precioMoto = precioMoto;
    }


    //SOBRECARGA DE OPERADORES
    public static bool operator ==(Lavadero lav, Vehiculo veh)
    {
      bool retorno = false;

      for (int i = 0; i < lav._vehiculos.Count; i++)
      {
        if (lav._vehiculos[i] == veh)
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }


    public static bool operator !=(Lavadero lav, Vehiculo veh)
    {
      return !(lav == veh);
    }


    public static Lavadero operator +(Lavadero lav, Vehiculo veh)
    {
      if (lav != veh)
      {
        lav._vehiculos.Add(veh);
      }
      return lav;
    }

    public static Lavadero operator -(Lavadero lav, Vehiculo veh)
    {
      if (lav == veh)
      {
        lav._vehiculos.Remove(veh);
      }
      return lav;
    }


    //METODOS MOSTRAR FACTURACION
    public double MostrarTotalFacturado()
    {
      double total = 0;

      for (int i = 0; i < this._vehiculos.Count; i++)
      {
        if (this._vehiculos[i] is Auto)
        {
          total += _precioAuto;
        }
        else if (this._vehiculos[i] is Camion)
        {
          total += _precioCamion;
        }
        else if (this._vehiculos[i] is Moto)
        {
          total += _precioMoto;
        }
      }
      return total;
    }


    public double MostrarTotalFacturado<EVehiculos>() //No es la manera correcta de hacerlo. Hay que pasarle un enumerado como parametro
    {
      double total = 0;

      for (int i = 0; i < this._vehiculos.Count; i++)
      {
        if (this._vehiculos[i] is EVehiculos)
        {
          if (this._vehiculos[i] is Auto)
          {
            total += this._precioAuto;
          }
          else if (this._vehiculos[i] is Camion)
          {
            total += this._precioCamion;
          }
          else if (this._vehiculos[i] is Moto)
          {
            total += this._precioMoto;
          }
        }
      }
      return total;
    }


    //METODOS DE ORDENAMIENTO

    public static int OrdenarVehiculosPorPatente(Vehiculo veh1, Vehiculo veh2)
    {
      return string.Compare(veh1.Patente, veh2.Patente);
    }


    public int OrdenarVehiculosPorMarca(Vehiculo veh1, Vehiculo veh2)
    {
      return string.Compare(veh1.Marca.ToString(), veh2.Marca.ToString());
    }

  }
}
