using System;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double entradaValor = double.Parse(Console.ReadLine());
            
            int nota100 = (int)(100 * entradaValor) / 10000;
            int resto100 = (int)(100 * entradaValor) % 10000;

            int nota50 = resto100 / 5000;
            int resto50 = resto100 % 5000;

            int nota20 = resto50 / 2000;
            int resto20 = resto50 % 2000;

            int nota10 = resto20 / 1000;
            int resto10 = resto20 % 1000;

            int nota5 = resto10 / 500;
            int resto5 = resto10 % 500;

            int nota2 = resto5 / 200;
            int resto2 = resto5 % 200;

            int moeda1 = resto2 / 100;
            int restomoeda1 = resto2 % 100;

            int moeda50 = restomoeda1 / 50;
            int restomoeda50 = restomoeda1 % 50;

            int moeda25 = restomoeda50 / 25;
            int restomoeda25 = restomoeda50 % 25;

            int moeda10 = restomoeda25 / 10;
            int restomoeda10 = restomoeda25 % 10;

            int moeda5 = restomoeda10 / 5;
            int restomoeda5 = restomoeda10 % 5;

            int moeda01 = restomoeda5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
            
        }
    }
}
