using System;

namespace ImparParOuRoubo
{
    class Program
    {
        static void Main(string[] args)
        {

            int p, j1, j2, total, r, a;
            string[] linha = Console.ReadLine().Split(' ');

            p = Convert.ToInt32(linha[0]);
            j1 = Convert.ToInt32(linha[1]);
            j2 = Convert.ToInt32(linha[2]);
            r = Convert.ToInt32(linha[3]);
            a = Convert.ToInt32(linha[4]);

            total = j1 + j2;

            if (r == 1)
            {
                if (a == 1)
                {
                    Console.WriteLine("Jogador 2 ganha!");
                }
                else
                {
                    Console.WriteLine("Jogador 1 ganha!");
                }
            }
            else
            {
                if (a == 1)
                {
                    Console.WriteLine("Jogador 1 ganha!");
                }
                else
                {
                    if (p == 1)
                    {
                        if (total % 2 == 0)
                        {
                            Console.WriteLine("Jogador 1 ganha!");
                        }
                        else
                        {
                            Console.WriteLine("Jogador 2 ganha!");
                        }
                    }
                    else
                    {
                        if (total % 2 != 0)
                        {
                            Console.WriteLine("Jogador 1 ganha!");
                        }
                        else
                        {
                            Console.WriteLine("jogador 2 ganha!");
                        }
                    }
                }
            }

        }
    }
}