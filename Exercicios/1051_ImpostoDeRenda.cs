using System;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = Convert.ToDouble(Console.ReadLine());
            double imposto = 0;

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine("R$ {0}", imposto.ToString("0.00"));
            }
            else if (salario <= 4500)
            {
                imposto = 80 + (salario - 3000) * 0.18;
                Console.WriteLine("R$ {0}", imposto.ToString("0.00"));
            }
            else
            {
                imposto = 350 + (salario - 4500) * 0.28;
                Console.WriteLine("R$ {0}", imposto.ToString("0.00"));
            }
        }
    }
}
