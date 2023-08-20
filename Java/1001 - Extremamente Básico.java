import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        int a, b, x;
        Scanner valor = new Scanner (System.in);
        a = valor.nextInt();
        b = valor.nextInt();
        x = a + b;
        
        System.out.println("X = " + x);
    }
}
