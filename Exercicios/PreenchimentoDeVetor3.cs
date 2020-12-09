using System;

namespace PreenchimentoDeVetor3
{
    class Program
    {
        static void Main(string[] args){

            decimal[] n;
            n = new decimal[100];

            decimal x = System.Convert.ToDecimal(Console.ReadLine());

            for (int i = 0; i < 100; i++){
                n[i] = x;
                x /= 2;
            }

            for (int i = 0; i < 100; i++){
                Console.WriteLine("N[" + i + "] = {0}", n[i].ToString("0.0000"));
            }

        }
    }
}