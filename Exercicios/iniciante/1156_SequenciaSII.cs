using System;

namespace SequenciaSII
{
    class Program
    {
        static void Main(string[] args){
            double s = 1;
            double j = 2;

            for (int i = 3; i <= 39; i += 2){
                s += i / j;
                j *= 2;
            }

            Console.WriteLine("{0}", s.ToString("0.00"));

        }
    }
}