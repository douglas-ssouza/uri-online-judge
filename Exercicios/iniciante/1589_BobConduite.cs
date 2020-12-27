using System;

namespace BobConduite
{
    class program
    {
        static void Main(string[] args){

            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++){

                string[] linha = Console.ReadLine().Split(' ');
                int r1 = Convert.ToInt32(linha[0]);
                int r2 = Convert.ToInt32(linha[1]);

                int menor = r1 + r2;

                Console.WriteLine(menor);

            }

        }
    }
}