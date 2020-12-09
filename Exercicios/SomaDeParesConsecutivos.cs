using System;

namespace SomaDeParesConsecutivos
{
    class Program
    {
        static void Main(string[] args){
            
            int x = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            while(x != 0){
                if (x % 2 != 0) x++;

                for (int i = 0; i < 5; i++){
                    soma += x;
                    x += 2;
                }
                Console.WriteLine(soma);

                x = Convert.ToInt32(Console.ReadLine());
                soma = 0;
            }

        }
    }
}