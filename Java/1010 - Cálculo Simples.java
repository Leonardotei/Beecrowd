import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        int codigo, qtdPecas;
        double valorUnit, valorProd1, valorProd2, valorTotal;
        
        Scanner valor = new Scanner(System.in);
        
        //Produto 1
        codigo = valor.nextInt();
        qtdPecas = valor.nextInt();
        valorUnit = valor.nextDouble();
        valorProd1 = qtdPecas * valorUnit;
        
        //Produto 2
        codigo = valor.nextInt();
        qtdPecas = valor.nextInt();
        valorUnit = valor.nextDouble();
        valorProd2 = qtdPecas * valorUnit;
        
        valorTotal = valorProd1 + valorProd2;
        
        System.out.println(String.format("VALOR A PAGAR: R$ %.2f", valorTotal));
    }
}
