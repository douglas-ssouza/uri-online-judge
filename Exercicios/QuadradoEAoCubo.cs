using System;

namespace QuadradoEAocubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = Convert.ToInt32(Console.ReadLine());
            int quadrado, cubo;

            for (int i = 1; i <= linhas; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
            }
        }
    }
}