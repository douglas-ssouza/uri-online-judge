using System;

namespace SequenciaIJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 7;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = cont; j >= (cont - 2); j--)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
                cont += 2;
            }
        }
    }
}
