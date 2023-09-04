using System;

namespace DistanciaDoisPontos
{
    class Program {
        static void Main(string[] args) {
            int quilometragem, minutos;

            quilometragem = Convert.ToInt32(Console.ReadLine());

            minutos = quilometragem * 2;

            Console.WriteLine(minutos + " minutos");
        }
    }
}
