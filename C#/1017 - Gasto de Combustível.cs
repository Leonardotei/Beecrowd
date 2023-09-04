using System;

namespace GastoCombustivel
{
    class Program {
        static void Main(string[] args) {

            int tempo = Convert.ToInt32(Console.ReadLine());
            int velocidade = Convert.ToInt32(Console.ReadLine());

            double combustivel = (tempo * velocidade)/12.0;

            Console.WriteLine(string.Format($"{combustivel.ToString("0.000")}"));

        }
    }
}
