using System;

namespace NossosDiasNuncaVoltarao
{
    class Program
    {
        static void Main(string[] args){

            string texto = "LIFE IS NOT A PROBLEM TO BE SOLVED"
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(texto.Substring(0, n));

        }
    }
}