import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        int a, b, PROD;
        
        Scanner valor = new Scanner (System.in);
        a = valor.nextInt();
        b = valor.nextInt();
        
        PROD = a * b;
        
        System.out.println(String.format("PROD = " + PROD));
    }
}
