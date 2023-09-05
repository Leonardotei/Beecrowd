using System;

namespace Celulas
{
    class Program {
        static void Main(string[] args) {
            int tempo, horas, minutos, segundos;

            tempo = Convert.ToInt32(Console.ReadLine());

            horas = tempo / 3600;

            minutos = tempo / 60 - (horas * 60);

            segundos = tempo - (horas * 3600) - (minutos * 60);

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
