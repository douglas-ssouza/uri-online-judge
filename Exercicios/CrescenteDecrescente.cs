using System;
using System.Security.Cryptography.X509Certificates;

namespace CrescenteDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            do
            {
                string linha = Console.ReadLine();
                string[] valores = linha.Split(' ');
                x = Convert.ToInt32(valores[0]);
                y = Convert.ToInt32(valores[1]);
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }else if(x < y)
                {
                    Console.WriteLine("Crescente");
                }
            } while (x != y);
        }
    }
}
