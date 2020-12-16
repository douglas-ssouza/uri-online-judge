using System;
using System.Xml.Schema;

namespace Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string linha;
            string[] dados;
            double cobaias = 0, coelhos = 0, ratos = 0, sapos = 0;
            double pctCoelhos, pctRatos, pctSapos;
            int numero;
            char animal;

            for (int i = 0; i < n; i++)
            {
                linha = Console.ReadLine();
                dados = linha.Split(' ');
                numero = Convert.ToInt32(dados[0]);
                animal = Convert.ToChar(dados[1]);
                cobaias += numero;

                if (animal == 'C')
                {
                    coelhos += numero;
                }
                else if (animal == 'R')
                {
                    ratos += numero;
                }
                else if (animal == 'S')
                {
                    sapos += numero;
                }
            }

            pctCoelhos = (coelhos * 100) / cobaias;
            pctRatos = (ratos * 100) / cobaias;
            pctSapos = (sapos * 100) / cobaias;

            Console.WriteLine("Total: " + cobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: {0} %", pctCoelhos.ToString("0.00"));
            Console.WriteLine("Percentual de ratos: {0} %", pctRatos.ToString("0.00"));
            Console.WriteLine("Percentual de sapos: {0} %", pctSapos.ToString("0.00"));

        }
    }
}
