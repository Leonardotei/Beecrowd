using System;

namespace Media{
    class Program{
        static void Main(string[] args){
            double a, b, media;
            
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            media = ((3.5 * a) + (7.5 * b))/11;
            
            Console.WriteLine(string.Format($"MEDIA = {media.ToString("0.00000")}"));
        }
    }
}
