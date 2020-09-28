using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double horas, valor, sal;

            num = Convert.ToInt32(Console.ReadLine());
            horas = Convert.ToDouble(Console.ReadLine());
            valor = Convert.ToDouble(Console.ReadLine());

            sal = horas * valor;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ {0}", sal.ToString("0.00"));
        }
    }
}