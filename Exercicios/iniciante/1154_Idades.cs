using System;

namespace Idades
{
    class Program
    {
        static void Main(string[] args){
            int quantidade = 0;
            double total = 0;
            int idade = 0;

            while (idade >= 0){
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 0){
                    quantidade++;
                    total += idade;
                }
            }

            double media = total / quantidade;

            Console.WriteLine("{0}", media.ToString("0.00"));
        }
    }
}