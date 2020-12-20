using System;

namespace ParesImparesPositivosNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0, impares = 0, pos = 0, neg = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num%2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (num > 0)
                {
                    pos++;
                }
                else if (num < 0)
                {
                    neg++;
                }
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");

        }
    }
}
