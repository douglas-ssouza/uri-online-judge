using System;
using System.Security.Cryptography.X509Certificates;

namespace CoordenadasDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            string[] valores = linha.Split(' ');
            double x = Convert.ToDouble(valores[0]);
            double y = Convert.ToDouble(valores[1]);


            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (y < 0)
                {
                    Console.WriteLine("Q4");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (y < 0)
                {
                    Console.WriteLine("Q3");
                }
            }
        }
    }
}