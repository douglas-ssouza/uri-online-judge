using System;

namespace MultiplosDe13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                if (x % 13 != 0)
                {
                    soma = x;
                }
            }

            Console.WriteLine(soma);
        }
    }
}