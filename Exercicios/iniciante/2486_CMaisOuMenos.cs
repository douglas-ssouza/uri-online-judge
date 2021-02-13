using System;

namespace CMaisOuMenos
{
    class Program
    {
        static void Main(string[] args)
        {
            string alimento;
            int casos, quantidade, total, diferenca;

            while (true)
            {
                casos = Convert.ToInt32(Console.ReadLine());
                if (casos == 0)
                {
                    break;
                }

                total = 0;

                for (int i = 0; i < casos; i++)
                {
                    string[] caso = Console.ReadLine().Split(' ');
                    quantidade = Convert.ToInt32(caso[0]);
                    alimento = caso[1];

                    switch (alimento)
                    {
                        case "suco":
                            total += (quantidade * 120);
                            break;
                        case "morango":
                            total += (quantidade * 85);
                            break;
                        case "mamao":
                            total += (quantidade * 85);
                            break;
                        case "goiaba":
                            total += (quantidade * 70);
                            break;
                        case "manga":
                            total += (quantidade * 56);
                            break;
                        case "laranja":
                            total += (quantidade * 50);
                            break;
                        case "brocolis":
                            total += (quantidade * 34);
                            break;
                    }

                }

                if (total < 110)
                {
                    diferenca = 110 - total;
                    Console.WriteLine("Mais " + diferenca + " mg");
                }
                else if (total > 130)
                {
                    diferenca = total - 130;
                    Console.WriteLine("Menos " + diferenca + " mg");
                }
                else
                {
                    Console.WriteLine(total + " mg");
                }
            }
        }
    }
}
