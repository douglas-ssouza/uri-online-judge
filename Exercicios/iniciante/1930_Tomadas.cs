using System;

namespace Tomadas
{
    class Program
    {
        static void Main(string[] args){

            /**
            * @author: Douglas Souza
            * @date: 01/01/2021
            * @name: Tomadas
            */

            string[] linha = Console.ReadLine().Split(' ');
            int[] valores;
            valores = new int[4];
            int total = -3;

            for (int i = 0; i < 4; i++){
                valores[i] = Convert.ToInt32(linha[i]);
                total += valores[i];
            }

            Console.WriteLine(total);

        }
    }
}