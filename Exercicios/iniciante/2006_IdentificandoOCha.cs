using System;

namespace IdentificandoOCha
{
    class Program
    {
        static void Main(string[] args)
        {

            int tipo, cha, corretos = 0;

            tipo = Convert.ToInt32(Console.ReadLine());
            
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < 5; i++){
                cha = Convert.ToInt32(linha[i]);

                if (cha == tipo){
                    corretos++;
                }
            }

            Console.WriteLine(corretos);

        }
    }
}