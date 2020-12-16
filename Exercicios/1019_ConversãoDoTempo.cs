using System;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, horas, minutos, segundos;

            tempo = Convert.ToInt32(Console.ReadLine());

            horas = tempo / 3600;
            minutos = (tempo % 3600) / 60;
            segundos = ((tempo % 3600) % 60);

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
