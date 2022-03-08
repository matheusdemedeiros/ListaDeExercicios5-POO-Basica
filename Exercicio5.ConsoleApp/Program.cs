using System;

namespace Exercicio5.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.Write("\nInforme o raio da esfera (metros): ");

            esfera.raio = double.Parse(Console.ReadLine());
                                                                                   //F2 é quantidade de cassa decimais a serem mostradas
            Console.WriteLine("\nO volume da esfera é: {0} m³", esfera.ObterVolume().ToString("F2"));
        }
    }
}
