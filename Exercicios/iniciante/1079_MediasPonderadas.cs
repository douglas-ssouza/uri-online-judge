using System;

namespace MediasPonderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string linha;
            string[] valores;
            double nota1, nota2, nota3, media;

            for (int i = 0; i < n; i++)
            {
                linha = Console.ReadLine();
                valores = linha.Split(' ');
                nota1 = Convert.ToDouble(valores[0]);
                nota2 = Convert.ToDouble(valores[1]);
                nota3 = Convert.ToDouble(valores[2]);
                media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;
                Console.WriteLine("{0}", media.ToString("0.0"));
            }
        }
    }
}
