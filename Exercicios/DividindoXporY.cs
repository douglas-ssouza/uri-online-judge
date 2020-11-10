using System;

namespace DividindoXporY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int x, y;
            double res;

            for (int i = 0; i < n; i++)
            {
                string linha = Console.ReadLine();
                string[] valores = linha.Split(' ');
                x = Convert.ToInt32(valores[0]);
                y = Convert.ToInt32(valores[1]);

                if (y != 0)
                {
                    res = (double) x / y;
                    Console.WriteLine("{0}", res.ToString("0.0"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
