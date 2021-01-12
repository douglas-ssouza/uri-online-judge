using System;

namespace SequenciaDeSequencia
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor, total = 1, caso = 1;

            while (true)
            {
                
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                valor = Convert.ToInt32(input);

                if (valor == 0)
                {
                    Console.WriteLine("Caso " + caso + ": 1 numero");
                    Console.WriteLine("0");
                }else
                {
                    for (int i = 1; i <= valor; i++)
                    {
                        total += i;
                    }
                    
                    Console.WriteLine("Caso " + caso + ": " + total + " numeros");
                    Console.Write("0 ");
                    for (int i = 1; i <= valor; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }

                caso++;

            }

        }
    }
}