using System;

namespace Exercicio9.ConsoleApp
{
    public class Aluno
    {
        public decimal[] todasAsNotas;
        public string nome;
        public int quantidadeDeNotas;

        public decimal ObterMediaHarmonica()
        {
            //A média harmônica é o inverso da média aritimética com os valores invertidos ex: 2 vira 1/2, 3 vira 1/3
            //(1/2 * 1/3 ) / 2 é a média aritimética com os valores invertidos, agora é só inverter o resultado disso
            //1 / ((1/2 * 1/3 ) / 2) é a média harmônica de 2 e 3. Lembrando que embaixo de cada número existe um
            //número 1 implicito.
            decimal somaDoInversoDasNotas = 0m;

            for (int i = 0; i < todasAsNotas.Length; i++)
            {
                somaDoInversoDasNotas += (1 / todasAsNotas[i]);
            }

            return 1 / (somaDoInversoDasNotas / quantidadeDeNotas);
        }
    }
}