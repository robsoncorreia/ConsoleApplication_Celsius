using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = -459.68f;
            double c;

            while (f < -459.67f || f > 1000f)
            {
                Console.WriteLine("Digite o valor em Fahrenheit:");
                f = double.Parse(Console.ReadLine());

                if (f < -459.67f || f > 1000f)
                {
                    Console.WriteLine("Valor invalido.");
                }
            }
            c = (f - 32f) / 1.8f;

            Console.WriteLine("{0:F2} Fahrenheit em Celsius é {1:F2}.", f, c);

            Console.ReadKey();
        }
    }
}
