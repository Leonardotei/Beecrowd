import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        double a, b, c, media;
        
        Scanner valor = new Scanner (System.in);
        a = valor.nextDouble();
        b = valor.nextDouble();
        c = valor.nextDouble();
        
        media = ((a * 2) + (b * 3) + (c * 5))/10;
        
        System.out.println(String.format("MEDIA = %.1f", media));
    }
}
