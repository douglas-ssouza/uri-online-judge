using System;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args){

            int t = Convert.ToInt32(Console.ReadLine());

            int pa, pb, anos = 0;
            double g1, g2;

            for (int i = 0; i < t; i++){

                string[] valores = Console.ReadLine().Split(' ');
                pa = Convert.ToInt32(valores[0]);
                pb = Convert.ToInt32(valores[1]);
                g1 = Convert.ToDouble(valores[2]);
                g2 = Convert.ToDouble(valores[3]);

                while (pa <= pb && anos <= 100){

                    pa += (int) ((pa * g1) / 100);
                    pb += (int) ((pa * g2) / 100);

                    anos++;

                }

                if (anos > 100){
                    Console.WriteLine("Mais de 1 seculo.");
                }else{
                    Console.WriteLine(anos + " anos.");
                } 

                anos = 0;

            }

        }
    }
}