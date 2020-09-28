using System;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio;

            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = {0}", volume.ToString("0.000"));
        }
    }
}
