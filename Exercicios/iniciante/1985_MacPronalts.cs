using System;

namespace MacPronalts
{
    class Program
    {
        static void Main(string[] args){

            int produtos = Convert.ToInt32(Console.ReadLine());
            double total = 0;
            int codigo, quant;

            for (int produto = 0; produto < produtos; produto++){

                string[] linha = Console.ReadLine().Split(' ');
                codigo = Convert.ToInt32(linha[0]);
                quant = Convert.ToInt32(linha[1]);

                switch(codigo){
                    case 1001: total += 1.5 * quant; break;
                    case 1002: total += 2.5 * quant; break;
                    case 1003: total += 3.5 * quant; break;
                    case 1004: total += 4.5 * quant; break;
                    case 1005: total += 5.5 * quant; break;
                }

            }

            Console.WriteLine("{0}", total.ToString("0.00"));

        }
    }
}