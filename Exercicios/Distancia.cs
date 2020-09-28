using System;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;

            minutos = Convert.ToInt32(Console.ReadLine());
            minutos *= 2;

            Console.WriteLine(minutos + " minutos");
        }
    }
}
