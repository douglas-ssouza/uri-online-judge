using System;

namespace NumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores;
            valores = new double[6];
            int quant = 0;

            for (int i = 0; i < 6; i++)
            {
                valores[i] = Convert.ToDouble(Console.ReadLine());
                if (valores[i] >= 0)
                {
                    quant++;
                }
            }

            Console.WriteLine(quant + " valores positivos");
        }
    }
}
