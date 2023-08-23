import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        String nome;
        double salarioFixo,vendas, salarioBonus;
        
        Scanner valor = new Scanner (System.in);
        nome = valor.next();
        salarioFixo = valor.nextDouble();
        vendas = valor.nextDouble();
        
        salarioBonus = (vendas * 0.15) + salarioFixo;
        
        System.out.println(String.format("TOTAL = R$ %.2f", salarioBonus));
        
    }
}
