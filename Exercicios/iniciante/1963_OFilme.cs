using System;

namespace OFilme
{
    class Program
    {
        static void Main(string[] args){

            string[] linha = Console.ReadLine().Split(' ');
            double preco1 = Convert.ToDouble(linha[0]);
            double preco2 = Convert.ToDouble(linha[1]);

            double dif, pct;

            dif = preco2 - preco1;
            pct = (dif * 100) / preco1;

            Console.WriteLine("{0}%", pct.ToString("0.00"));

        }
    }
}