using System;

namespace SequenciaDeNumerosESoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int soma;

            do
            {
                string linha = Console.ReadLine();
                string[] valores = linha.Split(' ');
                m = Convert.ToInt32(valores[0]);
                n = Convert.ToInt32(valores[1]);

                if (m > 0 && n > 0)
                {
                    soma = 0;

                    if (m < n)
                    {
                        for (int i = m; i <= n; i++)
                        {
                            Console.Write(i + " ");
                            soma += i;
                        }
                        Console.WriteLine("Sum=" + soma);
                    }
                    else if (m > n)
                    {
                        for (int i = n; i <= m; i++)
                        {
                            Console.Write(i + " ");
                            soma += i;
                        }
                        Console.WriteLine("Sum=" + soma);
                    }
                    else
                    {
                        Console.Write(m + " Sum=" + n);
                    }
                }

            } while (m > 0 && n > 0);
        }
    }
}
