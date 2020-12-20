using System;

namespace SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            string[] valores = linha.Split(' ');

            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            int c = Convert.ToInt32(valores[2]);

            if (a < b && a < c)
            {
                Console.WriteLine(a);
                if (b < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }else if(b < a && b < c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }else if (c < a && c < b)
            {
                Console.WriteLine(c);
                if (a < b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine("\n" + a + "\n" + b + "\n" + c);
            
        }
    }
}
