using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal patinhos;

            while (true)
            {
                patinhos = Convert.ToDecimal(Console.ReadLine());

                if (patinhos < 0)
                {
                    break;
                }

                if (patinhos == 0)
                {
                    Console.WriteLine(patinhos);
                }
                else
                {
                    Console.WriteLine(patinhos - 1);
                }
            }
        }
    }
}
