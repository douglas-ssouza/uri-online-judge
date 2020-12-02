using System;

namespace SomaDeParesConsecutivos
{
    class Program
    {
        static void Main(string[] args){
            int x;
            int soma = 0;

            do{
                x = Convert.ToInt32(Console.ReadLine());
                
                if (x != 0){
                    if (x % 2 != 0) x++;

                    for (int i = 0; i < 5; i++){
                        soma += x;
                        x += 2;
                    }
                    Console.WriteLine(soma);
                }

            }while (x != 0);
        }
    }
}