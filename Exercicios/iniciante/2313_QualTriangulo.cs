using System;

namespace QualTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração e leitura dos lados
            int a, b, c;
            string[] lados = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(lados[0]);
            b = Convert.ToInt32(lados[1]);
            c = Convert.ToInt32(lados[2]);

            // Verifica se os lados informados podem formar um triangulo
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                // Verifica qual o tipo de triangulo formado
                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Valido-Equilatero");
                }
                else if ((a != b && a != c && c != b))
                {
                    Console.WriteLine("Valido-Escaleno");
                }
                else
                {
                    Console.WriteLine("Valido-Isoceles");
                }

                // Verifica, através da hipotenusa, se o triangulo é retangulo ou não
                if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                {
                    Console.WriteLine("Retangulo: S");
                }
                else
                {
                    Console.WriteLine("Retangulo: N");
                }
            }
            else
            {
                Console.WriteLine("Invalido");
            }

            
        }
    }
}
