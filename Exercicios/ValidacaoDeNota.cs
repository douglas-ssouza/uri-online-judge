using System;

namespace ValidacaoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            do
            {
                nota1 = Convert.ToDouble(Console.ReadLine());

                if (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                }

            } while (nota1 < 0 || nota1 > 10);

            do
            {
                nota2 = Convert.ToDouble(Console.ReadLine());

                if (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                }

            } while (nota2 < 0 || nota2 > 10);

            media = (nota1 + nota2) / 2;

            Console.WriteLine("media = {0}", media.ToString("0.00"));
        }
    }
}
