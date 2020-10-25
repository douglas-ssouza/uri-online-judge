using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');
            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
