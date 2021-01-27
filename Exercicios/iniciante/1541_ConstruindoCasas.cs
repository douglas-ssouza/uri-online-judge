using System;

namespace ConstruindoCasas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] linha;
            int ladoA, ladoB, porc, areaCasa, areaTerreno, ladoTerr;

            while (true)
            {
                linha = Console.ReadLine().Split(' ');
                if (linha[0].Equals("0"))
                {
                    break;
                }

                ladoA = Convert.ToInt32(linha[0]);
                ladoB = Convert.ToInt32(linha[1]);
                porc = Convert.ToInt32(linha[2]);

                areaCasa = ladoA * ladoB;
                areaTerreno = areaCasa * 100 / porc;

                ladoTerr = (int)Math.Sqrt(areaTerreno);

                Console.WriteLine(ladoTerr);

            }


        }
    }
}
