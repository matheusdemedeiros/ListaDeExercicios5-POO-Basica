using System;

namespace Exercicio3.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            
            Console.Write("\nInforme o raio do cilindro: ");
            
            cilindro.raio = double.Parse(Console.ReadLine());
            
            Console.Write("\nInforme a altura do cilindro: ");
            
            cilindro.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO volume do cilindro é: {0}", cilindro.ObterVolume().ToString("F2)"));
        }
    }
}
