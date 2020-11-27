using System;

namespace UltrapassandoZ
{
    class Program
    {
        static void Main(string[] args){

            int x = Convert.ToInt32(Console.ReadLine());
            int y;

            do{
                y = Convert.ToInt32(Console.ReadLine());
            }while(y <= x);

            int soma = x;
            int total = 1;

            while (soma <= y){
                x++;
                soma += x; 
                total++;
            }

            Console.WriteLine(total);
        }
    }
}