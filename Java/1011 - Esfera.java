import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        int raio;
        double pi = 3.14159, volumeEsfera;
        
        Scanner valor = new Scanner(System.in);
        raio = valor.nextInt();
        volumeEsfera = (4/3.0) * pi * Math.pow(raio, 3.0);
        
        System.out.println(String.format("VOLUME = %.3f", volumeEsfera));
    }
}
