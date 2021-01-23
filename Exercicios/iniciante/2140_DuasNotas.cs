using System;

namespace DuasNotas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] linha;
            int total, pago, troco;
            bool possible;

            int[] possibilidades = new int[] { 4, 7, 10, 12, 15, 20, 22, 25, 30, 40, 52, 55, 60, 70, 100, 102, 105, 110, 120, 150, 200 };

            while (true)
            {
                linha = Console.ReadLine().Split(' ');
                total = Convert.ToInt32(linha[0]);
                pago = Convert.ToInt32(linha[1]);

                if (total == 0 && pago == 0)
                {
                    break;
                }

                possible = false;
                troco = pago - total;

                for (int i = 0; i < 21; i++)
                {
                    if (troco == possibilidades[i])
                    {
                        possible = true;
                        break;
                    }
                }

                if (possible)
                {
                    Console.WriteLine("possible");
                }
                else
                {
                    Console.WriteLine("impossible");
                }

            }
        }
    }
}
