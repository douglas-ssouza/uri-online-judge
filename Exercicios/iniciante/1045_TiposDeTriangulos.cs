using System;

namespace TiposDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] lados = linha.Split(' ');

            double lado1 = Convert.ToDouble(lados[0]);
            double lado2 = Convert.ToDouble(lados[1]);
            double lado3 = Convert.ToDouble(lados[2]);
            double a = lado1, b = lado2, c = lado3;

            if (lado1 > lado2 && lado1 > lado3)
            {
                a = lado1;
                if (lado2 > lado3)
                {
                    b = lado2;
                    c = lado3;
                }
                else
                {
                    b = lado3;
                    c = lado2;
                }
            }else if (lado2 > lado1 && lado2 > lado3)
            {
                a = lado2;
                if (lado1 > lado3)
                {
                    b = lado1;
                    c = lado3;
                }
                else
                {
                    b = lado3;
                    c = lado1;
                }
            }else if (lado3 > lado1 && lado3 > lado2)
            {
                a = lado3;
                if (lado1 > lado2)
                {
                    b = lado1;
                    c = lado2;
                }
                else
                {
                    b = lado2;
                    c = lado1;
                }
            }
            
            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
