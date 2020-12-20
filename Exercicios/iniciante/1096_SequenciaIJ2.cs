using System;

namespace SequenciaIJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                Console.WriteLine("I=" + i + " J=7");
                Console.WriteLine("I=" + i + " J=6");
                Console.WriteLine("I=" + i + " J=5");
            }
        }
    }
}