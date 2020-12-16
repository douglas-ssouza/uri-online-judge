using System;

namespace FormulaDeBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            double raiz1, raiz2;

            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');

            a = Convert.ToDouble(valores[0]);
            b = Convert.ToDouble(valores[1]);
            c = Convert.ToDouble(valores[2]);

            delta = Math.Pow(b, 2) - (4 * a * c);

            raiz1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
            raiz2 = (-(b) - Math.Sqrt(delta)) / (2 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = {0}", raiz1.ToString("0.00000"));
                Console.WriteLine("R2 = {0}", raiz2.ToString("0.00000"));
            }

        }
    }
}
