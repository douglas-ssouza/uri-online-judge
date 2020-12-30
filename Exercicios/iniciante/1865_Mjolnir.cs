using System;

namespace Mjolnir
{
    class Program
    {
        static void Main(string[] args){

            int casos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < casos; i++){
                string heroi = Console.ReadLine();
                if (heroi.Substring(0, 5).Equals("Thor ")){
                    Console.WriteLine("Y");
                }else{
                    Console.WriteLine("N");
                }
            }

        }
    }
}