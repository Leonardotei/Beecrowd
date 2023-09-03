using System;

namespace DistanciaDoisPontos
{
    class Program {
        static void Main(string[] args) {

            // Primeiro eixo
            String p1 = Console.ReadLine();
            string[] eixos1 = p1.Split(' ');
            double x1 = Convert.ToDouble(eixos1[0]);
            double y1 = Convert.ToDouble(eixos1[1]);

            // Segundo eixo
            String p2 = Console.ReadLine();
            string[] eixos2 = p2.Split(' ');
            double x2 = Convert.ToDouble(eixos2[0]);
            double y2 = Convert.ToDouble(eixos2[1]);

            double distancia = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)); 

            Console.WriteLine(string.Format($"{distancia.ToString ("0.0000")}"));

        }
    }
}
