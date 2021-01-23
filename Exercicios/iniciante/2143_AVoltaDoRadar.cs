using System;

namespace AVoltaDoRadar
{
    class Program
    {
        static void Main(string[] args)
        {

            int casos, pessoas, pedidos;

            while (true)
            {

                casos = Convert.ToInt32(Console.ReadLine());

                if (casos == 0)
                {
                    break;
                }

                for (int i = 0; i < casos; i++)
                {
                    pessoas = Convert.ToInt32(Console.ReadLine());

                    if (pessoas % 2 == 0)
                    {
                        pedidos = (pessoas - 2) * 2 + 2;
                    }
                    else
                    {
                        pedidos = (pessoas - 1) * 2 + 1;
                    }

                    Console.WriteLine(pedidos);
                }

            }

        }
    }
}
