using System;

namespace Salario{
    class Program{
        static void Main(string [] args){
            int numFunc, horasTrabalhadas;
            double valorHora, salario;
            
            numFunc = Convert.ToInt32(Console.ReadLine());
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            valorHora = Convert.ToDouble(Console.ReadLine());
            
            salario = valorHora * horasTrabalhadas;
            
            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine(string.Format($"SALARY = U$ {salario.ToString("0.00")}"));
        }
    }
}
