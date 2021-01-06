using System;
using System.Linq;

namespace ConverterParaHexadecimal
{
    class Program
    {
        static void Main(string[] args){

            int numero = Convert.ToInt32(Console.ReadLine());
            string hexadecimal = numero.ToString("X");

            Console.WriteLine(hexadecimal);

        }
    }
}