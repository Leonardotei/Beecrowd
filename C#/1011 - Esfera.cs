using System;

namespace Esfera{
    class Program{
        static void Main(string[] args){
            int raio;
            double pi = 3.14159, volumeEsfera;
            
            raio = Convert.ToInt32(Console.ReadLine());
            
            volumeEsfera = (4/3.0) * pi * Math.Pow(raio, 3);
            
            Console.WriteLine(string.Format($"VOLUME = {volumeEsfera.ToString("0.000")}"));
        }
    }
}
