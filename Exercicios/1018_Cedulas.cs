using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int cem, cinquenta, vinte, dez, cinco, dois, um;

            valor = Convert.ToInt32(Console.ReadLine());

            cem = valor / 100;
            cinquenta = (valor % 100) / 50;
            vinte = ((valor % 100) % 50) / 20;
            dez = (((valor % 100) % 50) % 20) / 10;
            cinco = ((((valor % 100) % 50) % 20) % 10) / 5;
            dois = (((((valor % 100) % 50) % 20) % 10) % 5) / 2;
            um = ((((((valor % 100) % 50) % 20) % 10) % 5) % 2);

            Console.WriteLine(valor);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
