using System;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args){

            int n100, n50, n20, n10, n5, n2, notas;
            double m1, m50, m25, m10, m05, m01, moedas, n;
            
            n = Convert.ToDouble(Console.ReadLine());
            
            notas = (int)n;
            moedas = (n - notas) * 100;

            if ((moedas * 1000) % 10 == 9)
            {
                moedas++;
            }


            n100 = notas / 100;
            notas = notas % 100;
            n50 = notas / 50;
            notas = notas % 50;
            n20 = notas / 20;
            notas = notas % 20;
            n10 = notas / 10;
            notas = notas % 10;
            n5 = notas / 5;
            notas = notas % 5;
            n2 = notas / 2;
            notas = notas % 2;

            m1 = notas / 1;
            notas = notas % 1;
            m50 = (int)moedas / 50;
            moedas = (int)moedas % 50;
            m25 = (int)moedas / 25;
            moedas = (int)moedas % 25;
            m10 = (int)moedas / 10;
            moedas = (int)moedas % 10;
            m05 = (int)moedas / 5;
            moedas = (int)moedas % 5;
            m01 = (int)moedas / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m01 + " moeda(s) de R$ 0.01");

        }
    }
}