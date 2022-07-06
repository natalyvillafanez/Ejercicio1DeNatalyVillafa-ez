using System;

namespace Ejercicio1DeNatalyVillafañez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "INFORME DE DOLARES Y EUROS";

            Console.WriteLine("Le informaremos la cantidad de Dólares que puede comprar...");
            Console.WriteLine("Para ello necesitamos saber de cuánto dinero dispone.");
            Console.Write("INGRESE LA CANTIDAD DE DINERO EN PESOS DISPONIBLE: ");
            var pesosIngresados = double.Parse(Console.ReadLine());

            var dolar = (pesosIngresados / 230);
            var euro = (dolar * 1.17);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Con {0} Pesos, puede comprar {1} Dólares.", pesosIngresados, dolar);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Y con {0} Dólares, puede comprar {1} Euros.", dolar, euro);
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
