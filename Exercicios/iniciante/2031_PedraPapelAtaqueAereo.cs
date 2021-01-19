using System;

namespace PedraPapelAtaqueAereo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string jogador1, jogador2;

            for (int i = 0; i < n; i++)
            {
                jogador1 = Console.ReadLine();
                jogador2 = Console.ReadLine();

                if (jogador1.Equals("papel"))
                {
                    if (jogador2.Equals("papel"))
                    {
                        Console.WriteLine("Ambos venceram");
                    }
                    else
                    {
                        Console.WriteLine("Jogador 2 venceu");
                    }
                }
                else if (jogador1.Equals("pedra"))
                {
                    if (jogador2.Equals("papel"))
                    {
                        Console.WriteLine("Jogador 1 venceu");
                    }
                    else if (jogador2.Equals("pedra"))
                    {
                        Console.WriteLine("Sem ganhador");
                    }
                    else
                    {
                        Console.WriteLine("Jogador 2 venceu");
                    }
                }
                else
                {
                    if (jogador2.Equals("papel") || jogador2.Equals("pedra"))
                    {
                        Console.WriteLine("Jogador 1 venceu");
                    }
                    else
                    {
                        Console.WriteLine("Aniquilacao mutua");
                    }
                }
            }
        }
    }
}
