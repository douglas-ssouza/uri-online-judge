using System;

namespace Evento
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            uint aumento, exp;

            while (true)
            {
                valores = Console.ReadLine().Split(' ');
                aumento = Convert.ToUInt32(valores[0]);
                exp = Convert.ToUInt32(valores[1]);

                if (aumento == 0 && exp == 0)
                {
                    break;
                }

                exp = aumento * exp;

                Console.WriteLine(exp);
            }
        }
    }
}
