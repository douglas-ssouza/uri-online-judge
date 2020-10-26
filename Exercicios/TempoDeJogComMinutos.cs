using System;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] tempo = linha.Split(' ');

            int horaIni = Convert.ToInt32(tempo[0]);
            int minIni = Convert.ToInt32(tempo[1]);
            int horaFim = Convert.ToInt32(tempo[2]);
            int minFim = Convert.ToInt32(tempo[3]);

            int horas, minutos;

            if (horaIni == horaFim)
            {
                if (minIni == minFim)
                {
                    horas = 24;
                    minutos = 0;
                }
                else if (minIni < minFim)
                {
                    horas = 0;
                    minutos = minFim - minIni;
                }
                else
                {
                    horas = 23;
                    minutos = (60 - minIni) + minFim;
                }
            }
            else if (horaIni < horaFim)
            {
                horas = (horaFim - horaIni);
                if (minIni == minFim)
                {
                    minutos = 0;
                }
                else if (minIni < minFim)
                {
                    minutos = minFim - minIni;
                }
                else
                {
                    horas--;
                    minutos = (60 - minIni) + minFim;
                }
            }
            else
            {
                horas = (24 - horaIni) + horaFim;
                if (minIni == minFim)
                {
                    minutos = 0;
                }
                else if (minIni < minFim)
                {
                    minutos = minFim - minIni;
                }
                else
                {
                    horas--;
                    minutos = (60 - minIni) + minFim;
                }
            }

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
