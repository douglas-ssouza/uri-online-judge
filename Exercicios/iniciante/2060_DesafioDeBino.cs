using System;

namespace DesafioDeBino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m2 = 0, m3 = 0, m4 = 0, m5 = 0, valor;
            string[] linha;

            n = Convert.ToInt32(Console.ReadLine());
            linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                valor = Convert.ToInt32(linha[i]);

                if (valor % 2 == 0)
                {
                    m2++;
                }

                if (valor % 3 == 0)
                {
                    m3++;
                }

                if (valor % 4 == 0)
                {
                    m4++;
                }

                if (valor % 5 == 0)
                {
                    m5++;
                }
            }

            Console.WriteLine(m2 + " Multiplo(s) de 2");
            Console.WriteLine(m3 + " Multiplo(s) de 3");
            Console.WriteLine(m4 + " Multiplo(s) de 4");
            Console.WriteLine(m5 + " Multiplo(s) de 5");
        }
    }
}
