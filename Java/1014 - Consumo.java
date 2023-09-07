import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        int distancia;
        double combustivel, gasto;
        
        Scanner valor = new Scanner(System.in);
        distancia = valor.nextInt();
        combustivel = valor.nextDouble();
        
        gasto = distancia / combustivel;
        
        System.out.println(String.format("%.3f km/l", gasto));
    }
}
