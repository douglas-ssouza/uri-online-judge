using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] lados = linha.Split(' ');

            double a = Convert.ToDouble(lados[0]);
            double b = Convert.ToDouble(lados[1]);
            double c = Convert.ToDouble(lados[2]);

            double perimetro, area;

            if ((a + b > c) && (a + c > b) && (c + b > a))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0}", perimetro.ToString("0.0"));
            }
            else
            {
                area = ((a + b) / 2) * c;
                Console.WriteLine("Area = {0}", area.ToString("0.0"));
            }
        }
    }
}
