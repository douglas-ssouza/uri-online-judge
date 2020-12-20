using System;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist;
            double gas, total;

            dist = Convert.ToInt32(Console.ReadLine());
            gas = Convert.ToDouble(Console.ReadLine());

            total = dist / gas;

            Console.WriteLine("{0} km/l", total.ToString("0.000"));
        }
    }
}
