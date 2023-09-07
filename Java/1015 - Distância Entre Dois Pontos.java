import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        double x1, x2, y1, y2, distancia;
        
        Scanner valor = new Scanner(System.in);
        x1 = valor.nextDouble();
        y1 = valor.nextDouble();
        x2 = valor.nextDouble();
        y2 = valor.nextDouble();
        
        distancia = Math.sqrt((Math.pow(x2 - x1, 2)) + (Math.pow(y2 - y1, 2)));

        System.out.println(String.format("%.4f", distancia));
    }
}
