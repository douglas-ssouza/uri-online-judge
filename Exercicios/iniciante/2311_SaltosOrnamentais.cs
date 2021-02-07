using System;

namespace SaltosOrnamentais
{
    class Program
    {
        static void Main(string[] args)
        {
            int saltos = Convert.ToInt32(Console.ReadLine());

            double dificuldade, resultado, maior, menor;
            double[] notas = new double[7];
            string[] nomes = new string[saltos];

            for (int salto = 0; salto < saltos; salto++)
            {
                nomes[salto] = Console.ReadLine();
                dificuldade = Convert.ToDouble(Console.ReadLine());
                string[] linha = Console.ReadLine().Split(' ');
                notas[0] = Convert.ToDouble(linha[0]);
                maior = notas[0];
                menor = notas[0];
                resultado = notas[0];
                for (int i = 1; i < 7; i++)
                {
                    notas[i] = Convert.ToDouble(linha[i]);
                    resultado += notas[i];
                    if (notas[i] > maior)
                    {
                        maior = notas[i];
                    }
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                    }
                }
                resultado = (resultado - maior - menor) * dificuldade;

                Console.WriteLine(nomes[salto] + " {0}", resultado.ToString("0.00"));

            }
        }
    }
}