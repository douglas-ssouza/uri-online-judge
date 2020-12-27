using System;

namespace HoHoHo
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++){
                if (i < n){
                    Console.Write("Ho ");
                }else{
                    Console.WriteLine("Ho!");
                }
            }

        }
    }
}