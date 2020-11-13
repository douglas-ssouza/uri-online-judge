using System;

namespace SequenciasCrescentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                if (x > 1)
                {
                    for (int i = 1; i <= x; i++)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine(" " + i);
                        }
                    }
                }
                else if (x < 1)
                {
                    for (int i = 1; i >= x; i--)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine(" " + i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(1);
                }

                x = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}