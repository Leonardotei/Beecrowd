using System;

namespace AreaCirculo{
    class Program{
        static void Main(string[] args){
            double pi = 3.14159, raio, area;

            raio = Convert.ToDouble(Console.ReadLine());
            area = pi * (raio * raio);
            
            Console.WriteLine(string.Format("A={0:0.0000}", area));
        }
    }
}
