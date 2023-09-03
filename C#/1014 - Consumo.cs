using System;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args) {
            int distancia;
            double combustivel, gasto;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivel = Convert.ToDouble(Console.ReadLine());

            gasto = distancia / combustivel;

            Console.WriteLine(string.Format($"{gasto.ToString("0.000")} km/l"));
        }
    }
}
