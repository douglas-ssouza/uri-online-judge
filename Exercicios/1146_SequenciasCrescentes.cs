using System;

namespace SequenciasCrescentes
{
    class Program
    {
        static void Main(string[] args){

            int x;

            do{

                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0){
                    break;
                }

                for (int i = 1; i <= x; i++){
                    if (i == x){
                        Console.Write(i);
                    }else{
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();

            } while(x != 0);

        }
    }
}