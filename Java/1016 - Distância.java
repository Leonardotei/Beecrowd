import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        int distancia, minutos;
        
        Scanner valor = new Scanner(System.in);
        distancia = valor.nextInt();
        
        minutos = distancia * 2;

        System.out.println(minutos + " minutos");
    }
}
