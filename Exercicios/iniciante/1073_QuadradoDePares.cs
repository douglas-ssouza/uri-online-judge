using System;

namespace QuadradoDePares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int quadrado;

            for (int i = 2; i <= n; i += 2)
            {
                if (i % 2 == 0)
                {
                    quadrado = Convert.ToInt32(Math.Pow(i, 2));
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}
