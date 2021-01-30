using System;

namespace Tuitando
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();

            if (texto.Length <= 140)
            {
                Console.WriteLine("TWEET");
            }
            else
            {
                Console.WriteLine("MUTE");
            }
        }
    }
}
