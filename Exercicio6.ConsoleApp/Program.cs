using System;

namespace Exercicio6.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.Write("\nInforme a temperatura em ºC: ");

            temperatura.grausCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTemeperatura convertida para ºF: {0}", temperatura.ObterEmFahrenheit());
        }
    }
}
