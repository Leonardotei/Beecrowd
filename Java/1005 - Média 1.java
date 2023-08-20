import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        double a, b, media;
        Scanner valor = new Scanner (System.in);
        a = valor.nextDouble();
        b = valor.nextDouble();
        media = ((a * 3.5) + (b * 7.5))/11;
        
        System.out.println(String.format("MEDIA = %.5f", media));
    }
}
