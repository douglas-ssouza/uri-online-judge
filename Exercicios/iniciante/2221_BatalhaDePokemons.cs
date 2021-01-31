using System;

namespace BatalhaDePokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            int batalhas = Convert.ToInt32(Console.ReadLine());
            int bonus, atkDab, defDab, nvlDab, atkGua, defGua, nvlGua, totDab, totGua;
            string[] dabriel;
            string[] guarte;

            for (int i = 0; i < batalhas; i++)
            {
                bonus = Convert.ToInt32(Console.ReadLine());
                dabriel = Console.ReadLine().Split(' ');
                guarte = Console.ReadLine().Split(' ');

                atkDab = Convert.ToInt32(dabriel[0]);
                defDab = Convert.ToInt32(dabriel[1]);
                nvlDab = Convert.ToInt32(dabriel[2]);
                totDab = (atkDab + defDab) / 2;
                if (nvlDab % 2 == 0)
                {
                    totDab += bonus;
                }

                atkGua = Convert.ToInt32(guarte[0]);
                defGua = Convert.ToInt32(guarte[1]);
                nvlGua = Convert.ToInt32(guarte[2]);
                totGua = (atkGua + defGua) / 2;
                if (nvlGua % 2 == 0)
                {
                    totGua += bonus;
                }

                if (totDab > totGua)
                {
                    Console.WriteLine("Dabriel");
                }
                else if (totGua > totDab)
                {
                    Console.WriteLine("Guarte");
                }
                else
                {
                    Console.WriteLine("Empate");
                }
            }
        }
    }
}
