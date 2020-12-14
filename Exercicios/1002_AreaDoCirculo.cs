using System;

namespace AreaDoCiruclo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r;
            const double PI = 3.14159;

            r = Convert.ToDouble(Console.ReadLine());

            a = PI * Math.Pow(r, 2);

            Console.WriteLine("A={0}", a.ToString("0.0000"));
        }
    }
}