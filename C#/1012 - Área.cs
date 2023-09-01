using System; 
  
 namespace Area{ 
     class Program{ 
        static void Main(string[] args){ 
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            
            // Recebe valores
            String valor = Console.ReadLine();
            string[] medida = valor.Split(' ');
            double a = Convert.ToDouble(medida[0]);
            double b = Convert.ToDouble(medida[1]);
            double c = Convert.ToDouble(medida[2]);
            
            // Calculo
            areaTriangulo = (a * c) / 2.0; 
            areaCirculo = Math.Pow(c, 2) * 3.14159; 
            areaTrapezio = ((a + b) * c) / 2.0; 
            areaQuadrado = Math.Pow(b, 2); 
            areaRetangulo = a * b;

            Console.WriteLine(string.Format($"TRIANGULO: {areaTriangulo.ToString("0.000")}")); 
            Console.WriteLine(string.Format($"CIRCULO: {areaCirculo.ToString("0.000")}")); 
            Console.WriteLine(string.Format($"TRAPEZIO: {areaTrapezio.ToString("0.000")}")); 
            Console.WriteLine(string.Format($"QUADRADO: {areaQuadrado.ToString("0.000")}")); 
            Console.WriteLine(string.Format($"RETANGULO: {areaRetangulo.ToString("0.000")}")); 
        }
    }
}
