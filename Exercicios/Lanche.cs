using System;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] num = linha.Split(' ');

            int cod = Convert.ToInt32(num[0]);
            int quant = Convert.ToInt32(num[1]);

            double preco = 0;

            switch (cod)
            {
                case 1:
                    preco = quant * 4.0;
                    break;
                case 2:
                    preco = quant * 4.5;
                    break;
                case 3:
                    preco = quant * 5.0;
                    break;
                case 4:
                    preco = quant * 2.0;
                    break;
                case 5:
                    preco = quant * 1.5;
                    break;
            }

            Console.WriteLine("Total: R$ {0}", preco.ToString("0.00"));
        }
    }
}
