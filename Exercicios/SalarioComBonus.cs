using System;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            double fixo, vendas, total;

            fixo = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());
            total = fixo + (vendas * 0.15);

            Console.WriteLine("TOTAL = " + Math.Round(total, 2));
        }
    }
}