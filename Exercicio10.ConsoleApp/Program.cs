using System;

namespace Exercicio10.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("\nInforme o nome do aluno: ");

            aluno.nome = Console.ReadLine();

            Console.Write("\nInforme a nota da prova 1 de {0}: ", aluno.nome);

            aluno.notaProva1 = decimal.Parse(Console.ReadLine());

            Console.Write("\nInforme a nota da prova 2 de {0}: ", aluno.nome);

            aluno.notaProva2 = decimal.Parse(Console.ReadLine());

            Console.Write("\nInforme o peso da prova 1 de {0}: ", aluno.nome);

            aluno.pesoProva1 = decimal.Parse(Console.ReadLine());

            Console.Write("\nInforme o peso da prova 2 de {0}: ", aluno.nome);

            aluno.pesoProva2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nA média ponderada de {0} é: {1}", aluno.nome, aluno.ObterMediaPonderada().ToString("F2"));
        }
    }
}
