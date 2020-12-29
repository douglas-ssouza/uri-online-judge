using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args){

            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= t; i++){
                string[] linha = Console.ReadLine().Split(' ');
                
                if (linha[0].Equals(linha[1])){
                    Console.WriteLine("Caso #{0}: De novo!", i.ToString("0"));
                }else if (linha[0].Equals("tesoura")){
                    if(linha[1].Equals("papel") || linha[1].Equals("lagarto")){
                        Console.WriteLine("Caso #{0}: Bazinga!", i.ToString("0"));
                    }else{
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i.ToString("0"));
                    }
                }else if (linha[0].Equals("papel")){
                    if (linha[1].Equals("pedra") || linha[1].Equals("Spock")){
                        Console.WriteLine("Caso #{0}: Bazinga!", i.ToString("0"));
                    }else{
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i.ToString("0"));
                    }
                }else if (linha[0].Equals("pedra")){
                    if (linha[1].Equals("lagarto") || linha[1].Equals("tesoura")){
                        Console.WriteLine("Caso #{0}: Bazinga!", i.ToString("0"));
                    }else{
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i.ToString("0"));
                    }
                }else if (linha[0].Equals("lagarto")){
                    if (linha[1].Equals("Spock") || linha[1].Equals("papel")){
                        Console.WriteLine("Caso #{0}: Bazinga!", i.ToString("0"));
                    }else{
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i.ToString("0"));
                    }
                }else{
                    if (linha[1].Equals("tesoura") || linha[1].Equals("pedra")){
                        Console.WriteLine("Caso #{0}: Bazinga!", i.ToString("0"));
                    }else{
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i.ToString("0"));
                    }
                }

            }

        }
    }
}