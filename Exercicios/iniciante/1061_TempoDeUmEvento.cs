using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args){

            int dias, horas, minutos, segundos;

            string linha1 = Console.ReadLine();
            string[] dia1 = linha1.Split(' ');
            int diaInicio = Convert.ToInt32(dia1[1]);

            string linha2 = Console.ReadLine();
            string[] inicio = linha2.Split(' ');
            int horaInicio = Convert.ToInt32(inicio[0]);
            int minInicio = Convert.ToInt32(inicio[2]);
            int segInicio = Convert.ToInt32(inicio[4]);

            string linha3 = Console.ReadLine();
            string[] dia2 = linha3.Split(' ');
            int diaFim = Convert.ToInt32(dia2[1]);
            
            string linha4 = Console.ReadLine();
            string[] fim = linha4.Split(' ');
            int horaFim = Convert.ToInt32(fim[0]);
            int minFim = Convert.ToInt32(fim[2]);
            int segFim = Convert.ToInt32(fim[4]);

            int tempoInicio = segInicio + (minInicio * 60) + (horaInicio * 60 * 60) + (diaInicio * 60 * 60 * 24);
            int tempoFim = segFim + (minFim * 60) + (horaFim * 60 * 60) + (diaFim * 60 * 60 * 24);
            int tempoTotal = tempoFim - tempoInicio;

            dias = tempoTotal / (60 * 60 * 24);
            tempoTotal = tempoTotal % (60 * 60 * 24);
            horas = tempoTotal / (60 * 60);
            tempoTotal = tempoTotal % (60 * 60);
            minutos = tempoTotal / (60);
            tempoTotal = tempoTotal % 60;
            segundos = tempoTotal;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");

        }
    }
}