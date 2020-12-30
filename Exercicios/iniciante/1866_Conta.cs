using System;

namespace Conta
{
    class Program
    {
        static void Main(string[] args){

            int casos = Convert.ToInt32(Console.ReadLine());
            int quant, s;

            for (int i = 0; i < casos; i++){
                quant = Convert.ToInt32(Console.ReadLine());
                if (quant % 2 == 0){
                    s = 0;
                }else{
                    s = 1;
                }
                Console.WriteLine(s);
            }

        }
    }
}