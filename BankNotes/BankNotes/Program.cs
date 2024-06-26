using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor, resto, N100, N50, N20, N10, N5, N2, N1;

            Console.WriteLine("Insira o valor total em Reais: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Este valor em reais daria: ");

            N100 = valor / 100;
            resto = valor % 100;

            N50 = resto / 50;
            resto = resto % 50;

            N20 = resto / 20;
            resto = resto % 20;

            N10 = resto / 10;
            resto = resto % 10;

            N5 = resto / 5;
            resto = resto % 5;

            N2 = resto / 2;
            resto = resto % 2;

            N1 = resto / 1;
            resto = resto % 1;


            Console.WriteLine(N100 + " nota(s) de R$ 100,00");
            Console.WriteLine(N50 + " nota(s) de R$ 50,00");
            Console.WriteLine(N20 + " nota(s) de R$ 20,00");
            Console.WriteLine(N10 + " nota(s) de R$ 10,00");
            Console.WriteLine(N5 + " nota(s) de R$ 5,00");
            Console.WriteLine(N2 + " nota(s) de R$ 2,00");
            Console.WriteLine(N1 + " nota(s) de R$ 1,00");
         

        }
    }
}