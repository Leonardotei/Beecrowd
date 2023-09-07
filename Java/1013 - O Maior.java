import java.io.IOException;
import java.util.*;

public class Main{
    public static void main(String[] args){
        int a, b, c, maiorAB, maiorABC;
        Scanner valor = new Scanner(System.in);
        
        a = valor.nextInt();
        b = valor.nextInt();
        c = valor.nextInt();
        
        maiorAB = (a + b + Math.abs(a -b ))/2;
        
        maiorABC = (maiorAB + c + Math.abs(maiorAB - c))/2;
        
        System.out.println(maiorABC + " eh o maior");
        
    }
}
