using System;

namespace SelecaoEmVetor1
{
    class Program
    {
        static void Main(string[] args){

            double[] A;
            A = new double[100];

            for (int i = 0; i < 100; i++){
                A[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 100; i++){
                if (A[i] <= 10){
                    Console.WriteLine("A[" + i + "] = {0}", A[i].ToString("0.0"));
                }
            }

        }
    }
}