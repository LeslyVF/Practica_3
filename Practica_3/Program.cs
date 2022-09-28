using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosLados;
            double tamanoLado, perimetro;

            Console.WriteLine("Dame el numero de lados");
            numerosLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la medida de uno de los lados");
            tamanoLado = Convert.ToDouble(Console.ReadLine());

            perimetro = numerosLados * tamanoLado;

            Console.WriteLine("El perimetro es : {0}", perimetro);
        }
    }
}
