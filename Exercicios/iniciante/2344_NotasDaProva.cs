using System;

namespace NotasDaProva
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 86)
            {
                Console.WriteLine("A");
            }
            else if (nota >= 61)
            {
                Console.WriteLine("B");
            }
            else if (nota >= 36)
            {
                Console.WriteLine("C");
            }
            else if (nota >= 1)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
        }
    }
}
