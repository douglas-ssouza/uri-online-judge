using System;

namespace DomingoDeManha
{
    class Program
    {
        static void Main(string[] args){

            int hora, minuto, tempo, atraso = 0;

            while (true)
            {
                
                string linha = Console.ReadLine();

                if (string.IsNullOrEmpty(horario))
                {
                    break;
                }

                string[] horario = linha.Split(':');
                hora = Convert.ToInt32(horario[0]);
                minuto = Convert.ToInt32(horario[1]);
                tempo = (hora * 60) + minuto;

                if (tempo > 420)
                {
                    atraso = tempo + 60 - 480;
                }

                Console.WriteLine("Atraso maximo: " + atraso);

            }

        }
    }
}