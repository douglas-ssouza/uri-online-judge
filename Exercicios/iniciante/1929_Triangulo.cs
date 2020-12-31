using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args){

            /**
            * @author: Douglas Souza
            * @date: 31/12/2020
            * @name: Triangulo
            */

            string[] linha = Console.ReadLine().Split(' ');
            int[] lados;
            lados = new int[4];
            int aux;

            for (int lado = 0; lado < 4; lado++){
                lados[lado] = Convert.ToInt32(linha[lado]);
            }

            for (int i = 0; i < 4; i++){
                for (int j = 1; j < 4; j++){
                    if (lados[j] < lados[j-1]){
                        aux = lados[j];
                        lados[j] = lados[j-1];
                        lados[j-1] = aux;
                    }
                }
            }

            if ((lados[1] - lados[0]) > (lados[3] - lados[2])){
                if (lados[1] + lados[2] > lados[3]){
                    Console.WriteLine("S");
                }else{
                    Console.WriteLine("N");
                }
            }else{
                if (lados[0] + lados[1] > lados[2]){
                    Console.WriteLine("S");
                }else{
                    Console.WriteLine("N");
                }
            }   
        }
    }
}