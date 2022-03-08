using System;

namespace Exercicio8.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo();

            Console.Write("\nInforme o raio da lata de óleo: ");

            lataDeOleo.raio = double.Parse(Console.ReadLine());

            Console.Write("\nInforme a altura da lata de óleo: ");

            lataDeOleo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO volume da lata é: {0}", lataDeOleo.ObterVolume().ToString("F2"));
        }
    }
}
