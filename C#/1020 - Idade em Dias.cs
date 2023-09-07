using System;

namespace Celulas
{
    class Program
    {
        static void Main(string[] args) {
            int idadeDias, anos, meses, dias;

            idadeDias = Convert.ToInt32(Console.ReadLine());

            anos = idadeDias / 365;
            idadeDias = idadeDias - (anos * 365);

            meses = idadeDias / 30;
            idadeDias = idadeDias - (meses * 30);

            dias = idadeDias;

            Console.WriteLine(anos + " ano(s)\n" + meses + " mes(es)\n" + dias + " dia(s)");
        }
    }
}
