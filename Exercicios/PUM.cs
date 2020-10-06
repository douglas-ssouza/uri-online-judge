using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int j = 1;

            for (int i = 1; i <= n*4; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("PUM");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
