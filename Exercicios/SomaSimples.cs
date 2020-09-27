using System;

namespace SomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            soma = a + b;

            Console.WriteLine("SOMA = " + soma);

        }
    }
}