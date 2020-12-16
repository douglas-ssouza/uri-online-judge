using System;

namespace SomaDeImparesConsecutivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            if ( x== y)
            {
                soma = 0;
            }
            else if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = x -1; i > y; i--)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }

            Console.WriteLine(soma);
        }
    }
}
