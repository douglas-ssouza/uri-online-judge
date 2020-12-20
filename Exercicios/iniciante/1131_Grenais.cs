using System;

namespace Grenal
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter = 0, gremio = 0, empate = 0;
            int denovo, total = 0;
            int golsInter, golsGremio;

            do{
                string linha = Console.ReadLine();
                string[] jogo = linha.Split(' ');

                golsInter = Convert.ToInt32(jogo[0]);
                golsGremio = Convert.ToInt32(jogo[1]);

                total++;

                if (golsInter > golsGremio)
                {
                    inter++;
                }
                else if (golsInter < golsGremio)
                {
                    gremio++;
                }
                else
                {
                    empate++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                denovo = Convert.ToInt32(Console.ReadLine());

            }while(denovo != 2);

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);
            
            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (inter < gremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}