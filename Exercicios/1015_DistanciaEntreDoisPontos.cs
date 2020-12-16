using System;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha1, linha2;
            double x1, x2, y1, y2, distancia;

            linha1 = Console.ReadLine();
            string[] vetor1 = linha1.Split(' ');
            x1 = Convert.ToDouble(vetor1[0]);
            y1 = Convert.ToDouble(vetor1[1]);

            linha2 = Console.ReadLine();
            string[] vetor2 = linha2.Split(' ');
            x2 = Convert.ToDouble(vetor2[0]);
            y2 = Convert.ToDouble(vetor2[1]);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("{0}", distancia.ToString("0.0000"));

        }
    }
}
