using System;

namespace NomeNoFormulario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();

            if (nome.Length <= 80)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
