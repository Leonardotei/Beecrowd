import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        double A, B, SOMA;
        Scanner valor = new Scanner (System.in);
        A = valor.nextInt();
        B = valor.nextInt();
        SOMA = A + B;
        
        System.out.println(String.format("SOMA = %.0f", SOMA));
    } 
}
