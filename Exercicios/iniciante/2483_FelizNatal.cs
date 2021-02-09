using System;

namespace FelizNatal
{
    class Program
    {
        static void Main(string[] args)
        {
            string grito = "Feliz nat";
            int indice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < indice; i++)
            {
                grito += 'a';
            }

            grito += "l!";

            Console.WriteLine(grito);
        }
    }
}
