using System;

namespace AsAbasDePericles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] linha = Console.ReadLine().Split(' ');

            int abas = Convert.ToInt32(linha[0]);
            int acoes = Convert.ToInt32(linha[1]);
            string acao;

            for (int i = 0; i < acoes; i++)
            {
                acao = Console.ReadLine();

                if (acao.Equals("fechou"))
                {
                    abas++;
                }
                else
                {
                    abas--;
                }
            }

            Console.WriteLine(abas);

        }
    }
}
