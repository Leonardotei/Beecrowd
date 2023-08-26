using System;

namespace Diferenca{
    class Program{
        static void Main(string[] args){
            int a, b, c, d, dif;
            
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            
            dif = (a * b) - (c * d);
            
            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
