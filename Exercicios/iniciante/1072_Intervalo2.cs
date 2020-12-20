using System;
using System.Net.NetworkInformation;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int dentro = 0, fora = 0;

            int valor;

            for (int i = 0; i < n; i++)
            {
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}
