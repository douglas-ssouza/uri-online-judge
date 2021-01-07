using System;

namespace HaMuitoMuitoTempoAtras
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());
            int anos;

            for (int i = 0; i < n; i++){
                anos = Convert.ToInt32(Console.ReadLine());

                if (anos >= 2015){
                    anos = anos - 2014;
                    Console.WriteLine(anos + " A.C.");
                }else{
                    anos = 2015 - anos;
                    Console.WriteLine(anos + " D.C.");
                }
            }

        }
    }
}