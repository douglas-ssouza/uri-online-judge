using System;

namespace Paridade
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            int total = 0;

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i].Equals('1'))
                {
                    total++;
                }
            }

            if (total % 2 == 0)
            {
                msg += '0';
            }
            else
            {
                msg += '1';
            }

            Console.WriteLine(msg);
        }
    }
}
