using System;

namespace CorvoContador
{
    class Program
    {
        static void Main(string[] args){

            int contador = 0;
            int gritos = 1;
            
            while (gritos < 3){
                string input = Console.ReadLine();

                if (input.Equals("--*")){
                    contador += 1;
                }else if (input.Equals("*--")){
                    contador += 4;
                }else if (input.Equals("-*-")){
                    contador += 2;    
                }else{
                    Console.WriteLine("caw caw");
                    contador = 0;
                    gritos++;
                }
            }  
        }
    }
}