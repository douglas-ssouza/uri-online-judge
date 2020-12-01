using System;

namespace FatorialSimples
{
    class Program
    {
        static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n - 1; i > 0; i--){
                n *= i;
            }

            Console.WriteLine(n);
        }
    }
}