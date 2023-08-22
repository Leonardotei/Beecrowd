import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        int a, b, c, d, dif;
        
        Scanner valor = new Scanner(System.in);
        a = valor.nextInt();
        b = valor.nextInt();
        c = valor.nextInt();
        d = valor.nextInt();
        
        dif = (a * b) - (c * d);
        
        System.out.println("DIFERENCA = " + dif);
    }
}
