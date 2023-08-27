using System;

namespace SalarioBonus{
    class Program{
        static void Main(string[] args){
            string nomeVend;
            double salarioFixo, totalVendas, salarioBonus;
            
            nomeVend = Convert.ToString(Console.ReadLine());
            salarioFixo = Convert.ToDouble(Console.ReadLine());
            totalVendas = Convert.ToDouble(Console.ReadLine());
            
            salarioBonus = (totalVendas * 0.15) + salarioFixo;
            
            Console.WriteLine(string.Format($"TOTAL = R$ {salarioBonus.ToString("0.00")}"));
        }
    }
}
