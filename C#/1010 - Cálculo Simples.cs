using System; 

class CalculoSimples{

    static void Main(string[] args){ 

        // Produto 1
        String prod1 = Console.ReadLine();
        string[] valor1 = prod1.Split(' ');
        int codPeca1 = Convert.ToInt32(valor1[0]);
        int qtdPeca1 = Convert.ToInt32(valor1[1]);
        double valorUnit1 = Convert.ToDouble(valor1[2]);

        // Produto 2
        String prod2 = Console.ReadLine();
        string[] valor2 = prod2.Split(' ');
        int codPeca2 = Convert.ToInt32(valor2[0]);
        int qtdPeca2 = Convert.ToInt32(valor2[1]);
        double valorUnit2 = Convert.ToDouble(valor2[2]);

        // Cálculo
        double valorTotal=(valorUnit1 * qtdPeca1) + (valorUnit2 * qtdPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ {0:00.00}",valorTotal);

    }   
}
