using System;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, meses, dias;

            idade = Convert.ToInt32(Console.ReadLine());

            anos = idade / 365;
            meses = (idade % 365) / 30;
            dias = (idade % 365) % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
