using System;

namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            Console.Write("\nInforme o salário base do vendedor: ");

            vendedor.salarioBase = decimal.Parse(Console.ReadLine());

            Console.Write("\nInforme o total de vendas do vendedor: ");

            vendedor.totalDeVendas = decimal.Parse(Console.ReadLine());
            
            Console.Write("\nInforme o percentual de comissões do vendedor: ");

            vendedor.percentualDeComissoes = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEste é o salário total do vendedor: R$ {0}", vendedor.ObterSalario().ToString("F2"));
        }
    }
}
