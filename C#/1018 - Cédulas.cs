using System;

namespace Celulas
{
    class Program {
        static void Main(string[] args) {
            int valor, sobra;

            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(valor + "\n" +"{0} nota(s) de R$ 100,00", valor / 100);
            sobra = (valor % 100);

            Console.WriteLine("{0} nota(s) de R$ 50,00", sobra / 50);
            sobra = (sobra % 50);

            Console.WriteLine("{0} nota(s) de R$ 20,00", sobra / 20);
            sobra = (sobra % 20);

            Console.WriteLine("{0} nota(s) de R$ 10,00", sobra / 10);
            sobra = (sobra % 10);

            Console.WriteLine("{0} nota(s) de R$ 5,00", sobra / 5);
            sobra = (sobra % 5);

            Console.WriteLine("{0} nota(s) de R$ 2,00", sobra / 2);
            sobra = (sobra % 2);

            Console.WriteLine("{0} nota(s) de R$ 1,00", sobra / 1);

        }
    }
}
