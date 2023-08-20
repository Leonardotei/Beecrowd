import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        double pi = 3.14159, raio, area;
        Scanner valorRaio = new Scanner (System.in);
        raio = valorRaio.nextDouble();
        area = pi * (raio * raio);
        
        System.out.println(String.format("A=%.4f", area));
    } 
}
