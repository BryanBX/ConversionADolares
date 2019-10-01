using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesosADolares
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pesos, Dolares, conversion;

            Console.WriteLine("Escriba valor en pesos");
            Pesos = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba valor del dolar");
            Dolares = double.Parse(Console.ReadLine());
            conversion = Pesos * Dolares;
            Console.WriteLine("El valor de {0} RD$ convertido en dolares es {1}", Pesos, conversion);
            Console.ReadKey();
        }
    }
}
