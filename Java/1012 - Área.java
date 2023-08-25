import java.io.IOException;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        double a, b, c;
        double triangulo, circulo, trapezio, quadrado, retangulo;
        double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
    
        Scanner valor = new Scanner(System.in);
        
        a = valor.nextDouble();
        b = valor.nextDouble();
        c = valor.nextDouble();
        
        areaTriangulo = (a * c) / 2.0;

        areaCirculo = (c * c) * 3.14159;
        
        areaTrapezio = ((a + b) * c) / 2;
        
        areaQuadrado = b * b;
        
        areaRetangulo = a * b;
        
        System.out.println(String.format("TRIANGULO: %.3f", areaTriangulo));
        System.out.println(String.format("CIRCULO: %.3f", areaCirculo));
        System.out.println(String.format("TRAPEZIO: %.3f", areaTrapezio));
        System.out.println(String.format("QUADRADO: %.3f", areaQuadrado));
        System.out.println(String.format("RETANGULO: %.3f", areaRetangulo));
    }
}
