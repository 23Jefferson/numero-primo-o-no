using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número Primo");
            Console.WriteLine("==========================");

            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }

        static bool EsPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}