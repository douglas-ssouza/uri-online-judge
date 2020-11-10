using System;

namespace Quadrante
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

                if(x != 0 && y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }

            } while (x != 0 && y != 0);
        }
    }
}
