using System;

namespace Exercicio1.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            
            Console.Write("\nInforme a altura da caixa: ");
            
            caixa.altura = decimal.Parse(Console.ReadLine());
            
            Console.Write("\nInforme a largura da caixa: ");
            
            caixa.largura = decimal.Parse(Console.ReadLine());
            
            Console.Write("\nInforme a cumprimento da caixa: ");
            
            caixa.cumprimento = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("\nO volume da caixa é:{0}", caixa.ObterVolume());
        }
    }
}


