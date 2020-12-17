using System;

namespace LinhaNaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = Convert.ToInt32(Console.ReadLine());
            string t = Console.ReadLine();
            double[,] matriz;
            matriz = new double[12, 12];
            double soma = 0, media;
            int quant = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            for (int i = linha; i <= linha; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma += matriz[i, j];
                    quant++;
                }
            }

            if (t == "S")
            {
                Console.WriteLine("{0}", soma.ToString("0.0"));
            }
            else if(t == "M")
            {
                media = soma / quant;
                Console.WriteLine("{0}", media.ToString("0.0"));
            }
        }
    }
}
