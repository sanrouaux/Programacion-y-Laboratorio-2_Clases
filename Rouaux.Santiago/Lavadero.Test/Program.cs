using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;
using Lavadero;


namespace Clase_08.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("AAA", 4, EMarca.Fiat, 5);
            Moto moto = new Moto("BBB", 2, EMarca.Zanella, 50);
            Camion camion = new Camion("CCC", 8, EMarca.Iveco, 5000);

            Lavadero.Lavadero lavadero = new Lavadero.Lavadero((float)22.5, (float)30.50, (float)12.5);
            Console.WriteLine("Presentacion de Mi Lavadero...\n");
            Console.WriteLine(lavadero.MiLavadero);

            Console.WriteLine("Agrego vehiculos al Lavadero...\n");
            lavadero += auto;
            lavadero += camion;
            lavadero += moto;
            Console.ReadKey();
            Console.WriteLine(lavadero.MiLavadero);
            Console.ReadKey();

            Console.WriteLine("Muestro la facturacion...");
            Console.WriteLine("El total facturado es: " + lavadero.MostrarTotalFacturado());
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Muestro la facturacion por tipo de vehiculo...");
            Console.WriteLine("Facturacion Autos: " + lavadero.MostrarTotalFacturado<Auto>());
            Console.WriteLine("Facturacion Camiones: " + lavadero.MostrarTotalFacturado<Camion>());
            Console.WriteLine("Facturacion Motos: " + lavadero.MostrarTotalFacturado<Moto>());
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Ordeno los vehiculos por patente...\n");
            List<Vehiculo> listaVehiculos = new List<Vehiculo>(lavadero.Vehiculos);
            listaVehiculos.Sort(Lavadero.Lavadero.OrdenarVehiculosPorPatente);
            listaVehiculos.ForEach(Console.WriteLine);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Ordeno los vehiculos por marca...\n");
            listaVehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);
            listaVehiculos.ForEach(Console.WriteLine);
            Console.ReadKey();


            auto.Precio = 150000.50;
            camion.Precio = 400000.32;
            moto.Precio = 30000.4876;
            Console.WriteLine("{0, -35} {1, -10: .00}", "El precio del auto con IVA es ", auto.CalcularPrecioConIva());
            Console.WriteLine("{0, -35} {1, -10: .00}", "El precio del camion con IVA es ", camion.CalcularPrecioConIva());
            Console.WriteLine("{0, -35} {1, -10: .00}", "El precio de la moto con IVA es ", moto.CalcularPrecioConIva());
            Console.ReadKey();
        }
    }
}
