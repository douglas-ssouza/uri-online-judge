using System;

namespace ACorridaDeLesmas
{
    class Program
    {
        static void Main(string[] args){

            while (true){
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)){
                    break;
                }
                
                int n = Convert.ToInt32(input);
                int[] velocidade;
                velocidade = new int[n];
                int maior = 0;
                string[] linha = Console.ReadLine().Split(' ');
                
                for (int i = 0; i < n; i++){
                    velocidade[i] = Convert.ToInt32(linha[i]);
                    if (velocidade[i] > maior){
                        maior = velocidade[i];
                    }
                }

                if (maior < 10){
                    Console.WriteLine("1");
                }else if (maior < 20){
                    Console.WriteLine("2");
                }else{
                    Console.WriteLine("3");
                }

            }

        }
    }
}