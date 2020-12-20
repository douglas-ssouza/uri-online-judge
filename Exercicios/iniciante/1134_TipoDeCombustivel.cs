using System;

namespace TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int opcao;
        
            do{
                opcao = Convert.ToInt32(Console.ReadLine());
            
                switch(opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        break;
                }
            } while (opcao != 4);

            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}