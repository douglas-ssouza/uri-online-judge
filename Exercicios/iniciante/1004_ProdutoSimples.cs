using System;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, prod;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            prod = a * b;

            Console.WriteLine("PROD = " + prod);
        }
    }
}