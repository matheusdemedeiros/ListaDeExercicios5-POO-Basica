using System;

namespace Exercicio9.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("\nInforme o nome do aluno: ");

            aluno.nome = Console.ReadLine();

            Console.Write("\nInforme a quantidade de notas de {0}: ", aluno.nome);

            aluno.quantidadeDeNotas = int.Parse(Console.ReadLine());

            if (aluno.quantidadeDeNotas > 0)
            {
                aluno.todasAsNotas = new decimal[aluno.quantidadeDeNotas];

                for (int i = 0; i < aluno.quantidadeDeNotas; i++)
                {
                    Console.Write("\nInforme a {0}ª nota de {1}: ", (i + 1), aluno.nome);

                    aluno.todasAsNotas[i] = decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nA média harmônica das notas de {0} é: {1}", aluno.nome, aluno.ObterMediaHarmonica().ToString("F2"));
            }
            else
            {
                Console.WriteLine("\n{0} ainda não têm nenhuma nota!!", aluno.nome);
            }
        }
    }
}
