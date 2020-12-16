using System;

namespace SeisNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                x++;
            }

            Console.WriteLine(x);

            for (int i = 0; i < 5; i++)
            {
                x = x + 2;
                Console.WriteLine(x);
            }
        }
    }
}
