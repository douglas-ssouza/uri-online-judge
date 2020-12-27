using System;

namespace VaiTerCopa
{
    class Program
    {
        static void Main(string[] args){

            while (true){
                int reclamacoes = Convert.ToInt32(Console.ReadLine());

                if (reclamacoes < 0){
                    break;
                }

                if (reclamacoes == 0){
                    Console.WriteLine("Vai ter copa!");
                }else{
                    Console.WriteLine("Vai ter duas!");
                }

            }

        }
    }
}