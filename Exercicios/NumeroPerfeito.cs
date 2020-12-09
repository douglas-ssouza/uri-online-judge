using System;

namespace NumeroPerfeito
{
    class Program
    {
        static void Main(string[] args){
            
            int n = Convert.ToInt32(Console.ReadLine());
            int valor;
            int soma;

            for (int i = 0; i < n; i++){
                valor = Convert.ToInt32(Console.ReadLine());
                soma = 0;

                for (int j = 1; j < valor; j++){
                    if (valor % j == 0){
                        soma += j;
                    }
                }

                if (soma == valor){
                    Console.WriteLine(valor + " eh perfeito");
                }else{
                    Console.WriteLine(valor + " nao eh perfeito");
                }

            }

        }
    }
}