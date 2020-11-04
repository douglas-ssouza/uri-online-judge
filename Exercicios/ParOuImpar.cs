using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int valor;

            for (int i = 0; i < n; i++)
            {
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (valor % 2 == 0)
                {
                    if (valor > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (valor > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
