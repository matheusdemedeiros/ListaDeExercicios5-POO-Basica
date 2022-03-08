using System;

namespace Exercicio4.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculoDeCombustivel calculoDeCombustivel = new CalculoDeCombustivel();
            
            Console.Write("\nInforme a Kilometragem inicial do percurso: ");

            calculoDeCombustivel.kilometragemInicial = double.Parse(Console.ReadLine());
            
            Console.Write("\nInforme a Kilometragem final do percurso: ");

            calculoDeCombustivel.kilometragemFinal = double.Parse(Console.ReadLine());

            Console.Write("\nInforme a quantidade de combustível inicial (tanque cheio): ");

            calculoDeCombustivel.quantidadeDeCombustivelComOhTanqueCheio = double.Parse(Console.ReadLine());
            
            Console.Write("\nInforme a quantidade de combustível final (depoois do percurso): ");

            calculoDeCombustivel.quantidadeDeCombustivelNoTanqueDepoisDoPercurso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO consumo de combustível por Km foi: {0}", calculoDeCombustivel.ObterConsumo());
        }
    }
}
