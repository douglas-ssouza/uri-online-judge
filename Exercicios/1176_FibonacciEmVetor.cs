using System;

namespace FibonacciEmVetor
{
    class Program
    {
        static void Main(string[] args){

            int testes = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < testes; i++){
                long a = 0, b = 1;
                long c;

                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0){
                    Console.WriteLine("Fib(0) = " + a);
                }else if (valor == 1){
                    Console.WriteLine("Fib(1) = " + b);
                }else{
                    for (int j = 2; j <= valor; j++){
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    Console.WriteLine("Fib(" + valor + ") = " + c);
                }
            }

        }
    }
}