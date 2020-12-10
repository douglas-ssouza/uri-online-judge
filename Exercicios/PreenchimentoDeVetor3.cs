using System;

namespace PreenchimentoDeVetor3
{
    class Program
    {
        static void Main(string[] args){

        float[] n;
        n = new float[100];

        float x = float.Parse(Console.ReadLine());

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