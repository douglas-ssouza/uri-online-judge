using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());
            int valor;
            bool primo;

            for (int i = 0; i < n; i++){
                valor = Convert.ToInt32(Console.ReadLine());
                primo = true;

                for (int j = 2; j < valor; j++){
                    if (valor % j == 0){
                        primo = False;
                    }
                }

                Console.WriteLine(primo ? valor + " eh primo" : valor + " nao eh primo");
            }
        }
    }
}