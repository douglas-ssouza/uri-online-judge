using System;

namespace ParesEntreCincoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores;
            valores = new int[5];
            int pares = 0;

            for (int i = 0; i < 5; i++)
            {
                valores[i] = Convert.ToInt32(Console.ReadLine());
                if (valores[i] % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine(pares + " valores pares");

        }
    }
}
