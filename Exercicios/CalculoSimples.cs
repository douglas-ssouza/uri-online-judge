using System;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double valor1, valor2, total;
            
            Console.ReadLine();
            num1 = Convert.ToInt32(Console.ReadLine());
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();
            num2 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToDouble(Console.ReadLine());

            total = ((num1 * valor1) + (num2 * valor2));

            Console.WriteLine("Valor a pagar: R$ " + Math.Round(total, 2));
        }
    }
}