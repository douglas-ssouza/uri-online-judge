using System;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args){
            double s = 0;

            for(double i = 1; i <= 100; i++){
                s += 1 / i;
            }

            Console.WriteLine("{0}", s.ToString("0.00"));
        }
    }
}