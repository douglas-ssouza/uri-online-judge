using System;

namespace PositivosEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            notas = new double[6];
            double total = 0;
            int quant = 0;
            int pos = 0;

            for (int i = 0; i < 6; i++)
            {
                notas[i] = Convert.ToDouble(Console.ReadLine());
                if (notas[i] >= 0)
                {
                    total += notas[i];
                    pos++;
                    quant++;
                }
            }

            double media = total / quant;

            Console.WriteLine(pos + " valores positivos");
            Console.WriteLine("{0}", media.ToString("0.0"));

        }
    }
}
