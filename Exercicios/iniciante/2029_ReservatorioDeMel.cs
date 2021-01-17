using System;

namespace ReservatorioDeMel
{
    class Program
    {
        static void Main(string[] args){

            while (true)
            {
                double volume, diametro, area, altura;
                
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                volume = Convert.ToDouble(input);
                diametro = Convert.ToDouble(Console.ReadLine());

                area = 3.14 * Math.Pow((diametro / 2), 2);
                altura = volume / area;

                Console.WriteLine("ALTURA = {0}", altura.ToString("0.00"));
                Console.WriteLine("AREA = {0}", area.ToString("0.00"));

            }

        }
    }
}