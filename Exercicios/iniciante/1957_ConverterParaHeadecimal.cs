using System;
using System.Linq;

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
            string caracteres = "";

            while (valor >= 16)
            {
                if (valor % 16 >= 10 && valor % 16 <= 15)
                {
                    switch (valor % 16)
                    {
                        case 10:
                            caracteres += 'A'; break;
                        case 11:
                            caracteres += 'B'; break;
                        case 12:
                            caracteres += 'C'; break;
                        case 13:
                            caracteres += 'D'; break;
                        case 14:
                            caracteres += 'E'; break;
                        case 15:
                            caracteres += 'F'; break;
                    }
                }
                else
                {
                    caracteres += Convert.ToString(valor % 16);
                }
                
                valor = valor / 16;
                if (valor < 16)
                {
                    caracteres += Convert.ToString(valor);
                }

            }

            string hexadecimal = new string(caracteres.Reverse().ToArray());

            Console.WriteLine(hexadecimal);



        }
    }
}