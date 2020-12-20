using System;

namespace TesteDeSelecao1
{
    class Program
    {
        static void Main(string[] args){

            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');

            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            int c = Convert.ToInt32(valores[2]);
            int d = Convert.ToInt32(valores[3]);

            if (b > c && d > a && (d + c) > (a + b) && (c > 0) && (d > 0) && (a % 2 == 0)){
                Console.WriteLine("Valores aceitos");
            }else{
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}