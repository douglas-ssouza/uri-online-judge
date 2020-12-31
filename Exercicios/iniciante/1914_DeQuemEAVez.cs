using System;

namespace DeQuemEAVez
{
    class Program
    {
        static void Main(string[] args){

            /**
            * @author: Douglas Souza
            * @date: 31/12/2020
            * @name: De quem é a vez?
            */

            int quant = Convert.ToInt32(Console.ReadLine());

            for (int jogos = 0; i < quant; i++){

                string[] escolhas = Console.ReadLine().Split(' ');
                string[] valores = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(valores[0]);
                int b = Convert.ToInt32(valores[1]);
                int soma = a + b;

                if (soma % 2 == 0){
                    if (escolhas[1].Equals("PAR")){
                        Console.WriteLine(escolhas[0]);
                    }else{
                        Console.WriteLine(escolhas[2]);
                    }
                }else{
                    if (escolhas[1].Equals("IMPAR")){
                        Console.WriteLine(escolhas[0]);
                    }else{
                        Console.WriteLine(escolhas[2]);
                    }
                }

            }

        }
    }
}