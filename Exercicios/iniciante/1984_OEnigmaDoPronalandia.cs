using System;
using System.Linq;

namespace OEnigmaDoPronalandia
{
    class Program
    {
        static void Main(string[] args){

            string numero = Console.ReadLine();
            string invertido = new string(numero.Reverse().ToArray());

            Console.WriteLine(invertido);
        }
    }
}