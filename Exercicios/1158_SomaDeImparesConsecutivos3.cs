using System;

namespace SomaDeImparesConsecutivos3
{
    class Program
    {
        static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++){
                string linha = Console.ReadLine();
                string[] valores = linha.Split(' ');
                int inicio = Convert.ToInt32(valores[0]);
                int quantidade = Convert.ToInt32(valores[1]);
                int total = 0;

                if (inicio % 2 == 0) inicio++;

                for (int j = 0; j < quantidade; j++){
                    total += inicio;
                    inicio += 2;
                }

                Console.WriteLine(total);
            }

        }
    }
}