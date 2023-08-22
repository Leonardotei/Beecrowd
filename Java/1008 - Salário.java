import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        int numFunc;
        double valorHora, valorTotal, horasTrabalhadas;
        
        Scanner valor = new Scanner (System.in);
        numFunc = valor.nextInt();
        valorHora = valor.nextDouble();
        horasTrabalhadas = valor.nextDouble();
        
        valorTotal = valorHora * horasTrabalhadas;
        
        System.out.println("NUMBER = " + numFunc); 
        System.out.println(String.format("SALARY = U$ %.2f", valorTotal));
    }
}
