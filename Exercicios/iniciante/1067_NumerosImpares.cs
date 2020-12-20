using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}