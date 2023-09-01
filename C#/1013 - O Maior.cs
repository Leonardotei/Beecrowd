using System;

namespace Maior{
    class Program{
        static void Main(string[] args){
            int a, b, c, maiorAB, maiorABC;
            
            String linha = Console.ReadLine();
            string[] valor = linha.Split(' ');
            a = Convert.ToInt32(valor[0]); 
            b = Convert.ToInt32(valor[1]); 
            c = Convert.ToInt32(valor[2]); 
            
            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
            
            Console.WriteLine(maiorABC + " eh o maior");
        }
    }
}
