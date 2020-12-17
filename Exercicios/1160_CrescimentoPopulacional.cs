using System;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args){

            long t = Convert.ToInt32(Console.ReadLine());
            long pa, pb;
            float g1, g2;
            int anos = 0;

            for (int i = 0; i < t; i++){
                string linha = Console.ReadLine();
                string[] valores = linha.Split(' ');
                pa = long.Parse(valores[0]);
                pb = long.Parse(valores[1]);
                g1 = float.Parse(valores[2]);
                g2 = float.Parse(valores[3]);

                while (pa < pb){
                    pa = long.Parse(pa + (pa * g1));
                    pb = long.Parse(pb + (pb * g2));
                    anos++;

                    if (pa > pb){
                        Console.WriteLine(ano + " anos.");
                    }

                    if (anos > 100){
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

            }

        }
    }
}