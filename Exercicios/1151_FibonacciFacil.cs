using System;

namespace FibonacciFacil
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;
            
            Console.Write(a + " " + b);

            for (int i = 0; i < n - 2; i++){
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            Console.WriteLine();
            
        }
    }
}