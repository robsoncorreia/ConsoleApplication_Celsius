using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento = 2016;
            float altura = -1;
            float peso = -1;
            float imc;
            string text = string.Empty;

            while ((2016 - anoNascimento) < 20)
            {
                Console.WriteLine("Digite ano de nascimento:");
                anoNascimento = int.Parse(Console.ReadLine());

                if ((2016 - anoNascimento) < 20)
                {
                    Console.WriteLine("Valor invalido.");
                }
            }

            while (altura < 1.22f || altura > 2.51f)
            {
                Console.WriteLine("Digite sua altura:");
                altura = float.Parse(Console.ReadLine());

                if (altura < 1.22f || altura > 2.51f)
                {
                    Console.WriteLine("Altura invalida.");
                }
            }

            while (peso < 25f || peso > 634f)
            {
                Console.WriteLine("Digite seu peso:");
                peso = float.Parse(Console.ReadLine());

                if (peso < 25f || peso > 634f)
                {
                    Console.WriteLine("Peso invalida.");
                }
            }

            imc = peso / (altura * altura);

            if (imc >= 40f)
            {
                text = "Obesidade III (mórbida)";
            }
            else if (imc >= 35f && imc <= 39.99f)
            {
                text = "Obesidade II (severa)";
            }
            else if (imc >= 30f && imc <= 34.99f)
            {
                text = "Obesidade I";
            }
            else if (imc >= 25f && imc <= 29.99f)
            {
                text = "Acima do peso";
            }
            else if (imc >= 18.5f && imc <= 24.99f)
            {
                text = "Peso normal";
            }
            else if (imc >= 17f && imc <= 18.49f)
            {
                text = "Abaixo do peso";
            }
            else
            {
                text = "Muito abaixo do peso";
            }

            Console.WriteLine("Seu IMC é {0:F2} \n{1}", imc, text);

            Console.ReadKey();
        }
    }
}
