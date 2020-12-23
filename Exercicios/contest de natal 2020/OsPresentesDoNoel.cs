using System;

namespace OsPresentesDoNoel
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());
            string[] linha = Console.ReadLine().Split(' ');
            int[] g;
            g = new int[n];

            for (int i = 0; i < n; i++){
                g[i] = Convert.ToInt32(linha[i]);
            }
            

        }
    }
}