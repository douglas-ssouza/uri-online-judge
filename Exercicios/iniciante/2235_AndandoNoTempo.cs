using System;

namespace AndandoNoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            char possivel;
            
            // Armazena o valor dos créditos em um array string
            string[] creditos = Console.ReadLine().Split(' ');

            // Converte os valores em int e armazena em variáveis simples
            int a = Convert.ToInt32(creditos[0]);
            int b = Convert.ToInt32(creditos[1]);
            int c = Convert.ToInt32(creditos[2]);

            if (a == 0 || b == 0 || c == 0)
            {
                possivel = 'S';
            }
            else if (a == b || b == c || c == a)
            {
                possivel = 'S';
            }
            else if (a + b == c || b + c == a || a + c == b)
            {
                possivel = 'S';
            }
            else if (a - b == Math.Abs(c) || b - c == Math.Abs(a) || a - c == Math.Abs(b))
            {
                possivel = 'S';
            }
            else
            {
                possivel = 'N';
            }

            Console.WriteLine(possivel);
        }
    }
}
