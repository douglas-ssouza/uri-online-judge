using System;

namespace BemVindosEBemVindasAoInverno
{
    class Program
    {
        static void Main(string[] args){

            string[] linha = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(linha[0]);
            int b = Convert.ToInt32(linha[1]);
            int c = Convert.ToInt32(linha[2]);
            int difAB, difBC;

            if (a > b){
                if (b <= c){
                    Console.WriteLine(":)");
                }else{
                    difAB = a - b;
                    difBC = b - c;
                    if (difBC < difAB){
                        Console.WriteLine(":)");
                    }else{
                        Console.WriteLine(":(");
                    }
                }
            }else if (a < b){
                if (b >= c){
                    Console.WriteLine(":(");
                }else{
                    difAB = b - a;
                    difBC = c - b;
                    if (difBC < difAB){
                        Console.WriteLine(":(");
                    }else{
                        Console.WriteLine(":)");
                    }
                }
            }else{
                if (b < c){
                    Console.WriteLine(":)");
                }else{
                    Console.WriteLine(":(");
                }
            }

        }
    }
}