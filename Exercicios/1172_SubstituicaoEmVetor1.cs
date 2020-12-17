using System;

namespace SubstituicaoEmVetor1
{
    class Program
    {
        static void Main(string[] args){
            
            int[] x;
            x = new int[10];

            for (int i = 0; i < 10; i++){
                x[i] = Convert.ToInt32(Console.ReadLine());
                
                if (x[i] <= 0){
                    x[i] = 1;
                }
            }

            for (int i = 0; i < 10; i++){
                Console.WriteLine("X[" + i + "] = " + x[i]);
            }
        }
    }
}