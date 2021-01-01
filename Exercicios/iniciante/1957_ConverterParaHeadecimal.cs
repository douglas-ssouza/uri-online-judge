using System;

namespace ConverterParaHexadecimal
{
    class Program
    {
        static void Main(string[] args){

            /**
            * @author: Douglas Souza
            * @date: 01/01/2021
            * @name: Converter para hexadecimal
            */

            int valor = Convert.ToInt32(Console.ReadLine());
            string hexadecimal;

            while (valor >= 16){

                hexadecimal += Convert.ToString(valor%16);
                valor = valor / 16;

            }
            hexadecimal += Convert.ToString(valor/16);



        }
    }
}