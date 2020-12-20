using System;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = Convert.ToDouble(Console.ReadLine());
            double novoSal, reajuste;
            int percentual;

            if (salario <= 400.00)
            {
                novoSal = salario + (salario * 0.15);
                reajuste = novoSal - salario;
                percentual = 15;
            }
            else if (salario <= 800.00)
            {
                novoSal = salario + (salario * 0.12);
                reajuste = novoSal - salario;
                percentual = 12;
            }
            else if (salario <= 1200.00)
            {
                novoSal = salario + (salario * 0.1);
                reajuste = novoSal - salario;
                percentual = 10;
            }
            else if (salario <= 2000.00)
            {
                novoSal = salario + (salario * 0.07);
                reajuste = novoSal - salario;
                percentual = 7;
            }
            else
            {
                novoSal = salario + (salario * 0.04);
                reajuste = novoSal - salario;
                percentual = 4;
            }

            Console.WriteLine("Novo salario: {0}", novoSal.ToString("0.00"));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("0.00"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
