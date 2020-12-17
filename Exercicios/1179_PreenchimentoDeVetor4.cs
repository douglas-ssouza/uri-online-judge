    using System;

namespace PreenchimentoDeVetor4
{
    class Program
    {
        static void Main(string[] args){

            int[] pares, impares;
            pares = new int[5];
            impares = new int[5];

            int x, indPar = 0, indImpar = 0;

            for (int i = 0; i < 15; i++){
                x = Convert.ToInt32(Console.ReadLine());

                if (x % 2 == 0){
                    pares[indPar] = x;
                    indPar++;
                    if (indPar == 5){
                        for (int j = 0; j < 5; j++){
                            Console.WriteLine("par[" + j + "] = " + pares[j]);
                        }
                        indPar = 0;
                    }
                }else{
                    impares[indImpar] = x;
                    indImpar++;
                    if (indImpar == 5){
                        for (int j = 0; j < 5; j++){
                            Console.WriteLine("impar[" + j + "] = " + impares[j]);
                        }
                        indImpar = 0;
                    }
                }
            }

            for (int i = 0; i < indImpar; i++){
                Console.WriteLine("impar[" + i + "] = " + impares[i]);
            }

            for (int i = 0; i < indPar; i++){
                Console.WriteLine("par[" + i + "] = " + pares[i]);
            }

        }
    }
}