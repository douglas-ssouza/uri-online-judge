using System;

namespace NatalDePedrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string linha = Console.ReadLine();
                if (string.IsNullOrEmpty(linha))
                {
                    break;
                }
                string[] valores = linha.Split(' ');
                int mes = Convert.ToInt32(valores[0]);
                int dia = Convert.ToInt32(valores[1]);
                int dias;

                switch (mes)
                {
                    case 1:
                        dias = 360 - dia;
                        break;
                    case 2:
                        dias = 360 - 31 - dia;
                        break;
                    case 3:
                        dias = 360 - 31 - 29 - dia;
                        break;
                    case 4:
                        dias = 360 - 31 - 29 - 31 - dia;
                        break;
                    case 5:
                        dias = 360 - 31 - 29 - 31 - 30 - dia;
                        break;
                    case 6:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - dia;
                        break;
                    case 7:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - dia;
                        break;
                    case 8:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - 31 - dia;
                        break;
                    case 9:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - 31 - 31 - dia;
                        break;
                    case 10:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - dia;
                        break;
                    case 11:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - dia;
                        break;
                    case 12:
                        dias = 360 - 31 - 29 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - dia;
                        break;
                    default:
                        dias = 0;
                        break;
                }

                if (dias < 0)
                {
                    Console.WriteLine("Ja passou!");
                }
                else if (dias == 0)
                {
                    Console.WriteLine("E natal!");
                }
                else if (dias == 1)
                {
                    Console.WriteLine("E vespera de natal!");
                }
                else
                {
                    Console.WriteLine("Faltam " + dias + " dias para o natal!");
                }
            }

        }
    }
}
