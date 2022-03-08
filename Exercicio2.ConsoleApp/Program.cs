using System;

namespace Exercicio2.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.Write("\nInforme a temperatura em ºF: ");

            temperatura.grausFahrenheit = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nTemeperatura convertida para ºC: {0}", temperatura.ObterEmCelsius());
        }
    }
}
