using System;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, vel;
            double litros;

            horas = Convert.ToInt32(Console.ReadLine());
            vel = Convert.ToInt32(Console.ReadLine());

            double dist = vel * horas;

            litros = dist / 12;

            Console.WriteLine("{0}", litros.ToString("0.000"));
        }
    }
}
