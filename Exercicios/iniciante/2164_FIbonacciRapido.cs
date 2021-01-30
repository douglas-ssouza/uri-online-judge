using System;

namespace FibonacciRapido
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double fib = Math.Round((Math.Pow(((1 + Math.Sqrt(5)) / 2), n) - Math.Pow(((1 - Math.Sqrt(5)) / 2), n)) / Math.Sqrt(5));

            Console.WriteLine("{0}", fib.ToString("0.0"));

        }
    }
}
