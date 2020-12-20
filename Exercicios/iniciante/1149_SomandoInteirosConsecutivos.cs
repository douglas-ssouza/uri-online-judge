using System;

namespace SomandoInteirosConsecutivos
{
    class Program
    {
        static void Main(string[] args){

            int a, n, soma = 0;

            string[] valores = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(valores[0]);
            n = Convert.ToInt32(valores[1]);

            int pos = 1;

            while (n <= 0)
            {
                pos++;
                n = Convert.ToInt32(valores[pos]);
            }

            for (int i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);

        }
    }
}