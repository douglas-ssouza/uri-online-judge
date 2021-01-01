using System;

namespace Tri_du
{
    class Program
    {
        static void Main(string[] args){

            /**
            * @author: Douglas Souza
            * @date: 01/01/2021
            * @name: Tri-du
            */

            string[] cartas = Console.ReadLine().Split(' ');
            int carta1, carta2, carta3;

            carta1 = Convert.ToInt32(cartas[0]);
            carta2 = Convert.ToInt32(cartas[1]);

            if (carta1 >= carta2){
                carta3 = carta1;
            }else{
                carta3 = carta2;
            }

            Console.WriteLine(carta3);

        }
    }
}