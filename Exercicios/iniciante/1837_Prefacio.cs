using System;

namespace Prefacio
{
    class Program
    {
        static void Main(string[] args){

            string[] linha = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(linha[0]);
            int b = Convert.ToInt32(linha[1]);
            int q = a / b;
            int r = a % b;

            Console.WriteLine(q + " " + r);

        }
    }
}