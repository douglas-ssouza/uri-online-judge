using System;

namespace VaiTerCopa
{
    class Program
    {
        static void Main(string[] args){

            int reclamacoes;
            string linha;

            while (true){
                linha = Console.ReadLine();
                if (string.IsNullOrEmpty(linha))
                {
                    break;
                }

                reclamacoes = Convert.ToInt32(linha);

                if (reclamacoes == 0){
                    Console.WriteLine("vai ter copa!");
                }else{
                    Console.WriteLine("vai ter duas!");
                }

            }

        }
    }
}